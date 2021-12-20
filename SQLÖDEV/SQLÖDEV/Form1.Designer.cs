
namespace SQLÖDEV
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtbiletno = new System.Windows.Forms.TextBox();
            this.Btnlistele = new System.Windows.Forms.Button();
            this.Txtmüsterino = new System.Windows.Forms.TextBox();
            this.Txtşehir = new System.Windows.Forms.TextBox();
            this.Txtülke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btnekleme = new System.Windows.Forms.Button();
            this.Btnarama = new System.Windows.Forms.Button();
            this.Btnsilme = new System.Windows.Forms.Button();
            this.Btngüncelleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(763, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(848, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "biletno :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txtbiletno
            // 
            this.Txtbiletno.Location = new System.Drawing.Point(960, 42);
            this.Txtbiletno.Name = "Txtbiletno";
            this.Txtbiletno.Size = new System.Drawing.Size(100, 24);
            this.Txtbiletno.TabIndex = 2;
            this.Txtbiletno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Btnlistele
            // 
            this.Btnlistele.Location = new System.Drawing.Point(1096, 33);
            this.Btnlistele.Name = "Btnlistele";
            this.Btnlistele.Size = new System.Drawing.Size(102, 34);
            this.Btnlistele.TabIndex = 3;
            this.Btnlistele.Text = "listele";
            this.Btnlistele.UseVisualStyleBackColor = true;
            this.Btnlistele.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txtmüsterino
            // 
            this.Txtmüsterino.Location = new System.Drawing.Point(960, 83);
            this.Txtmüsterino.Name = "Txtmüsterino";
            this.Txtmüsterino.Size = new System.Drawing.Size(100, 24);
            this.Txtmüsterino.TabIndex = 4;
            // 
            // Txtşehir
            // 
            this.Txtşehir.Location = new System.Drawing.Point(960, 183);
            this.Txtşehir.Name = "Txtşehir";
            this.Txtşehir.Size = new System.Drawing.Size(100, 24);
            this.Txtşehir.TabIndex = 5;
            // 
            // Txtülke
            // 
            this.Txtülke.Location = new System.Drawing.Point(960, 130);
            this.Txtülke.Name = "Txtülke";
            this.Txtülke.Size = new System.Drawing.Size(100, 24);
            this.Txtülke.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(848, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "müşterino :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(848, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "ülke :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(848, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "şehir :";
            // 
            // Btnekleme
            // 
            this.Btnekleme.Location = new System.Drawing.Point(1096, 73);
            this.Btnekleme.Name = "Btnekleme";
            this.Btnekleme.Size = new System.Drawing.Size(102, 32);
            this.Btnekleme.TabIndex = 10;
            this.Btnekleme.Text = "ekleme";
            this.Btnekleme.UseVisualStyleBackColor = true;
            this.Btnekleme.Click += new System.EventHandler(this.Btnekleme_Click);
            // 
            // Btnarama
            // 
            this.Btnarama.Location = new System.Drawing.Point(1096, 111);
            this.Btnarama.Name = "Btnarama";
            this.Btnarama.Size = new System.Drawing.Size(102, 32);
            this.Btnarama.TabIndex = 11;
            this.Btnarama.Text = "arama";
            this.Btnarama.UseVisualStyleBackColor = true;
            this.Btnarama.Click += new System.EventHandler(this.Btnarama_Click);
            // 
            // Btnsilme
            // 
            this.Btnsilme.Location = new System.Drawing.Point(1096, 149);
            this.Btnsilme.Name = "Btnsilme";
            this.Btnsilme.Size = new System.Drawing.Size(102, 31);
            this.Btnsilme.TabIndex = 12;
            this.Btnsilme.Text = "silme";
            this.Btnsilme.UseVisualStyleBackColor = true;
            this.Btnsilme.Click += new System.EventHandler(this.Btnsilme_Click);
            // 
            // Btngüncelleme
            // 
            this.Btngüncelleme.Location = new System.Drawing.Point(1096, 186);
            this.Btngüncelleme.Name = "Btngüncelleme";
            this.Btngüncelleme.Size = new System.Drawing.Size(102, 32);
            this.Btngüncelleme.TabIndex = 13;
            this.Btngüncelleme.Text = "güncelleme";
            this.Btngüncelleme.UseVisualStyleBackColor = true;
            this.Btngüncelleme.Click += new System.EventHandler(this.Btngüncelleme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 384);
            this.Controls.Add(this.Btngüncelleme);
            this.Controls.Add(this.Btnsilme);
            this.Controls.Add(this.Btnarama);
            this.Controls.Add(this.Btnekleme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtülke);
            this.Controls.Add(this.Txtşehir);
            this.Controls.Add(this.Txtmüsterino);
            this.Controls.Add(this.Btnlistele);
            this.Controls.Add(this.Txtbiletno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtbiletno;
        private System.Windows.Forms.Button Btnlistele;
        private System.Windows.Forms.TextBox Txtmüsterino;
        private System.Windows.Forms.TextBox Txtşehir;
        private System.Windows.Forms.TextBox Txtülke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btnekleme;
        private System.Windows.Forms.Button Btnarama;
        private System.Windows.Forms.Button Btnsilme;
        private System.Windows.Forms.Button Btngüncelleme;
    }
}

