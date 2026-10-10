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
            SuspendLayout();
            // 
            // lblZeroFake
            // 
            lblZeroFake.AutoSize = true;
            lblZeroFake.BackColor = Color.Transparent;
            lblZeroFake.FlatStyle = FlatStyle.Popup;
            lblZeroFake.Font = new Font("Agency FB", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZeroFake.Location = new Point(45, 9);
            lblZeroFake.Name = "lblZeroFake";
            lblZeroFake.Size = new Size(170, 59);
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
            btnDetector.TabIndex = 2;
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
            btnQuiz.TabIndex = 4;
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
            btnSair.Location = new Point(26, 227);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(213, 41);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += Sair;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(270, 280);
            Controls.Add(btnSair);
            Controls.Add(btnQuiz);
            Controls.Add(btnAprenda);
            Controls.Add(btnDetector);
            Controls.Add(lblZeroFake);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
    }
}
