
namespace İstasyon
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelSicaklik = new System.Windows.Forms.Label();
            this.labelNem = new System.Windows.Forms.Label();
            this.labelDurum = new System.Windows.Forms.Label();
            this.labelIsikDegeri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSicaklik
            // 
            this.labelSicaklik.AutoSize = true;
            this.labelSicaklik.BackColor = System.Drawing.Color.White;
            this.labelSicaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSicaklik.Location = new System.Drawing.Point(40, 155);
            this.labelSicaklik.Name = "labelSicaklik";
            this.labelSicaklik.Size = new System.Drawing.Size(486, 91);
            this.labelSicaklik.TabIndex = 0;
            this.labelSicaklik.Text = "labelSicaklik";
            // 
            // labelNem
            // 
            this.labelNem.AutoSize = true;
            this.labelNem.BackColor = System.Drawing.Color.White;
            this.labelNem.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNem.Location = new System.Drawing.Point(40, 272);
            this.labelNem.Name = "labelNem";
            this.labelNem.Size = new System.Drawing.Size(382, 91);
            this.labelNem.TabIndex = 1;
            this.labelNem.Text = "labelNem";
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.BackColor = System.Drawing.Color.White;
            this.labelDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDurum.Location = new System.Drawing.Point(40, 391);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(455, 91);
            this.labelDurum.TabIndex = 2;
            this.labelDurum.Text = "labelDurum";
            // 
            // labelIsikDegeri
            // 
            this.labelIsikDegeri.AutoSize = true;
            this.labelIsikDegeri.BackColor = System.Drawing.Color.White;
            this.labelIsikDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIsikDegeri.Location = new System.Drawing.Point(40, 514);
            this.labelIsikDegeri.Name = "labelIsikDegeri";
            this.labelIsikDegeri.Size = new System.Drawing.Size(573, 91);
            this.labelIsikDegeri.TabIndex = 3;
            this.labelIsikDegeri.Text = "labelIsikDegeri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(304, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 91);
            this.label1.TabIndex = 4;
            this.label1.Text = "Anlık Veriler";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::İstasyon.Properties.Resources.Gunduz;
            this.pictureBox4.Location = new System.Drawing.Point(1310, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(293, 264);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::İstasyon.Properties.Resources.Yagmurlu;
            this.pictureBox3.Location = new System.Drawing.Point(1310, 303);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(293, 292);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::İstasyon.Properties.Resources.Gece;
            this.pictureBox2.Location = new System.Drawing.Point(939, 303);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 292);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::İstasyon.Properties.Resources.Nem;
            this.pictureBox1.Location = new System.Drawing.Point(939, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 264);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1650, 693);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIsikDegeri);
            this.Controls.Add(this.labelDurum);
            this.Controls.Add(this.labelNem);
            this.Controls.Add(this.labelSicaklik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelSicaklik;
        private System.Windows.Forms.Label labelNem;
        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.Label labelIsikDegeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

