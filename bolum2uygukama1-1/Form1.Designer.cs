namespace bolum2uygukama1_1
{
    partial class lblDurum
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
            this.lblYas = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYas.Location = new System.Drawing.Point(64, 105);
            this.lblYas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(52, 25);
            this.lblYas.TabIndex = 0;
            this.lblYas.Text = "yaş:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(64, 164);
            this.lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(78, 25);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "durum:";
            // 
            // txtYas
            // 
            this.txtYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYas.Location = new System.Drawing.Point(116, 105);
            this.txtYas.Margin = new System.Windows.Forms.Padding(6);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(170, 31);
            this.txtYas.TabIndex = 2;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(69, 215);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(6);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(217, 67);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblYas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "lblDurum";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.Button btnHesapla;
    }
}

