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
    public partial class FromDataUser : Form
    {
        public FromDataUser()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = true;

        }
        private void loadAll()
        {
         // TODO: This line of code loads data into the 'pilketosDataSet.user' table. You can move, or remove it, as needed.
                    this.userTableAdapter.Fill(this.pilketosDataSet.user);
                    PanelMenu.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            button3.Enabled = false;
            button4.Enabled = false;
        }
        private void FromDataUser_Load(object sender, EventArgs e)
        {
            PanelMenu.BringToFront();
            loadAll();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = false;
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

        private void Button5_Click(object sender, EventArgs e)
        {

            LoginFrom login = new LoginFrom();
            login.Show();
            this.Close();

        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        int ID;

        private void Button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                user use = new user();
                use.UserName = textBox1.Text;
                use.password = textBox2.Text;
                db.users.InsertOnSubmit(use);
                db.SubmitChanges();
                loadAll();

            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            ID = Convert.ToInt32(row.Cells[0].Value);
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();

            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                user use = new user();
                use = db.users.Single(x => x.id == ID);
                use.UserName = textBox1.Text;
                use.password = textBox2.Text;
                db.SubmitChanges();
                loadAll();

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var mess = MessageBox.Show("yakin","", MessageBoxButtons.YesNo);
            if(mess == DialogResult.Yes)
            {
                user use = new user();
                use = db.users.Single(x => x.id == ID);
                db.users.DeleteOnSubmit(use);
                db.SubmitChanges();
                loadAll();
            }
        }
    }
}
