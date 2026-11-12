namespace ZeroFake.Créditos
{
    partial class frmCreditos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreditos));
            lbl1 = new Label();
            lbl2 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            gbxCreditos = new GroupBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            btnFechar = new Button();
            lbl3 = new Label();
            gbxCreditos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(6, 19);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(288, 17);
            lbl1.TabIndex = 0;
            lbl1.Text = "Projeto de Programação de Computadores";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(6, 45);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(437, 17);
            lbl2.TabIndex = 1;
            lbl2.Text = "Professor Coordenador do Projeto: Prof. Dr. Elvio Gilberto da Silva";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl4.Location = new Point(6, 152);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(233, 17);
            lbl4.TabIndex = 3;
            lbl4.Text = "Carlos Eduardo Passarelli da Silva";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl5.Location = new Point(6, 179);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(141, 17);
            lbl5.TabIndex = 4;
            lbl5.Text = "Felipe Bissoli Botura";
            // 
            // gbxCreditos
            // 
            gbxCreditos.Controls.Add(lbl3);
            gbxCreditos.Controls.Add(lbl1);
            gbxCreditos.Controls.Add(lbl5);
            gbxCreditos.Controls.Add(lbl2);
            gbxCreditos.Controls.Add(lbl4);
            gbxCreditos.Location = new Point(12, 209);
            gbxCreditos.Name = "gbxCreditos";
            gbxCreditos.Size = new Size(482, 215);
            gbxCreditos.TabIndex = 5;
            gbxCreditos.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(137, 18);
            label1.TabIndex = 6;
            label1.Text = "Desenvolvimento:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatStyle = FlatStyle.Popup;
            btnFechar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(389, 443);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(105, 33);
            btnFechar.TabIndex = 8;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lbl3
            // 
            lbl3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(6, 73);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(437, 79);
            lbl3.TabIndex = 5;
            lbl3.Text = resources.GetString("lbl3.Text");
            // 
            // frmCreditos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(519, 493);
            Controls.Add(btnFechar);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(gbxCreditos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmCreditos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Créditos";
            gbxCreditos.ResumeLayout(false);
            gbxCreditos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label label2;
        private Label lbl4;
        private Label lbl5;
        private GroupBox gbxCreditos;
        private Label label1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Button btnFechar;
        private Label lbl3;
    }
}