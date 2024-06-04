using EmlakTakip.Forms;

namespace EmlakTakip
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        void OpenForm(Form f)
        {
            panel3.Controls.Clear();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.Show();

        }

        private void btnPropertyOwners_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPropertyOwner());
        }

        private void btnSoldProperties_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmListing());
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmProperties());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}