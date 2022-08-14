namespace kitaplık_proje
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkitap = new System.Windows.Forms.TextBox();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbtur = new System.Windows.Forms.ComboBox();
            this.rdbkullanılmıs = new System.Windows.Forms.RadioButton();
            this.rdbsıfır = new System.Windows.Forms.RadioButton();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnbul = new System.Windows.Forms.Button();
            this.txtkitapbul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 392);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(918, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Ad:";
            // 
            // txtkitap
            // 
            this.txtkitap.Location = new System.Drawing.Point(138, 120);
            this.txtkitap.Name = "txtkitap";
            this.txtkitap.Size = new System.Drawing.Size(214, 36);
            this.txtkitap.TabIndex = 2;
            // 
            // txtyazar
            // 
            this.txtyazar.Location = new System.Drawing.Point(138, 176);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(214, 36);
            this.txtyazar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar:";
            // 
            // txtsayfa
            // 
            this.txtsayfa.Location = new System.Drawing.Point(138, 234);
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(214, 36);
            this.txtsayfa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sayfa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tür:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Durum:";
            // 
            // cmbtur
            // 
            this.cmbtur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtur.FormattingEnabled = true;
            this.cmbtur.Items.AddRange(new object[] {
            "roman",
            "hikaye",
            "siir",
            "tiyatro",
            "deneme"});
            this.cmbtur.Location = new System.Drawing.Point(138, 287);
            this.cmbtur.Name = "cmbtur";
            this.cmbtur.Size = new System.Drawing.Size(214, 36);
            this.cmbtur.TabIndex = 9;
            // 
            // rdbkullanılmıs
            // 
            this.rdbkullanılmıs.AutoSize = true;
            this.rdbkullanılmıs.Location = new System.Drawing.Point(138, 340);
            this.rdbkullanılmıs.Name = "rdbkullanılmıs";
            this.rdbkullanılmıs.Size = new System.Drawing.Size(135, 32);
            this.rdbkullanılmıs.TabIndex = 10;
            this.rdbkullanılmıs.TabStop = true;
            this.rdbkullanılmıs.Text = "Kullanılmış";
            this.rdbkullanılmıs.UseVisualStyleBackColor = true;
            this.rdbkullanılmıs.CheckedChanged += new System.EventHandler(this.rdbkullanılmıs_CheckedChanged);
            // 
            // rdbsıfır
            // 
            this.rdbsıfır.AutoSize = true;
            this.rdbsıfır.Location = new System.Drawing.Point(281, 340);
            this.rdbsıfır.Name = "rdbsıfır";
            this.rdbsıfır.Size = new System.Drawing.Size(71, 32);
            this.rdbsıfır.TabIndex = 11;
            this.rdbsıfır.TabStop = true;
            this.rdbsıfır.Text = "Sıfır";
            this.rdbsıfır.UseVisualStyleBackColor = true;
            this.rdbsıfır.CheckedChanged += new System.EventHandler(this.rdbsıfır_CheckedChanged);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(138, 65);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(214, 36);
            this.txtid.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kitap id:";
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(393, 65);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(202, 54);
            this.btnlistele.TabIndex = 14;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(393, 287);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(202, 59);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(393, 211);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(202, 59);
            this.btnguncelle.TabIndex = 16;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(393, 138);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(202, 54);
            this.btnkaydet.TabIndex = 17;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnbul
            // 
            this.btnbul.Location = new System.Drawing.Point(711, 176);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(100, 44);
            this.btnbul.TabIndex = 18;
            this.btnbul.Text = "Bul";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // txtkitapbul
            // 
            this.txtkitapbul.Location = new System.Drawing.Point(711, 131);
            this.txtkitapbul.Name = "txtkitapbul";
            this.txtkitapbul.Size = new System.Drawing.Size(230, 36);
            this.txtkitapbul.TabIndex = 20;
       //     this.txtkitapbul.TextChanged += new System.EventHandler(this.txtkitapbul_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kitap Adı:";
       //     this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(841, 176);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(100, 44);
            this.btnara.TabIndex = 21;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(964, 636);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtkitapbul);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdbsıfır);
            this.Controls.Add(this.rdbkullanılmıs);
            this.Controls.Add(this.cmbtur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsayfa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtyazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkitap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkitap;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbtur;
        private System.Windows.Forms.RadioButton rdbkullanılmıs;
        private System.Windows.Forms.RadioButton rdbsıfır;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.TextBox txtkitapbul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnara;
    }
}

