namespace WindowsFormsApp1
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnEsquerdo = new System.Windows.Forms.Panel();
            this.pnCabeca = new System.Windows.Forms.Panel();
            this.lblTela = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnAdm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnVenda = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnCabeca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnEsquerdo
            // 
            this.pnEsquerdo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnEsquerdo.Location = new System.Drawing.Point(3, 58);
            this.pnEsquerdo.Name = "pnEsquerdo";
            this.pnEsquerdo.Size = new System.Drawing.Size(194, 100);
            this.pnEsquerdo.TabIndex = 0;
            // 
            // pnCabeca
            // 
            this.pnCabeca.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnCabeca.Controls.Add(this.lblTela);
            this.pnCabeca.Controls.Add(this.label1);
            this.pnCabeca.Controls.Add(this.lblNome);
            this.pnCabeca.Controls.Add(this.pictureBox1);
            this.pnCabeca.Controls.Add(this.pnEsquerdo);
            this.pnCabeca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabeca.Location = new System.Drawing.Point(0, 0);
            this.pnCabeca.Name = "pnCabeca";
            this.pnCabeca.Size = new System.Drawing.Size(1278, 52);
            this.pnCabeca.TabIndex = 1;
            // 
            // lblTela
            // 
            this.lblTela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTela.AutoSize = true;
            this.lblTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTela.Location = new System.Drawing.Point(642, 13);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(66, 29);
            this.lblTela.TabIndex = 10;
            this.lblTela.Text = "Tela";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome Usuário";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(19, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(72, 18);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Usuário:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1220, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 657);
            this.panel1.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel10.Controls.Add(this.pictureBox6);
            this.panel10.Controls.Add(this.btnAdm);
            this.panel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel10.Location = new System.Drawing.Point(4, 540);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(202, 68);
            this.panel10.TabIndex = 7;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(15, 13);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(45, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // btnAdm
            // 
            this.btnAdm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdm.FlatAppearance.BorderSize = 0;
            this.btnAdm.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdm.Location = new System.Drawing.Point(3, 3);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(196, 62);
            this.btnAdm.TabIndex = 5;
            this.btnAdm.TabStop = false;
            this.btnAdm.Text = "     ADMIN";
            this.btnAdm.UseVisualStyleBackColor = true;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btnVenda);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(4, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 68);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnVenda
            // 
            this.btnVenda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVenda.Location = new System.Drawing.Point(3, 3);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(196, 62);
            this.btnVenda.TabIndex = 2;
            this.btnVenda.TabStop = false;
            this.btnVenda.Text = "     VENDA";
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel7
            // 
            this.panel7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.btnAbrirCaixa);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(4, 35);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(202, 68);
            this.panel7.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbrirCaixa.FlatAppearance.BorderSize = 0;
            this.btnAbrirCaixa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbrirCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAbrirCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaixa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAbrirCaixa.Location = new System.Drawing.Point(3, 3);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAbrirCaixa.Size = new System.Drawing.Size(196, 62);
            this.btnAbrirCaixa.TabIndex = 1;
            this.btnAbrirCaixa.TabStop = false;
            this.btnAbrirCaixa.Text = "           ABRIR  / FECHAR    CAIXA";
            this.btnAbrirCaixa.UseCompatibleTextRendering = true;
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            this.btnAbrirCaixa.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel9
            // 
            this.panel9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel9.Controls.Add(this.pictureBox4);
            this.panel9.Controls.Add(this.btnEstoque);
            this.panel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel9.Location = new System.Drawing.Point(4, 291);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(202, 68);
            this.panel9.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // btnEstoque
            // 
            this.btnEstoque.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEstoque.Location = new System.Drawing.Point(3, 3);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(196, 62);
            this.btnEstoque.TabIndex = 3;
            this.btnEstoque.TabStop = false;
            this.btnEstoque.Text = "          ESTOQUE";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // panel8
            // 
            this.panel8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel8.Controls.Add(this.pictureBox5);
            this.panel8.Controls.Add(this.btnRelatorio);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(4, 417);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(202, 68);
            this.panel8.TabIndex = 7;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelatorio.Location = new System.Drawing.Point(3, 3);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(196, 62);
            this.btnRelatorio.TabIndex = 4;
            this.btnRelatorio.TabStop = false;
            this.btnRelatorio.Text = "                RELÁTORIOS";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 624);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Location = new System.Drawing.Point(212, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1066, 657);
            this.panel6.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 707);
            this.Controls.Add(this.pnCabeca);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnCabeca.ResumeLayout(false);
            this.pnCabeca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEsquerdo;
        private System.Windows.Forms.Panel pnCabeca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAbrirCaixa;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnRelatorio;
    }
}