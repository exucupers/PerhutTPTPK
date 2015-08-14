namespace Perhutani
{
    partial class FormTPK_Kapling
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBlok = new System.Windows.Forms.TextBox();
            this.textBoxSubBlok = new System.Windows.Forms.TextBox();
            this.textBoxNoKapling = new System.Windows.Forms.TextBox();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel0 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLastScan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panel0.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.Text = "Blok";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.Text = "Sub Blok";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.Text = "No Kapling";
            // 
            // textBoxBlok
            // 
            this.textBoxBlok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxBlok.Location = new System.Drawing.Point(105, 8);
            this.textBoxBlok.MaxLength = 1;
            this.textBoxBlok.Name = "textBoxBlok";
            this.textBoxBlok.Size = new System.Drawing.Size(42, 23);
            this.textBoxBlok.TabIndex = 1;
            this.textBoxBlok.TextChanged += new System.EventHandler(this.textBoxBlok_TextChanged);
            this.textBoxBlok.GotFocus += new System.EventHandler(this.textBoxBlok_GotFocus);
            this.textBoxBlok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBlok_KeyPress);
            this.textBoxBlok.LostFocus += new System.EventHandler(this.textBoxBlok_LostFocus);
            // 
            // textBoxSubBlok
            // 
            this.textBoxSubBlok.Location = new System.Drawing.Point(105, 35);
            this.textBoxSubBlok.MaxLength = 1;
            this.textBoxSubBlok.Name = "textBoxSubBlok";
            this.textBoxSubBlok.Size = new System.Drawing.Size(42, 23);
            this.textBoxSubBlok.TabIndex = 2;
            this.textBoxSubBlok.TextChanged += new System.EventHandler(this.textBoxSubBlok_TextChanged);
            this.textBoxSubBlok.GotFocus += new System.EventHandler(this.textBoxSubBlok_GotFocus);
            this.textBoxSubBlok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSubBlok_KeyPress);
            this.textBoxSubBlok.LostFocus += new System.EventHandler(this.textBoxSubBlok_LostFocus);
            // 
            // textBoxNoKapling
            // 
            this.textBoxNoKapling.Location = new System.Drawing.Point(105, 61);
            this.textBoxNoKapling.MaxLength = 10;
            this.textBoxNoKapling.Name = "textBoxNoKapling";
            this.textBoxNoKapling.Size = new System.Drawing.Size(115, 23);
            this.textBoxNoKapling.TabIndex = 3;
            this.textBoxNoKapling.GotFocus += new System.EventHandler(this.textBoxNoKapling_GotFocus);
            this.textBoxNoKapling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNoKapling_KeyPress);
            this.textBoxNoKapling.LostFocus += new System.EventHandler(this.textBoxNoKapling_LostFocus);
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(105, 31);
            this.textBoxBarcode.MaxLength = 12;
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(115, 23);
            this.textBoxBarcode.TabIndex = 6;
            this.textBoxBarcode.GotFocus += new System.EventHandler(this.textBoxBarcode_GotFocus);
            this.textBoxBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarcode_KeyPress);
            this.textBoxBarcode.LostFocus += new System.EventHandler(this.textBoxBarcode_LostFocus);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.Text = "Barcode";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.LightGray;
            this.buttonNext.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.buttonNext.Location = new System.Drawing.Point(148, 88);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(72, 25);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Lanjut";
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            this.buttonNext.GotFocus += new System.EventHandler(this.buttonNext_GotFocus);
            this.buttonNext.LostFocus += new System.EventHandler(this.buttonNext_LostFocus);
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.LightGray;
            this.buttonNew.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.buttonNew.Location = new System.Drawing.Point(138, 60);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(82, 25);
            this.buttonNew.TabIndex = 7;
            this.buttonNew.Text = "Blok Baru";
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            this.buttonNew.GotFocus += new System.EventHandler(this.buttonNew_GotFocus);
            this.buttonNew.LostFocus += new System.EventHandler(this.buttonNew_LostFocus);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.LightGray;
            this.buttonClose.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.buttonClose.Location = new System.Drawing.Point(148, 218);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(72, 25);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Tutup";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.GotFocus += new System.EventHandler(this.buttonClose_GotFocus);
            this.buttonClose.LostFocus += new System.EventHandler(this.buttonClose_LostFocus);
            // 
            // panel0
            // 
            this.panel0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel0.Controls.Add(this.buttonClear);
            this.panel0.Controls.Add(this.buttonNext);
            this.panel0.Controls.Add(this.textBoxNoKapling);
            this.panel0.Controls.Add(this.textBoxSubBlok);
            this.panel0.Controls.Add(this.textBoxBlok);
            this.panel0.Controls.Add(this.label3);
            this.panel0.Controls.Add(this.label2);
            this.panel0.Controls.Add(this.label1);
            this.panel0.Location = new System.Drawing.Point(0, 1);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(238, 120);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightGray;
            this.buttonClear.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(13, 88);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(72, 25);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Reset";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.buttonClear.GotFocus += new System.EventHandler(this.buttonClear_GotFocus);
            this.buttonClear.LostFocus += new System.EventHandler(this.buttonClear_LostFocus);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonNew);
            this.panel1.Controls.Add(this.labelLastScan);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxBarcode);
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 92);
            // 
            // labelLastScan
            // 
            this.labelLastScan.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelLastScan.Location = new System.Drawing.Point(3, 4);
            this.labelLastScan.Name = "labelLastScan";
            this.labelLastScan.Size = new System.Drawing.Size(232, 24);
            this.labelLastScan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(13, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ganti Kapling";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 249);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(238, 24);
            this.statusBar1.Text = "statusBar1";
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelTotal.Location = new System.Drawing.Point(3, 219);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(139, 25);
            this.labelTotal.Text = "Total";
            // 
            // FormTPK_Kapling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 273);
            this.ControlBox = false;
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormTPK_Kapling";
            this.Text = ".::: Kavling TPK";
            this.Load += new System.EventHandler(this.FormTPK_Kapling_Load);
            this.panel0.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBlok;
        private System.Windows.Forms.TextBox textBoxSubBlok;
        private System.Windows.Forms.TextBox textBoxNoKapling;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelLastScan;
        private System.Windows.Forms.Button button1;
    }
}