namespace dproject_yeni
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtmarkaadı = new System.Windows.Forms.TextBox();
            this.txtModelAdı = new System.Windows.Forms.TextBox();
            this.txtKasaTipi = new System.Windows.Forms.TextBox();
            this.txtVitesTipi = new System.Windows.Forms.TextBox();
            this.txtModelYılı = new System.Windows.Forms.TextBox();
            this.MarkaAdı = new System.Windows.Forms.Label();
            this.ModelAdı = new System.Windows.Forms.Label();
            this.KasaTipi = new System.Windows.Forms.Label();
            this.ModelYılı = new System.Windows.Forms.Label();
            this.VitesTipi = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmarkaadı
            // 
            this.txtmarkaadı.Location = new System.Drawing.Point(172, 203);
            this.txtmarkaadı.Name = "txtmarkaadı";
            this.txtmarkaadı.Size = new System.Drawing.Size(125, 27);
            this.txtmarkaadı.TabIndex = 0;
            // 
            // txtModelAdı
            // 
            this.txtModelAdı.Location = new System.Drawing.Point(172, 71);
            this.txtModelAdı.Name = "txtModelAdı";
            this.txtModelAdı.Size = new System.Drawing.Size(125, 27);
            this.txtModelAdı.TabIndex = 1;
            // 
            // txtKasaTipi
            // 
            this.txtKasaTipi.Location = new System.Drawing.Point(172, 104);
            this.txtKasaTipi.Name = "txtKasaTipi";
            this.txtKasaTipi.Size = new System.Drawing.Size(125, 27);
            this.txtKasaTipi.TabIndex = 2;
            // 
            // txtVitesTipi
            // 
            this.txtVitesTipi.Location = new System.Drawing.Point(172, 137);
            this.txtVitesTipi.Name = "txtVitesTipi";
            this.txtVitesTipi.Size = new System.Drawing.Size(125, 27);
            this.txtVitesTipi.TabIndex = 3;
            // 
            // txtModelYılı
            // 
            this.txtModelYılı.Location = new System.Drawing.Point(172, 170);
            this.txtModelYılı.Name = "txtModelYılı";
            this.txtModelYılı.Size = new System.Drawing.Size(125, 27);
            this.txtModelYılı.TabIndex = 4;
            // 
            // MarkaAdı
            // 
            this.MarkaAdı.AutoSize = true;
            this.MarkaAdı.Location = new System.Drawing.Point(43, 206);
            this.MarkaAdı.Name = "MarkaAdı";
            this.MarkaAdı.Size = new System.Drawing.Size(77, 20);
            this.MarkaAdı.TabIndex = 5;
            this.MarkaAdı.Text = "Marka Adı";
            // 
            // ModelAdı
            // 
            this.ModelAdı.AutoSize = true;
            this.ModelAdı.Location = new System.Drawing.Point(43, 78);
            this.ModelAdı.Name = "ModelAdı";
            this.ModelAdı.Size = new System.Drawing.Size(79, 20);
            this.ModelAdı.TabIndex = 6;
            this.ModelAdı.Text = "Model Adı";
            // 
            // KasaTipi
            // 
            this.KasaTipi.AutoSize = true;
            this.KasaTipi.Location = new System.Drawing.Point(51, 111);
            this.KasaTipi.Name = "KasaTipi";
            this.KasaTipi.Size = new System.Drawing.Size(69, 20);
            this.KasaTipi.TabIndex = 7;
            this.KasaTipi.Text = "Kasa Tipi";
            // 
            // ModelYılı
            // 
            this.ModelYılı.AutoSize = true;
            this.ModelYılı.Location = new System.Drawing.Point(46, 177);
            this.ModelYılı.Name = "ModelYılı";
            this.ModelYılı.Size = new System.Drawing.Size(76, 20);
            this.ModelYılı.TabIndex = 8;
            this.ModelYılı.Text = "Model Yılı";
            // 
            // VitesTipi
            // 
            this.VitesTipi.AutoSize = true;
            this.VitesTipi.Location = new System.Drawing.Point(52, 146);
            this.VitesTipi.Name = "VitesTipi";
            this.VitesTipi.Size = new System.Drawing.Size(70, 20);
            this.VitesTipi.TabIndex = 9;
            this.VitesTipi.Text = "Vites Tipi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(594, 121);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(94, 76);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(794, 27);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 71);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(694, 121);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(94, 76);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(794, 121);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 76);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(806, 356);
            this.dataGridView1.TabIndex = 14;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(628, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 27);
            this.txtID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Araba ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.VitesTipi);
            this.Controls.Add(this.ModelYılı);
            this.Controls.Add(this.KasaTipi);
            this.Controls.Add(this.ModelAdı);
            this.Controls.Add(this.MarkaAdı);
            this.Controls.Add(this.txtModelYılı);
            this.Controls.Add(this.txtVitesTipi);
            this.Controls.Add(this.txtKasaTipi);
            this.Controls.Add(this.txtModelAdı);
            this.Controls.Add(this.txtmarkaadı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtmarkaadı;
        private TextBox txtModelAdı;
        private TextBox txtKasaTipi;
        private TextBox txtVitesTipi;
        private TextBox txtModelYılı;
        private Label MarkaAdı;
        private Label ModelAdı;
        private Label KasaTipi;
        private Label ModelYılı;
        private Label VitesTipi;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnListele;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private TextBox txtID;
        private Label label1;
    }
}