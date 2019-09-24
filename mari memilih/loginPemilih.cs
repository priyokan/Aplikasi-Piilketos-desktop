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

        private void Button1_Click(object sender, EventArgs e)
        {
            wellcomePemilih wellpem = new wellcomePemilih();
            wellpem.Show();
            this.Hide();

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginFrom login = new LoginFrom();
            login.Show();
            this.Close();

        }
    }
}
