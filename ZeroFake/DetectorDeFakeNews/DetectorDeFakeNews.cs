using System.Text.Json;

namespace ZeroFake
{
    public partial class frmDetector : Form
    {
        private const int TotalNoticias = 10;
        private List<NoticiaDetector> noticias = new();
        private int indiceNoticia;
        private int totalCheckboxesAcertados;

        public frmDetector()
        {
            InitializeComponent();
            btnComecarAnalise.Click += BtnComecarAnalise_Click;
            btnFinalizarAnalise.Click += BtnFinalizarAnalise_Click;
            btnSair.Click += (_, _) => this.Close();
        }

        private void BtnComecarAnalise_Click(object? sender, EventArgs e)
        {
            try
            {
                CarregarNoticias();
                if (noticias.Count < TotalNoticias)
                {
                    MessageBox.Show($"O arquivo noticias.json precisa conter pelo menos {TotalNoticias} notícias.", "Detector de Fake News", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                indiceNoticia = 0;
                totalCheckboxesAcertados = 0;
                HabilitarAnalise(true);
                ExibirNoticiaAtual();
            }
            catch (Exception ex) when (ex is IOException || ex is JsonException || ex is UnauthorizedAccessException)
            {
                MessageBox.Show($"Não foi possível carregar as notícias do arquivo noticias.json.\n\n{ex.Message}", "Erro ao carregar notícias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnFinalizarAnalise_Click(object? sender, EventArgs e)
        {
            NoticiaDetector noticia = noticias[indiceNoticia];
            bool[] respostas = ObterRespostasMarcadas();
            bool[] gabarito = noticia.Gabarito.ComoArray();
            int acertosNoticia = respostas.Zip(gabarito, (resposta, correta) => resposta == correta ? 1 : 0).Sum();
            totalCheckboxesAcertados += acertosNoticia;

            using (var resultado = new ResultadoDetectorDeFakeNews(
                noticia.Classificacao,
                noticia.SinaisDeAlerta,
                acertosNoticia,
                gabarito.Length))
            {
                resultado.ShowDialog(this);
            }

            indiceNoticia++;
            LimparRespostas();

            if (indiceNoticia < TotalNoticias)
            {
                ExibirNoticiaAtual();
                return;
            }

            using var telaFinal = new frmFinalDetectorDeFakeNews(TotalNoticias, totalCheckboxesAcertados, TotalNoticias * 5);
            if (telaFinal.ShowDialog(this) == DialogResult.Retry)
            {
                indiceNoticia = 0;
                totalCheckboxesAcertados = 0;
                LimparRespostas();
                ExibirNoticiaAtual();
            }
            else
            {
                HabilitarAnalise(false);
            }
        }

        private void CarregarNoticias()
        {
            string caminho = Path.Combine(AppContext.BaseDirectory, "noticias.json");
            string json = File.ReadAllText(caminho);
            noticias = JsonSerializer.Deserialize<List<NoticiaDetector>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<NoticiaDetector>();
        }

        private void ExibirNoticiaAtual()
        {
            NoticiaDetector noticia = noticias[indiceNoticia];
            lblTituloNoticia.Text = noticia.Titulo;
            lblAutorNoticia.Text = string.IsNullOrWhiteSpace(noticia.Autor) ? "Autor não informado" : $"Autor: {noticia.Autor}";
            lblDataNoticia.Text = string.IsNullOrWhiteSpace(noticia.Data) ? "Data não informada" : $"Data: {noticia.Data}";
            lblFonteNoticia.Text = string.IsNullOrWhiteSpace(noticia.Fonte) ? "Fonte não informada" : $"Fonte: {noticia.Fonte}";
            lblNoticia.Text = noticia.Texto;
            gbxNoticia.Text = $"Analise a notícia abaixo ({indiceNoticia + 1}/{TotalNoticias}):";
        }

        private bool[] ObterRespostasMarcadas() => new[]
        {
            chkAutor.Checked, chkData.Checked, chkTitulo.Checked,
            chkLinguagem.Checked, chkFonte.Checked
        };

        private void LimparRespostas()
        {
            chkAutor.Checked = false;
            chkData.Checked = false;
            chkTitulo.Checked = false;
            chkLinguagem.Checked = false;
            chkFonte.Checked = false;
        }

        private void HabilitarAnalise(bool habilitada)
        {
            gbxNoticia.Enabled = habilitada;
            chkAutor.Enabled = habilitada;
            chkFonte.Enabled = habilitada;
            chkData.Enabled = habilitada;
            chkLinguagem.Enabled = habilitada;
            chkTitulo.Enabled = habilitada;
            btnFinalizarAnalise.Enabled = habilitada;
        }

        private sealed class NoticiaDetector
        {
            public string Titulo { get; set; } = string.Empty;
            public string Fonte { get; set; } = string.Empty;
            public string Autor { get; set; } = string.Empty;
            public string Data { get; set; } = string.Empty;
            public string Texto { get; set; } = string.Empty;
            public string Classificacao { get; set; } = string.Empty;
            public List<string> SinaisDeAlerta { get; set; } = new();
            public GabaritoDetector Gabarito { get; set; } = new();
        }

        private sealed class GabaritoDetector
        {
            public bool AutorDesconhecido { get; set; }
            public bool DataAntiga { get; set; }
            public bool TituloExagerado { get; set; }
            public bool LinguagemSensacionalista { get; set; }
            public bool FonteDesconhecida { get; set; }

            public bool[] ComoArray() => new[]
            {
                AutorDesconhecido, DataAntiga, TituloExagerado,
                LinguagemSensacionalista, FonteDesconhecida
            };
        }
    }
}
