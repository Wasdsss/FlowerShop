namespace FlowerShop.UI.Client
{
    partial class fmQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmQRCode));
            this.picQRQode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQRQode)).BeginInit();
            this.SuspendLayout();
            // 
            // picQRQode
            // 
            this.picQRQode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picQRQode.Location = new System.Drawing.Point(29, 27);
            this.picQRQode.Name = "picQRQode";
            this.picQRQode.Size = new System.Drawing.Size(304, 266);
            this.picQRQode.TabIndex = 0;
            this.picQRQode.TabStop = false;
            // 
            // fmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 325);
            this.Controls.Add(this.picQRQode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отзыв";
            this.Load += new System.EventHandler(this.fmQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQRQode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picQRQode;
    }
}