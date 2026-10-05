namespace ZeroFake
{
    partial class frmQuiz
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
            gbxAlternativas = new GroupBox();
            btnAlternativa2 = new Button();
            btnAlternativa4 = new Button();
            btnAlternativa3 = new Button();
            btnAlternativa1 = new Button();
            label1 = new Label();
            lblNumeroPergunta = new Label();
            label2 = new Label();
            btnFechar = new Button();
            gbxAlternativas.SuspendLayout();
            SuspendLayout();
            // 
            // gbxAlternativas
            // 
            gbxAlternativas.AutoSize = true;
            gbxAlternativas.Controls.Add(btnAlternativa2);
            gbxAlternativas.Controls.Add(btnAlternativa4);
            gbxAlternativas.Controls.Add(btnAlternativa3);
            gbxAlternativas.Controls.Add(btnAlternativa1);
            gbxAlternativas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxAlternativas.Location = new Point(12, 217);
            gbxAlternativas.Name = "gbxAlternativas";
            gbxAlternativas.Size = new Size(526, 221);
            gbxAlternativas.TabIndex = 0;
            gbxAlternativas.TabStop = false;
            gbxAlternativas.Text = "Escolha uma alternativa";
            // 
            // btnAlternativa2
            // 
            btnAlternativa2.AutoSize = true;
            btnAlternativa2.BackColor = Color.FromArgb(255, 192, 192);
            btnAlternativa2.Cursor = Cursors.Hand;
            btnAlternativa2.FlatStyle = FlatStyle.Popup;
            btnAlternativa2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlternativa2.Location = new Point(6, 76);
            btnAlternativa2.Name = "btnAlternativa2";
            btnAlternativa2.Size = new Size(506, 36);
            btnAlternativa2.TabIndex = 4;
            btnAlternativa2.Text = "A segunda alternativa aparece aqui";
            btnAlternativa2.TextAlign = ContentAlignment.MiddleLeft;
            btnAlternativa2.UseVisualStyleBackColor = false;
            // 
            // btnAlternativa4
            // 
            btnAlternativa4.AutoSize = true;
            btnAlternativa4.BackColor = Color.FromArgb(192, 255, 192);
            btnAlternativa4.Cursor = Cursors.Hand;
            btnAlternativa4.FlatStyle = FlatStyle.Popup;
            btnAlternativa4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlternativa4.Location = new Point(6, 160);
            btnAlternativa4.Name = "btnAlternativa4";
            btnAlternativa4.Size = new Size(506, 36);
            btnAlternativa4.TabIndex = 3;
            btnAlternativa4.Text = "A quarta alternativa aparece aqui";
            btnAlternativa4.TextAlign = ContentAlignment.MiddleLeft;
            btnAlternativa4.UseVisualStyleBackColor = false;
            // 
            // btnAlternativa3
            // 
            btnAlternativa3.AutoSize = true;
            btnAlternativa3.BackColor = Color.FromArgb(255, 224, 192);
            btnAlternativa3.Cursor = Cursors.Hand;
            btnAlternativa3.FlatStyle = FlatStyle.Popup;
            btnAlternativa3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlternativa3.Location = new Point(6, 118);
            btnAlternativa3.Name = "btnAlternativa3";
            btnAlternativa3.Size = new Size(506, 36);
            btnAlternativa3.TabIndex = 2;
            btnAlternativa3.Text = "A terceira alternativa aparece aqui";
            btnAlternativa3.TextAlign = ContentAlignment.MiddleLeft;
            btnAlternativa3.UseVisualStyleBackColor = false;
            // 
            // btnAlternativa1
            // 
            btnAlternativa1.AutoSize = true;
            btnAlternativa1.BackColor = Color.FromArgb(192, 255, 255);
            btnAlternativa1.Cursor = Cursors.Hand;
            btnAlternativa1.FlatStyle = FlatStyle.Popup;
            btnAlternativa1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlternativa1.Location = new Point(6, 34);
            btnAlternativa1.Name = "btnAlternativa1";
            btnAlternativa1.Size = new Size(506, 36);
            btnAlternativa1.TabIndex = 1;
            btnAlternativa1.Text = "A primeira alternativa aparece aqui";
            btnAlternativa1.TextAlign = ContentAlignment.MiddleLeft;
            btnAlternativa1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 22);
            label1.TabIndex = 1;
            label1.Text = "Número da Pergunta:";
            // 
            // lblNumeroPergunta
            // 
            lblNumeroPergunta.AutoSize = true;
            lblNumeroPergunta.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroPergunta.ForeColor = Color.Black;
            lblNumeroPergunta.Location = new Point(226, 9);
            lblNumeroPergunta.Name = "lblNumeroPergunta";
            lblNumeroPergunta.Size = new Size(294, 23);
            lblNumeroPergunta.TabIndex = 2;
            lblNumeroPergunta.Text = "O número da sua pergunta aparece aqui";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 3;
            label2.Text = "Sua pergunta aparece aqui";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(434, 457);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(105, 33);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // frmQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(551, 502);
            Controls.Add(btnFechar);
            Controls.Add(label2);
            Controls.Add(lblNumeroPergunta);
            Controls.Add(label1);
            Controls.Add(gbxAlternativas);
            Name = "frmQuiz";
            Text = "Quiz";
            gbxAlternativas.ResumeLayout(false);
            gbxAlternativas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxAlternativas;
        private Button btnAlternativa1;
        private Button btnAlternativa2;
        private Button btnAlternativa4;
        private Button btnAlternativa3;
        private Label label1;
        private Label lblNumeroPergunta;
        private Label label2;
        private Button btnFechar;
    }
}