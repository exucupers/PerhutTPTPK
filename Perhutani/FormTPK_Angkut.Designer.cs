namespace Perhutani
{
    partial class FormTPK_Angkut
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
            this.textBoxNoPolisi = new System.Windows.Forms.TextBox();
            this.textBoxNoKavling = new System.Windows.Forms.TextBox();
            this.textBoxTujuanAngkut = new System.Windows.Forms.TextBox();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLastScan = new System.Windows.Forms.Label();
            this.panel0 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel0.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.Text = "NO POLISI";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.Text = "NO KAVLING";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.Text = "TUJUAN ANGKUT";
            // 
            // textBoxNoPolisi
            // 
            this.textBoxNoPolisi.Location = new System.Drawing.Point(129, 20);
            this.textBoxNoPolisi.MaxLength = 9;
            this.textBoxNoPolisi.Name = "textBoxNoPolisi";
            this.textBoxNoPolisi.Size = new System.Drawing.Size(100, 23);
            this.textBoxNoPolisi.TabIndex = 0;
            this.textBoxNoPolisi.GotFocus += new System.EventHandler(this.textBoxNoPolisi_GotFocus);
            this.textBoxNoPolisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNoPolisi_KeyPress);
            this.textBoxNoPolisi.LostFocus += new System.EventHandler(this.textBoxNoPolisi_LostFocus);
            // 
            // textBoxNoKavling
            // 
            this.textBoxNoKavling.Location = new System.Drawing.Point(129, 49);
            this.textBoxNoKavling.MaxLength = 10;
            this.textBoxNoKavling.Name = "textBoxNoKavling";
            this.textBoxNoKavling.Size = new System.Drawing.Size(99, 23);
            this.textBoxNoKavling.TabIndex = 1;
            this.textBoxNoKavling.GotFocus += new System.EventHandler(this.textBoxNoKavling_GotFocus);
            this.textBoxNoKavling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNoKavling_KeyPress);
            this.textBoxNoKavling.LostFocus += new System.EventHandler(this.textBoxNoKavling_LostFocus);
            // 
            // textBoxTujuanAngkut
            // 
            this.textBoxTujuanAngkut.Location = new System.Drawing.Point(129, 77);
            this.textBoxTujuanAngkut.MaxLength = 6;
            this.textBoxTujuanAngkut.Name = "textBoxTujuanAngkut";
            this.textBoxTujuanAngkut.Size = new System.Drawing.Size(99, 23);
            this.textBoxTujuanAngkut.TabIndex = 2;
            this.textBoxTujuanAngkut.GotFocus += new System.EventHandler(this.textBoxTujuanAngkut_GotFocus);
            this.textBoxTujuanAngkut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTujuanAngkut_KeyPress);
            this.textBoxTujuanAngkut.LostFocus += new System.EventHandler(this.textBoxTujuanAngkut_LostFocus);
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(97, 6);
            this.textBoxBarcode.MaxLength = 12;
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(126, 23);
            this.textBoxBarcode.TabIndex = 5;
            this.textBoxBarcode.GotFocus += new System.EventHandler(this.textBoxBarcode_GotFocus);
            this.textBoxBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarcode_KeyPress);
            this.textBoxBarcode.LostFocus += new System.EventHandler(this.textBoxBarcode_LostFocus);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.Text = "BARCODE";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.LightGray;
            this.buttonNext.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.buttonNext.Location = new System.Drawing.Point(137, 106);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(72, 25);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Lanjut";
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            this.buttonNext.GotFocus += new System.EventHandler(this.buttonNext_GotFocus);
            this.buttonNext.LostFocus += new System.EventHandler(this.buttonNext_LostFocus);
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.LightGray;
            this.buttonNew.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.buttonNew.Location = new System.Drawing.Point(137, 35);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(72, 25);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "Baru";
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            this.buttonNew.GotFocus += new System.EventHandler(this.buttonNew_GotFocus);
            this.buttonNew.LostFocus += new System.EventHandler(this.buttonNew_LostFocus);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.LightGray;
            this.buttonClose.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.Location = new System.Drawing.Point(138, 222);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(72, 25);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Tutup";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.GotFocus += new System.EventHandler(this.buttonClose_GotFocus);
            this.buttonClose.LostFocus += new System.EventHandler(this.buttonClose_LostFocus);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelLastScan);
            this.panel1.Controls.Add(this.textBoxBarcode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonNew);
            this.panel1.Location = new System.Drawing.Point(1, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 68);
            // 
            // labelLastScan
            // 
            this.labelLastScan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelLastScan.Location = new System.Drawing.Point(7, 38);
            this.labelLastScan.Name = "labelLastScan";
            this.labelLastScan.Size = new System.Drawing.Size(124, 20);
            // 
            // panel0
            // 
            this.panel0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel0.Controls.Add(this.buttonClear);
            this.panel0.Controls.Add(this.label3);
            this.panel0.Controls.Add(this.label1);
            this.panel0.Controls.Add(this.label2);
            this.panel0.Controls.Add(this.buttonNext);
            this.panel0.Controls.Add(this.textBoxNoPolisi);
            this.panel0.Controls.Add(this.textBoxTujuanAngkut);
            this.panel0.Controls.Add(this.textBoxNoKavling);
            this.panel0.Location = new System.Drawing.Point(1, 0);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(236, 146);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightGray;
            this.buttonClear.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(18, 106);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 25);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Bersihkan";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.buttonClear.GotFocus += new System.EventHandler(this.buttonClear_GotFocus);
            this.buttonClear.LostFocus += new System.EventHandler(this.buttonClear_LostFocus);
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
            this.labelTotal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelTotal.Location = new System.Drawing.Point(3, 222);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(129, 20);
            this.labelTotal.Text = "Total Scan";
            // 
            // FormTPK_Angkut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 273);
            this.ControlBox = false;
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormTPK_Angkut";
            this.Text = ".::: Angkut TPK";
            this.Load += new System.EventHandler(this.FormTPK_Angkut_Load);
            this.panel1.ResumeLayout(false);
            this.panel0.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNoPolisi;
        private System.Windows.Forms.TextBox textBoxNoKavling;
        private System.Windows.Forms.TextBox textBoxTujuanAngkut;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelLastScan;
    }
}