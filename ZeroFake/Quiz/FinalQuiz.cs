using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZeroFake
{
    public partial class frmFinalQuiz : Form
    {
        public frmFinalQuiz(int acertos, int erros)
        {
            InitializeComponent();

            lblQuantidadeCorretas.Text = acertos.ToString();
            lblQuantidadeIncorretas.Text = erros.ToString();

            int total = acertos + erros;
            double porcentagem = (double)acertos / total * 100;

            if (porcentagem <= 50)
                lblMensagemDesempenho.Text = "Continue treinando!";
            else if (porcentagem <= 80)
                lblMensagemDesempenho.Text = "Bom trabalho!";
            else
                lblMensagemDesempenho.Text = "Excelente!";
        }

        private void Fechar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TentarNovamente(object sender, EventArgs e)
        {

        }
    }
}
