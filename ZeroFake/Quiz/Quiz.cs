using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace ZeroFake
{
    public partial class frmQuiz : Form
    {
        private List<Pergunta> perguntas;
        private int indiceAtual = 0;

        public frmQuiz()
        {
            InitializeComponent();

            // Configurações do JSON
            string caminho = Path.Combine(AppContext.BaseDirectory, "perguntas.json");
            string json = File.ReadAllText(caminho);

            var opcoes = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            perguntas = JsonSerializer.Deserialize<List<Pergunta>>(json, opcoes);

            MostrarPergunta();
        }

        private void MostrarPergunta()
        {
            Pergunta p = perguntas[indiceAtual];

            lblNumeroPergunta.Text = (indiceAtual + 1) + " de " + perguntas.Count;
            lblPergunta.Text = p.Texto;
            btnAlternativa1.Text = p.Alternativas[0];
            btnAlternativa2.Text = p.Alternativas[1];
            btnAlternativa3.Text = p.Alternativas[2];
            btnAlternativa4.Text = p.Alternativas[3];
        }

        private int acertos = 0;
        private int erros = 0;


        private void ProximaPergunta()
        {
            indiceAtual++;

            if (indiceAtual < perguntas.Count)
            {
                MostrarPergunta();
            }
            else
            {
                frmFinalQuiz fim = new frmFinalQuiz(acertos, erros);
                DialogResult resultado = fim.ShowDialog();

                if (resultado == DialogResult.Retry)
                {
                    indiceAtual = 0;
                    acertos = 0;
                    erros = 0;
                    MostrarPergunta();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void ClicarAlternativa(object sender, EventArgs e)
        {
            Button clicado = (Button)sender;

            int escolhida = 0;
            if (clicado == btnAlternativa2) escolhida = 1;
            else if (clicado == btnAlternativa3) escolhida = 2;
            else if (clicado == btnAlternativa4) escolhida = 3;

            Pergunta p = perguntas[indiceAtual];
            bool acertou = (escolhida == p.RespostaCorreta);

            if (acertou) acertos++;
            else erros++;

            string textoCorreto = p.Alternativas[p.RespostaCorreta];

            frmRespostaQuiz resposta = new frmRespostaQuiz(acertou, textoCorreto, p.Explicacao);
            resposta.ShowDialog();

            ProximaPergunta();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Pergunta
        {
            public int Id { get; set; }

            [JsonPropertyName("pergunta")]
            public string Texto { get; set; }

            public string[] Alternativas { get; set; }

            public int RespostaCorreta { get; set; }

            public string Explicacao { get; set; }
    }
}
