namespace Bestway2Learn
{
    partial class TelaAviso1
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
            this.lblVoceEntendeu = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVoceEntendeu
            // 
            this.lblVoceEntendeu.AutoSize = true;
            this.lblVoceEntendeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoceEntendeu.Location = new System.Drawing.Point(24, 39);
            this.lblVoceEntendeu.Name = "lblVoceEntendeu";
            this.lblVoceEntendeu.Size = new System.Drawing.Size(350, 29);
            this.lblVoceEntendeu.TabIndex = 0;
            this.lblVoceEntendeu.Text = "Você entendeu bem o assunto?";
            // 
            // btnSim
            // 
            this.btnSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSim.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSim.Location = new System.Drawing.Point(40, 109);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(143, 37);
            this.btnSim.TabIndex = 1;
            this.btnSim.Text = "Sim, vamos lá!\r\n";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNao
            // 
            this.btnNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNao.ForeColor = System.Drawing.Color.Red;
            this.btnNao.Location = new System.Drawing.Point(211, 109);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(111, 37);
            this.btnNao.TabIndex = 2;
            this.btnNao.Text = "Não :(";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.lblVoceEntendeu);
            this.panel1.Controls.Add(this.btnSim);
            this.panel1.Controls.Add(this.btnNao);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 177);
            this.panel1.TabIndex = 3;
            // 
            // TelaAviso1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 199);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "TelaAviso1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestway2Learn - Você entendeu?";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVoceEntendeu;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.Panel panel1;
    }
}