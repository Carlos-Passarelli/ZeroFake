namespace ZeroFake
{
    public partial class ResultadoDetectorDeFakeNews : Form
    {
        public ResultadoDetectorDeFakeNews(string classificacao, IEnumerable<string> sinaisDeAlerta, int acertos, int totalCheckboxes)
        {
            InitializeComponent();
            label5.Text = classificacao;
            label5.ForeColor = classificacao.ToLowerInvariant() switch
            {
                "confiavel" => Color.ForestGreen,
                "falsa" => Color.Firebrick,
                _ => Color.DarkGoldenrod
            };
            label3.Text = sinaisDeAlerta.Any() ? string.Join(", ", sinaisDeAlerta) : "Nenhum sinal de alerta informado.";
            label7.Text = $"{acertos} de {totalCheckboxes}";
            btnFechar.Click += (_, _) => Close();
        }

        private void button1_Click(object? sender, EventArgs e) => Close();
    }
}
