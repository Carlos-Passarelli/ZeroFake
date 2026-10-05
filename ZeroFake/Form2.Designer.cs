namespace ZeroFake
{
    partial class frmDetector
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
            btnComecarAnalise = new Button();
            lblTituloNoticia = new Label();
            lblNoticia = new Label();
            lblAutorNoticia = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnComecarAnalise
            // 
            btnComecarAnalise.Location = new Point(108, 42);
            btnComecarAnalise.Name = "btnComecarAnalise";
            btnComecarAnalise.Size = new Size(105, 37);
            btnComecarAnalise.TabIndex = 0;
            btnComecarAnalise.Text = "Começar Análise";
            btnComecarAnalise.UseVisualStyleBackColor = true;
            // 
            // lblTituloNoticia
            // 
            lblTituloNoticia.AutoSize = true;
            lblTituloNoticia.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloNoticia.Location = new Point(27, 137);
            lblTituloNoticia.Name = "lblTituloNoticia";
            lblTituloNoticia.Size = new Size(281, 23);
            lblTituloNoticia.TabIndex = 1;
            lblTituloNoticia.Text = "O Título da sua notícia aparece aqui";
            // 
            // lblNoticia
            // 
            lblNoticia.AutoSize = true;
            lblNoticia.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoticia.Location = new Point(27, 276);
            lblNoticia.Name = "lblNoticia";
            lblNoticia.Size = new Size(156, 20);
            lblNoticia.TabIndex = 2;
            lblNoticia.Text = "Sua notícia aparece aqui";
            // 
            // lblAutorNoticia
            // 
            lblAutorNoticia.AutoSize = true;
            lblAutorNoticia.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAutorNoticia.Location = new Point(27, 169);
            lblAutorNoticia.Name = "lblAutorNoticia";
            lblAutorNoticia.Size = new Size(220, 20);
            lblAutorNoticia.TabIndex = 3;
            lblAutorNoticia.Text = "O autor da sua notícia aparece aqui";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 198);
            label1.Name = "label1";
            label1.Size = new Size(215, 20);
            label1.TabIndex = 4;
            label1.Text = "A data da sua noticia aparece aqui";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 227);
            label2.Name = "label2";
            label2.Size = new Size(219, 20);
            label2.TabIndex = 5;
            label2.Text = "A fonte da sua noticia aparece aqui";
            // 
            // frmDetector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 630);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAutorNoticia);
            Controls.Add(lblNoticia);
            Controls.Add(lblTituloNoticia);
            Controls.Add(btnComecarAnalise);
            Name = "frmDetector";
            Text = "Detector de Fake News";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComecarAnalise;
        private Label lblTituloNoticia;
        private Label lblNoticia;
        private Label lblAutorNoticia;
        private Label label1;
        private Label label2;
    }
}