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
    public partial class frmPilihan : Form
    {
        public frmPilihan()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        public static int id;
        int[] id_kandidat_10 = new int[4];
        int[] id_kandidat_11 = new int[4];
        int id10_1 = 1, id10_2 = 2, id10_3 = 3, id10_4 = 4, id11_1 = 1, id11_2 = 2, id11_3 = 3, id11_4 = 4;

        private void Buttondetail5_Click(object sender, EventArgs e)
        {
            id = id_kandidat_11[id11_1 - 1];
            openDetail();
        }

        private void Buttondetail6_Click(object sender, EventArgs e)
        {
            id = id_kandidat_11[id11_2 - 1];
            openDetail();
        }

        private void Buttondetail7_Click(object sender, EventArgs e)
        {
            id = id_kandidat_11[id11_3- 1];
            openDetail();
        }

        private void Buttondetail8_Click(object sender, EventArgs e)
        {
            id = id_kandidat_11[id11_4 - 1];
            openDetail();
        }

        private void Buttondetail4_Click(object sender, EventArgs e)
        {
            id = id_kandidat_10[3];
            openDetail();
        }

        private void Buttondetail3_Click(object sender, EventArgs e)
        {
            id = id_kandidat_10[2];
            openDetail();
        }

        private void BtnDetail2_Click(object sender, EventArgs e)
        {
            id = id_kandidat_10[1];
            openDetail();
        }

        private void FrmPilihan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pilketosDataSet1.kandidat' table. You can move, or remove it, as needed.
            this.kandidatTableAdapter.Fill(this.pilketosDataSet1.kandidat);
            kandidat kand = new kandidat();

            panel4.Enabled = true;
            panel5.Enabled = true;

            Pemilih pemil = new Pemilih();
            pemil = db.Pemilihs.Single(x => x.id == loginPemilih.id_pemilih);

            if (pemil.status == "10")
            {
                panel5.Enabled = false; 
            }else if(pemil.status == "11")
            {
                panel4.Enabled = false;
            }
            
            int j = 0, k =0 ;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() == "10") 
                {
                    id_kandidat_10[j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    j++;
                }
                else if(dataGridView1.Rows[i].Cells[6].Value.ToString() == "11")
                {
                    id_kandidat_11[k] = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    k++;
                }
            }

            if(id_kandidat_10[0] != 0)
            {
                kand = db.kandidats.Single(x => x.id == id_kandidat_10[0]);
                labelNama1.Text = kand.Nama;

                byte[] img = new byte[0];
                img = kand.Foto.ToArray();
                MemoryStream ms = new MemoryStream(img);
                foto1.Image = Image.FromStream(ms);
            }
            if (id_kandidat_10[1] != 0)
            {
                kand = db.kandidats.Single(x => x.id == id_kandidat_10[id10_2 - 1]);
                LabelNama2.Text = kand.Nama;

                byte[] img = new byte[0];
                img = kand.Foto.ToArray();
                MemoryStream ms = new MemoryStream(img);
                foto2.Image = Image.FromStream(ms);
            }
            if (id_kandidat_10[2] != 0)
            {
                kand = db.kandidats.Single(x => x.id == id_kandidat_10[id10_3 - 1]);
                labelnama3.Text = kand.Nama;

                byte[] img = new byte[0];
                img = kand.Foto.ToArray();
                MemoryStream ms = new MemoryStream(img);
                Foto3.Image = Image.FromStream(ms);

            }
            if (id_kandidat_10[id10_4 - 1] != 0 )
            {
                kand = db.kandidats.Single(x => x.id == id_kandidat_10[id10_4 - 1]);
                labelnama4.Text = kand.Nama;

                byte[] img = new byte[0];
                img = kand.Foto.ToArray();
                MemoryStream ms = new MemoryStream(img);
                foto4.Image = Image.FromStream(ms);

            }
            if (id_kandidat_11[id11_1 - 1] != 0)
            {
                kand = db.kandidats.Single(x => x.id == id_kandidat_11[id11_1 - 1]);
                labelnama5.Text = kand.Nama;

                byte[] img = new byte[0];
                img = kand.Foto.ToArray();
                MemoryStream ms = new MemoryStream(img);
                foto5.Image = Image.FromStream(ms);

            }
            if (id_kandidat_11[id11_2 - 1] != 0)

            {
                kand = db.kandidats.Single(x => x.id == id_kandidat_11[id11_2 - 1]);
                labelnama6.Text = kand.Nama;

                byte[] img = new byte[0];
                img = kand.Foto.ToArray();
                MemoryStream ms = new MemoryStream(img);
                foto6.Image = Image.FromStream(ms);

            }
            if (id_kandidat_11[id11_3 - 1] != 0)

            {
                kand = db.kandidats.Single(x => x.id == id_kandidat_11[id11_3 - 1]);
                labelnama7.Text = kand.Nama;

                byte[] img = new byte[0];
                img = kand.Foto.ToArray();
                MemoryStream ms = new MemoryStream(img);
                foto7.Image = Image.FromStream(ms);

            }
            if (id_kandidat_11[id11_4 - 1] != 0)
            {
                kand = db.kandidats.Single(x => x.id == id_kandidat_11[id11_4 - 1]);
                labelnama8.Text = kand.Nama;

                byte[] img = new byte[0];
                img = kand.Foto.ToArray();
                MemoryStream ms = new MemoryStream(img);
                foto8.Image = Image.FromStream(ms);

            }


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void openDetail()
        {
            detailPilihan detail = new detailPilihan();
            detail.Show();
            this.Close();

        }

        private void Btndetail1_Click(object sender, EventArgs e)
        {
            id = id_kandidat_10[0];
            openDetail();
        }
    }
}
