using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Perhutani
{
    public partial class FormTP : Form
    {
        public FormTP()
        {
            InitializeComponent();
        }

        private void FormTP_Load(object sender, EventArgs e)
        {
            statusBar1.Text = "User : " + ClassUser.UserID.ToString() + " | Id Hand Held : " + ClassUser.HandheldID;
        }

        private void buttonTerimaTP_Click(object sender, EventArgs e)
        {
            FormTP_Terima2a FTTP = new FormTP_Terima2a();
            FTTP.ShowDialog();
        }

        private void buttonAngkutTP_Click(object sender, EventArgs e)
        {
            FormTP_Angkut FATP = new FormTP_Angkut();
            FATP.ShowDialog();
        }

        private void buttonDocking_Click(object sender, EventArgs e)
        {
            //convert TP to csv
            FormTP_Docking FTPD = new FormTP_Docking();
            FTPD.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Logout?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.OK == pesan)
            { this.Close(); }
        }


        private void buttonTerimaTP_GotFocus(object sender, EventArgs e)
        {
            buttonTerimaTP.BackColor = Color.Orange;
        }

        private void buttonTerimaTP_LostFocus(object sender, EventArgs e)
        {
            buttonTerimaTP.BackColor = Color.LightGray;
        }

        private void buttonAngkutTP_GotFocus(object sender, EventArgs e)
        {
            buttonAngkutTP.BackColor = Color.Orange;
        }

        private void buttonAngkutTP_LostFocus(object sender, EventArgs e)
        {
            buttonAngkutTP.BackColor = Color.LightGray;
        }

        private void buttonDocking_GotFocus(object sender, EventArgs e)
        {
            buttonDocking.BackColor = Color.Orange;
        }

        private void buttonDocking_LostFocus(object sender, EventArgs e)
        {
            buttonDocking.BackColor = Color.LightGray;
        }

        private void buttonExit_GotFocus(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.Orange;
        }

        private void buttonExit_LostFocus(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.LightGray;
        }

        private void FormTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void sc(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 49)
            {
                buttonTerimaTP_Click(sender, e);
            }
            else if (e.KeyChar == 50)
            {
                buttonAngkutTP_Click(sender, e);
            }
            else if (e.KeyChar == 51)
            {
                buttonDocking_Click(sender, e);
            }
            else if (e.KeyChar == 52)
            {
                buttonExit_Click(sender, e);
            }
        }

        private void buttonTerimaTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc(sender,e);
        }

        private void buttonAngkutTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc(sender, e);
        }

        private void buttonDocking_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc(sender, e);
        }

        private void buttonExit_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc(sender, e);
        }

    }
}