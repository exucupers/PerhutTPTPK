namespace Perhutani
{
    partial class FormTP_Angkut
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
            this.panelAtas = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxNamaTP = new System.Windows.Forms.TextBox();
            this.textBoxNomorator = new System.Windows.Forms.TextBox();
            this.textBoxNoPolisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.panelBawah = new System.Windows.Forms.Panel();
            this.labelLastScan = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelAtas.SuspendLayout();
            this.panelBawah.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panelAtas.Controls.Add(this.buttonClear);
            this.panelAtas.Controls.Add(this.buttonNext);
            this.panelAtas.Controls.Add(this.textBoxNamaTP);
            this.panelAtas.Controls.Add(this.textBoxNomorator);
            this.panelAtas.Controls.Add(this.textBoxNoPolisi);
            this.panelAtas.Controls.Add(this.label3);
            this.panelAtas.Controls.Add(this.label1);
            this.panelAtas.Controls.Add(this.label2);
            this.panelAtas.Location = new System.Drawing.Point(0, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(238, 140);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightGray;
            this.buttonClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(14, 104);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(72, 25);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Reset";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.buttonClear.GotFocus += new System.EventHandler(this.buttonClear_GotFocus);
            this.buttonClear.LostFocus += new System.EventHandler(this.buttonClear_LostFocus);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.LightGray;
            this.buttonNext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.buttonNext.Location = new System.Drawing.Point(150, 104);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(72, 25);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Lanjut";
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            this.buttonNext.GotFocus += new System.EventHandler(this.buttonNext_GotFocus);
            this.buttonNext.LostFocus += new System.EventHandler(this.buttonNext_LostFocus);
            // 
            // textBoxNamaTP
            // 
            this.textBoxNamaTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxNamaTP.Location = new System.Drawing.Point(123, 73);
            this.textBoxNamaTP.MaxLength = 2;
            this.textBoxNamaTP.Name = "textBoxNamaTP";
            this.textBoxNamaTP.Size = new System.Drawing.Size(36, 23);
            this.textBoxNamaTP.TabIndex = 2;
            this.textBoxNamaTP.GotFocus += new System.EventHandler(this.textBoxNamaTP_GotFocus);
            this.textBoxNamaTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNamaTP_KeyPress);
            this.textBoxNamaTP.LostFocus += new System.EventHandler(this.textBoxNamaTP_LostFocus);
            // 
            // textBoxNomorator
            // 
            this.textBoxNomorator.Location = new System.Drawing.Point(123, 42);
            this.textBoxNomorator.MaxLength = 6;
            this.textBoxNomorator.Name = "textBoxNomorator";
            this.textBoxNomorator.Size = new System.Drawing.Size(65, 23);
            this.textBoxNomorator.TabIndex = 1;
            this.textBoxNomorator.GotFocus += new System.EventHandler(this.textBoxNomorator_GotFocus);
            this.textBoxNomorator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNomorator_KeyPress);
            this.textBoxNomorator.LostFocus += new System.EventHandler(this.textBoxNomorator_LostFocus);
            // 
            // textBoxNoPolisi
            // 
            this.textBoxNoPolisi.Location = new System.Drawing.Point(123, 12);
            this.textBoxNoPolisi.MaxLength = 9;
            this.textBoxNoPolisi.Name = "textBoxNoPolisi";
            this.textBoxNoPolisi.Size = new System.Drawing.Size(84, 23);
            this.textBoxNoPolisi.TabIndex = 0;
            this.textBoxNoPolisi.GotFocus += new System.EventHandler(this.textBoxNoPolisi_GotFocus);
            this.textBoxNoPolisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNoPolisi_KeyPress);
            this.textBoxNoPolisi.LostFocus += new System.EventHandler(this.textBoxNoPolisi_LostFocus);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.Text = "NAMA TP";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.Text = "NO POLISI";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 35);
            this.label2.Text = "NOMORATOR DK 304";
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(123, 8);
            this.textBoxBarcode.MaxLength = 9;
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(99, 23);
            this.textBoxBarcode.TabIndex = 5;
            this.textBoxBarcode.GotFocus += new System.EventHandler(this.textBoxBarcode_GotFocus);
            this.textBoxBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarcode_KeyPress);
            this.textBoxBarcode.LostFocus += new System.EventHandler(this.textBoxBarcode_LostFocus);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(5, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.Text = "SCAN BARCODE";
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.LightGray;
            this.buttonNew.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.buttonNew.Location = new System.Drawing.Point(150, 36);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(72, 25);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "Baru";
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            this.buttonNew.GotFocus += new System.EventHandler(this.buttonNew_GotFocus);
            this.buttonNew.LostFocus += new System.EventHandler(this.buttonNew_LostFocus);
            // 
            // panelBawah
            // 
            this.panelBawah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelBawah.Controls.Add(this.labelLastScan);
            this.panelBawah.Controls.Add(this.label8);
            this.panelBawah.Controls.Add(this.buttonNew);
            this.panelBawah.Controls.Add(this.textBoxBarcode);
            this.panelBawah.Location = new System.Drawing.Point(0, 143);
            this.panelBawah.Name = "panelBawah";
            this.panelBawah.Size = new System.Drawing.Size(238, 67);
            // 
            // labelLastScan
            // 
            this.labelLastScan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelLastScan.Location = new System.Drawing.Point(14, 39);
            this.labelLastScan.Name = "labelLastScan";
            this.labelLastScan.Size = new System.Drawing.Size(123, 20);
            this.labelLastScan.Text = " ";
            this.labelLastScan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.LightGray;
            this.buttonClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.buttonClose.Location = new System.Drawing.Point(150, 218);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(72, 25);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Tutup";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.GotFocus += new System.EventHandler(this.buttonClose_GotFocus);
            this.buttonClose.LostFocus += new System.EventHandler(this.buttonClose_LostFocus);
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
            this.labelTotal.Location = new System.Drawing.Point(3, 221);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(123, 20);
            this.labelTotal.Text = "Total : ";
            // 
            // FormTP_Angkut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(238, 273);
            this.ControlBox = false;
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelBawah);
            this.Controls.Add(this.panelAtas);
            this.Name = "FormTP_Angkut";
            this.Text = ".::: AngkutTP";
            this.Load += new System.EventHandler(this.FormTP_Angkut_Load);
            this.panelAtas.ResumeLayout(false);
            this.panelBawah.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.TextBox textBoxNamaTP;
        private System.Windows.Forms.TextBox textBoxNomorator;
        private System.Windows.Forms.TextBox textBoxNoPolisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Panel panelBawah;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelLastScan;
    }
}