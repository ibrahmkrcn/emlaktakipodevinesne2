using EmlakTakip.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace EmlakTakip.Forms
{
    public partial class FrmPropertyOwner : Form
    {
        public FrmPropertyOwner()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        void GetPropertyOwnerList()
        {
            dgPropertyOwner.Rows.Clear();
            var propertyowners = db.PropertyOwner.ToList();
            foreach (var propertyownerr in propertyowners)
            {
                dgPropertyOwner.Rows.Add(propertyownerr.Id, propertyownerr.Name, propertyownerr.Surname, propertyownerr.PhoneNumber,propertyownerr.EmailAdress, propertyownerr.Address);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSurname.Text == "" || txtPhone.Text == "" || txtMail.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Lütfen Alanları Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.PropertyOwner.Count(x => x.Name == txtName.Text) > 0)
            {
                MessageBox.Show("Girilen İsim Zaten Kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var propertyownerr = new PropertyOwner();
            propertyownerr.Name = txtName.Text;
            propertyownerr.Surname = txtSurname.Text;
            propertyownerr.PhoneNumber = Convert.ToInt32(txtPhone.Text);
            propertyownerr.EmailAdress = txtMail.Text;
            propertyownerr.Address = txtAddress.Text;

            db.PropertyOwner.Add(propertyownerr);
            db.SaveChanges();
            MessageBox.Show("Emlak Sahibi Eklendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetPropertyOwnerList();
            btnClear.PerformClick();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtSurname.Text == "" || txtPhone.Text == "" || txtMail.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz ve Alanları Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtId.Text);
            var propertyownerr = db.PropertyOwner.Where(x => x.Id == id).SingleOrDefault();
            if (propertyownerr == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            propertyownerr.Name = txtName.Text;
            propertyownerr.Surname = txtSurname.Text;
            propertyownerr.PhoneNumber = Convert.ToInt32(txtPhone.Text);
            propertyownerr.EmailAdress = txtMail.Text;
            propertyownerr.Address = txtAddress.Text;

            db.PropertyOwner.Update(propertyownerr);
            db.SaveChanges();
            MessageBox.Show("Kayıt Güncellendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetPropertyOwnerList();
            btnClear.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtId.Text);
            var propertyownerr = db.PropertyOwner.Where(x => x.Id == id).SingleOrDefault();
            if (propertyownerr == null)
            {
                MessageBox.Show("Geçerli Bir Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.PropertyOwner.Remove(propertyownerr);
            db.SaveChanges();
            MessageBox.Show("Emlak Sahibi Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetPropertyOwnerList();
            btnClear.PerformClick();
        }

        private void dgPropertyOwner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgPropertyOwner.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgPropertyOwner.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dgPropertyOwner.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dgPropertyOwner.CurrentRow.Cells[3].Value.ToString();
            txtMail.Text = dgPropertyOwner.CurrentRow.Cells[4].Value.ToString();
            txtAddress.Text = dgPropertyOwner.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var x in Controls)
            {
                if (x is TextBox)
                {
                    (x as TextBox).Clear();
                }
            }
        }

        private void FrmPropertyOwner_Load(object sender, EventArgs e)
        {
            GetPropertyOwnerList();
        }
    }
}
