namespace ZeroFake
{
    public partial class frmFinalDetectorDeFakeNews : Form
    {
        public frmFinalDetectorDeFakeNews(int noticiasAnalisadas, int checkboxesAcertados, int totalCheckboxes)
        {
            InitializeComponent();
            lblQuantidadeNoticiasAnalisadas.Text = $"{noticiasAnalisadas} de 10";
            lblQuantidadeCheckboxes.Text = $"{checkboxesAcertados} de {totalCheckboxes}";
            double porcentagem = totalCheckboxes == 0 ? 0 : checkboxesAcertados * 100.0 / totalCheckboxes;
            lblPorcentagemAcerto.Text = $"{porcentagem:0.#}%";
            lblMensagemDesempenho.Text = porcentagem <= 50 ? "Continue treinando!" : porcentagem <= 80 ? "Bom trabalho!" : "Excelente!";
            btnTentarNovamente.Click += (_, _) => DialogResult = DialogResult.Retry;
            btnFechar.Click += (_, _) => Close();
        }
    }
}
