namespace Bestway2Learn
{
    partial class TelaPraticar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPraticar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNaoConsegui = new System.Windows.Forms.Button();
            this.btnConsegui = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnNaoConsegui);
            this.panel1.Controls.Add(this.btnConsegui);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 542);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnNaoConsegui
            // 
            this.btnNaoConsegui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNaoConsegui.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaoConsegui.Location = new System.Drawing.Point(364, 353);
            this.btnNaoConsegui.Name = "btnNaoConsegui";
            this.btnNaoConsegui.Size = new System.Drawing.Size(253, 70);
            this.btnNaoConsegui.TabIndex = 3;
            this.btnNaoConsegui.Text = "Não consegui explicar algumas coisas.\r\n";
            this.btnNaoConsegui.UseVisualStyleBackColor = false;
            this.btnNaoConsegui.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsegui
            // 
            this.btnConsegui.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConsegui.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsegui.Location = new System.Drawing.Point(45, 353);
            this.btnConsegui.Name = "btnConsegui";
            this.btnConsegui.Size = new System.Drawing.Size(253, 70);
            this.btnConsegui.TabIndex = 2;
            this.btnConsegui.Text = "Consegui explicar tudo que queria :)\r\n";
            this.btnConsegui.UseVisualStyleBackColor = false;
            this.btnConsegui.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(196, 30);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(310, 62);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Vamos praticar!";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(19, 128);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(684, 150);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = resources.GetString("lbl2.Text");
            // 
            // TelaPraticar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(731, 566);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "TelaPraticar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bestway2Learn - Praticar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnConsegui;
        private System.Windows.Forms.Button btnNaoConsegui;
    }
}