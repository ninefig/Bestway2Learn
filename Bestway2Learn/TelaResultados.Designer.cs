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
            this.lblVideos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dtgridVideos = new System.Windows.Forms.DataGridView();
            this.dtgridLivros = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVideos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLivros
            // 
            this.lblLivros.AutoSize = true;
            this.lblLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivros.Location = new System.Drawing.Point(170, 62);
            this.lblLivros.Name = "lblLivros";
            this.lblLivros.Size = new System.Drawing.Size(302, 20);
            this.lblLivros.TabIndex = 0;
            this.lblLivros.Text = "Livros mais indicados sobre este assunto:";
            // 
            // lblVideos
            // 
            this.lblVideos.AutoSize = true;
            this.lblVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideos.Location = new System.Drawing.Point(216, 247);
            this.lblVideos.Name = "lblVideos";
            this.lblVideos.Size = new System.Drawing.Size(176, 20);
            this.lblVideos.TabIndex = 1;
            this.lblVideos.Text = "Videos mais relevantes:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblResultados);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.dtgridVideos);
            this.panel1.Controls.Add(this.dtgridLivros);
            this.panel1.Controls.Add(this.lblLivros);
            this.panel1.Controls.Add(this.lblVideos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 635);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(247, 14);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(120, 25);
            this.lblResultados.TabIndex = 6;
            this.lblResultados.Text = "Resultados";
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(449, 503);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(93, 23);
            this.btnProximo.TabIndex = 5;
            this.btnProximo.Text = "PRÓXIMO";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(90, 503);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(93, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dtgridVideos
            // 
            this.dtgridVideos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridVideos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgridVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridVideos.Location = new System.Drawing.Point(47, 285);
            this.dtgridVideos.Name = "dtgridVideos";
            this.dtgridVideos.Size = new System.Drawing.Size(548, 191);
            this.dtgridVideos.TabIndex = 3;
            // 
            // dtgridLivros
            // 
            this.dtgridLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridLivros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgridLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridLivros.Location = new System.Drawing.Point(47, 99);
            this.dtgridLivros.Name = "dtgridLivros";
            this.dtgridLivros.Size = new System.Drawing.Size(548, 95);
            this.dtgridLivros.TabIndex = 2;
            // 
            // TelaResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 669);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "TelaResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestway2Learn - Resultados";
            this.Load += new System.EventHandler(this.TelaResultados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridVideos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLivros;
        private System.Windows.Forms.Label lblVideos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dtgridVideos;
        private System.Windows.Forms.DataGridView dtgridLivros;
        private System.Windows.Forms.Label lblResultados;
    }
}