using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZeroFake
{
    public partial class frmAprenda2 : Form
    {
        public frmAprenda2()
        {
            InitializeComponent();
        }

        private void AbrirAprenda3(object sender, EventArgs e)
        {
            this.Hide();
            frmAprenda3 tela = new frmAprenda3();
            tela.ShowDialog();
            this.Show();
        }

        private void Fechar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
