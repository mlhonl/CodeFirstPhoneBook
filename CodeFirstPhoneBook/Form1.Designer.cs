namespace CodeFirstPhoneBook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlSave = new Panel();
            txtFirstName = new TextBox();
            btnAdd = new Button();
            txtPhone = new TextBox();
            txtLastName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSearch = new Button();
            txtFind = new TextBox();
            pnlFind = new Panel();
            btnUpdate = new Button();
            label6 = new Label();
            label5 = new Label();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            label7 = new Label();
            lstContactList = new ListView();
            csmMenu = new ContextMenuStrip(components);
            tsmUpdate = new ToolStripMenuItem();
            tsmDelete = new ToolStripMenuItem();
            btnRefresh = new Button();
            pnlSave.SuspendLayout();
            pnlFind.SuspendLayout();
            csmMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSave
            // 
            pnlSave.BackColor = Color.Lavender;
            pnlSave.Controls.Add(txtFirstName);
            pnlSave.Controls.Add(btnAdd);
            pnlSave.Controls.Add(txtPhone);
            pnlSave.Controls.Add(txtLastName);
            pnlSave.Controls.Add(label4);
            pnlSave.Controls.Add(label3);
            pnlSave.Controls.Add(label2);
            pnlSave.Controls.Add(label1);
            pnlSave.Location = new Point(7, 5);
            pnlSave.Name = "pnlSave";
            pnlSave.Size = new Size(297, 238);
            pnlSave.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(91, 49);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(185, 23);
            txtFirstName.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PapayaWhip;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(91, 136);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(185, 44);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "REHBERE EKLE";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnClick;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(91, 105);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(185, 23);
            txtPhone.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(91, 76);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(185, 23);
            txtLastName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 108);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 2;
            label4.Text = "TELEFON:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 79);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "SOYAD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 49);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "AD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 19);
            label1.TabIndex = 0;
            label1.Text = "YENİ OLUŞTUR";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.PapayaWhip;
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Location = new Point(346, 67);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 44);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "KİŞİ ARA";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnClick;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(15, 79);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(325, 23);
            txtFind.TabIndex = 3;
            // 
            // pnlFind
            // 
            pnlFind.BackColor = Color.Lavender;
            pnlFind.Controls.Add(btnUpdate);
            pnlFind.Controls.Add(btnSearch);
            pnlFind.Controls.Add(label6);
            pnlFind.Controls.Add(label5);
            pnlFind.Controls.Add(txtFind);
            pnlFind.Location = new Point(310, 5);
            pnlFind.Name = "pnlFind";
            pnlFind.Size = new Size(478, 238);
            pnlFind.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.PapayaWhip;
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(15, 136);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 44);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += BtnClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 52);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 1;
            label6.Text = "AD VEYA SOYAD:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 9);
            label5.Name = "label5";
            label5.Size = new Size(35, 19);
            label5.TabIndex = 0;
            label5.Text = "BUL";
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(7, 255);
            label7.Name = "label7";
            label7.Size = new Size(61, 19);
            label7.TabIndex = 0;
            label7.Text = "REHBER";
            // 
            // lstContactList
            // 
            lstContactList.BackColor = Color.MistyRose;
            lstContactList.Location = new Point(7, 286);
            lstContactList.Name = "lstContactList";
            lstContactList.Size = new Size(781, 222);
            lstContactList.TabIndex = 5;
            lstContactList.UseCompatibleStateImageBehavior = false;
            lstContactList.MouseClick += lstContactList_MouseClick;
            // 
            // csmMenu
            // 
            csmMenu.Items.AddRange(new ToolStripItem[] { tsmUpdate, tsmDelete });
            csmMenu.Name = "csmMenu";
            csmMenu.Size = new Size(121, 48);
            // 
            // tsmUpdate
            // 
            tsmUpdate.Name = "tsmUpdate";
            tsmUpdate.Size = new Size(120, 22);
            tsmUpdate.Text = "Güncelle";
            tsmUpdate.Click += TsmClick;
            // 
            // tsmDelete
            // 
            tsmDelete.Name = "tsmDelete";
            tsmDelete.Size = new Size(120, 22);
            tsmDelete.Text = "Sil";
            tsmDelete.Click += TsmClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.PapayaWhip;
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(686, 245);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(102, 38);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "YENİLE";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(792, 511);
            Controls.Add(btnRefresh);
            Controls.Add(lstContactList);
            Controls.Add(pnlFind);
            Controls.Add(pnlSave);
            Controls.Add(label7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlSave.ResumeLayout(false);
            pnlSave.PerformLayout();
            pnlFind.ResumeLayout(false);
            pnlFind.PerformLayout();
            csmMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSave;
        private TextBox txtLastName;
        private TextBox txtFind;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSearch;
        private TextBox txtPhone;
        private Label label4;
        private Panel pnlFind;
        private Label label5;
        private Label label6;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnAdd;
        private Button btnUpdate;
        private Label label7;
   
        private ListView lstContactList;
        private ContextMenuStrip csmMenu;
        private ToolStripMenuItem tsmUpdate;
        private ToolStripMenuItem tsmDelete;
        private TextBox txtFirstName;
        private Button btnRefresh;
    }
}
