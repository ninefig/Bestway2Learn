namespace Bestway2Learn
{
    partial class TelaInicial
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
            this.lblOla = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.btnTecnologia = new System.Windows.Forms.Button();
            this.btnCiencias = new System.Windows.Forms.Button();
            this.btnPortugues = new System.Windows.Forms.Button();
            this.lblOutraOpcao = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgLearn = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFontes = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLearn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOla
            // 
            this.lblOla.AutoSize = true;
            this.lblOla.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOla.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblOla.Location = new System.Drawing.Point(170, 35);
            this.lblOla.Name = "lblOla";
            this.lblOla.Size = new System.Drawing.Size(90, 37);
            this.lblOla.TabIndex = 0;
            this.lblOla.Text = "Olá! ";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTema.Location = new System.Drawing.Point(89, 193);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(261, 29);
            this.lblTema.TabIndex = 1;
            this.lblTema.Text = "Escolha abaixo o tema:";
            // 
            // btnTecnologia
            // 
            this.btnTecnologia.Location = new System.Drawing.Point(91, 241);
            this.btnTecnologia.Name = "btnTecnologia";
            this.btnTecnologia.Size = new System.Drawing.Size(256, 39);
            this.btnTecnologia.TabIndex = 2;
            this.btnTecnologia.Text = "Tecnologia";
            this.btnTecnologia.UseVisualStyleBackColor = true;
            this.btnTecnologia.Click += new System.EventHandler(this.btnTecnologia_Click);
            // 
            // btnCiencias
            // 
            this.btnCiencias.Location = new System.Drawing.Point(91, 299);
            this.btnCiencias.Name = "btnCiencias";
            this.btnCiencias.Size = new System.Drawing.Size(256, 39);
            this.btnCiencias.TabIndex = 3;
            this.btnCiencias.Text = "Ciências";
            this.btnCiencias.UseVisualStyleBackColor = true;
            this.btnCiencias.Click += new System.EventHandler(this.btnCiencias_Click);
            // 
            // btnPortugues
            // 
            this.btnPortugues.Location = new System.Drawing.Point(91, 355);
            this.btnPortugues.Name = "btnPortugues";
            this.btnPortugues.Size = new System.Drawing.Size(256, 39);
            this.btnPortugues.TabIndex = 4;
            this.btnPortugues.Text = "Português";
            this.btnPortugues.UseVisualStyleBackColor = true;
            this.btnPortugues.Click += new System.EventHandler(this.btnPortugues_Click);
            // 
            // lblOutraOpcao
            // 
            this.lblOutraOpcao.AutoSize = true;
            this.lblOutraOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutraOpcao.Location = new System.Drawing.Point(86, 420);
            this.lblOutraOpcao.Name = "lblOutraOpcao";
            this.lblOutraOpcao.Size = new System.Drawing.Size(267, 40);
            this.lblOutraOpcao.TabIndex = 5;
            this.lblOutraOpcao.Text = "Caso não seja nenhuma das opções\r\nacima, digite o assunto desejado:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(91, 482);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(256, 20);
            this.txtAssunto.TabIndex = 6;
            this.txtAssunto.TextChanged += new System.EventHandler(this.txtAssunto_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(177, 519);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(85, 39);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.imgLearn);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.txtAssunto);
            this.panel1.Controls.Add(this.lblOla);
            this.panel1.Controls.Add(this.lblOutraOpcao);
            this.panel1.Controls.Add(this.lblTema);
            this.panel1.Controls.Add(this.btnPortugues);
            this.panel1.Controls.Add(this.btnTecnologia);
            this.panel1.Controls.Add(this.btnCiencias);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 577);
            this.panel1.TabIndex = 8;
            // 
            // imgLearn
            // 
            this.imgLearn.Image = global::Bestway2Learn.Properties.Resources.learn;
            this.imgLearn.Location = new System.Drawing.Point(127, 75);
            this.imgLearn.Name = "imgLearn";
            this.imgLearn.Size = new System.Drawing.Size(174, 105);
            this.imgLearn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLearn.TabIndex = 8;
            this.imgLearn.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Arquivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Arquivo
            // 
            this.Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSobre,
            this.menuFontes});
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.Size = new System.Drawing.Size(61, 20);
            this.Arquivo.Text = "Arquivo";
            // 
            // menuSobre
            // 
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(109, 22);
            this.menuSobre.Text = "Sobre";
            this.menuSobre.Click += new System.EventHandler(this.menuSobre_Click_1);
            // 
            // menuFontes
            // 
            this.menuFontes.Name = "menuFontes";
            this.menuFontes.Size = new System.Drawing.Size(109, 22);
            this.menuFontes.Text = "Fontes";
            this.menuFontes.Click += new System.EventHandler(this.menuFontes_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 601);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestway2Learn - Escolha o tema";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLearn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOla;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Button btnTecnologia;
        private System.Windows.Forms.Button btnCiencias;
        private System.Windows.Forms.Button btnPortugues;
        private System.Windows.Forms.Label lblOutraOpcao;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgLearn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Arquivo;
        private System.Windows.Forms.ToolStripMenuItem menuSobre;
        private System.Windows.Forms.ToolStripMenuItem menuFontes;
    }
}

