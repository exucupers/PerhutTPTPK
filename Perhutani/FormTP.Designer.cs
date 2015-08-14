namespace Perhutani
{
    partial class FormTP
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
            this.buttonTerimaTP = new System.Windows.Forms.Button();
            this.buttonAngkutTP = new System.Windows.Forms.Button();
            this.buttonDocking = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // buttonTerimaTP
            // 
            this.buttonTerimaTP.BackColor = System.Drawing.Color.LightGray;
            this.buttonTerimaTP.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.buttonTerimaTP.ForeColor = System.Drawing.Color.Black;
            this.buttonTerimaTP.Location = new System.Drawing.Point(27, 20);
            this.buttonTerimaTP.Name = "buttonTerimaTP";
            this.buttonTerimaTP.Size = new System.Drawing.Size(180, 38);
            this.buttonTerimaTP.TabIndex = 0;
            this.buttonTerimaTP.Text = "1. Terima TP";
            this.buttonTerimaTP.Click += new System.EventHandler(this.buttonTerimaTP_Click);
            this.buttonTerimaTP.GotFocus += new System.EventHandler(this.buttonTerimaTP_GotFocus);
            this.buttonTerimaTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonTerimaTP_KeyPress);
            this.buttonTerimaTP.LostFocus += new System.EventHandler(this.buttonTerimaTP_LostFocus);
            // 
            // buttonAngkutTP
            // 
            this.buttonAngkutTP.BackColor = System.Drawing.Color.LightGray;
            this.buttonAngkutTP.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAngkutTP.ForeColor = System.Drawing.Color.Black;
            this.buttonAngkutTP.Location = new System.Drawing.Point(27, 64);
            this.buttonAngkutTP.Name = "buttonAngkutTP";
            this.buttonAngkutTP.Size = new System.Drawing.Size(180, 37);
            this.buttonAngkutTP.TabIndex = 1;
            this.buttonAngkutTP.Text = "2. Angkut TP";
            this.buttonAngkutTP.Click += new System.EventHandler(this.buttonAngkutTP_Click);
            this.buttonAngkutTP.GotFocus += new System.EventHandler(this.buttonAngkutTP_GotFocus);
            this.buttonAngkutTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonAngkutTP_KeyPress);
            this.buttonAngkutTP.LostFocus += new System.EventHandler(this.buttonAngkutTP_LostFocus);
            // 
            // buttonDocking
            // 
            this.buttonDocking.BackColor = System.Drawing.Color.LightGray;
            this.buttonDocking.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDocking.ForeColor = System.Drawing.Color.Black;
            this.buttonDocking.Location = new System.Drawing.Point(27, 107);
            this.buttonDocking.Name = "buttonDocking";
            this.buttonDocking.Size = new System.Drawing.Size(180, 38);
            this.buttonDocking.TabIndex = 2;
            this.buttonDocking.Text = "3. Docking";
            this.buttonDocking.Click += new System.EventHandler(this.buttonDocking_Click);
            this.buttonDocking.GotFocus += new System.EventHandler(this.buttonDocking_GotFocus);
            this.buttonDocking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonDocking_KeyPress);
            this.buttonDocking.LostFocus += new System.EventHandler(this.buttonDocking_LostFocus);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.LightGray;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(27, 199);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 38);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "4. Keluar";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.GotFocus += new System.EventHandler(this.buttonExit_GotFocus);
            this.buttonExit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonExit_KeyPress);
            this.buttonExit.LostFocus += new System.EventHandler(this.buttonExit_LostFocus);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 249);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(238, 24);
            this.statusBar1.Text = "User | ID Handheld";
            // 
            // FormTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 273);
            this.ControlBox = false;
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDocking);
            this.Controls.Add(this.buttonAngkutTP);
            this.Controls.Add(this.buttonTerimaTP);
            this.Name = "FormTP";
            this.Text = ".:: Menu TP";
            this.Load += new System.EventHandler(this.FormTP_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormTP_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTerimaTP;
        private System.Windows.Forms.Button buttonAngkutTP;
        private System.Windows.Forms.Button buttonDocking;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.StatusBar statusBar1;
    }
}