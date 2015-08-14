namespace Perhutani
{
    partial class FormTP_Docking
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAngkutTP = new System.Windows.Forms.Button();
            this.buttonTerimaTP = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Gray;
            this.buttonClose.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.Location = new System.Drawing.Point(3, 186);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(232, 45);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Tutup";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            this.buttonClose.GotFocus += new System.EventHandler(this.buttonClose_GotFocus);
            this.buttonClose.LostFocus += new System.EventHandler(this.buttonClose_LostFocus);
            // 
            // buttonAngkutTP
            // 
            this.buttonAngkutTP.BackColor = System.Drawing.Color.Gray;
            this.buttonAngkutTP.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAngkutTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonAngkutTP.Location = new System.Drawing.Point(3, 69);
            this.buttonAngkutTP.Name = "buttonAngkutTP";
            this.buttonAngkutTP.Size = new System.Drawing.Size(232, 60);
            this.buttonAngkutTP.TabIndex = 2;
            this.buttonAngkutTP.Text = "Angkut TP";
            this.buttonAngkutTP.Click += new System.EventHandler(this.buttonAngkutTP_Click);
            this.buttonAngkutTP.GotFocus += new System.EventHandler(this.buttonAngkutTP_GotFocus);
            this.buttonAngkutTP.LostFocus += new System.EventHandler(this.buttonAngkutTP_LostFocus);
            // 
            // buttonTerimaTP
            // 
            this.buttonTerimaTP.BackColor = System.Drawing.Color.Gray;
            this.buttonTerimaTP.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.buttonTerimaTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonTerimaTP.Location = new System.Drawing.Point(3, 3);
            this.buttonTerimaTP.Name = "buttonTerimaTP";
            this.buttonTerimaTP.Size = new System.Drawing.Size(232, 60);
            this.buttonTerimaTP.TabIndex = 1;
            this.buttonTerimaTP.Text = "Terima TP";
            this.buttonTerimaTP.Click += new System.EventHandler(this.buttonTerimaTP_Click);
            this.buttonTerimaTP.GotFocus += new System.EventHandler(this.buttonTerimaTP_GotFocus);
            this.buttonTerimaTP.LostFocus += new System.EventHandler(this.buttonTerimaTP_LostFocus);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 249);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(238, 24);
            this.statusBar1.Text = "statusBar1";
            // 
            // FormTP_Docking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(238, 273);
            this.ControlBox = false;
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAngkutTP);
            this.Controls.Add(this.buttonTerimaTP);
            this.Name = "FormTP_Docking";
            this.Text = ".::: TP Docking";
            this.Load += new System.EventHandler(this.FormTP_Docking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAngkutTP;
        private System.Windows.Forms.Button buttonTerimaTP;
        private System.Windows.Forms.StatusBar statusBar1;
    }
}