namespace ucakotomasyonu
{
    partial class formdeneyimgoruntuleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formdeneyimgoruntuleme));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.element1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.element2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.element3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.element4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.element23 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.accordionControl1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 691);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1022, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 214;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(244, 195);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(710, 342);
            this.listBox1.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(384, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "DENEYİM GÖRÜNTÜLEME PANELİ";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.element1,
            this.element2,
            this.element3,
            this.element4,
            this.element23});
            this.accordionControl1.Location = new System.Drawing.Point(2, 118);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(236, 422);
            this.accordionControl1.TabIndex = 72;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // element1
            // 
            this.element1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("element1.ImageOptions.Image")));
            this.element1.Name = "element1";
            this.element1.Text = "Duyuru Ve Kampanya Paneli";
            // 
            // element2
            // 
            this.element2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("element2.ImageOptions.Image")));
            this.element2.Name = "element2";
            this.element2.Text = "Sefer Düzenleme Paneli";
            // 
            // element3
            // 
            this.element3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("element3.ImageOptions.Image")));
            this.element3.Name = "element3";
            this.element3.Text = "Seyahat Deneyimi Görüntüleme Paneli";
            // 
            // element4
            // 
            this.element4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("element4.ImageOptions.Image")));
            this.element4.Name = "element4";
            this.element4.Text = "Rezerv Görüntüleme Paneli";
            // 
            // element23
            // 
            this.element23.Expanded = true;
            this.element23.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("element23.ImageOptions.Image")));
            this.element23.Name = "element23";
            this.element23.Text = "ÇIKIŞ";
            // 
            // formdeneyimgoruntuleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 540);
            this.Controls.Add(this.panel1);
            this.Name = "formdeneyimgoruntuleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formdeneyimgoruntuleme";
            this.Load += new System.EventHandler(this.formdeneyimgoruntuleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement element1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement element2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement element3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement element4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement element23;
    }
}