using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace Perhutani
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        ClassConnection cKoneksi = new ClassConnection();
        ClassSound cSound = new ClassSound();
        string UserID = "";
        string TP = "";
        string TPK = "";
        string IDHH = "";

        private void cekrole()
        {
            if (TP == "True" && TPK == "False")
            {
                MessageBox.Show("Welcome " + textBoxuserid.Text + "", "TP",MessageBoxButtons.OK, MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
                textBoxuserid.Text = "";
                textBoxPassword.Text = "";
                FormTP FTP = new FormTP();
                FTP.ShowDialog();
            }
            else if (TP == "False" && TPK == "True") 
            {
                MessageBox.Show("Welcome " + textBoxuserid.Text + "", "TPK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                textBoxuserid.Text = "";
                textBoxPassword.Text = "";
                FormTPK FTPK = new FormTPK();
                FTPK.ShowDialog();
            }
            else if (TP == "True" && TPK == "True")
            {
                MessageBox.Show("Welcome " + textBoxuserid.Text + "", "Super User", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                textBoxuserid.Text = "";
                textBoxPassword.Text = ""; 
                FormMenu FMenu = new FormMenu();
                FMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Anda Tidak Mempunyai Hak Akses Ke Menu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                textBoxuserid.Text = "";
                textBoxPassword.Text = "";
            }
        }
        public void Login()
        {
            try
            {
                SqlCeDataReader dr;
                string sql = "SELECT * From Users cross join idhandheld where userid='" + textBoxuserid.Text + "' and password ='" + textBoxPassword.Text + "'";
                SqlCeCommand cmd = new SqlCeCommand(sql,cKoneksi.Con);
                if (cKoneksi.Con.State == ConnectionState.Closed) { cKoneksi.Con.Open(); }
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    UserID = dr["Userid"].ToString();
                    IDHH = dr["IDHH"].ToString();
                    ClassUser.UserID = UserID.Trim();
                    ClassUser.HandheldID = IDHH.Trim();
                    TP = dr["TP"].ToString();
                    TPK = dr["TPK"].ToString();
                    dr.Close();
                    cmd.Dispose();
                    if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
                    cekrole();
                }
                else
                {
                    if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
                    dr.Close();
                    cmd.Dispose();
                    MessageBox.Show("Username / Password Salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                    textBoxuserid.Text = "";
                    textBoxuserid.Focus();
                    textBoxPassword.Text = "";
                }
                textBoxuserid.Text = "";
                textBoxuserid.Focus();
                textBoxPassword.Text = "";
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxuserid.Text = "";
            textBoxuserid.Focus();
            textBoxPassword.Text = "";
        }

        private void textBoxuserid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxuserid.Text == "")
                {
                    textBoxuserid.Focus();
                    textBoxuserid.BackColor = Color.Red;
                    return;
                }
                textBoxuserid.BackColor = Color.White;
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxPassword.Text == "")
                {
                    textBoxPassword.Focus();
                    textBoxPassword.BackColor = Color.Red;
                    return;
                }
                textBoxPassword.BackColor = Color.White;
                buttonLogin_Click(sender,e);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxuserid.Text == "" && textBoxPassword.Text == "")
            {
                textBoxuserid.BackColor = Color.Red;
                textBoxPassword.BackColor = Color.Red;
                textBoxuserid.Focus();
                return;
            }            
            
            if (textBoxuserid.Text == "")
            {
                textBoxuserid.Focus();
                textBoxuserid.BackColor = Color.LightGray;
                return;
            }
            textBoxuserid.BackColor = Color.White;

            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Focus();
                textBoxPassword.BackColor = Color.LightGray;
                return;
            }

            textBoxPassword.BackColor = Color.White;
            
            Login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Keluar Aplikasi ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (DialogResult.Yes == pesan)
            {
                //Application.Exit();
                this.Close(); 
            }
        }

        private void textBoxuserid_GotFocus(object sender, EventArgs e)
        {
            textBoxuserid.BackColor = Color.LightGray;
        }

        private void textBoxuserid_LostFocus(object sender, EventArgs e)
        {
            textBoxuserid.BackColor = Color.White;
        }

        private void textBoxPassword_GotFocus(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.LightGray;
        }

        private void textBoxPassword_LostFocus(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
        }

        private void buttonLogin_GotFocus(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.Orange;
        }

        private void buttonLogin_LostFocus(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.Gray;
        }
        
        private void button2_GotFocus(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange;
        }

        private void button2_LostFocus(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gray;
        }        

    }
}