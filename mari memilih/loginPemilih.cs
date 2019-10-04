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
    public partial class loginPemilih : Form
    {
        public loginPemilih()
        {
            InitializeComponent();
        }
        public static int id_pemilih;
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void Button1_Click(object sender, EventArgs e)
        {
            var loginPem = (from a in db.Pemilihs
                            where a.kodePemilih == textBox2.Text
                            select a).FirstOrDefault();

            if (loginPem != null)
            {
                if (loginPem.status == "sudah")
                {
                    lblerror.Text = "Kode ini sudah dipakai!";
                    lblerror.Visible = true;
                }
                else
                {
                    id_pemilih = loginPem.id;

                    wellcomePemilih wellpem = new wellcomePemilih();
                    wellpem.Show();
                    this.Hide();
                }
            }
            else if (textBox2.Text == "")
            {
                lblerror.Text = "Kode tidak boleh kosong!";
                lblerror.Visible = true;
            }
            else {

                lblerror.Text = "Maaf, kode salah.";
                lblerror.Visible = true;
            }


        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginFrom login = new LoginFrom();
            login.Show();
            this.Close();

        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            lblerror.Visible = false;
        }
    }
}
