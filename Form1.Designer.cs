namespace ResimKarsilastirma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.lbResim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSec2 = new System.Windows.Forms.Button();
            this.lbResim2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnKarsilastir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb.Location = new System.Drawing.Point(6, 19);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(256, 173);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSec);
            this.groupBox1.Controls.Add(this.lbResim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pb);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birinci Resim";
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(6, 211);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(256, 23);
            this.btnSec.TabIndex = 7;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // lbResim
            // 
            this.lbResim.Location = new System.Drawing.Point(62, 195);
            this.lbResim.Name = "lbResim";
            this.lbResim.Size = new System.Drawing.Size(200, 13);
            this.lbResim.TabIndex = 4;
            this.lbResim.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resim Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSec2);
            this.groupBox2.Controls.Add(this.lbResim2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pb2);
            this.groupBox2.Location = new System.Drawing.Point(286, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 240);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İkinci Resim";
            // 
            // btnSec2
            // 
            this.btnSec2.Location = new System.Drawing.Point(9, 211);
            this.btnSec2.Name = "btnSec2";
            this.btnSec2.Size = new System.Drawing.Size(256, 23);
            this.btnSec2.TabIndex = 8;
            this.btnSec2.Text = "Seç";
            this.btnSec2.UseVisualStyleBackColor = true;
            this.btnSec2.Click += new System.EventHandler(this.btnSec2_Click);
            // 
            // lbResim2
            // 
            this.lbResim2.Location = new System.Drawing.Point(63, 195);
            this.lbResim2.Name = "lbResim2";
            this.lbResim2.Size = new System.Drawing.Size(199, 13);
            this.lbResim2.TabIndex = 6;
            this.lbResim2.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resim Adı :";
            // 
            // pb2
            // 
            this.pb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb2.Location = new System.Drawing.Point(6, 19);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(256, 173);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 0;
            this.pb2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 251);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(397, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // btnKarsilastir
            // 
            this.btnKarsilastir.Location = new System.Drawing.Point(434, 251);
            this.btnKarsilastir.Name = "btnKarsilastir";
            this.btnKarsilastir.Size = new System.Drawing.Size(120, 23);
            this.btnKarsilastir.TabIndex = 4;
            this.btnKarsilastir.Text = "Karşılaştır";
            this.btnKarsilastir.UseVisualStyleBackColor = true;
            this.btnKarsilastir.Click += new System.EventHandler(this.btnKarsilastir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 284);
            this.Controls.Add(this.btnKarsilastir);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resim Karşılaştırma Programı v1.0 | Kodlayan İlkcan Doğan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label lbResim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSec2;
        private System.Windows.Forms.Label lbResim2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnKarsilastir;
    }
}

