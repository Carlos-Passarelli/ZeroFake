namespace ZeroFake
{
    partial class frmRespostaQuiz
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
            lblStatus = new Label();
            lblTituloCorreta = new Label();
            lblAlternativaCorreta = new Label();
            btnProsseguir = new Button();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(142, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(199, 29);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloCorreta
            // 
            lblTituloCorreta.AutoSize = true;
            lblTituloCorreta.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloCorreta.Location = new Point(12, 70);
            lblTituloCorreta.Name = "lblTituloCorreta";
            lblTituloCorreta.Size = new Size(154, 19);
            lblTituloCorreta.TabIndex = 1;
            lblTituloCorreta.Text = "Alternativa correta:";
            // 
            // lblAlternativaCorreta
            // 
            lblAlternativaCorreta.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlternativaCorreta.Location = new Point(12, 98);
            lblAlternativaCorreta.Name = "lblAlternativaCorreta";
            lblAlternativaCorreta.Size = new Size(459, 118);
            lblAlternativaCorreta.TabIndex = 2;
            lblAlternativaCorreta.Text = "A alternativa correta aparece aqui";
            // 
            // btnProsseguir
            // 
            btnProsseguir.BackColor = Color.DodgerBlue;
            btnProsseguir.Cursor = Cursors.Hand;
            btnProsseguir.FlatStyle = FlatStyle.Popup;
            btnProsseguir.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProsseguir.ForeColor = Color.White;
            btnProsseguir.Location = new Point(188, 230);
            btnProsseguir.Name = "btnProsseguir";
            btnProsseguir.Size = new Size(105, 33);
            btnProsseguir.TabIndex = 8;
            btnProsseguir.Text = "Prosseguir";
            btnProsseguir.UseVisualStyleBackColor = false;
            btnProsseguir.Click += btnProsseguir_Click;
            // 
            // frmRespostaQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 275);
            Controls.Add(btnProsseguir);
            Controls.Add(lblAlternativaCorreta);
            Controls.Add(lblTituloCorreta);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmRespostaQuiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resposta do Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Label lblTituloCorreta;
        private Label lblAlternativaCorreta;
        private Button btnProsseguir;
    }
}