using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZeroFake
{
    public partial class frmAprenda1 : Form
    {
        public frmAprenda1()
        {
            InitializeComponent();
        }

        private void AbrirAprenda2(object sender, EventArgs e)
        {
            this.Hide();
            frmAprenda2 tela = new frmAprenda2();
            tela.ShowDialog();
            this.Show();
        }

        private void Fechar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
