using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace mari_memilih
{
    public partial class dataKandidat : Form
    {
        public dataKandidat()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = true;
            PanelMenu.BringToFront();

        }

        private void loadAll()
        {
            txtNama.Text = "";
            txtvisi.Text = "";
            txtMisi.Text = "";
            foto.Image = null;
            btnedit.Enabled = false;
            btnhapus.Enabled = false;

            PanelMenu.Visible = false;
            // TODO: This line of code loads data into the 'pilketosDataSet1.kandidat' table. You can move, or remove it, as needed.
            this.kandidatTableAdapter.Fill(this.pilketosDataSet1.kandidat);
        }

        private void DataKandidat_Load(object sender, EventArgs e)
        {
          
            loadAll();
            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = false;

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        int id;
        private void Btntambah_Click(object sender, EventArgs e)
        {
            if(txtNama.Text !=""&&txtvisi.Text != "" && txtMisi.Text != ""&&foto.Image!=null && comboBox1.Text != "")
            {
                kandidat kand = new kandidat();
                kand.Nama = txtNama.Text;
                kand.Kelas = comboBox1.Text;
                kand.Visi = txtvisi.Text;
                kand.Misi = txtMisi.Text;
                MemoryStream ms = new MemoryStream();
                foto.Image.Save(ms, foto.Image.RawFormat);
                byte[] img = ms.ToArray();
                kand.Foto = img;
                db.kandidats.InsertOnSubmit(kand);
                db.SubmitChanges();
                loadAll();
            }
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            if (txtNama.Text != "" && txtvisi.Text != "" && txtMisi.Text != "" && foto.Image != null && comboBox1.Text!="")
            {
                kandidat kand = new kandidat();
                kand = db.kandidats.Single(x => x.id == id);
                kand.Kelas = comboBox1.Text;
                kand.Nama = txtNama.Text;
                kand.Visi = txtvisi.Text;
                kand.Misi = txtMisi.Text;
                MemoryStream ms = new MemoryStream();
                foto.Image.Save(ms, foto.Image.RawFormat);
                byte[] img = ms.ToArray();
                kand.Foto = img;
                db.SubmitChanges();
                loadAll();
            }
        }

        private void Btnsrc_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg,*.jpeg,*.png)|*.JPG;*.JPEG;*.PNG";
            if (op.ShowDialog() == DialogResult.OK)
            {
                foto.Image = Image.FromFile(op.FileName);
            }
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.CurrentRow;
            id = Convert.ToInt32(row.Cells[0].Value);
            txtNama.Text = row.Cells[1].Value.ToString();
            txtvisi.Text = row.Cells[2].Value.ToString();
            txtMisi.Text = row.Cells[3].Value.ToString();


            byte[] img = (Byte[])row.Cells[4].Value;
            MemoryStream ms = new MemoryStream(img);
            foto.Image = Image.FromStream(ms);

            btnedit.Enabled = true;
            btnhapus.Enabled = true;

        }

        private void Btnhapus_Click(object sender, EventArgs e)
        {
            var mess = MessageBox.Show("Yakin hapus", "", MessageBoxButtons.YesNo);
            if (mess == DialogResult.Yes)
            {
                kandidat kand = new kandidat();
                kand = db.kandidats.Single(x => x.id == id);
                db.kandidats.DeleteOnSubmit(kand);
                db.SubmitChanges();
                loadAll();
            }

        }

        private void BtnDataUSer_Click(object sender, EventArgs e)
        {
            FromDataUser frmdatauser = new FromDataUser();
            frmdatauser.Show();
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

        private void Button5_Click(object sender, EventArgs e)
        {
            LoginFrom login = new LoginFrom();
            login.Show();
            this.Close();

        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar)){
                e.Handled = true;
            }
        }
    }
}
