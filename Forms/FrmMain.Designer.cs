namespace EmlakTakip
{
    partial class FrmMain
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
            panel1 = new Panel();
            btnExit = new Button();
            btnProperties = new Button();
            btnSoldProperties = new Button();
            btnPropertyOwners = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnProperties);
            panel1.Controls.Add(btnSoldProperties);
            panel1.Controls.Add(btnPropertyOwners);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 649);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.CadetBlue;
            btnExit.Location = new Point(12, 380);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(208, 57);
            btnExit.TabIndex = 3;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnProperties
            // 
            btnProperties.FlatStyle = FlatStyle.Flat;
            btnProperties.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProperties.ForeColor = Color.CadetBlue;
            btnProperties.Location = new Point(12, 299);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(208, 57);
            btnProperties.TabIndex = 2;
            btnProperties.Text = "Emlak İlanları";
            btnProperties.UseVisualStyleBackColor = true;
            btnProperties.Click += btnProperties_Click;
            // 
            // btnSoldProperties
            // 
            btnSoldProperties.FlatStyle = FlatStyle.Flat;
            btnSoldProperties.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSoldProperties.ForeColor = Color.CadetBlue;
            btnSoldProperties.Location = new Point(12, 213);
            btnSoldProperties.Name = "btnSoldProperties";
            btnSoldProperties.Size = new Size(208, 57);
            btnSoldProperties.TabIndex = 1;
            btnSoldProperties.Text = "Satılan Emlaklar";
            btnSoldProperties.UseVisualStyleBackColor = true;
            btnSoldProperties.Click += btnSoldProperties_Click;
            // 
            // btnPropertyOwners
            // 
            btnPropertyOwners.FlatStyle = FlatStyle.Flat;
            btnPropertyOwners.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPropertyOwners.ForeColor = Color.CadetBlue;
            btnPropertyOwners.Location = new Point(12, 129);
            btnPropertyOwners.Name = "btnPropertyOwners";
            btnPropertyOwners.Size = new Size(208, 57);
            btnPropertyOwners.TabIndex = 0;
            btnPropertyOwners.Text = "Emlak Sahipleri";
            btnPropertyOwners.UseVisualStyleBackColor = true;
            btnPropertyOwners.Click += btnPropertyOwners_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(235, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1039, 100);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(52, 31);
            label1.Name = "label1";
            label1.Size = new Size(272, 37);
            label1.TabIndex = 0;
            label1.Text = "Emlak Takip Programı";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(235, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(1039, 549);
            panel3.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1274, 649);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Button btnExit;
        private Button btnProperties;
        private Button btnSoldProperties;
        private Button btnPropertyOwners;
    }
}