namespace Uygulama16
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
            this.lblTurkceBaslik = new System.Windows.Forms.Label();
            this.lblMatBaslik = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.txtTurkceDogru = new System.Windows.Forms.TextBox();
            this.txtTurkceYanlis = new System.Windows.Forms.TextBox();
            this.txtTurkceNet = new System.Windows.Forms.TextBox();
            this.txtMatNet = new System.Windows.Forms.TextBox();
            this.txtMatYanlis = new System.Windows.Forms.TextBox();
            this.txtMatDogru = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTurkceBaslik
            // 
            this.lblTurkceBaslik.AutoSize = true;
            this.lblTurkceBaslik.Location = new System.Drawing.Point(48, 99);
            this.lblTurkceBaslik.Name = "lblTurkceBaslik";
            this.lblTurkceBaslik.Size = new System.Drawing.Size(100, 13);
            this.lblTurkceBaslik.TabIndex = 0;
            this.lblTurkceBaslik.Text = "TÜRKÇE 40 SORU";
            // 
            // lblMatBaslik
            // 
            this.lblMatBaslik.AutoSize = true;
            this.lblMatBaslik.Location = new System.Drawing.Point(48, 139);
            this.lblMatBaslik.Name = "lblMatBaslik";
            this.lblMatBaslik.Size = new System.Drawing.Size(119, 13);
            this.lblMatBaslik.TabIndex = 1;
            this.lblMatBaslik.Text = "MATEMATİK 40 SORU";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(274, 58);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(47, 13);
            this.lblDogru.TabIndex = 2;
            this.lblDogru.Text = "DOĞRU";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Location = new System.Drawing.Point(368, 58);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(45, 13);
            this.lblYanlis.TabIndex = 3;
            this.lblYanlis.Text = "YANLIŞ";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Location = new System.Drawing.Point(450, 58);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(29, 13);
            this.lblNet.TabIndex = 4;
            this.lblNet.Text = "NET";
            // 
            // txtTurkceDogru
            // 
            this.txtTurkceDogru.Location = new System.Drawing.Point(277, 91);
            this.txtTurkceDogru.Name = "txtTurkceDogru";
            this.txtTurkceDogru.Size = new System.Drawing.Size(61, 20);
            this.txtTurkceDogru.TabIndex = 5;
            // 
            // txtTurkceYanlis
            // 
            this.txtTurkceYanlis.Location = new System.Drawing.Point(371, 92);
            this.txtTurkceYanlis.Name = "txtTurkceYanlis";
            this.txtTurkceYanlis.Size = new System.Drawing.Size(61, 20);
            this.txtTurkceYanlis.TabIndex = 6;
            // 
            // txtTurkceNet
            // 
            this.txtTurkceNet.Location = new System.Drawing.Point(453, 91);
            this.txtTurkceNet.Name = "txtTurkceNet";
            this.txtTurkceNet.ReadOnly = true;
            this.txtTurkceNet.Size = new System.Drawing.Size(61, 20);
            this.txtTurkceNet.TabIndex = 7;
            // 
            // txtMatNet
            // 
            this.txtMatNet.Location = new System.Drawing.Point(453, 136);
            this.txtMatNet.Name = "txtMatNet";
            this.txtMatNet.ReadOnly = true;
            this.txtMatNet.Size = new System.Drawing.Size(61, 20);
            this.txtMatNet.TabIndex = 10;
            // 
            // txtMatYanlis
            // 
            this.txtMatYanlis.Location = new System.Drawing.Point(371, 137);
            this.txtMatYanlis.Name = "txtMatYanlis";
            this.txtMatYanlis.Size = new System.Drawing.Size(61, 20);
            this.txtMatYanlis.TabIndex = 9;
            // 
            // txtMatDogru
            // 
            this.txtMatDogru.Location = new System.Drawing.Point(277, 136);
            this.txtMatDogru.Name = "txtMatDogru";
            this.txtMatDogru.Size = new System.Drawing.Size(61, 20);
            this.txtMatDogru.TabIndex = 8;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(277, 183);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(237, 62);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "NET HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(569, 300);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtMatNet);
            this.Controls.Add(this.txtMatYanlis);
            this.Controls.Add(this.txtMatDogru);
            this.Controls.Add(this.txtTurkceNet);
            this.Controls.Add(this.txtTurkceYanlis);
            this.Controls.Add(this.txtTurkceDogru);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblYanlis);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblMatBaslik);
            this.Controls.Add(this.lblTurkceBaslik);
            this.Name = "Form1";
            this.Text = "Net Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurkceBaslik;
        private System.Windows.Forms.Label lblMatBaslik;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.TextBox txtTurkceDogru;
        private System.Windows.Forms.TextBox txtTurkceYanlis;
        private System.Windows.Forms.TextBox txtTurkceNet;
        private System.Windows.Forms.TextBox txtMatNet;
        private System.Windows.Forms.TextBox txtMatYanlis;
        private System.Windows.Forms.TextBox txtMatDogru;
        private System.Windows.Forms.Button btnHesapla;
    }
}

