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
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void Button1_Click(object sender, EventArgs e)
        {
            var login = (from a in db.users
                        where a.UserName == textBox1.Text
                        && a.password == textBox2.Text
                        select a).FirstOrDefault();

            if (login != null)
            {
                WellcomeAdmin welcomead = new WellcomeAdmin();
                welcomead.Show();
                this.Hide();
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                lblerror.Visible = true;
                lblerror.Text = "Username dan Password harus di isi!";
            }
            else {
                lblerror.Visible = true;
                lblerror.Text = "Username atau Password salah!";
            }
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            loginPemilih lopem = new loginPemilih();
            lopem.Show();
            this.Hide();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
