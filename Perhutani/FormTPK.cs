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
    public partial class FormTPK : Form
    {
        public FormTPK()
        {
            InitializeComponent();
        }

        private void FormTP_Load(object sender, EventArgs e)
        {
            statusBar1.Text = "User : " + ClassUser.UserID.ToString() + " | Id Hand Held : " + ClassUser.HandheldID;
        }

        private void buttonTerimaTPK_Click(object sender, EventArgs e)
        {
            FormTPK_Terima FTTPK = new FormTPK_Terima();
            FTTPK.ShowDialog();
        }

        private void buttonKapling_Click(object sender, EventArgs e)
        {
            FormTPK_Kapling FKapling = new FormTPK_Kapling();
            FKapling.ShowDialog();
        }

        private void buttonAngkutTPK_Click(object sender, EventArgs e)
        {
            FormTPK_Angkut FATPK = new FormTPK_Angkut();
            FATPK.ShowDialog();
        }

        private void buttonDocking_Click(object sender, EventArgs e)
        {
            //Convert
            FormTPK_Docking FTPKD = new FormTPK_Docking();
            FTPKD.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Logout?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.OK == pesan)
            { this.Close(); }
        }

        private void buttonTerimaTPK_GotFocus(object sender, EventArgs e)
        {
            buttonTerimaTPK.BackColor = Color.Orange;
        }

        private void buttonTerimaTPK_LostFocus(object sender, EventArgs e)
        {
            buttonTerimaTPK.BackColor = Color.LightGray;
        }

        private void buttonKapling_GotFocus(object sender, EventArgs e)
        {
            buttonKapling.BackColor = Color.Orange;
        }

        private void buttonKapling_LostFocus(object sender, EventArgs e)
        {
            buttonKapling.BackColor = Color.LightGray;
        }

        private void buttonAngkutTPK_GotFocus(object sender, EventArgs e)
        {
            buttonAngkutTPK.BackColor = Color.Orange;
        }

        private void buttonAngkutTPK_LostFocus(object sender, EventArgs e)
        {
            buttonAngkutTPK.BackColor = Color.LightGray;
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
        private void sortcut(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 49)
            {
                buttonTerimaTPK_Click(sender, e);
            }
            else if (e.KeyChar == 50)
            {
                buttonKapling_Click(sender, e);
            }
            else if (e.KeyChar == 51)
            {
                buttonAngkutTPK_Click(sender, e);
            }
            else if (e.KeyChar == 52)
            {
                buttonDocking_Click(sender, e);
            }
            else if (e.KeyChar == 53)
            {
                buttonExit_Click(sender, e);
            }
        }

        private void buttonTerimaTPK_KeyPress(object sender, KeyPressEventArgs e)
        {
            sortcut(sender, e);
        }

        private void buttonKapling_KeyPress(object sender, KeyPressEventArgs e)
        {
            sortcut(sender, e);
        }

        private void buttonAngkutTPK_KeyPress(object sender, KeyPressEventArgs e)
        {
            sortcut(sender, e);
        }

        private void buttonDocking_KeyPress(object sender, KeyPressEventArgs e)
        {
            sortcut(sender, e);
        }

        private void buttonExit_KeyPress(object sender, KeyPressEventArgs e)
        {
            sortcut(sender, e);
        }

        
    }
}