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
    public partial class hasilPemilihan : Form
    {
        public hasilPemilihan()
        {
            InitializeComponent();
        }

        private void HasilPemilihan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pilketosDataSet1.kandidat' table. You can move, or remove it, as needed.
            this.kandidatTableAdapter.Fill(this.pilketosDataSet1.kandidat);
            kandidat kand = new kandidat();

            PanelMenu.Visible = false;
            PanelMenu.BringToFront();
            for(int i = 0; i<dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "10")
                {
                    this.chart1.Series["Suara"].Points.AddXY(dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
                }
                else if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "11") {
                    this.chart2.Series["Suara"].Points.AddXY(dataGridView1.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PanelMenu.Visible = true;

        }

        private void BtnDataUSer_Click(object sender, EventArgs e)
        {
            FromDataUser daus = new FromDataUser();
            daus.Show();
            this.Show();
        }

        private void BtndataPemilih_Click(object sender, EventArgs e)
        {
            dataPemilih dapem = new dataPemilih();
            dapem.Show();
            this.Close();

        }

        private void BtndataKandidat_Click(object sender, EventArgs e)
        {
            dataKandidat dakan = new dataKandidat();
            dakan.Show();
            this.Close();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            LoginFrom log = new LoginFrom();
            log.Show();
            this.Close();

        }
    }
}
