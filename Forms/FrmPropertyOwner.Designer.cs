namespace EmlakTakip.Forms
{
    partial class FrmPropertyOwner
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgPropertyOwner = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtPhone = new TextBox();
            txtMail = new TextBox();
            txtAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgPropertyOwner).BeginInit();
            SuspendLayout();
            // 
            // dgPropertyOwner
            // 
            dgPropertyOwner.AllowUserToAddRows = false;
            dgPropertyOwner.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgPropertyOwner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgPropertyOwner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPropertyOwner.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgPropertyOwner.DefaultCellStyle = dataGridViewCellStyle2;
            dgPropertyOwner.Location = new Point(110, 56);
            dgPropertyOwner.Name = "dgPropertyOwner";
            dgPropertyOwner.ReadOnly = true;
            dgPropertyOwner.RowTemplate.Height = 25;
            dgPropertyOwner.Size = new Size(543, 418);
            dgPropertyOwner.TabIndex = 0;
            dgPropertyOwner.CellClick += dgPropertyOwner_CellClick;
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
            Column2.HeaderText = "İsim";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Soyisim";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefon";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "E-Mail";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Adres";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(784, 316);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(922, 316);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(784, 362);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(922, 362);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 40);
            btnClear.TabIndex = 4;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(841, 98);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(156, 23);
            txtId.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(841, 127);
            txtName.Name = "txtName";
            txtName.Size = new Size(156, 23);
            txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(841, 156);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(156, 23);
            txtSurname.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(841, 185);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(156, 23);
            txtPhone.TabIndex = 10;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(841, 214);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(156, 23);
            txtMail.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(841, 243);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(156, 23);
            txtAddress.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(796, 101);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 15;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(784, 130);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 16;
            label2.Text = "İsim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(766, 159);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 17;
            label3.Text = "Soyisim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(771, 188);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 18;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(772, 217);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 19;
            label5.Text = "E-Mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(776, 246);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 20;
            label6.Text = "Adres";
            // 
            // FrmPropertyOwner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1331, 580);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtMail);
            Controls.Add(txtAddress);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dgPropertyOwner);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPropertyOwner";
            Text = "FrmPropertyOwners";
            Load += FrmPropertyOwner_Load;
            ((System.ComponentModel.ISupportInitialize)dgPropertyOwner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPropertyOwner;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtPhone;
        private TextBox txtMail;
        private TextBox txtAddress;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}