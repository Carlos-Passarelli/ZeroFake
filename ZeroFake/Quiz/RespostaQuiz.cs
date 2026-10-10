using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZeroFake
{
    public partial class frmRespostaQuiz : Form
    {
        public frmRespostaQuiz(bool acertou, string alternativaCorreta, string explicacao)
        {
            InitializeComponent();

            if (acertou)
            {
                lblStatus.Text = "Você acertou!";
                lblStatus.ForeColor = Color.Green;
                lblTituloCorreta.Visible = false;
            }
            else
            {
                lblStatus.Text = "Você errou!";
                lblStatus.ForeColor = Color.Red;
            }

            lblAlternativaCorreta.Text = alternativaCorreta + "\n\n" + explicacao;
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
