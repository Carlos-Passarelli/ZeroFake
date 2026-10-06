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
            lblDataNoticia = new Label();
            lblFonteNoticia = new Label();
            gbxNoticia = new GroupBox();
            chkAutor = new CheckBox();
            chkFonte = new CheckBox();
            chkData = new CheckBox();
            chkLinguagem = new CheckBox();
            chkTitulo = new CheckBox();
            btnFinalizarAnalise = new Button();
            gbxNoticia.SuspendLayout();
            SuspendLayout();
            // 
            // btnComecarAnalise
            // 
            btnComecarAnalise.AutoSize = true;
            btnComecarAnalise.BackColor = Color.DodgerBlue;
            btnComecarAnalise.Cursor = Cursors.Hand;
            btnComecarAnalise.FlatStyle = FlatStyle.Popup;
            btnComecarAnalise.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComecarAnalise.Location = new Point(12, 12);
            btnComecarAnalise.Name = "btnComecarAnalise";
            btnComecarAnalise.Size = new Size(729, 37);
            btnComecarAnalise.TabIndex = 0;
            btnComecarAnalise.Text = "Começar Análise";
            btnComecarAnalise.UseVisualStyleBackColor = false;
            // 
            // lblTituloNoticia
            // 
            lblTituloNoticia.AutoSize = true;
            lblTituloNoticia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloNoticia.Location = new Point(15, 32);
            lblTituloNoticia.Name = "lblTituloNoticia";
            lblTituloNoticia.Size = new Size(280, 19);
            lblTituloNoticia.TabIndex = 1;
            lblTituloNoticia.Text = "O Título da sua notícia aparece aqui";
            lblTituloNoticia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNoticia
            // 
            lblNoticia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoticia.Location = new Point(16, 170);
            lblNoticia.Name = "lblNoticia";
            lblNoticia.Size = new Size(696, 200);
            lblNoticia.TabIndex = 2;
            lblNoticia.Text = "Sua notícia aparece aqui";
            // 
            // lblAutorNoticia
            // 
            lblAutorNoticia.AutoSize = true;
            lblAutorNoticia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAutorNoticia.Location = new Point(15, 66);
            lblAutorNoticia.Name = "lblAutorNoticia";
            lblAutorNoticia.Size = new Size(255, 18);
            lblAutorNoticia.TabIndex = 3;
            lblAutorNoticia.Text = "O autor da sua notícia aparece aqui";
            lblAutorNoticia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDataNoticia
            // 
            lblDataNoticia.AutoSize = true;
            lblDataNoticia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataNoticia.Location = new Point(15, 96);
            lblDataNoticia.Name = "lblDataNoticia";
            lblDataNoticia.Size = new Size(250, 18);
            lblDataNoticia.TabIndex = 4;
            lblDataNoticia.Text = "A data da sua noticia aparece aqui";
            // 
            // lblFonteNoticia
            // 
            lblFonteNoticia.AutoSize = true;
            lblFonteNoticia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFonteNoticia.Location = new Point(16, 125);
            lblFonteNoticia.Name = "lblFonteNoticia";
            lblFonteNoticia.Size = new Size(253, 18);
            lblFonteNoticia.TabIndex = 5;
            lblFonteNoticia.Text = "A fonte da sua noticia aparece aqui";
            // 
            // gbxNoticia
            // 
            gbxNoticia.AutoSize = true;
            gbxNoticia.Controls.Add(lblAutorNoticia);
            gbxNoticia.Controls.Add(lblNoticia);
            gbxNoticia.Controls.Add(lblFonteNoticia);
            gbxNoticia.Controls.Add(lblTituloNoticia);
            gbxNoticia.Controls.Add(lblDataNoticia);
            gbxNoticia.Enabled = false;
            gbxNoticia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxNoticia.Location = new Point(12, 67);
            gbxNoticia.Name = "gbxNoticia";
            gbxNoticia.Size = new Size(730, 401);
            gbxNoticia.TabIndex = 6;
            gbxNoticia.TabStop = false;
            gbxNoticia.Text = "Analise a notícia abaixo:";
            // 
            // chkAutor
            // 
            chkAutor.Cursor = Cursors.Hand;
            chkAutor.Enabled = false;
            chkAutor.FlatStyle = FlatStyle.Popup;
            chkAutor.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAutor.Location = new Point(12, 474);
            chkAutor.Name = "chkAutor";
            chkAutor.Size = new Size(147, 24);
            chkAutor.TabIndex = 7;
            chkAutor.Text = "Autor desconhecido";
            chkAutor.UseVisualStyleBackColor = true;
            // 
            // chkFonte
            // 
            chkFonte.AutoSize = true;
            chkFonte.Cursor = Cursors.Hand;
            chkFonte.Enabled = false;
            chkFonte.FlatStyle = FlatStyle.Popup;
            chkFonte.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkFonte.Location = new Point(226, 504);
            chkFonte.Name = "chkFonte";
            chkFonte.Size = new Size(149, 24);
            chkFonte.TabIndex = 8;
            chkFonte.Text = "Fonte desconhecida";
            chkFonte.UseVisualStyleBackColor = true;
            // 
            // chkData
            // 
            chkData.AutoSize = true;
            chkData.Cursor = Cursors.Hand;
            chkData.Enabled = false;
            chkData.FlatStyle = FlatStyle.Popup;
            chkData.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkData.Location = new Point(226, 474);
            chkData.Name = "chkData";
            chkData.Size = new Size(180, 24);
            chkData.TabIndex = 9;
            chkData.Text = "Data de publicação antiga";
            chkData.UseVisualStyleBackColor = true;
            // 
            // chkLinguagem
            // 
            chkLinguagem.AutoSize = true;
            chkLinguagem.Cursor = Cursors.Hand;
            chkLinguagem.Enabled = false;
            chkLinguagem.FlatStyle = FlatStyle.Popup;
            chkLinguagem.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkLinguagem.Location = new Point(12, 504);
            chkLinguagem.Name = "chkLinguagem";
            chkLinguagem.Size = new Size(187, 24);
            chkLinguagem.TabIndex = 10;
            chkLinguagem.Text = "Linguagem sensacionalista";
            chkLinguagem.UseVisualStyleBackColor = true;
            // 
            // chkTitulo
            // 
            chkTitulo.AutoSize = true;
            chkTitulo.Cursor = Cursors.Hand;
            chkTitulo.Enabled = false;
            chkTitulo.FlatStyle = FlatStyle.Popup;
            chkTitulo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkTitulo.Location = new Point(422, 474);
            chkTitulo.Name = "chkTitulo";
            chkTitulo.Size = new Size(126, 24);
            chkTitulo.TabIndex = 11;
            chkTitulo.Text = "Título exagerado";
            chkTitulo.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarAnalise
            // 
            btnFinalizarAnalise.AutoSize = true;
            btnFinalizarAnalise.BackColor = Color.Salmon;
            btnFinalizarAnalise.Cursor = Cursors.Hand;
            btnFinalizarAnalise.Enabled = false;
            btnFinalizarAnalise.FlatStyle = FlatStyle.Popup;
            btnFinalizarAnalise.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarAnalise.Location = new Point(12, 544);
            btnFinalizarAnalise.Name = "btnFinalizarAnalise";
            btnFinalizarAnalise.Size = new Size(729, 37);
            btnFinalizarAnalise.TabIndex = 12;
            btnFinalizarAnalise.Text = "Finalizar Análise";
            btnFinalizarAnalise.UseVisualStyleBackColor = false;
            // 
            // frmDetector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(754, 594);
            Controls.Add(btnFinalizarAnalise);
            Controls.Add(chkTitulo);
            Controls.Add(chkLinguagem);
            Controls.Add(chkData);
            Controls.Add(chkFonte);
            Controls.Add(chkAutor);
            Controls.Add(gbxNoticia);
            Controls.Add(btnComecarAnalise);
            Name = "frmDetector";
            Text = "Detector de Fake News";
            gbxNoticia.ResumeLayout(false);
            gbxNoticia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComecarAnalise;
        private Label lblTituloNoticia;
        private Label lblNoticia;
        private Label lblAutorNoticia;
        private Label lblDataNoticia;
        private Label lblFonteNoticia;
        private GroupBox gbxNoticia;
        private CheckBox chkAutor;
        private CheckBox chkFonte;
        private CheckBox chkData;
        private CheckBox chkLinguagem;
        private CheckBox chkTitulo;
        private Button btnFinalizarAnalise;
    }
}