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
    public partial class dataPemilih : Form
    {
        public dataPemilih()
        {
            InitializeComponent();
        }
        private void loadAll()
        {
            // TODO: This line of code loads data into the 'pilketosDataSet.Pemilih' table. You can move, or remove it, as needed.
            this.pemilihTableAdapter.Fill(this.pilketosDataSet.Pemilih);
            PanelMenu.Visible = false;
            button4.Enabled = false;
        }

        private void DataPemilih_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void BtnDataUSer_Click(object sender, EventArgs e)
        {

            FromDataUser frmdatauser = new FromDataUser();
            frmdatauser.Show();
            this.Close();
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

        public static string GenerateCoupon(int length, Random random)
        {
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        int id;

        private void Button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] coupon = new string[1];
            for (int i = 0; i < coupon.Length; i++)
            {
                coupon[i] = GenerateCoupon(10, rnd);
            }
            Console.WriteLine(String.Join(Environment.NewLine, coupon));

            Pemilih pemil = new Pemilih();
            pemil.kodePemilih = String.Join(Environment.NewLine, coupon);
            pemil.status = "belum";
            db.Pemilihs.InsertOnSubmit(pemil);
            db.SubmitChanges();
            loadAll();
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.CurrentRow;
            id = Convert.ToInt32(row.Cells[0].Value);
            button4.Enabled = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Pemilih pemil = new Pemilih();
            pemil = db.Pemilihs.Single(x => x.id == id);
            db.Pemilihs.DeleteOnSubmit(pemil);
            db.SubmitChanges();
            loadAll();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            LoginFrom login = new LoginFrom();
            login.Show();
            this.Close();

        }

        private void HasilPemilihan_Click(object sender, EventArgs e)
        {
            hasilPemilihan hapem = new hasilPemilihan();
            hapem.Show();
            this.Close();

        }

        private void BtndataPemilih_Click(object sender, EventArgs e)
        {

        }

        private void BtndataKandidat_Click(object sender, EventArgs e)
        {
            dataKandidat dakand = new dataKandidat();
            dakand.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}
