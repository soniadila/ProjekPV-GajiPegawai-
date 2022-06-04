/*
 * Created by SharpDevelop.
 * User: User
 * Date: 11/05/2022
 * Time: 10:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.id_pegawai = new System.Windows.Forms.TextBox();
			this.nama = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.gajipokok = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.totalgaji = new System.Windows.Forms.Label();
			this.gaji_pokoktxt = new System.Windows.Forms.TextBox();
			this.tunjangan_istritxt = new System.Windows.Forms.TextBox();
			this.tunjangan_anaktxt = new System.Windows.Forms.TextBox();
			this.total_gajitxt = new System.Windows.Forms.TextBox();
			this.departemen = new System.Windows.Forms.ComboBox();
			this.button7 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.jumlahanak = new System.Windows.Forms.Label();
			this.golongan = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cari = new System.Windows.Forms.TextBox();
			this.jenis_kelamin = new System.Windows.Forms.GroupBox();
			this.wanita = new System.Windows.Forms.RadioButton();
			this.pria = new System.Windows.Forms.RadioButton();
			this.status = new System.Windows.Forms.GroupBox();
			this.belum_menikah = new System.Windows.Forms.RadioButton();
			this.menikah = new System.Windows.Forms.RadioButton();
			this.jumlah_anak = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.jenis_kelamin.SuspendLayout();
			this.status.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.jumlah_anak)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(433, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 58);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gaji Pegawai";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 106);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "ID Pegawai";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 147);
			this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nama";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(7, 186);
			this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Departemen";
			// 
			// id_pegawai
			// 
			this.id_pegawai.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.id_pegawai.Location = new System.Drawing.Point(144, 105);
			this.id_pegawai.Margin = new System.Windows.Forms.Padding(1);
			this.id_pegawai.Name = "id_pegawai";
			this.id_pegawai.Size = new System.Drawing.Size(283, 30);
			this.id_pegawai.TabIndex = 5;
			this.id_pegawai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Id_pegawaiKeyPress);
			// 
			// nama
			// 
			this.nama.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nama.Location = new System.Drawing.Point(144, 146);
			this.nama.Margin = new System.Windows.Forms.Padding(1);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(283, 30);
			this.nama.TabIndex = 6;
			this.nama.TextChanged += new System.EventHandler(this.NamaTextChanged);
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.Location = new System.Drawing.Point(10, 381);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1087, 227);
			this.dataGridView1.TabIndex = 14;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(1026, 133);
			this.button1.Margin = new System.Windows.Forms.Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 26);
			this.button1.TabIndex = 15;
			this.button1.Text = "Simpan";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(1026, 161);
			this.button2.Margin = new System.Windows.Forms.Padding(1);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(71, 24);
			this.button2.TabIndex = 16;
			this.button2.Text = "Ubah";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(1026, 187);
			this.button3.Margin = new System.Windows.Forms.Padding(1);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(71, 27);
			this.button3.TabIndex = 17;
			this.button3.Text = "Hapus";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(1026, 216);
			this.button4.Margin = new System.Windows.Forms.Padding(1);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(71, 25);
			this.button4.TabIndex = 18;
			this.button4.Text = "Reset";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(1026, 243);
			this.button5.Margin = new System.Windows.Forms.Padding(1);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(71, 28);
			this.button5.TabIndex = 19;
			this.button5.Text = "Keluar";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(1026, 332);
			this.button6.Margin = new System.Windows.Forms.Padding(1);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(71, 26);
			this.button6.TabIndex = 20;
			this.button6.Text = "Cari";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(10, 278);
			this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(132, 33);
			this.label6.TabIndex = 21;
			this.label6.Text = "Jenis Kelamin";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// gajipokok
			// 
			this.gajipokok.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gajipokok.Location = new System.Drawing.Point(467, 147);
			this.gajipokok.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.gajipokok.Name = "gajipokok";
			this.gajipokok.Size = new System.Drawing.Size(109, 30);
			this.gajipokok.TabIndex = 29;
			this.gajipokok.Text = "Gaji Pokok";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(467, 186);
			this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(156, 30);
			this.label10.TabIndex = 30;
			this.label10.Text = "Tunjangan Istri";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(469, 229);
			this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(154, 30);
			this.label11.TabIndex = 31;
			this.label11.Text = "Tunjangan Anak";
			// 
			// totalgaji
			// 
			this.totalgaji.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalgaji.Location = new System.Drawing.Point(469, 278);
			this.totalgaji.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.totalgaji.Name = "totalgaji";
			this.totalgaji.Size = new System.Drawing.Size(111, 30);
			this.totalgaji.TabIndex = 32;
			this.totalgaji.Text = "Total Gaji";
			// 
			// gaji_pokoktxt
			// 
			this.gaji_pokoktxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gaji_pokoktxt.Location = new System.Drawing.Point(636, 146);
			this.gaji_pokoktxt.Margin = new System.Windows.Forms.Padding(1);
			this.gaji_pokoktxt.Name = "gaji_pokoktxt";
			this.gaji_pokoktxt.Size = new System.Drawing.Size(302, 30);
			this.gaji_pokoktxt.TabIndex = 33;
			// 
			// tunjangan_istritxt
			// 
			this.tunjangan_istritxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tunjangan_istritxt.Location = new System.Drawing.Point(636, 185);
			this.tunjangan_istritxt.Margin = new System.Windows.Forms.Padding(1);
			this.tunjangan_istritxt.Name = "tunjangan_istritxt";
			this.tunjangan_istritxt.Size = new System.Drawing.Size(302, 30);
			this.tunjangan_istritxt.TabIndex = 34;
			// 
			// tunjangan_anaktxt
			// 
			this.tunjangan_anaktxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tunjangan_anaktxt.Location = new System.Drawing.Point(636, 228);
			this.tunjangan_anaktxt.Margin = new System.Windows.Forms.Padding(1);
			this.tunjangan_anaktxt.Name = "tunjangan_anaktxt";
			this.tunjangan_anaktxt.Size = new System.Drawing.Size(302, 30);
			this.tunjangan_anaktxt.TabIndex = 35;
			// 
			// total_gajitxt
			// 
			this.total_gajitxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.total_gajitxt.Location = new System.Drawing.Point(636, 275);
			this.total_gajitxt.Margin = new System.Windows.Forms.Padding(1);
			this.total_gajitxt.Name = "total_gajitxt";
			this.total_gajitxt.Size = new System.Drawing.Size(302, 30);
			this.total_gajitxt.TabIndex = 36;
			// 
			// departemen
			// 
			this.departemen.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.departemen.FormattingEnabled = true;
			this.departemen.Location = new System.Drawing.Point(144, 185);
			this.departemen.Margin = new System.Windows.Forms.Padding(1);
			this.departemen.Name = "departemen";
			this.departemen.Size = new System.Drawing.Size(283, 31);
			this.departemen.TabIndex = 37;
			this.departemen.SelectedIndexChanged += new System.EventHandler(this.DepartemenSelectedIndexChanged);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(1026, 105);
			this.button7.Margin = new System.Windows.Forms.Padding(1);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(71, 26);
			this.button7.TabIndex = 42;
			this.button7.Text = "Hitung";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 327);
			this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 25);
			this.label5.TabIndex = 43;
			this.label5.Text = "Status";
			// 
			// jumlahanak
			// 
			this.jumlahanak.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jumlahanak.Location = new System.Drawing.Point(467, 106);
			this.jumlahanak.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.jumlahanak.Name = "jumlahanak";
			this.jumlahanak.Size = new System.Drawing.Size(130, 29);
			this.jumlahanak.TabIndex = 44;
			this.jumlahanak.Text = "Jumlah Anak";
			// 
			// golongan
			// 
			this.golongan.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.golongan.FormattingEnabled = true;
			this.golongan.Location = new System.Drawing.Point(144, 228);
			this.golongan.Margin = new System.Windows.Forms.Padding(1);
			this.golongan.Name = "golongan";
			this.golongan.Size = new System.Drawing.Size(283, 31);
			this.golongan.TabIndex = 46;
			this.golongan.SelectedIndexChanged += new System.EventHandler(this.GolonganSelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(10, 229);
			this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(90, 25);
			this.label7.TabIndex = 47;
			this.label7.Text = "Golongan";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cari);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(622, 310);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
			this.groupBox1.Size = new System.Drawing.Size(333, 59);
			this.groupBox1.TabIndex = 48;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pencarian ID dan Nama Pegawai";
			// 
			// cari
			// 
			this.cari.Location = new System.Drawing.Point(14, 25);
			this.cari.Margin = new System.Windows.Forms.Padding(1);
			this.cari.Name = "cari";
			this.cari.Size = new System.Drawing.Size(302, 23);
			this.cari.TabIndex = 0;
			this.cari.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// jenis_kelamin
			// 
			this.jenis_kelamin.Controls.Add(this.wanita);
			this.jenis_kelamin.Controls.Add(this.pria);
			this.jenis_kelamin.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jenis_kelamin.Location = new System.Drawing.Point(144, 265);
			this.jenis_kelamin.Margin = new System.Windows.Forms.Padding(1);
			this.jenis_kelamin.Name = "jenis_kelamin";
			this.jenis_kelamin.Padding = new System.Windows.Forms.Padding(1);
			this.jenis_kelamin.Size = new System.Drawing.Size(283, 43);
			this.jenis_kelamin.TabIndex = 52;
			this.jenis_kelamin.TabStop = false;
			this.jenis_kelamin.Text = "Jenis Kelamin";
			// 
			// wanita
			// 
			this.wanita.Location = new System.Drawing.Point(117, 15);
			this.wanita.Margin = new System.Windows.Forms.Padding(1);
			this.wanita.Name = "wanita";
			this.wanita.Size = new System.Drawing.Size(104, 26);
			this.wanita.TabIndex = 1;
			this.wanita.TabStop = true;
			this.wanita.Text = "Wanita";
			this.wanita.UseVisualStyleBackColor = true;
			// 
			// pria
			// 
			this.pria.Location = new System.Drawing.Point(13, 15);
			this.pria.Margin = new System.Windows.Forms.Padding(1);
			this.pria.Name = "pria";
			this.pria.Size = new System.Drawing.Size(64, 27);
			this.pria.TabIndex = 0;
			this.pria.TabStop = true;
			this.pria.Text = "Pria";
			this.pria.UseVisualStyleBackColor = true;
			// 
			// status
			// 
			this.status.Controls.Add(this.belum_menikah);
			this.status.Controls.Add(this.menikah);
			this.status.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.status.Location = new System.Drawing.Point(144, 314);
			this.status.Margin = new System.Windows.Forms.Padding(1);
			this.status.Name = "status";
			this.status.Padding = new System.Windows.Forms.Padding(1);
			this.status.Size = new System.Drawing.Size(283, 43);
			this.status.TabIndex = 53;
			this.status.TabStop = false;
			this.status.Text = "Status";
			// 
			// belum_menikah
			// 
			this.belum_menikah.Location = new System.Drawing.Point(117, 18);
			this.belum_menikah.Margin = new System.Windows.Forms.Padding(1);
			this.belum_menikah.Name = "belum_menikah";
			this.belum_menikah.Size = new System.Drawing.Size(110, 20);
			this.belum_menikah.TabIndex = 1;
			this.belum_menikah.TabStop = true;
			this.belum_menikah.Text = "Belum Menikah";
			this.belum_menikah.UseVisualStyleBackColor = true;
			// 
			// menikah
			// 
			this.menikah.Location = new System.Drawing.Point(13, 15);
			this.menikah.Margin = new System.Windows.Forms.Padding(1);
			this.menikah.Name = "menikah";
			this.menikah.Size = new System.Drawing.Size(75, 26);
			this.menikah.TabIndex = 0;
			this.menikah.TabStop = true;
			this.menikah.Text = "Menikah";
			this.menikah.UseVisualStyleBackColor = true;
			// 
			// jumlah_anak
			// 
			this.jumlah_anak.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jumlah_anak.Location = new System.Drawing.Point(636, 106);
			this.jumlah_anak.Margin = new System.Windows.Forms.Padding(1);
			this.jumlah_anak.Name = "jumlah_anak";
			this.jumlah_anak.Size = new System.Drawing.Size(302, 30);
			this.jumlah_anak.TabIndex = 54;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1107, 618);
			this.Controls.Add(this.jumlah_anak);
			this.Controls.Add(this.status);
			this.Controls.Add(this.jenis_kelamin);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.golongan);
			this.Controls.Add(this.jumlahanak);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.departemen);
			this.Controls.Add(this.total_gajitxt);
			this.Controls.Add(this.tunjangan_anaktxt);
			this.Controls.Add(this.tunjangan_istritxt);
			this.Controls.Add(this.gaji_pokoktxt);
			this.Controls.Add(this.totalgaji);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.gajipokok);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.id_pegawai);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "MainForm";
			this.Text = "Gaji Pegawai";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.jenis_kelamin.ResumeLayout(false);
			this.status.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.jumlah_anak)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.NumericUpDown jumlah_anak;
		private System.Windows.Forms.RadioButton menikah;
		private System.Windows.Forms.RadioButton belum_menikah;
		private System.Windows.Forms.RadioButton pria;
		private System.Windows.Forms.RadioButton wanita;
		private System.Windows.Forms.TextBox cari;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox golongan;
		private System.Windows.Forms.Label jumlahanak;
		private System.Windows.Forms.GroupBox status;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.GroupBox jenis_kelamin;
		private System.Windows.Forms.ComboBox departemen;
		private System.Windows.Forms.TextBox total_gajitxt;
		private System.Windows.Forms.TextBox tunjangan_anaktxt;
		private System.Windows.Forms.TextBox tunjangan_istritxt;
		private System.Windows.Forms.TextBox gaji_pokoktxt;
		private System.Windows.Forms.Label totalgaji;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label gajipokok;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox id_pegawai;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
