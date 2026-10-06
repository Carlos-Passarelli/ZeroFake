namespace ZeroFake
{
    partial class frmFinalDetectorDeFakeNews
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalDetectorDeFakeNews));
            lblMensagemDesempenho = new Label();
            label5 = new Label();
            label2 = new Label();
            lblQuantidadeCheckboxes = new Label();
            label4 = new Label();
            lblQuantidadeNoticiasAnalisadas = new Label();
            label3 = new Label();
            lblPorcentagemAcerto = new Label();
            panel1 = new Panel();
            btnTentarNovamente = new Button();
            btnFechar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMensagemDesempenho
            // 
            lblMensagemDesempenho.AutoSize = true;
            lblMensagemDesempenho.BackColor = Color.Transparent;
            lblMensagemDesempenho.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagemDesempenho.Location = new Point(121, 29);
            lblMensagemDesempenho.Name = "lblMensagemDesempenho";
            lblMensagemDesempenho.Size = new Size(334, 32);
            lblMensagemDesempenho.TabIndex = 1;
            lblMensagemDesempenho.Text = "Mensagem desempenho";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(156, 74);
            label5.Name = "label5";
            label5.Size = new Size(227, 23);
            label5.TabIndex = 7;
            label5.Text = "Você analisou todas as notícias";
            label5.Click += this.label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(13, 13);
            label2.Name = "label2";
            label2.Size = new Size(164, 19);
            label2.TabIndex = 8;
            label2.Text = "Notícias Analisadas:";
            // 
            // lblQuantidadeCheckboxes
            // 
            lblQuantidadeCheckboxes.AutoSize = true;
            lblQuantidadeCheckboxes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidadeCheckboxes.Location = new Point(211, 43);
            lblQuantidadeCheckboxes.Name = "lblQuantidadeCheckboxes";
            lblQuantidadeCheckboxes.Size = new Size(296, 19);
            lblQuantidadeCheckboxes.TabIndex = 9;
            lblQuantidadeCheckboxes.Text = "Quantidade de checkboxes acertadas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(13, 43);
            label4.Name = "label4";
            label4.Size = new Size(190, 19);
            label4.TabIndex = 10;
            label4.Text = "Checkboxes acertadas:";
            // 
            // lblQuantidadeNoticiasAnalisadas
            // 
            lblQuantidadeNoticiasAnalisadas.AutoSize = true;
            lblQuantidadeNoticiasAnalisadas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidadeNoticiasAnalisadas.Location = new Point(183, 13);
            lblQuantidadeNoticiasAnalisadas.Name = "lblQuantidadeNoticiasAnalisadas";
            lblQuantidadeNoticiasAnalisadas.Size = new Size(270, 19);
            lblQuantidadeNoticiasAnalisadas.TabIndex = 11;
            lblQuantidadeNoticiasAnalisadas.Text = "Quantidade de notícias analisadas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(15, 75);
            label3.Name = "label3";
            label3.Size = new Size(192, 19);
            label3.TabIndex = 12;
            label3.Text = "Porcentagem de acerto:";
            // 
            // lblPorcentagemAcerto
            // 
            lblPorcentagemAcerto.AutoSize = true;
            lblPorcentagemAcerto.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentagemAcerto.Location = new Point(211, 75);
            lblPorcentagemAcerto.Name = "lblPorcentagemAcerto";
            lblPorcentagemAcerto.Size = new Size(288, 19);
            lblPorcentagemAcerto.TabIndex = 13;
            lblPorcentagemAcerto.Text = "Porcentagem de acerto aparece aqui";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblPorcentagemAcerto);
            panel1.Controls.Add(lblQuantidadeCheckboxes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblQuantidadeNoticiasAnalisadas);
            panel1.Location = new Point(21, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 107);
            panel1.TabIndex = 14;
            // 
            // btnTentarNovamente
            // 
            btnTentarNovamente.BackColor = Color.DodgerBlue;
            btnTentarNovamente.Cursor = Cursors.Hand;
            btnTentarNovamente.FlatStyle = FlatStyle.Popup;
            btnTentarNovamente.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTentarNovamente.ForeColor = Color.White;
            btnTentarNovamente.Location = new Point(21, 245);
            btnTentarNovamente.Name = "btnTentarNovamente";
            btnTentarNovamente.Size = new Size(165, 33);
            btnTentarNovamente.TabIndex = 14;
            btnTentarNovamente.Text = "Tentar novamente";
            btnTentarNovamente.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(373, 245);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(165, 33);
            btnFechar.TabIndex = 15;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // frmFinalDetectorDeFakeNews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(559, 290);
            Controls.Add(btnFechar);
            Controls.Add(btnTentarNovamente);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(lblMensagemDesempenho);
            Name = "frmFinalDetectorDeFakeNews";
            Text = "Final do Detector de Fake News";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensagemDesempenho;
        private Label label5;
        private Label label2;
        private Label lblQuantidadeCheckboxes;
        private Label label4;
        private Label lblQuantidadeNoticiasAnalisadas;
        private Label label3;
        private Label lblPorcentagemAcerto;
        private Panel panel1;
        private Button btnTentarNovamente;
        private Button btnFechar;
    }
}