namespace Perhutani
{
    partial class FormMenu
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
            this.buttonTP = new System.Windows.Forms.Button();
            this.buttonTPK = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMasterUser = new System.Windows.Forms.Button();
            this.buttonSetHHID = new System.Windows.Forms.Button();
            this.textBoxHHID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTP
            // 
            this.buttonTP.BackColor = System.Drawing.Color.Gray;
            this.buttonTP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTP.ForeColor = System.Drawing.Color.Black;
            this.buttonTP.Location = new System.Drawing.Point(35, 13);
            this.buttonTP.Name = "buttonTP";
            this.buttonTP.Size = new System.Drawing.Size(167, 35);
            this.buttonTP.TabIndex = 0;
            this.buttonTP.Text = "Menu TP";
            this.buttonTP.Click += new System.EventHandler(this.buttonTP_Click);
            this.buttonTP.GotFocus += new System.EventHandler(this.buttonTP_GotFocus);
            this.buttonTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonTP_KeyPress);
            this.buttonTP.LostFocus += new System.EventHandler(this.buttonTP_LostFocus);
            // 
            // buttonTPK
            // 
            this.buttonTPK.BackColor = System.Drawing.Color.Gray;
            this.buttonTPK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTPK.ForeColor = System.Drawing.Color.Black;
            this.buttonTPK.Location = new System.Drawing.Point(35, 54);
            this.buttonTPK.Name = "buttonTPK";
            this.buttonTPK.Size = new System.Drawing.Size(167, 35);
            this.buttonTPK.TabIndex = 1;
            this.buttonTPK.Text = "Menu TPK";
            this.buttonTPK.Click += new System.EventHandler(this.buttonTPK_Click);
            this.buttonTPK.GotFocus += new System.EventHandler(this.buttonTPK_GotFocus);
            this.buttonTPK.LostFocus += new System.EventHandler(this.buttonTPK_LostFocus);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 256);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(238, 24);
            this.statusBar1.Text = "User";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(44, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.GotFocus += new System.EventHandler(this.button1_GotFocus);
            this.button1.LostFocus += new System.EventHandler(this.button1_LostFocus);
            // 
            // buttonMasterUser
            // 
            this.buttonMasterUser.BackColor = System.Drawing.Color.Gray;
            this.buttonMasterUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.buttonMasterUser.ForeColor = System.Drawing.Color.Black;
            this.buttonMasterUser.Location = new System.Drawing.Point(35, 95);
            this.buttonMasterUser.Name = "buttonMasterUser";
            this.buttonMasterUser.Size = new System.Drawing.Size(167, 30);
            this.buttonMasterUser.TabIndex = 2;
            this.buttonMasterUser.Text = "Master User";
            this.buttonMasterUser.Click += new System.EventHandler(this.buttonMasterUser_Click);
            this.buttonMasterUser.GotFocus += new System.EventHandler(this.buttonMasterUser_GotFocus);
            this.buttonMasterUser.LostFocus += new System.EventHandler(this.buttonMasterUser_LostFocus);
            // 
            // buttonSetHHID
            // 
            this.buttonSetHHID.BackColor = System.Drawing.Color.Gray;
            this.buttonSetHHID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSetHHID.ForeColor = System.Drawing.Color.Black;
            this.buttonSetHHID.Location = new System.Drawing.Point(44, 49);
            this.buttonSetHHID.Name = "buttonSetHHID";
            this.buttonSetHHID.Size = new System.Drawing.Size(77, 24);
            this.buttonSetHHID.TabIndex = 4;
            this.buttonSetHHID.Text = "Set HH ID";
            this.buttonSetHHID.Click += new System.EventHandler(this.buttonSetHHID_Click);
            this.buttonSetHHID.GotFocus += new System.EventHandler(this.buttonSetHHID_GotFocus);
            this.buttonSetHHID.LostFocus += new System.EventHandler(this.buttonSetHHID_LostFocus);
            // 
            // textBoxHHID
            // 
            this.textBoxHHID.Location = new System.Drawing.Point(75, 14);
            this.textBoxHHID.MaxLength = 3;
            this.textBoxHHID.Name = "textBoxHHID";
            this.textBoxHHID.Size = new System.Drawing.Size(57, 23);
            this.textBoxHHID.TabIndex = 3;
            this.textBoxHHID.GotFocus += new System.EventHandler(this.textBoxHHID_GotFocus);
            this.textBoxHHID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHHID_KeyPress);
            this.textBoxHHID.LostFocus += new System.EventHandler(this.textBoxHHID_LostFocus);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxHHID);
            this.panel1.Controls.Add(this.buttonSetHHID);
            this.panel1.Location = new System.Drawing.Point(35, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 116);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.Text = "ID";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(238, 280);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonMasterUser);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.buttonTPK);
            this.Controls.Add(this.buttonTP);
            this.Name = "FormMenu";
            this.Text = ".:: Form Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTP;
        private System.Windows.Forms.Button buttonTPK;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMasterUser;
        private System.Windows.Forms.Button buttonSetHHID;
        private System.Windows.Forms.TextBox textBoxHHID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

