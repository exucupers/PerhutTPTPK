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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        
        ClassUser cUser = new ClassUser();
        ClassConnection cKoneksi = new ClassConnection();
        ClassQuery cQuery = new ClassQuery();

        private void FormMenu_Load(object sender, EventArgs e)
        {
            statusBar1.Text = "User : " + ClassUser.UserID.ToString() + " | Id Hand Held : " + ClassUser.HandheldID;
        }

        private void buttonTP_Click(object sender, EventArgs e)
        {
            FormTP FTP = new FormTP();
            FTP.ShowDialog();
        }

        private void buttonTPK_Click(object sender, EventArgs e)
        {
            FormTPK FTPK = new FormTPK();
            FTPK.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Logout?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.OK == pesan)
            { this.Close(); }
        }

        private void buttonMasterUser_Click(object sender, EventArgs e)
        {
            FormMasterUser FMUser = new FormMasterUser();
            FMUser.ShowDialog();
        }

        private void buttonSetHHID_Click(object sender, EventArgs e)
        {
            if (textBoxHHID.Text == "")
            {
                MessageBox.Show("Input ID handheld", "Informasi");
                return;
            }
            if (textBoxHHID.Text.Length != 3)
            {
                MessageBox.Show("ID handheld antara 000 s/d 999", "Informasi");
                return;
            }
            DialogResult pesan;
            pesan = MessageBox.Show("Anda yakin ingin mengubah ID handheld ini?","Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.Yes == pesan)
            {
                //string strSQL = "Insert Into IDHandHeld Values ('" + textBoxHHID.Text + "',GetDate())";
                string strSQL = "UPDATE IDHandheld set IDHH = '" + textBoxHHID.Text + "', DateChange = Getdate()";
                cQuery.Execute(strSQL);
                ClassUser.HandheldID = textBoxHHID.Text;
                MessageBox.Show("ID handheld berhasil di rubah", "Informasi");
                FormMenu_Load(sender, e);
            }
        }

        private void textBoxHHID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.Handled+"");
            //if (e.KeyChar == )
            //{

            //}
        }

        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (buttonTPK.Focus())
                {
                    buttonTP.Focus();
                }
                if (buttonMasterUser.Focus())
                {
                    buttonTPK.Focus();
                }
                if (textBoxHHID.Focus())
                {
                    buttonMasterUser.Focus();
                }
                if (buttonSetHHID.Focus())
                {
                    textBoxHHID.Focus();
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Keluar Aplikasi ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (DialogResult.Yes == pesan)
            {
                this.Close();
            }
        }

        private void buttonTP_GotFocus(object sender, EventArgs e)
        {
            buttonTP.BackColor = Color.Orange;
        }

        private void buttonTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void buttonTPK_GotFocus(object sender, EventArgs e)
        {
            buttonTPK.BackColor = Color.Orange;
        }

        private void buttonTPK_LostFocus(object sender, EventArgs e)
        {
            buttonTPK.BackColor = Color.Gray;
        }

        private void buttonMasterUser_LostFocus(object sender, EventArgs e)
        {
            buttonMasterUser.BackColor = Color.Gray;
        }

        private void buttonMasterUser_GotFocus(object sender, EventArgs e)
        {
            buttonMasterUser.BackColor = Color.Orange;
        }

        private void textBoxHHID_GotFocus(object sender, EventArgs e)
        {
            textBoxHHID.BackColor = Color.Orange;
        }

        private void textBoxHHID_LostFocus(object sender, EventArgs e)
        {
            textBoxHHID.BackColor = Color.Gray;
        }

        private void buttonSetHHID_LostFocus(object sender, EventArgs e)
        {
            buttonSetHHID.BackColor = Color.Gray;
        }

        private void buttonSetHHID_GotFocus(object sender, EventArgs e)
        {
            buttonSetHHID.BackColor = Color.Orange;
        }

        private void button1_GotFocus(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
        }

        private void button1_LostFocus(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void buttonTP_LostFocus(object sender, EventArgs e)
        {
            buttonTP.BackColor = Color.Gray;
        }
               
    }
}