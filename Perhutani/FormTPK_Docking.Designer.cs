namespace Perhutani
{
    partial class FormTPK_Docking
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
            this.buttonTerimaTPK = new System.Windows.Forms.Button();
            this.buttonAngkutTPK = new System.Windows.Forms.Button();
            this.buttoKavlingTPK = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // buttonTerimaTPK
            // 
            this.buttonTerimaTPK.BackColor = System.Drawing.Color.Gray;
            this.buttonTerimaTPK.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.buttonTerimaTPK.Location = new System.Drawing.Point(3, 7);
            this.buttonTerimaTPK.Name = "buttonTerimaTPK";
            this.buttonTerimaTPK.Size = new System.Drawing.Size(232, 55);
            this.buttonTerimaTPK.TabIndex = 0;
            this.buttonTerimaTPK.Text = "Terima TPK";
            this.buttonTerimaTPK.Click += new System.EventHandler(this.buttonTerimaTPK_Click);
            this.buttonTerimaTPK.GotFocus += new System.EventHandler(this.buttonTerimaTPK_GotFocus);
            this.buttonTerimaTPK.LostFocus += new System.EventHandler(this.buttonTerimaTPK_LostFocus);
            // 
            // buttonAngkutTPK
            // 
            this.buttonAngkutTPK.BackColor = System.Drawing.Color.Gray;
            this.buttonAngkutTPK.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAngkutTPK.Location = new System.Drawing.Point(3, 125);
            this.buttonAngkutTPK.Name = "buttonAngkutTPK";
            this.buttonAngkutTPK.Size = new System.Drawing.Size(232, 55);
            this.buttonAngkutTPK.TabIndex = 2;
            this.buttonAngkutTPK.Text = "Angkut TPK";
            this.buttonAngkutTPK.Click += new System.EventHandler(this.buttonAngkutTPK_Click);
            this.buttonAngkutTPK.GotFocus += new System.EventHandler(this.buttonAngkutTPK_GotFocus);
            this.buttonAngkutTPK.LostFocus += new System.EventHandler(this.buttonAngkutTPK_LostFocus);
            // 
            // buttoKavlingTPK
            // 
            this.buttoKavlingTPK.BackColor = System.Drawing.Color.Gray;
            this.buttoKavlingTPK.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.buttoKavlingTPK.Location = new System.Drawing.Point(3, 66);
            this.buttoKavlingTPK.Name = "buttoKavlingTPK";
            this.buttoKavlingTPK.Size = new System.Drawing.Size(232, 55);
            this.buttoKavlingTPK.TabIndex = 1;
            this.buttoKavlingTPK.Text = "Kavling TPK";
            this.buttoKavlingTPK.Click += new System.EventHandler(this.buttoKavlingTPK_Click);
            this.buttoKavlingTPK.GotFocus += new System.EventHandler(this.buttoKavlingTPK_GotFocus);
            this.buttoKavlingTPK.LostFocus += new System.EventHandler(this.buttoKavlingTPK_LostFocus);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Gray;
            this.buttonClose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonClose.Location = new System.Drawing.Point(3, 198);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(232, 45);
            this.buttonClose.TabIndex = 3;
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
            // FormTPK_Docking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(238, 273);
            this.ControlBox = false;
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttoKavlingTPK);
            this.Controls.Add(this.buttonAngkutTPK);
            this.Controls.Add(this.buttonTerimaTPK);
            this.Name = "FormTPK_Docking";
            this.Text = ".::: TPK Docking";
            this.Load += new System.EventHandler(this.FormTPK_Docking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTerimaTPK;
        private System.Windows.Forms.Button buttonAngkutTPK;
        private System.Windows.Forms.Button buttoKavlingTPK;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.StatusBar statusBar1;
    }
}