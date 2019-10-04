using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace mari_memilih
{
    public partial class detailPilihan : Form
    {
        public detailPilihan()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void DetailPilihan_Load(object sender, EventArgs e)
        {
            var kand = (from a in db.kandidats
                       where a.id == frmPilihan.id select a).FirstOrDefault();

            if (kand != null)
            {
                labelNama.Text = kand.Nama;
                byte[] img = new byte[0];
                img = kand.Foto.ToArray();
                MemoryStream ms = new MemoryStream(img);
                FotoKandidat.Image = Image.FromStream(ms);
                txtvisi.Text = kand.Visi;
                txtMisi.Text = kand.Misi;
                lblkelas.Text = kand.Kelas;
            }
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmPilihan piliha = new frmPilihan();
            piliha.Show();
            this.Close();

        }

        private void Btndetail1_Click(object sender, EventArgs e)
        {
            var mess =  MessageBox.Show("Pilih "+ labelNama.Text,"Yakin?",MessageBoxButtons.YesNo) ;
            if(mess == DialogResult.Yes)
            {
                kandidat kandidat = new kandidat();
                kandidat = db.kandidats.Single(x => x.id == frmPilihan.id);
                kandidat.Suara += 1;
                db.SubmitChanges();

                Pemilih pemil = new Pemilih();
                pemil = db.Pemilihs.Single(x => x.id == loginPemilih.id_pemilih);
                if(pemil.status == "belum")
                {
                    pemil.status = lblkelas.Text;

                    db.SubmitChanges();
                    frmPilihan piliha = new frmPilihan();
                    piliha.Show();
                    this.Close();
                }
                else if(pemil.status == "10"|| pemil.status == "11")
                {
                    pemil.status = "sudah";

                    db.SubmitChanges();
                    loginPemilih login = new loginPemilih();
                    login.Show();
                    this.Close();
                }
            }


        }
    }
}
