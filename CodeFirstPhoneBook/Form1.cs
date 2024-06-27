using CodeFirstPhoneBook.Context;
using CodeFirstPhoneBook.Entity;

namespace CodeFirstPhoneBook
{
    public partial class Form1 : Form
    {
        private readonly PhoneDbContext db;
        public Form1()
        {
            InitializeComponent();
            db = new PhoneDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewEdit();
            ListFill(db.Contacts.ToList());
            btnSearch.Enabled = db.Contacts.Count() > 0;
            btnUpdate.Enabled = false;

        }

        private void BtnClick(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            string name = btn.Name;
            switch (name)
            {
                case "btnAdd": Create(); break;
                case "btnUpdate": BtnUpdate(); break;
                case "btnSearch": Search(); break;
                case "btnRefresh": BtnRefresh(); break;

            }

        }

        private void BtnRefresh()
        {
            ListFill(db.Contacts.ToList());
        }

        private void Search()
        {
            string filter = txtFind.Text.Trim();
            List<Contact> filteredContactList = db.Contacts.Where(
                x => x.FirstName.Contains(filter) || x.LastName.Contains(filter)).ToList();
            ListFill(filteredContactList);
            ClearPanelItem(pnlFind);


        }

        private void BtnUpdate()
        {
            bool isEmpty = string.IsNullOrEmpty(txtFirstName.Text) 
                || string.IsNullOrEmpty(txtLastName.Text)
                || string.IsNullOrEmpty(txtPhone.Text);
            try
            {
                if (isEmpty)
                {
                    MessageBox.Show("Tüm alanlarý doldurunuz");
                    return;
                }
                selectedContact.FirstName = txtFirstName.Text;
                selectedContact.LastName = txtLastName.Text;
                selectedContact.Phone = txtPhone.Text;
                db.SaveChanges();
                MessageBox.Show("Güncelleme Baþarýlý");
                ListFill(db.Contacts.ToList());
                ClearPanelItem(pnlSave);
                btnAdd.Enabled = btnSearch.Enabled = true;
                btnUpdate.Enabled = false;
                selectedContact = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Güncelleme baþarýsýz");
            }
        }

        private void Create()
        {
            string firstName = txtFirstName.Text.Trim(),
                   lastName = txtLastName.Text.Trim(),
                   phoneNumber = txtPhone.Text.Trim();

            bool isEmpty = string.IsNullOrEmpty(firstName) ||
                           string.IsNullOrEmpty(lastName) ||
                           string.IsNullOrEmpty(phoneNumber);

            try
            {
                if (isEmpty)
                {
                    MessageBox.Show("Lütfen tüm alanlarý doldurunuz");
                    return;
                }
                Contact contact = new Contact()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Phone = phoneNumber,
                };
                db.Contacts.Add(contact);
                db.SaveChanges();
                MessageBox.Show("Ekleme Baþarýlý");
                ListFill(db.Contacts.ToList());
                btnSearch.Enabled = true;
                ClearPanelItem(pnlSave);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ekleme baþarýsýz");
            }
        }
        /// <summary>
        /// Panel içerisinde bulunan text box larýn textlerini temizleyen metot
        /// </summary>
        /// <param name="pnl"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ClearPanelItem(Panel pnl)
        {
            foreach (Control item in pnl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        /// <summary>
        /// Listview içerisini parametrelerden gelen listedeki verilerle dolduran metot
        /// </summary>
        /// <param name="contacts"></param>

        private void ListFill(List<Contact> contacts)
        {
            lstContactList.Items.Clear();
            for (int i = 0; i < contacts.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = contacts[i].ID.ToString();
                item.SubItems.Add(contacts[i].FirstName);
                item.SubItems.Add(contacts[i].LastName);
                item.SubItems.Add(contacts[i].Phone);
                item.Tag = contacts[i];
                lstContactList.Items.Add(item);
            }

        }

        private void ListViewEdit()
        {
            lstContactList.View = View.Details;
            int width = lstContactList.Width / 4;
            ColumnHeader[] headers =
            {
                new ColumnHeader()
                {
                    Name = "ID",Text = "ID",Width = width,TextAlign=HorizontalAlignment.Center
                },
                new ColumnHeader()
                {
                    Name="FirstName",Text="AD",Width=
                    width,TextAlign=HorizontalAlignment.Center
                },
                new ColumnHeader()
                {
                    Name="LastName",Text="SOYAD",Width=
                    width,TextAlign=HorizontalAlignment.Center
                },
                new ColumnHeader()
                {
                    Name="Phone",Text="TELEFON",Width=
                    width,TextAlign=HorizontalAlignment.Center
                }

            };
            lstContactList.Columns.AddRange(headers);
            lstContactList.FullRowSelect = true;
        }

        private void lstContactList_MouseClick(object sender, MouseEventArgs e)
        {
            MouseButtons button = e.Button;
            if (button != MouseButtons.Right) return;
            ListViewItem focusedItem = lstContactList.FocusedItem;
            bool isbound = focusedItem.Bounds.Contains(e.Location);
            if (isbound == null || !isbound) return;
            csmMenu.Show(Cursor.Position);
        }

        private void TsmClick(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            string name = menuItem.Name;
            switch(name)
            {
                case "tsmUpdate":TsmUpdate();break;
                case "tsmDelete":TsmDelete();break;
            }
        }

        private void TsmDelete()
        {
            selectedContact = lstContactList.SelectedItems[0].Tag as Contact;
            db.Contacts.Remove(selectedContact);
            db.SaveChanges();
            MessageBox.Show("Kayýt Silindi");
            ListFill(db.Contacts.ToList());
        }
        Contact selectedContact;
        private void TsmUpdate()
        {
            selectedContact = lstContactList.SelectedItems[0].Tag as Contact;
            txtFirstName.Text = selectedContact.FirstName;
            txtLastName.Text = selectedContact.LastName;
            txtPhone.Text = selectedContact.Phone;
            btnUpdate.Enabled = true;
            btnAdd.Enabled=btnSearch.Enabled = false;
             
        }
    }
}
