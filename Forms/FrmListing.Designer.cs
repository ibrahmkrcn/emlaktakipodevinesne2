namespace EmlakTakip.Forms
{
    partial class FrmListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgListing = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            txtBuyerPhone = new TextBox();
            txtSaleDate = new TextBox();
            txtSalePrice = new TextBox();
            txtBuyerSurname = new TextBox();
            txtBuyerName = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgListing).BeginInit();
            SuspendLayout();
            // 
            // dgListing
            // 
            dgListing.AllowUserToAddRows = false;
            dgListing.AllowUserToDeleteRows = false;
            dgListing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListing.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgListing.Location = new Point(128, 68);
            dgListing.Name = "dgListing";
            dgListing.ReadOnly = true;
            dgListing.RowTemplate.Height = 25;
            dgListing.Size = new Size(543, 484);
            dgListing.TabIndex = 0;
            dgListing.CellClick += dgListing_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.HeaderText = "Alıcı Adı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Alıcı Soyadı";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Alıcı Telefon Numarası";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Satış Tarihi";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Satılan Fiyat";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(919, 420);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 40);
            btnClear.TabIndex = 33;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(781, 420);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 40);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(919, 374);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 40);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(781, 374);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 40);
            btnSave.TabIndex = 30;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtBuyerPhone
            // 
            txtBuyerPhone.Location = new Point(895, 218);
            txtBuyerPhone.Name = "txtBuyerPhone";
            txtBuyerPhone.Size = new Size(156, 23);
            txtBuyerPhone.TabIndex = 41;
            // 
            // txtSaleDate
            // 
            txtSaleDate.Location = new Point(895, 247);
            txtSaleDate.Name = "txtSaleDate";
            txtSaleDate.Size = new Size(156, 23);
            txtSaleDate.TabIndex = 40;
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(895, 276);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(156, 23);
            txtSalePrice.TabIndex = 39;
            // 
            // txtBuyerSurname
            // 
            txtBuyerSurname.Location = new Point(895, 189);
            txtBuyerSurname.Name = "txtBuyerSurname";
            txtBuyerSurname.Size = new Size(156, 23);
            txtBuyerSurname.TabIndex = 38;
            // 
            // txtBuyerName
            // 
            txtBuyerName.Location = new Point(895, 160);
            txtBuyerName.Name = "txtBuyerName";
            txtBuyerName.Size = new Size(156, 23);
            txtBuyerName.TabIndex = 37;
            // 
            // txtId
            // 
            txtId.Location = new Point(895, 131);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(156, 23);
            txtId.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(806, 279);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 51;
            label6.Text = "Satılan Fiyat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(814, 253);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 50;
            label5.Text = "Satış Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(752, 224);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 49;
            label4.Text = "Alıcı Telefon Numarası";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(808, 195);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 48;
            label3.Text = "Alıcı Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(825, 166);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 47;
            label2.Text = "Alıcı Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(859, 134);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 46;
            label1.Text = "Id";
            // 
            // FrmListing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1246, 649);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBuyerPhone);
            Controls.Add(txtSaleDate);
            Controls.Add(txtSalePrice);
            Controls.Add(txtBuyerSurname);
            Controls.Add(txtBuyerName);
            Controls.Add(txtId);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dgListing);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmListing";
            Text = "FrmListings";
            Load += FrmListing_Load;
            ((System.ComponentModel.ISupportInitialize)dgListing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgListing;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox txtBuyerPhone;
        private TextBox txtSaleDate;
        private TextBox txtSalePrice;
        private TextBox txtBuyerSurname;
        private TextBox txtBuyerName;
        private TextBox txtId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}