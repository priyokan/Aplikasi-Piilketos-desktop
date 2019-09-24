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
    public partial class frmPilihan : Form
    {
        public frmPilihan()
        {
            InitializeComponent();
        }

        private void FrmPilihan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pilketosDataSet.kandidat' table. You can move, or remove it, as needed.
            this.kandidatTableAdapter.Fill(this.pilketosDataSet.kandidat);
            int[] id_kandidat = new int[dataGridView1.RowCount];
            string[] nama_kandidat = new string[dataGridView1.RowCount];

            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i] != null)
                {
                    id_kandidat[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    nama_kandidat[i] = dataGridView1.Rows[i].Cells[1].Value.ToString();

                }
            }

            if(id_kandidat.Length  >= 1)
            {
                labelNama1.Text = nama_kandidat[0].ToString();
            }
            if(id_kandidat.Length  >= 2)
            {
                LabelNama2.Text = nama_kandidat[1].ToString();

            }
            if (id_kandidat.Length >= 3)

            {
                labelnama3.Text = id_kandidat[2].ToString();

            }
            if (id_kandidat.Length >= 4)

            {
                labelnama4.Text = id_kandidat[3].ToString();

            }
            if (id_kandidat.Length >= 5)

            {
                labelnama5.Text = id_kandidat[4].ToString();

            }
            if (id_kandidat.Length >= 6)

            {
                labelnama6.Text = id_kandidat[5].ToString();

            }
            if (id_kandidat.Length >= 7)

            {
                labelnama7.Text = id_kandidat[6].ToString();

            }
            if (id_kandidat.Length >= 8)

            {
                labelnama8.Text = id_kandidat[7].ToString();

            }
            

        }
    }
}
