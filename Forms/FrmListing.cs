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
using System.Xml.Linq;

namespace EmlakTakip.Forms
{
    public partial class FrmListing : Form
    {
        public FrmListing()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();

        private void FrmListing_Load(object sender, EventArgs e)
        {
            GetListingList();
        }
        void GetListingList()
        {
            dgListing.Rows.Clear();
            var listingss = db.Listing.ToList();
            foreach (var listing in listingss)
            {
                dgListing.Rows.Add(listing.Id, listing.BuyerName, listing.BuyerSurname, listing.BuyerPhonenumber, listing.SaleDate, listing.PaymentAmount);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBuyerName.Text == "" || txtBuyerSurname.Text == "" || txtBuyerPhone.Text == "" || txtSaleDate.Text == "" || txtSalePrice.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.Listing.Count(x => x.BuyerName == txtBuyerName.Text) > 0)
            {
                MessageBox.Show("Girilen İsim Zaten Kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var listing = new Listing();
            listing.BuyerName = txtBuyerName.Text;
            listing.BuyerSurname = txtBuyerSurname.Text;
            listing.BuyerPhonenumber = Convert.ToInt32(txtBuyerPhone.Text);
            listing.SaleDate = txtSaleDate.Text;
            listing.PaymentAmount = Convert.ToInt32(txtSalePrice.Text);
            db.Listing.Add(listing);
            db.SaveChanges();
            MessageBox.Show("Yeni Listeleme Eklendi.", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetListingList();
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

        private void dgListing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgListing.CurrentRow.Cells[0].Value.ToString();
            txtBuyerName.Text = dgListing.CurrentRow.Cells[1].Value.ToString();
            txtBuyerSurname.Text = dgListing.CurrentRow.Cells[2].Value.ToString();
            txtBuyerPhone.Text = dgListing.CurrentRow.Cells[3].Value.ToString();
            txtSaleDate.Text = dgListing.CurrentRow.Cells[4].Value.ToString();
            txtSalePrice.Text = dgListing.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtBuyerName.Text == "" || txtBuyerSurname.Text == "" || txtBuyerPhone.Text == "" || txtSaleDate.Text == "" || txtSalePrice.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var listing = db.Listing.Where(x => x.Id == id).SingleOrDefault();
            if (listing == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listing.BuyerName = txtBuyerName.Text;
            listing.BuyerSurname = txtBuyerSurname.Text;
            listing.BuyerPhonenumber = Convert.ToInt32(txtBuyerPhone.Text);
            listing.SaleDate = txtSaleDate.Text;
            listing.PaymentAmount = Convert.ToInt32(txtSalePrice.Text);
            db.Listing.Update(listing);
            db.SaveChanges();
            MessageBox.Show("Kayıt Güncellendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetListingList();
            btnClear.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(txtId.Text);
            var listing = db.Listing.Where(x => x.Id == id).SingleOrDefault();
            if (listing == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Listing.Remove(listing);
            db.SaveChanges();
            MessageBox.Show("Kayıt Silindi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetListingList();
            btnClear.PerformClick();
        }
    }
}
