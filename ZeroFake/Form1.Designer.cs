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
            btnSera = new Button();
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
            btnDetector.Font = new Font("Agency FB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetector.Location = new Point(26, 86);
            btnDetector.Name = "btnDetector";
            btnDetector.Size = new Size(213, 41);
            btnDetector.TabIndex = 2;
            btnDetector.Text = "Detector de Fake News";
            btnDetector.UseVisualStyleBackColor = false;
            // 
            // btnSera
            // 
            btnSera.BackColor = Color.MediumSpringGreen;
            btnSera.Cursor = Cursors.Hand;
            btnSera.FlatStyle = FlatStyle.Popup;
            btnSera.Font = new Font("Agency FB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSera.Location = new Point(26, 133);
            btnSera.Name = "btnSera";
            btnSera.Size = new Size(213, 41);
            btnSera.TabIndex = 3;
            btnSera.Text = "Será que é verdade?";
            btnSera.UseVisualStyleBackColor = false;
            // 
            // btnQuiz
            // 
            btnQuiz.BackColor = Color.FromArgb(255, 128, 0);
            btnQuiz.Cursor = Cursors.Hand;
            btnQuiz.FlatStyle = FlatStyle.Popup;
            btnQuiz.Font = new Font("Agency FB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuiz.Location = new Point(26, 180);
            btnQuiz.Name = "btnQuiz";
            btnQuiz.Size = new Size(213, 41);
            btnQuiz.TabIndex = 4;
            btnQuiz.Text = "Quiz";
            btnQuiz.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.Font = new Font("Agency FB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(26, 227);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(213, 41);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
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
            Controls.Add(btnSera);
            Controls.Add(btnDetector);
            Controls.Add(lblZeroFake);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblZeroFake;
        private Button btnDetector;
        private Button btnSera;
        private Button btnQuiz;
        private Button btnSair;
    }
}
