namespace odev1_847
{
    partial class Form1
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
            this.hesapla = new System.Windows.Forms.Button();
            this.lblBuyuk = new System.Windows.Forms.Label();
            this.lblKucuk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesapla
            // 
            this.hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapla.Location = new System.Drawing.Point(108, 75);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(136, 41);
            this.hesapla.TabIndex = 0;
            this.hesapla.Text = "hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // lblBuyuk
            // 
            this.lblBuyuk.AutoSize = true;
            this.lblBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBuyuk.Location = new System.Drawing.Point(287, 54);
            this.lblBuyuk.Name = "lblBuyuk";
            this.lblBuyuk.Size = new System.Drawing.Size(88, 24);
            this.lblBuyuk.TabIndex = 1;
            this.lblBuyuk.Text = "en büyük";
            // 
            // lblKucuk
            // 
            this.lblKucuk.AutoSize = true;
            this.lblKucuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKucuk.Location = new System.Drawing.Point(288, 92);
            this.lblKucuk.Name = "lblKucuk";
            this.lblKucuk.Size = new System.Drawing.Size(87, 24);
            this.lblKucuk.TabIndex = 2;
            this.lblKucuk.Text = "en küçük";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKucuk);
            this.Controls.Add(this.lblBuyuk);
            this.Controls.Add(this.hesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Label lblBuyuk;
        private System.Windows.Forms.Label lblKucuk;
    }
}

