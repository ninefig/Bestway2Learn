namespace Bestway2Learn
{
    partial class TelaAviso_Estudar
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
            this.lblMaravilha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaravilha
            // 
            this.lblMaravilha.AutoSize = true;
            this.lblMaravilha.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaravilha.Location = new System.Drawing.Point(67, 31);
            this.lblMaravilha.Name = "lblMaravilha";
            this.lblMaravilha.Size = new System.Drawing.Size(263, 47);
            this.lblMaravilha.TabIndex = 0;
            this.lblMaravilha.Text = "Hora de estudar! ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.lblMaravilha);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 486);
            this.panel1.TabIndex = 1;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(3, 309);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(268, 20);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "                       E lá vamos nós  \\o/\r\n";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(12, 210);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(318, 60);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "- Coloque seu celular no silencioso; \r\n- Desligue o wi-fi;\r\n- Foco total. ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 90);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(375, 100);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "\r\nAgora que você já possui o conteúdo necessário,\r\n                            va" +
    "mos estudar! \r\n\r\nAlguns lembretes básicos, porém necessários: \r\n";
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(110, 362);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(153, 44);
            this.btnProximo.TabIndex = 1;
            this.btnProximo.Text = "PRÓXIMO";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // TelaAviso_Estudar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 510);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "TelaAviso_Estudar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestway2Learn - Hora de Estudar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaravilha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
    }
}