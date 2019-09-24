using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mari_memilih
{
    public partial class WellcomeAdmin : Form
    {
        public WellcomeAdmin()
        {
            InitializeComponent();
        }

        private void WellcomeAdmin_Load(object sender, EventArgs e)
        {
            PanelMenu.Visible = false;
            PanelMenu.BringToFront();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = true;
            PanelMenu.BringToFront();

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = false;
        }

        private void BtnHasilPemilihanCepat_Click(object sender, EventArgs e)
        {

            hasilPemilihan hapem = new hasilPemilihan();
            hapem.Show();
            this.Close();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            LoginFrom login = new LoginFrom();
            login.Show();
            this.Close();

        }

        private void BtnDataUSer_Click(object sender, EventArgs e)
        {
            FromDataUser frmdatauser = new FromDataUser();
            frmdatauser.Show();
            this.Close();

        }

        private void BtndataKandidat_Click(object sender, EventArgs e)
        {
            dataKandidat dakan = new dataKandidat();
            dakan.Show();
            this.Close();

        }

        private void BtndataPemilih_Click(object sender, EventArgs e)
        {
            dataPemilih dapem = new dataPemilih();
            dapem.Show();
            this.Close();

        }

        private void HasilPemilihan_Click(object sender, EventArgs e)
        {
            hasilPemilihan hapem = new hasilPemilihan();
            hapem.Show();
            this.Close();

        }
    }
}
