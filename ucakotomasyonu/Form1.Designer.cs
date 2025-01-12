namespace ucakotomasyonu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxNereye = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxNereden = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEditdönüs = new DevExpress.XtraEditors.DateEdit();
            this.dateEditgidis = new DevExpress.XtraEditors.DateEdit();
            this.checkedListBoxSeferler = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxtekyon = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.element1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.element2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.element3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.element4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.element5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileControl2 = new DevExpress.XtraEditors.TileControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kampanyapaneli = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxNereye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxNereden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditdönüs.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditdönüs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditgidis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditgidis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.kampanyapaneli.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBoxNereye);
            this.panel1.Controls.Add(this.comboBoxNereden);
            this.panel1.Controls.Add(this.dateEditdönüs);
            this.panel1.Controls.Add(this.dateEditgidis);
            this.panel1.Controls.Add(this.checkedListBoxSeferler);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.checkBoxtekyon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.accordionControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 755);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1022, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 213;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxNereye
            // 
            this.comboBoxNereye.Location = new System.Drawing.Point(518, 192);
            this.comboBoxNereye.Name = "comboBoxNereye";
            this.comboBoxNereye.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxNereye.Size = new System.Drawing.Size(100, 20);
            this.comboBoxNereye.TabIndex = 212;
            // 
            // comboBoxNereden
            // 
            this.comboBoxNereden.Location = new System.Drawing.Point(277, 192);
            this.comboBoxNereden.Name = "comboBoxNereden";
            this.comboBoxNereden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxNereden.Size = new System.Drawing.Size(100, 20);
            this.comboBoxNereden.TabIndex = 211;
            // 
            // dateEditdönüs
            // 
            this.dateEditdönüs.EditValue = null;
            this.dateEditdönüs.Location = new System.Drawing.Point(518, 271);
            this.dateEditdönüs.Name = "dateEditdönüs";
            this.dateEditdönüs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditdönüs.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditdönüs.Size = new System.Drawing.Size(100, 20);
            this.dateEditdönüs.TabIndex = 210;
            // 
            // dateEditgidis
            // 
            this.dateEditgidis.EditValue = null;
            this.dateEditgidis.Location = new System.Drawing.Point(277, 271);
            this.dateEditgidis.Name = "dateEditgidis";
            this.dateEditgidis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditgidis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditgidis.Size = new System.Drawing.Size(100, 20);
            this.dateEditgidis.TabIndex = 209;
            // 
            // checkedListBoxSeferler
            // 
            this.checkedListBoxSeferler.FormattingEnabled = true;
            this.checkedListBoxSeferler.Location = new System.Drawing.Point(277, 372);
            this.checkedListBoxSeferler.Name = "checkedListBoxSeferler";
            this.checkedListBoxSeferler.Size = new System.Drawing.Size(323, 94);
            this.checkedListBoxSeferler.TabIndex = 208;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(414, 662);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 26);
            this.button2.TabIndex = 205;
            this.button2.Text = "DEVAM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(274, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 13);
            this.label1.TabIndex = 204;
            this.label1.Text = "Kişi Başı Ücret: 50TL                           100TL               200TL";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton3.Location = new System.Drawing.Point(516, 582);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 17);
            this.radioButton3.TabIndex = 203;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Business";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(431, 582);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 202;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Orta";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(337, 582);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 201;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ekonomi";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(448, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 200;
            this.label11.Text = "Bebek";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(515, 500);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 199;
            this.label10.Text = "Çocuk";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(388, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 198;
            this.label9.Text = "Yetişkin";
            // 
            // comboBox6
            // 
            this.comboBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox6.Location = new System.Drawing.Point(451, 527);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(30, 21);
            this.comboBox6.TabIndex = 197;
            // 
            // comboBox5
            // 
            this.comboBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox5.Location = new System.Drawing.Point(518, 527);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(30, 21);
            this.comboBox5.TabIndex = 196;
            // 
            // comboBox4
            // 
            this.comboBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox4.Location = new System.Drawing.Point(391, 527);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(30, 21);
            this.comboBox4.TabIndex = 195;
            this.comboBox4.Tag = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 194;
            this.button1.Text = "Sefer Kontrol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(274, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 191;
            this.label7.Text = "Gidiş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(518, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 190;
            this.label6.Text = "Dönüş";
            // 
            // checkBoxtekyon
            // 
            this.checkBoxtekyon.AutoSize = true;
            this.checkBoxtekyon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxtekyon.Location = new System.Drawing.Point(414, 273);
            this.checkBoxtekyon.Name = "checkBoxtekyon";
            this.checkBoxtekyon.Size = new System.Drawing.Size(67, 17);
            this.checkBoxtekyon.TabIndex = 189;
            this.checkBoxtekyon.Text = "Tek Yön";
            this.checkBoxtekyon.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(515, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 186;
            this.label5.Text = "Nereye";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(274, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 185;
            this.label4.Text = "Nereden ";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.element1,
            this.element2,
            this.element3,
            this.element4,
            this.element5});
            this.accordionControl1.Location = new System.Drawing.Point(1, 115);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(209, 614);
            this.accordionControl1.TabIndex = 179;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // element1
            // 
            this.element1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("element1.ImageOptions.Image")));
            this.element1.Name = "element1";
            this.element1.Text = "ANA SAYFA";
            // 
            // element2
            // 
            this.element2.Expanded = true;
            this.element2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("element2.ImageOptions.Image")));
            this.element2.Name = "element2";
            this.element2.Text = "SEYAHAT BİLGİLERİ";
            // 
            // element3
            // 
            this.element3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("element3.ImageOptions.Image")));
            this.element3.Name = "element3";
            this.element3.Text = "SEYAHAT DENEYİMİ";
            // 
            // element4
            // 
            this.element4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("element4.ImageOptions.Image")));
            this.element4.Name = "element4";
            this.element4.Text = "OYUN";
            // 
            // element5
            // 
            this.element5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("element5.ImageOptions.Image")));
            this.element5.Name = "element5";
            this.element5.Text = "KULLANICI SAYFASI";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(730, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 728);
            this.panel2.TabIndex = 180;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tileControl1);
            this.panel3.Controls.Add(this.tileControl2);
            this.panel3.Location = new System.Drawing.Point(-7, -6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 741);
            this.panel3.TabIndex = 51;
            // 
            // tileControl1
            // 
            this.tileControl1.AppearanceText.BackColor = System.Drawing.Color.Black;
            this.tileControl1.AppearanceText.BackColor2 = System.Drawing.Color.Black;
            this.tileControl1.AppearanceText.BorderColor = System.Drawing.Color.Black;
            this.tileControl1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileControl1.AppearanceText.Options.UseBackColor = true;
            this.tileControl1.AppearanceText.Options.UseBorderColor = true;
            this.tileControl1.AppearanceText.Options.UseFont = true;
            this.tileControl1.BackColor = System.Drawing.Color.LightGray;
            this.tileControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileControl1.BackgroundImage")));
            this.tileControl1.Location = new System.Drawing.Point(19, 313);
            this.tileControl1.MaxId = 5;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.ShowText = true;
            this.tileControl1.Size = new System.Drawing.Size(230, 317);
            this.tileControl1.TabIndex = 1;
            this.tileControl1.Text = "KAMPANYALAR";
            // 
            // tileControl2
            // 
            this.tileControl2.AppearanceText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileControl2.AppearanceText.Options.UseFont = true;
            this.tileControl2.BackColor = System.Drawing.Color.LightGray;
            this.tileControl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileControl2.BackgroundImage")));
            this.tileControl2.Location = new System.Drawing.Point(19, 6);
            this.tileControl2.MaxId = 4;
            this.tileControl2.Name = "tileControl2";
            this.tileControl2.ShowText = true;
            this.tileControl2.Size = new System.Drawing.Size(230, 308);
            this.tileControl2.TabIndex = 0;
            this.tileControl2.Text = "  DUYURULAR";
            this.tileControl2.Click += new System.EventHandler(this.tileControl2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.kampanyapaneli);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(769, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 715);
            this.panel4.TabIndex = 181;
            // 
            // kampanyapaneli
            // 
            this.kampanyapaneli.Controls.Add(this.label13);
            this.kampanyapaneli.Location = new System.Drawing.Point(0, 332);
            this.kampanyapaneli.Name = "kampanyapaneli";
            this.kampanyapaneli.Size = new System.Drawing.Size(200, 380);
            this.kampanyapaneli.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 25);
            this.label13.TabIndex = 95;
            this.label13.Text = "KAMPANYALAR";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label15);
            this.panel6.Location = new System.Drawing.Point(3, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 319);
            this.panel6.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(21, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(152, 25);
            this.label15.TabIndex = 94;
            this.label15.Text = "DUYURULAR";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(974, 738);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxNereye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxNereden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditdönüs.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditdönüs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditgidis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditgidis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.kampanyapaneli.ResumeLayout(false);
            this.kampanyapaneli.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement element1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement element2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement element3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement element4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement element5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileControl tileControl2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel kampanyapaneli;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckedListBox checkedListBoxSeferler;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxtekyon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit dateEditdönüs;
        private DevExpress.XtraEditors.DateEdit dateEditgidis;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxNereye;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxNereden;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

