namespace OgrenciKayit
{
    partial class OgrenciListele
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
            this._dtview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._dtview)).BeginInit();
            this.SuspendLayout();
            // 
            // _dtview
            // 
            this._dtview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dtview.Location = new System.Drawing.Point(13, 13);
            this._dtview.Name = "_dtview";
            this._dtview.Size = new System.Drawing.Size(676, 204);
            this._dtview.TabIndex = 0;
            // 
            // OgrenciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 229);
            this.Controls.Add(this._dtview);
            this.Name = "OgrenciListele";
            this.Text = "OgrenciListele";
            this.Load += new System.EventHandler(this.OgrenciListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dtview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dtview;
    }
}