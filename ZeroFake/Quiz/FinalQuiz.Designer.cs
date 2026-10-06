namespace ZeroFake
{
    partial class FinalQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalQuiz));
            label2 = new Label();
            lblQuantidadeCorretas = new Label();
            lblQuantidadeIncorretas = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            btnFechar = new Button();
            btnTentarNovamente = new Button();
            lblMensagemDesempenho = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(167, 19);
            label2.TabIndex = 1;
            label2.Text = "Respostas Corretas:";
            // 
            // lblQuantidadeCorretas
            // 
            lblQuantidadeCorretas.AutoSize = true;
            lblQuantidadeCorretas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidadeCorretas.Location = new Point(185, 12);
            lblQuantidadeCorretas.Name = "lblQuantidadeCorretas";
            lblQuantidadeCorretas.Size = new Size(267, 19);
            lblQuantidadeCorretas.TabIndex = 2;
            lblQuantidadeCorretas.Text = "Quantidade de respostas corretas";
            // 
            // lblQuantidadeIncorretas
            // 
            lblQuantidadeIncorretas.AutoSize = true;
            lblQuantidadeIncorretas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidadeIncorretas.Location = new Point(196, 42);
            lblQuantidadeIncorretas.Name = "lblQuantidadeIncorretas";
            lblQuantidadeIncorretas.Size = new Size(281, 19);
            lblQuantidadeIncorretas.TabIndex = 4;
            lblQuantidadeIncorretas.Text = "Quantidade de respostas incorretas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(12, 42);
            label4.Name = "label4";
            label4.Size = new Size(178, 19);
            label4.TabIndex = 3;
            label4.Text = "Respostas Incorretas:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblQuantidadeIncorretas);
            panel1.Controls.Add(lblQuantidadeCorretas);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 76);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(178, 66);
            label5.Name = "label5";
            label5.Size = new Size(161, 23);
            label5.TabIndex = 6;
            label5.Text = "Você finalizou o quiz";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(337, 195);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(165, 33);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // btnTentarNovamente
            // 
            btnTentarNovamente.BackColor = Color.DodgerBlue;
            btnTentarNovamente.Cursor = Cursors.Hand;
            btnTentarNovamente.FlatStyle = FlatStyle.Popup;
            btnTentarNovamente.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTentarNovamente.ForeColor = Color.White;
            btnTentarNovamente.Location = new Point(12, 195);
            btnTentarNovamente.Name = "btnTentarNovamente";
            btnTentarNovamente.Size = new Size(165, 33);
            btnTentarNovamente.TabIndex = 11;
            btnTentarNovamente.Text = "Tentar novamente";
            btnTentarNovamente.UseVisualStyleBackColor = false;
            // 
            // lblMensagemDesempenho
            // 
            lblMensagemDesempenho.AutoSize = true;
            lblMensagemDesempenho.BackColor = Color.Transparent;
            lblMensagemDesempenho.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagemDesempenho.Location = new Point(96, 22);
            lblMensagemDesempenho.Name = "lblMensagemDesempenho";
            lblMensagemDesempenho.Size = new Size(334, 32);
            lblMensagemDesempenho.TabIndex = 12;
            lblMensagemDesempenho.Text = "Mensagem desempenho";
            // 
            // FinalQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(514, 240);
            Controls.Add(lblMensagemDesempenho);
            Controls.Add(btnTentarNovamente);
            Controls.Add(btnFechar);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "FinalQuiz";
            Text = "Final do Quiz";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label lblQuantidadeCorretas;
        private Label lblQuantidadeIncorretas;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Button btnFechar;
        private Button btnTentarNovamente;
        private Label lblMensagemDesempenho;
    }
}