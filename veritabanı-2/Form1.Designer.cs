namespace veritabanı_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbno = new System.Windows.Forms.TextBox();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.tbsoyadi = new System.Windows.Forms.TextBox();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbsil = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbara = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbmail = new System.Windows.Forms.TextBox();
            this.tbadres = new System.Windows.Forms.TextBox();
            this.tbeski = new System.Windows.Forms.TextBox();
            this.tbyeni = new System.Windows.Forms.TextBox();
            this.tbteshis = new System.Windows.Forms.TextBox();
            this.tbilac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbno
            // 
            this.tbno.Location = new System.Drawing.Point(136, 62);
            this.tbno.MaxLength = 11;
            this.tbno.Name = "tbno";
            this.tbno.Size = new System.Drawing.Size(176, 20);
            this.tbno.TabIndex = 0;
            this.tbno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbno_KeyPress);
            // 
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(136, 95);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(176, 20);
            this.tbadi.TabIndex = 1;
            this.tbadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbadi_KeyPress);
            // 
            // tbsoyadi
            // 
            this.tbsoyadi.Location = new System.Drawing.Point(136, 131);
            this.tbsoyadi.Name = "tbsoyadi";
            this.tbsoyadi.Size = new System.Drawing.Size(176, 20);
            this.tbsoyadi.TabIndex = 2;
            this.tbsoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbsoyadi_KeyPress);
            // 
            // tbtel
            // 
            this.tbtel.Location = new System.Drawing.Point(136, 167);
            this.tbtel.MaxLength = 11;
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(176, 20);
            this.tbtel.TabIndex = 3;
            this.tbtel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbtel_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(-2, 423);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1053, 203);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(15, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "KAYIT EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(116)))), ((int)(((byte)(191)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(164, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "(TC NO GİRİN)";
            // 
            // tbsil
            // 
            this.tbsil.Location = new System.Drawing.Point(168, 237);
            this.tbsil.MaxLength = 11;
            this.tbsil.Name = "tbsil";
            this.tbsil.Size = new System.Drawing.Size(147, 20);
            this.tbsil.TabIndex = 12;
            this.tbsil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbsil_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(16, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "KAYIT SİL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "ADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "SOYADI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "TELEFONU";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(15, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 40);
            this.button3.TabIndex = 11;
            this.button3.Text = "GÜNCELLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.button4.Location = new System.Drawing.Point(15, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 40);
            this.button4.TabIndex = 15;
            this.button4.Text = "KAYIT ARA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbara
            // 
            this.tbara.Location = new System.Drawing.Point(168, 309);
            this.tbara.MaxLength = 11;
            this.tbara.Name = "tbara";
            this.tbara.Size = new System.Drawing.Size(147, 20);
            this.tbara.TabIndex = 14;
            this.tbara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbara_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbmail
            // 
            this.tbmail.Location = new System.Drawing.Point(136, 204);
            this.tbmail.Name = "tbmail";
            this.tbmail.Size = new System.Drawing.Size(176, 20);
            this.tbmail.TabIndex = 4;
            // 
            // tbadres
            // 
            this.tbadres.Location = new System.Drawing.Point(136, 239);
            this.tbadres.Name = "tbadres";
            this.tbadres.Size = new System.Drawing.Size(176, 20);
            this.tbadres.TabIndex = 5;
            // 
            // tbeski
            // 
            this.tbeski.Location = new System.Drawing.Point(136, 275);
            this.tbeski.Name = "tbeski";
            this.tbeski.Size = new System.Drawing.Size(176, 20);
            this.tbeski.TabIndex = 6;
            this.tbeski.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbeski_KeyPress);
            // 
            // tbyeni
            // 
            this.tbyeni.Location = new System.Drawing.Point(136, 311);
            this.tbyeni.Name = "tbyeni";
            this.tbyeni.Size = new System.Drawing.Size(176, 20);
            this.tbyeni.TabIndex = 7;
            this.tbyeni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbyeni_KeyPress);
            // 
            // tbteshis
            // 
            this.tbteshis.Location = new System.Drawing.Point(136, 347);
            this.tbteshis.Name = "tbteshis";
            this.tbteshis.Size = new System.Drawing.Size(176, 20);
            this.tbteshis.TabIndex = 8;
            // 
            // tbilac
            // 
            this.tbilac.Location = new System.Drawing.Point(136, 383);
            this.tbilac.Name = "tbilac";
            this.tbilac.Size = new System.Drawing.Size(176, 20);
            this.tbilac.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "E-MAIL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.label8.Location = new System.Drawing.Point(12, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "ADRES";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.label10.Location = new System.Drawing.Point(12, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "ESKİ KİLO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.label11.Location = new System.Drawing.Point(12, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 19);
            this.label11.TabIndex = 32;
            this.label11.Text = "YENİ KİLO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.label12.Location = new System.Drawing.Point(12, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 33;
            this.label12.Text = "TEŞHİS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.label13.Location = new System.Drawing.Point(12, 384);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 19);
            this.label13.TabIndex = 34;
            this.label13.Text = "İLAÇ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(116)))), ((int)(((byte)(191)))));
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(164, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "(TC NO GİRİN)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 417);
            this.panel1.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 32);
            this.label7.TabIndex = 38;
            this.label7.Text = "HASTA BİLGİLERİ ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(116)))), ((int)(((byte)(191)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.tbsil);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbara);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(356, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 420);
            this.panel2.TabIndex = 37;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.button5.Location = new System.Drawing.Point(16, 363);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(309, 46);
            this.button5.TabIndex = 40;
            this.button5.Text = "EKRANI TEMİZLE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(116)))), ((int)(((byte)(191)))));
            this.label14.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(9, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(246, 32);
            this.label14.TabIndex = 39;
            this.label14.Text = "İŞLEM BÖLÜMÜ";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(0, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(318, 217);
            this.label15.TabIndex = 38;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(182, 409);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 22);
            this.label16.TabIndex = 40;
            this.label16.Text = "MR.VEDAT D.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::veritabanı_2.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(242)))), ((int)(((byte)(220)))));
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(703, -14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 431);
            this.panel3.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1020, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbilac);
            this.Controls.Add(this.tbteshis);
            this.Controls.Add(this.tbyeni);
            this.Controls.Add(this.tbeski);
            this.Controls.Add(this.tbadres);
            this.Controls.Add(this.tbmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbtel);
            this.Controls.Add(this.tbsoyadi);
            this.Controls.Add(this.tbno);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diyetisyen Hasta Takip Programı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbno;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.TextBox tbsoyadi;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbsil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbara;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbmail;
        private System.Windows.Forms.TextBox tbadres;
        private System.Windows.Forms.TextBox tbeski;
        private System.Windows.Forms.TextBox tbyeni;
        private System.Windows.Forms.TextBox tbteshis;
        private System.Windows.Forms.TextBox tbilac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
    }
}

