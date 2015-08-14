namespace Perhutani
{
    partial class FormTPK
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDocking = new System.Windows.Forms.Button();
            this.buttonAngkutTPK = new System.Windows.Forms.Button();
            this.buttonTerimaTPK = new System.Windows.Forms.Button();
            this.buttonKapling = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.LightGray;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(28, 199);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 38);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "5. Keluar";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.GotFocus += new System.EventHandler(this.buttonExit_GotFocus);
            this.buttonExit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonExit_KeyPress);
            this.buttonExit.LostFocus += new System.EventHandler(this.buttonExit_LostFocus);
            // 
            // buttonDocking
            // 
            this.buttonDocking.BackColor = System.Drawing.Color.LightGray;
            this.buttonDocking.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDocking.ForeColor = System.Drawing.Color.Black;
            this.buttonDocking.Location = new System.Drawing.Point(28, 147);
            this.buttonDocking.Name = "buttonDocking";
            this.buttonDocking.Size = new System.Drawing.Size(180, 38);
            this.buttonDocking.TabIndex = 4;
            this.buttonDocking.Text = "4. Docking";
            this.buttonDocking.Click += new System.EventHandler(this.buttonDocking_Click);
            this.buttonDocking.GotFocus += new System.EventHandler(this.buttonDocking_GotFocus);
            this.buttonDocking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonDocking_KeyPress);
            this.buttonDocking.LostFocus += new System.EventHandler(this.buttonDocking_LostFocus);
            // 
            // buttonAngkutTPK
            // 
            this.buttonAngkutTPK.BackColor = System.Drawing.Color.LightGray;
            this.buttonAngkutTPK.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAngkutTPK.ForeColor = System.Drawing.Color.Black;
            this.buttonAngkutTPK.Location = new System.Drawing.Point(28, 103);
            this.buttonAngkutTPK.Name = "buttonAngkutTPK";
            this.buttonAngkutTPK.Size = new System.Drawing.Size(180, 38);
            this.buttonAngkutTPK.TabIndex = 3;
            this.buttonAngkutTPK.Text = "3. Angkut TPK";
            this.buttonAngkutTPK.Click += new System.EventHandler(this.buttonAngkutTPK_Click);
            this.buttonAngkutTPK.GotFocus += new System.EventHandler(this.buttonAngkutTPK_GotFocus);
            this.buttonAngkutTPK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonAngkutTPK_KeyPress);
            this.buttonAngkutTPK.LostFocus += new System.EventHandler(this.buttonAngkutTPK_LostFocus);
            // 
            // buttonTerimaTPK
            // 
            this.buttonTerimaTPK.BackColor = System.Drawing.Color.LightGray;
            this.buttonTerimaTPK.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.buttonTerimaTPK.ForeColor = System.Drawing.Color.Black;
            this.buttonTerimaTPK.Location = new System.Drawing.Point(28, 15);
            this.buttonTerimaTPK.Name = "buttonTerimaTPK";
            this.buttonTerimaTPK.Size = new System.Drawing.Size(180, 38);
            this.buttonTerimaTPK.TabIndex = 1;
            this.buttonTerimaTPK.Text = "1. Terima TPK";
            this.buttonTerimaTPK.Click += new System.EventHandler(this.buttonTerimaTPK_Click);
            this.buttonTerimaTPK.GotFocus += new System.EventHandler(this.buttonTerimaTPK_GotFocus);
            this.buttonTerimaTPK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonTerimaTPK_KeyPress);
            this.buttonTerimaTPK.LostFocus += new System.EventHandler(this.buttonTerimaTPK_LostFocus);
            // 
            // buttonKapling
            // 
            this.buttonKapling.BackColor = System.Drawing.Color.LightGray;
            this.buttonKapling.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.buttonKapling.ForeColor = System.Drawing.Color.Black;
            this.buttonKapling.Location = new System.Drawing.Point(28, 59);
            this.buttonKapling.Name = "buttonKapling";
            this.buttonKapling.Size = new System.Drawing.Size(180, 38);
            this.buttonKapling.TabIndex = 2;
            this.buttonKapling.Text = "2. Kavling";
            this.buttonKapling.Click += new System.EventHandler(this.buttonKapling_Click);
            this.buttonKapling.GotFocus += new System.EventHandler(this.buttonKapling_GotFocus);
            this.buttonKapling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonKapling_KeyPress);
            this.buttonKapling.LostFocus += new System.EventHandler(this.buttonKapling_LostFocus);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 249);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(238, 24);
            this.statusBar1.Text = "User | ID Handheld";
            // 
            // FormTPK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(238, 273);
            this.ControlBox = false;
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.buttonKapling);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDocking);
            this.Controls.Add(this.buttonAngkutTPK);
            this.Controls.Add(this.buttonTerimaTPK);
            this.Name = "FormTPK";
            this.Text = ".:: Menu TPK";
            this.Load += new System.EventHandler(this.FormTP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDocking;
        private System.Windows.Forms.Button buttonAngkutTPK;
        private System.Windows.Forms.Button buttonTerimaTPK;
        private System.Windows.Forms.Button buttonKapling;
        private System.Windows.Forms.StatusBar statusBar1;
    }
}