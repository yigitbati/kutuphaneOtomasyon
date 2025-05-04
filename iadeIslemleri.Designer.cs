namespace kütüphaneOtomasyonuUygulaması
{
    partial class iadeIslemleri
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
            this.components = new System.ComponentModel.Container();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSonTeslimTarih = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOduncTarih = new System.Windows.Forms.TextBox();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.txtUyeID = new System.Windows.Forms.TextBox();
            this.txtOduncID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oduncIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oduncTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonTeslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oduncTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneOtomasyonDataSet8 = new kütüphaneOtomasyonuUygulaması.kütüphaneOtomasyonDataSet8();
            this.oduncTblTableAdapter = new kütüphaneOtomasyonuUygulaması.kütüphaneOtomasyonDataSet8TableAdapters.oduncTblTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox4.Controls.Add(this.lblDurum);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtSonTeslimTarih);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.txtOduncTarih);
            this.groupBox4.Controls.Add(this.txtKitapID);
            this.groupBox4.Controls.Add(this.txtUyeID);
            this.groupBox4.Controls.Add(this.txtOduncID);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 489);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Düzenleme";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(203, 385);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(147, 27);
            this.lblDurum.TabIndex = 25;
            this.lblDurum.Text = "_________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "Zamanında Teslim:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(0, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "Son Teslim Tarihi:";
            // 
            // txtSonTeslimTarih
            // 
            this.txtSonTeslimTarih.Location = new System.Drawing.Point(155, 171);
            this.txtSonTeslimTarih.Name = "txtSonTeslimTarih";
            this.txtSonTeslimTarih.Size = new System.Drawing.Size(179, 32);
            this.txtSonTeslimTarih.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 32);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 452);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 31);
            this.button7.TabIndex = 20;
            this.button7.Text = "Ana Menü";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(230, 314);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 31);
            this.button6.TabIndex = 19;
            this.button6.Text = "Aktar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(123, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 31);
            this.button5.TabIndex = 18;
            this.button5.Text = "Temizle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 31);
            this.button4.TabIndex = 17;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(230, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 31);
            this.button3.TabIndex = 16;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 31);
            this.button2.TabIndex = 15;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOduncTarih
            // 
            this.txtOduncTarih.Location = new System.Drawing.Point(155, 138);
            this.txtOduncTarih.Name = "txtOduncTarih";
            this.txtOduncTarih.Size = new System.Drawing.Size(179, 32);
            this.txtOduncTarih.TabIndex = 9;
            // 
            // txtKitapID
            // 
            this.txtKitapID.Location = new System.Drawing.Point(155, 105);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(179, 32);
            this.txtKitapID.TabIndex = 8;
            // 
            // txtUyeID
            // 
            this.txtUyeID.Location = new System.Drawing.Point(155, 72);
            this.txtUyeID.Name = "txtUyeID";
            this.txtUyeID.Size = new System.Drawing.Size(179, 32);
            this.txtUyeID.TabIndex = 7;
            // 
            // txtOduncID
            // 
            this.txtOduncID.Location = new System.Drawing.Point(155, 39);
            this.txtOduncID.Name = "txtOduncID";
            this.txtOduncID.Size = new System.Drawing.Size(179, 32);
            this.txtOduncID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ödünç Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(82, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uye ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödünç ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oduncIDDataGridViewTextBoxColumn,
            this.uyeIDDataGridViewTextBoxColumn,
            this.kitapIDDataGridViewTextBoxColumn,
            this.oduncTarihiDataGridViewTextBoxColumn,
            this.sonTeslimTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oduncTblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(376, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(542, 489);
            this.dataGridView1.TabIndex = 9;
            // 
            // oduncIDDataGridViewTextBoxColumn
            // 
            this.oduncIDDataGridViewTextBoxColumn.DataPropertyName = "OduncID";
            this.oduncIDDataGridViewTextBoxColumn.HeaderText = "OduncID";
            this.oduncIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oduncIDDataGridViewTextBoxColumn.Name = "oduncIDDataGridViewTextBoxColumn";
            this.oduncIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oduncIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyeIDDataGridViewTextBoxColumn
            // 
            this.uyeIDDataGridViewTextBoxColumn.DataPropertyName = "UyeID";
            this.uyeIDDataGridViewTextBoxColumn.HeaderText = "UyeID";
            this.uyeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uyeIDDataGridViewTextBoxColumn.Name = "uyeIDDataGridViewTextBoxColumn";
            this.uyeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapIDDataGridViewTextBoxColumn
            // 
            this.kitapIDDataGridViewTextBoxColumn.DataPropertyName = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.HeaderText = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapIDDataGridViewTextBoxColumn.Name = "kitapIDDataGridViewTextBoxColumn";
            this.kitapIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // oduncTarihiDataGridViewTextBoxColumn
            // 
            this.oduncTarihiDataGridViewTextBoxColumn.DataPropertyName = "OduncTarihi";
            this.oduncTarihiDataGridViewTextBoxColumn.HeaderText = "OduncTarihi";
            this.oduncTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oduncTarihiDataGridViewTextBoxColumn.Name = "oduncTarihiDataGridViewTextBoxColumn";
            this.oduncTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sonTeslimTarihiDataGridViewTextBoxColumn
            // 
            this.sonTeslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "SonTeslimTarihi";
            this.sonTeslimTarihiDataGridViewTextBoxColumn.HeaderText = "SonTeslimTarihi";
            this.sonTeslimTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sonTeslimTarihiDataGridViewTextBoxColumn.Name = "sonTeslimTarihiDataGridViewTextBoxColumn";
            this.sonTeslimTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // oduncTblBindingSource
            // 
            this.oduncTblBindingSource.DataMember = "oduncTbl";
            this.oduncTblBindingSource.DataSource = this.kütüphaneOtomasyonDataSet8;
            // 
            // kütüphaneOtomasyonDataSet8
            // 
            this.kütüphaneOtomasyonDataSet8.DataSetName = "kütüphaneOtomasyonDataSet8";
            this.kütüphaneOtomasyonDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oduncTblTableAdapter
            // 
            this.oduncTblTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightYellow;
            this.pictureBox2.Location = new System.Drawing.Point(-9, -17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(379, 535);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // iadeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(930, 513);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox2);
            this.Name = "iadeIslemleri";
            this.Text = "İade İşlemleri";
            this.Load += new System.EventHandler(this.iadeIslemleri_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oduncTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOduncTarih;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.TextBox txtUyeID;
        private System.Windows.Forms.TextBox txtOduncID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private kütüphaneOtomasyonDataSet8 kütüphaneOtomasyonDataSet8;
        private System.Windows.Forms.BindingSource oduncTblBindingSource;
        private kütüphaneOtomasyonDataSet8TableAdapters.oduncTblTableAdapter oduncTblTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSonTeslimTarih;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oduncIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oduncTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonTeslimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDurum;
    }
}