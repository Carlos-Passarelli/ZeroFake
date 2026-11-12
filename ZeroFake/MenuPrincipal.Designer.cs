namespace ZeroFake
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            lblZeroFake = new Label();
            btnDetector = new Button();
            btnAprenda = new Button();
            btnQuiz = new Button();
            btnSair = new Button();
            btnCredito = new Button();
            SuspendLayout();
            // 
            // lblZeroFake
            // 
            lblZeroFake.AutoSize = true;
            lblZeroFake.BackColor = Color.Transparent;
            lblZeroFake.FlatStyle = FlatStyle.Popup;
            lblZeroFake.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZeroFake.Location = new Point(12, 9);
            lblZeroFake.Name = "lblZeroFake";
            lblZeroFake.Size = new Size(238, 55);
            lblZeroFake.TabIndex = 0;
            lblZeroFake.Text = "ZeroFake";
            // 
            // btnDetector
            // 
            btnDetector.BackColor = Color.Cyan;
            btnDetector.Cursor = Cursors.Hand;
            btnDetector.FlatStyle = FlatStyle.Popup;
            btnDetector.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetector.Location = new Point(26, 86);
            btnDetector.Name = "btnDetector";
            btnDetector.Size = new Size(213, 41);
            btnDetector.TabIndex = 1;
            btnDetector.Text = "Detector de Fake News";
            btnDetector.UseVisualStyleBackColor = false;
            btnDetector.Click += AbrirDetectorFakeNews;
            // 
            // btnAprenda
            // 
            btnAprenda.BackColor = Color.MediumSpringGreen;
            btnAprenda.Cursor = Cursors.Hand;
            btnAprenda.FlatStyle = FlatStyle.Popup;
            btnAprenda.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAprenda.Location = new Point(26, 180);
            btnAprenda.Name = "btnAprenda";
            btnAprenda.Size = new Size(213, 41);
            btnAprenda.TabIndex = 3;
            btnAprenda.Text = "Aprenda";
            btnAprenda.UseVisualStyleBackColor = false;
            btnAprenda.Click += AbrirAprenda1;
            // 
            // btnQuiz
            // 
            btnQuiz.BackColor = Color.FromArgb(255, 128, 0);
            btnQuiz.Cursor = Cursors.Hand;
            btnQuiz.FlatStyle = FlatStyle.Popup;
            btnQuiz.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuiz.Location = new Point(26, 133);
            btnQuiz.Name = "btnQuiz";
            btnQuiz.Size = new Size(213, 41);
            btnQuiz.TabIndex = 2;
            btnQuiz.Text = "Quiz";
            btnQuiz.UseVisualStyleBackColor = false;
            btnQuiz.Click += AbrirQuiz;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(26, 274);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(213, 41);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += Sair;
            // 
            // btnCredito
            // 
            btnCredito.BackColor = Color.Silver;
            btnCredito.Cursor = Cursors.Hand;
            btnCredito.FlatStyle = FlatStyle.Popup;
            btnCredito.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCredito.Location = new Point(26, 227);
            btnCredito.Name = "btnCredito";
            btnCredito.Size = new Size(213, 41);
            btnCredito.TabIndex = 5;
            btnCredito.Text = "Créditos";
            btnCredito.UseVisualStyleBackColor = false;
            btnCredito.Click += btnCredito_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(270, 330);
            Controls.Add(btnCredito);
            Controls.Add(btnSair);
            Controls.Add(btnQuiz);
            Controls.Add(btnAprenda);
            Controls.Add(btnDetector);
            Controls.Add(lblZeroFake);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblZeroFake;
        private Button btnDetector;
        private Button btnAprenda;
        private Button btnQuiz;
        private Button btnSair;
        private Button btnCreditos;
        private Button btnCredito;
    }
}
