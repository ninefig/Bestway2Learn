namespace Bestway2Learn
{
    partial class TelaResultados
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
            this.lblLivros = new System.Windows.Forms.Label();
            this.lblNoticias = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dtgridNoticias = new System.Windows.Forms.DataGridView();
            this.dtgridLivros = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridNoticias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLivros
            // 
            this.lblLivros.AutoSize = true;
            this.lblLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivros.Location = new System.Drawing.Point(43, 66);
            this.lblLivros.Name = "lblLivros";
            this.lblLivros.Size = new System.Drawing.Size(302, 20);
            this.lblLivros.TabIndex = 0;
            this.lblLivros.Text = "Livros mais indicados sobre este assunto:";
            // 
            // lblNoticias
            // 
            this.lblNoticias.AutoSize = true;
            this.lblNoticias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoticias.Location = new System.Drawing.Point(43, 211);
            this.lblNoticias.Name = "lblNoticias";
            this.lblNoticias.Size = new System.Drawing.Size(183, 20);
            this.lblNoticias.TabIndex = 1;
            this.lblNoticias.Text = "Notícias mais relevantes:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblResultados);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.dtgridNoticias);
            this.panel1.Controls.Add(this.dtgridLivros);
            this.panel1.Controls.Add(this.lblLivros);
            this.panel1.Controls.Add(this.lblNoticias);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 517);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(128, 18);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(120, 25);
            this.lblResultados.TabIndex = 6;
            this.lblResultados.Text = "Resultados";
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(252, 482);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(93, 23);
            this.btnProximo.TabIndex = 5;
            this.btnProximo.Text = "PRÓXIMO";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(47, 482);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dtgridNoticias
            // 
            this.dtgridNoticias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridNoticias.Location = new System.Drawing.Point(47, 247);
            this.dtgridNoticias.Name = "dtgridNoticias";
            this.dtgridNoticias.Size = new System.Drawing.Size(298, 229);
            this.dtgridNoticias.TabIndex = 3;
            // 
            // dtgridLivros
            // 
            this.dtgridLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridLivros.Location = new System.Drawing.Point(47, 99);
            this.dtgridLivros.Name = "dtgridLivros";
            this.dtgridLivros.Size = new System.Drawing.Size(298, 95);
            this.dtgridLivros.TabIndex = 2;
            // 
            // TelaResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 541);
            this.Controls.Add(this.panel1);
            this.Name = "TelaResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestway2Learn - Resultados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridNoticias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLivros;
        private System.Windows.Forms.Label lblNoticias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dtgridNoticias;
        private System.Windows.Forms.DataGridView dtgridLivros;
        private System.Windows.Forms.Label lblResultados;
    }
}