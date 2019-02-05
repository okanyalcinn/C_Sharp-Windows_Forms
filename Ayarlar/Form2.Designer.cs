namespace Ayarlar
{
    partial class Form2
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
            this._btnKaydet = new System.Windows.Forms.Button();
            this._btnEKiltle = new System.Windows.Forms.Button();
            this._chckSecim1 = new System.Windows.Forms.CheckBox();
            this._chckSecim2 = new System.Windows.Forms.CheckBox();
            this._txt1 = new System.Windows.Forms.TextBox();
            this._txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _btnKaydet
            // 
            this._btnKaydet.Location = new System.Drawing.Point(39, 162);
            this._btnKaydet.Name = "_btnKaydet";
            this._btnKaydet.Size = new System.Drawing.Size(75, 23);
            this._btnKaydet.TabIndex = 0;
            this._btnKaydet.Text = "Kaydet";
            this._btnKaydet.UseVisualStyleBackColor = true;
            this._btnKaydet.Click += new System.EventHandler(this._btnKaydet_Click);
            // 
            // _btnEKiltle
            // 
            this._btnEKiltle.Location = new System.Drawing.Point(150, 162);
            this._btnEKiltle.Name = "_btnEKiltle";
            this._btnEKiltle.Size = new System.Drawing.Size(75, 23);
            this._btnEKiltle.TabIndex = 0;
            this._btnEKiltle.Text = "Ekranı Kilitle";
            this._btnEKiltle.UseVisualStyleBackColor = true;
            this._btnEKiltle.Click += new System.EventHandler(this._btnEKiltle_Click);
            // 
            // _chckSecim1
            // 
            this._chckSecim1.AutoSize = true;
            this._chckSecim1.Location = new System.Drawing.Point(33, 103);
            this._chckSecim1.Name = "_chckSecim1";
            this._chckSecim1.Size = new System.Drawing.Size(49, 17);
            this._chckSecim1.TabIndex = 1;
            this._chckSecim1.Text = "Mavi";
            this._chckSecim1.UseVisualStyleBackColor = true;
            this._chckSecim1.CheckedChanged += new System.EventHandler(this._chckSecim1_CheckedChanged);
            // 
            // _chckSecim2
            // 
            this._chckSecim2.AutoSize = true;
            this._chckSecim2.Location = new System.Drawing.Point(33, 126);
            this._chckSecim2.Name = "_chckSecim2";
            this._chckSecim2.Size = new System.Drawing.Size(55, 17);
            this._chckSecim2.TabIndex = 2;
            this._chckSecim2.Text = "Kırmızı";
            this._chckSecim2.UseVisualStyleBackColor = true;
            this._chckSecim2.CheckedChanged += new System.EventHandler(this._chckSecim2_CheckedChanged);
            // 
            // _txt1
            // 
            this._txt1.Location = new System.Drawing.Point(33, 24);
            this._txt1.Name = "_txt1";
            this._txt1.Size = new System.Drawing.Size(192, 20);
            this._txt1.TabIndex = 3;
            // 
            // _txt2
            // 
            this._txt2.Location = new System.Drawing.Point(33, 65);
            this._txt2.Name = "_txt2";
            this._txt2.Size = new System.Drawing.Size(192, 20);
            this._txt2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 215);
            this.Controls.Add(this._txt2);
            this.Controls.Add(this._txt1);
            this.Controls.Add(this._chckSecim2);
            this.Controls.Add(this._chckSecim1);
            this.Controls.Add(this._btnEKiltle);
            this.Controls.Add(this._btnKaydet);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnKaydet;
        private System.Windows.Forms.Button _btnEKiltle;
        private System.Windows.Forms.CheckBox _chckSecim1;
        private System.Windows.Forms.CheckBox _chckSecim2;
        private System.Windows.Forms.TextBox _txt1;
        private System.Windows.Forms.TextBox _txt2;
    }
}