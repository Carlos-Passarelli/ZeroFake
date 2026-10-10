namespace ZeroFake
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirAprenda1(object sender, EventArgs e)
        {
            this.Hide();
            frmAprenda1 tela = new frmAprenda1();
            tela.ShowDialog();
            this.Show();
        }

        private void Sair(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirQuiz(object sender, EventArgs e)
        {
            MessageBox.Show("Você escolheu o quiz" +
               "\n" +
               "\nCertifique-se de fazer o detector de notícias antes" +
               "\n" +
               "\nBoa sorte!");

            this.Hide();
            frmQuiz tela = new frmQuiz();
            tela.ShowDialog();
            this.Show();
        }

        private void AbrirDetectorFakeNews(object sender, EventArgs e)
        {
            this.Hide();
            frmDetector tela = new frmDetector();
            tela.ShowDialog();
            this.Show();
        }
    }
}
