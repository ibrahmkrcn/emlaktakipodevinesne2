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
using System.Xml.Linq;

namespace EmlakTakip.Forms
{
    public partial class FrmProperties : Form
    {
        public FrmProperties()
        {
            InitializeComponent();
        }

        AppDbContext db = new AppDbContext();

        void GetPropertiesList()
        {
            dgProperties.Rows.Clear();
            var properties = db.Properties.ToList();
            foreach (var property in properties)
            {
                dgProperties.Rows.Add(property.Id, property.PropertyType, property.Address, property.Price, property.Area, property.NumberOfRooms, property.NumberOfBathrooms, property.NumberOfFloors, property.ListingDate, property.Status);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPropertyType.Text == "" || txtAddress.Text == "" || txtPrice.Text == "" || txtArea.Text == "" || txtNumofRooms.Text == "" || txtNumofBrooms.Text == "" || txtNumofFloors.Text == "" || txtListingDate.Text == "" || txtStatus.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.Properties.Count(c => c.PropertyType == txtPropertyType.Text) > 0)
            {
                MessageBox.Show("Girilen Zaten Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var property = new Properties();
            property.PropertyType = txtPropertyType.Text;
            property.Address = txtAddress.Text;
            property.Price = Convert.ToInt32(txtPrice.Text);
            property.Area = Convert.ToInt32(txtArea.Text);
            property.NumberOfRooms = Convert.ToInt32(txtNumofRooms.Text);
            property.NumberOfBathrooms = Convert.ToInt32(txtNumofBrooms.Text);
            property.NumberOfFloors = Convert.ToInt32(txtNumofFloors.Text);
            property.ListingDate = Convert.ToInt32(txtListingDate.Text);
            property.Status = txtStatus.Text;
            db.Properties.Add(property);
            db.SaveChanges();
            MessageBox.Show("Emlak Eklendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetPropertiesList();
            btnClear.PerformClick();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtPropertyType.Text == "" || txtAddress.Text == "" || txtPrice.Text == "" || txtArea.Text == "" || txtNumofRooms.Text == "" || txtNumofBrooms.Text == "" || txtNumofFloors.Text == "" || txtListingDate.Text == "" || txtStatus.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz ve Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtId.Text);
            var property = db.Properties.Where(x => x.Id == id).SingleOrDefault();
            if (property == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            property.PropertyType = txtPropertyType.Text;
            property.Address = txtAddress.Text;
            property.Price = Convert.ToInt32(txtPrice.Text);
            property.Area = Convert.ToInt32(txtArea.Text);
            property.NumberOfRooms = Convert.ToInt32(txtNumofRooms.Text);
            property.NumberOfBathrooms = Convert.ToInt32(txtNumofBrooms.Text);
            property.NumberOfFloors = Convert.ToInt32(txtNumofFloors.Text);
            property.ListingDate = Convert.ToInt32(txtListingDate.Text);
            property.Status = txtStatus.Text;

            db.Properties.Update(property);
            db.SaveChanges();
            MessageBox.Show("Ders Güncellendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetPropertiesList();
            btnClear.PerformClick();
        }

        private void dgProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgProperties.CurrentRow.Cells[0].Value.ToString();
            txtPropertyType.Text = dgProperties.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dgProperties.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dgProperties.CurrentRow.Cells[3].Value.ToString();
            txtArea.Text = dgProperties.CurrentRow.Cells[4].Value.ToString();
            txtNumofRooms.Text = dgProperties.CurrentRow.Cells[5].Value.ToString();
            txtNumofBrooms.Text = dgProperties.CurrentRow.Cells[6].Value.ToString();
            txtNumofFloors.Text = dgProperties.CurrentRow.Cells[7].Value.ToString();
            txtListingDate.Text = dgProperties.CurrentRow.Cells[8].Value.ToString();
            txtStatus.Text = dgProperties.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtId.Text);
            var lesson = db.Properties.Where(x => x.Id == id).SingleOrDefault();
            if (lesson == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Properties.Remove(lesson);
            db.SaveChanges();
            MessageBox.Show("Kayıt Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetPropertiesList();
            btnClear.PerformClick();
        }

        private void FrmProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
