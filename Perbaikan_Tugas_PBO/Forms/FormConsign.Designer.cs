namespace Perbaikan_Tugas_PBO.Forms
{
    partial class FormConsign
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNamaPengirim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbTransfer = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNomorTelepon1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbKartuKredit = new System.Windows.Forms.RadioButton();
            this.rbRekber = new System.Windows.Forms.RadioButton();
            this.rbDirectDebit = new System.Windows.Forms.RadioButton();
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbAlamatPengirim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAlamatPenerima = new System.Windows.Forms.TextBox();
            this.tbNomorTelepon2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNamaPenerima = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbKondisiBarang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbKodeBarang = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.btnSelanjutnya = new System.Windows.Forms.Button();
            this.rbB4 = new System.Windows.Forms.RadioButton();
            this.rbB2 = new System.Windows.Forms.RadioButton();
            this.rbB3 = new System.Windows.Forms.RadioButton();
            this.rbB1 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pengirim";
            // 
            // tbNamaPengirim
            // 
            this.tbNamaPengirim.Location = new System.Drawing.Point(183, 143);
            this.tbNamaPengirim.Name = "tbNamaPengirim";
            this.tbNamaPengirim.Size = new System.Drawing.Size(183, 20);
            this.tbNamaPengirim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alamat Pengirim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Metode Pembayaran";
            // 
            // rbTransfer
            // 
            this.rbTransfer.AutoSize = true;
            this.rbTransfer.Location = new System.Drawing.Point(183, 335);
            this.rbTransfer.Name = "rbTransfer";
            this.rbTransfer.Size = new System.Drawing.Size(64, 17);
            this.rbTransfer.TabIndex = 7;
            this.rbTransfer.TabStop = true;
            this.rbTransfer.Text = "Transfer";
            this.rbTransfer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Formulir Pengiriman Barang";
            // 
            // tbNomorTelepon1
            // 
            this.tbNomorTelepon1.Location = new System.Drawing.Point(183, 275);
            this.tbNomorTelepon1.Name = "tbNomorTelepon1";
            this.tbNomorTelepon1.Size = new System.Drawing.Size(183, 20);
            this.tbNomorTelepon1.TabIndex = 12;
            this.tbNomorTelepon1.TextChanged += new System.EventHandler(this.tbNomorTelepon1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nomor Telepon";
            // 
            // rbKartuKredit
            // 
            this.rbKartuKredit.AutoSize = true;
            this.rbKartuKredit.Location = new System.Drawing.Point(280, 334);
            this.rbKartuKredit.Name = "rbKartuKredit";
            this.rbKartuKredit.Size = new System.Drawing.Size(80, 17);
            this.rbKartuKredit.TabIndex = 13;
            this.rbKartuKredit.TabStop = true;
            this.rbKartuKredit.Text = "Kartu Kredit";
            this.rbKartuKredit.UseVisualStyleBackColor = true;
            // 
            // rbRekber
            // 
            this.rbRekber.AutoSize = true;
            this.rbRekber.Location = new System.Drawing.Point(183, 365);
            this.rbRekber.Name = "rbRekber";
            this.rbRekber.Size = new System.Drawing.Size(60, 17);
            this.rbRekber.TabIndex = 14;
            this.rbRekber.TabStop = true;
            this.rbRekber.Text = "Rekber";
            this.rbRekber.UseVisualStyleBackColor = true;
            // 
            // rbDirectDebit
            // 
            this.rbDirectDebit.AutoSize = true;
            this.rbDirectDebit.Location = new System.Drawing.Point(280, 365);
            this.rbDirectDebit.Name = "rbDirectDebit";
            this.rbDirectDebit.Size = new System.Drawing.Size(81, 17);
            this.rbDirectDebit.TabIndex = 15;
            this.rbDirectDebit.TabStop = true;
            this.rbDirectDebit.Text = "Direct Debit";
            this.rbDirectDebit.UseVisualStyleBackColor = true;
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            // 
            // tbAlamatPengirim
            // 
            this.tbAlamatPengirim.Location = new System.Drawing.Point(183, 186);
            this.tbAlamatPengirim.Multiline = true;
            this.tbAlamatPengirim.Name = "tbAlamatPengirim";
            this.tbAlamatPengirim.Size = new System.Drawing.Size(183, 67);
            this.tbAlamatPengirim.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nama Pengirim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Nama Penerima";
            // 
            // tbAlamatPenerima
            // 
            this.tbAlamatPenerima.Location = new System.Drawing.Point(571, 186);
            this.tbAlamatPenerima.Multiline = true;
            this.tbAlamatPenerima.Name = "tbAlamatPenerima";
            this.tbAlamatPenerima.Size = new System.Drawing.Size(183, 67);
            this.tbAlamatPenerima.TabIndex = 27;
            // 
            // tbNomorTelepon2
            // 
            this.tbNomorTelepon2.Location = new System.Drawing.Point(571, 275);
            this.tbNomorTelepon2.Name = "tbNomorTelepon2";
            this.tbNomorTelepon2.Size = new System.Drawing.Size(183, 20);
            this.tbNomorTelepon2.TabIndex = 26;
            this.tbNomorTelepon2.TextChanged += new System.EventHandler(this.tbNomorTelepon2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nomor Telepon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Alamat Penerima";
            // 
            // tbNamaPenerima
            // 
            this.tbNamaPenerima.Location = new System.Drawing.Point(571, 143);
            this.tbNamaPenerima.Name = "tbNamaPenerima";
            this.tbNamaPenerima.Size = new System.Drawing.Size(183, 20);
            this.tbNamaPenerima.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nama Penerima";
            // 
            // cbKondisiBarang
            // 
            this.cbKondisiBarang.FormattingEnabled = true;
            this.cbKondisiBarang.Items.AddRange(new object[] {
            "Baru",
            "Bekas"});
            this.cbKondisiBarang.Location = new System.Drawing.Point(571, 52);
            this.cbKondisiBarang.Name = "cbKondisiBarang";
            this.cbKondisiBarang.Size = new System.Drawing.Size(183, 21);
            this.cbKondisiBarang.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(447, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Kondisi Barang";
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.Location = new System.Drawing.Point(183, 55);
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.Size = new System.Drawing.Size(183, 20);
            this.tbKodeBarang.TabIndex = 33;
            this.tbKodeBarang.TextChanged += new System.EventHandler(this.tbKodeBarang_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Kode Barang";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb8);
            this.groupBox2.Controls.Add(this.cb7);
            this.groupBox2.Controls.Add(this.cb6);
            this.groupBox2.Controls.Add(this.cb5);
            this.groupBox2.Controls.Add(this.cb4);
            this.groupBox2.Controls.Add(this.cb3);
            this.groupBox2.Controls.Add(this.cb2);
            this.groupBox2.Controls.Add(this.cb1);
            this.groupBox2.Location = new System.Drawing.Point(528, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 131);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paket Pengiriman";
            // 
            // cb8
            // 
            this.cb8.AutoSize = true;
            this.cb8.Enabled = false;
            this.cb8.Location = new System.Drawing.Point(110, 97);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(63, 17);
            this.cb8.TabIndex = 7;
            this.cb8.Text = "Express";
            this.cb8.UseVisualStyleBackColor = true;
            // 
            // cb7
            // 
            this.cb7.AutoSize = true;
            this.cb7.Enabled = false;
            this.cb7.Location = new System.Drawing.Point(110, 71);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(63, 17);
            this.cb7.TabIndex = 6;
            this.cb7.Text = "Reguler";
            this.cb7.UseVisualStyleBackColor = true;
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.Enabled = false;
            this.cb6.Location = new System.Drawing.Point(110, 45);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(63, 17);
            this.cb6.TabIndex = 5;
            this.cb6.Text = "Express";
            this.cb6.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Enabled = false;
            this.cb5.Location = new System.Drawing.Point(110, 19);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(63, 17);
            this.cb5.TabIndex = 4;
            this.cb5.Text = "Reguler";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Enabled = false;
            this.cb4.Location = new System.Drawing.Point(6, 97);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(63, 17);
            this.cb4.TabIndex = 3;
            this.cb4.Text = "Express";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Enabled = false;
            this.cb3.Location = new System.Drawing.Point(6, 71);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(63, 17);
            this.cb3.TabIndex = 2;
            this.cb3.Text = "Reguler";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Enabled = false;
            this.cb2.Location = new System.Drawing.Point(6, 45);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(63, 17);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "Express";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Enabled = false;
            this.cb1.Location = new System.Drawing.Point(6, 19);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(63, 17);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Reguler";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // btnSelanjutnya
            // 
            this.btnSelanjutnya.Location = new System.Drawing.Point(618, 335);
            this.btnSelanjutnya.Name = "btnSelanjutnya";
            this.btnSelanjutnya.Size = new System.Drawing.Size(106, 47);
            this.btnSelanjutnya.TabIndex = 35;
            this.btnSelanjutnya.Text = "Selanjutnya";
            this.btnSelanjutnya.UseVisualStyleBackColor = true;
            this.btnSelanjutnya.Click += new System.EventHandler(this.btnSelanjutnya_Click);
            // 
            // rbB4
            // 
            this.rbB4.AutoSize = true;
            this.rbB4.Location = new System.Drawing.Point(280, 472);
            this.rbB4.Name = "rbB4";
            this.rbB4.Size = new System.Drawing.Size(68, 17);
            this.rbB4.TabIndex = 40;
            this.rbB4.TabStop = true;
            this.rbB4.Text = "> 21 Kg -";
            this.rbB4.UseVisualStyleBackColor = true;
            // 
            // rbB2
            // 
            this.rbB2.AutoSize = true;
            this.rbB2.Location = new System.Drawing.Point(183, 472);
            this.rbB2.Name = "rbB2";
            this.rbB2.Size = new System.Drawing.Size(93, 17);
            this.rbB2.TabIndex = 39;
            this.rbB2.TabStop = true;
            this.rbB2.Text = "> 1 Kg - 10 Kg";
            this.rbB2.UseVisualStyleBackColor = true;
            // 
            // rbB3
            // 
            this.rbB3.AutoSize = true;
            this.rbB3.Location = new System.Drawing.Point(280, 441);
            this.rbB3.Name = "rbB3";
            this.rbB3.Size = new System.Drawing.Size(99, 17);
            this.rbB3.TabIndex = 38;
            this.rbB3.TabStop = true;
            this.rbB3.Text = "> 11 Kg - 20 Kg";
            this.rbB3.UseVisualStyleBackColor = true;
            // 
            // rbB1
            // 
            this.rbB1.AutoSize = true;
            this.rbB1.Location = new System.Drawing.Point(183, 442);
            this.rbB1.Name = "rbB1";
            this.rbB1.Size = new System.Drawing.Size(56, 17);
            this.rbB1.TabIndex = 37;
            this.rbB1.TabStop = true;
            this.rbB1.Text = "< 1 Kg";
            this.rbB1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 442);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Berat Barang";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(280, 612);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(106, 47);
            this.btnSimpan.TabIndex = 41;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(428, 612);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 47);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormConsign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.rbB4);
            this.Controls.Add(this.rbB2);
            this.Controls.Add(this.rbB3);
            this.Controls.Add(this.rbB1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSelanjutnya);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbKodeBarang);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbKondisiBarang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAlamatPenerima);
            this.Controls.Add(this.tbNomorTelepon2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbNamaPenerima);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbAlamatPengirim);
            this.Controls.Add(this.rbDirectDebit);
            this.Controls.Add(this.rbRekber);
            this.Controls.Add(this.rbKartuKredit);
            this.Controls.Add(this.tbNomorTelepon1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbTransfer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNamaPengirim);
            this.Controls.Add(this.label1);
            this.Name = "FormConsign";
            this.Text = "FormConsign";
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamaPengirim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbTransfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNomorTelepon1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbKartuKredit;
        private System.Windows.Forms.RadioButton rbRekber;
        private System.Windows.Forms.RadioButton rbDirectDebit;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAlamatPenerima;
        private System.Windows.Forms.TextBox tbNomorTelepon2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNamaPenerima;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAlamatPengirim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbKondisiBarang;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.RadioButton rbB4;
        private System.Windows.Forms.RadioButton rbB2;
        private System.Windows.Forms.RadioButton rbB3;
        private System.Windows.Forms.RadioButton rbB1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSelanjutnya;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb8;
        private System.Windows.Forms.CheckBox cb7;
        private System.Windows.Forms.CheckBox cb6;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.TextBox tbKodeBarang;
        private System.Windows.Forms.Label label12;
    }
}