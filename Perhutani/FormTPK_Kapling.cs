using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Perhutani
{
    public partial class FormTPK_Kapling : Form
    {
        public FormTPK_Kapling()
        {
            InitializeComponent();
        }

        ClassConnection cKoneksi = new ClassConnection();
        ClassQuery cQuery = new ClassQuery();
        ClassError cError = new ClassError();
        ClassSound cSound = new ClassSound();

        private void kondisi1()
        {
            panel0.Enabled = true;
            panel1.Enabled = false;
            textBoxBlok.Text = "";
            textBoxBlok.Focus();
            textBoxSubBlok.Text = "";
            textBoxNoKapling.Text = "";
            textBoxBarcode.Text = "";
        }

        private void kondisi2()
        {
            panel0.Enabled = false;
            panel1.Enabled = true;
            textBoxBarcode.Text = "";
            textBoxBarcode.Focus();
        }

        private void Save()
        {
            try
            {
                SqlCeDataReader dr;
                string str = "SELECT [scanbarcode] from Kavling where scanbarcode='" + textBoxBarcode.Text + "'";
                SqlCeCommand cmd = new SqlCeCommand(str, cKoneksi.Con);
                if (cKoneksi.Con.State == ConnectionState.Closed) { cKoneksi.Con.Open(); }
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
                    dr.Close();
                    cmd.Dispose();
                    //cSound.suaraError();
                    MessageBox.Show("Duplicate Scan!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    
                }
                else
                {
                    dr.Close();
                    cmd.Dispose();
                    string strSQL = "INSERT into Kavling Values('" + textBoxBlok.Text + "','" + textBoxSubBlok.Text + "','" + textBoxNoKapling.Text + "','" + textBoxBarcode.Text + "',getdate())";
                    cQuery.Execute(strSQL);
                    //cSound.suaraOK();
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            }
        }

        private void FormTPK_Kapling_Load(object sender, EventArgs e)
        {
            labelTotal.Text = cQuery.hitungtotal("Kavling");
            statusBar1.Text = "User : " + ClassUser.UserID.ToString() + " | Id Hand Held : " + ClassUser.HandheldID; 
            kondisi1();
        }

        private void textBoxBlok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxBlok.Text.Length != 5)
                {

                }
                if (textBoxBlok.Text == "")
                {
                    textBoxBlok.BackColor = Color.Red;
                    textBoxBlok.Focus();
                    return;
                }
                try
                {
                    Convert.ToInt16(textBoxBlok.Text);
                    textBoxBlok.Text = "";
                    textBoxBlok.Focus();
                    MessageBox.Show("Inputan Blok Hanya boleh huruf.", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    return;
                }
                catch
                {
                    textBoxSubBlok.Focus();
                }
                textBoxBlok.BackColor = Color.White;
                textBoxSubBlok.Focus();
            }
        }

        private void textBoxSubBlok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                textBoxBlok.Focus();
            }
            if (e.KeyChar == 13)
            {
                if (textBoxSubBlok.Text == "")
                {
                    textBoxSubBlok.BackColor = Color.Red;
                    textBoxSubBlok.Focus();
                    return;
                }
                try
                {
                    Convert.ToInt16(textBoxSubBlok.Text);
                }   
                catch
                {
                    textBoxSubBlok.Text = "";
                    textBoxSubBlok.Focus();
                    MessageBox.Show("Sub-Blok Hanya boleh angka","Perhatian",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
                    return;
                }
                textBoxSubBlok.BackColor = Color.White;
                textBoxNoKapling.Focus();
            }
        }

        private void textBoxNoKapling_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                textBoxSubBlok.Focus();
            }
            if (e.KeyChar == 13)
            {
                if (textBoxNoKapling.Text.Length != 9)
                {
                    MessageBox.Show("Panjang No Kapling Tidak Sesuai (*9)", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    textBoxNoKapling.BackColor = Color.Red;
                    textBoxNoKapling.Focus();
                    textBoxNoKapling.Text = "";
                    return;
                }
                if (textBoxNoKapling.Text == "")
                {
                    textBoxNoKapling.BackColor = Color.Red;
                    textBoxNoKapling.Focus();
                    return;
                }
                textBoxNoKapling.BackColor = Color.White;
                buttonNext.Focus();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBoxBlok.Text == "" || textBoxSubBlok.Text == "" || textBoxNoKapling.Text == "")
            {
                MessageBox.Show("Lengkapi data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            if (textBoxNoKapling.Text.Length > 9)
            {
                MessageBox.Show("Panjang No Kapling Maximal 9 Digit.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            kondisi2();
        }

        private void textBoxBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxBarcode.Text.Length != 9)
                {
                    textBoxBarcode.BackColor = Color.Red;
                    textBoxBarcode.Focus();
                    textBoxBarcode.Text = "";
                    MessageBox.Show("Panjang Barcode Tidak Sesuai", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (textBoxBarcode.Text == "")
                {
                    textBoxBarcode.BackColor = Color.Red;
                    textBoxBarcode.Focus();
                    return;
                }
                textBoxBarcode.BackColor = Color.White;
                textBoxBarcode.Focus();
                Save();
                labelLastScan.Text = ">> " +textBoxBarcode.Text;
                textBoxBarcode.Text = "";
                textBoxBarcode.Focus();
                labelTotal.Text = cQuery.hitungtotal("Kavling");
            }
        }
        
        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormTPK_Kapling_Load(sender, e);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxBlok.Text = "";
            textBoxBlok.Focus();
            textBoxSubBlok.Text = "";
            textBoxNoKapling.Text = "";
        }

        private void textBoxBlok_GotFocus(object sender, EventArgs e)
        {
            textBoxBlok.BackColor = Color.LightGray;
        }

        private void textBoxBlok_LostFocus(object sender, EventArgs e)
        {
            textBoxBlok.BackColor = Color.WhiteSmoke;
        }

        private void textBoxSubBlok_GotFocus(object sender, EventArgs e)
        {
            textBoxSubBlok.BackColor = Color.LightGray;
        }

        private void textBoxSubBlok_LostFocus(object sender, EventArgs e)
        {
            textBoxSubBlok.BackColor = Color.WhiteSmoke;
        }

        private void textBoxNoKapling_GotFocus(object sender, EventArgs e)
        {
            textBoxNoKapling.BackColor = Color.LightGray;
        }

        private void textBoxNoKapling_LostFocus(object sender, EventArgs e)
        {
            textBoxNoKapling.BackColor = Color.WhiteSmoke;
        }

        private void buttonNext_GotFocus(object sender, EventArgs e)
        {
            buttonNext.BackColor = Color.Orange;
        }

        private void buttonNext_LostFocus(object sender, EventArgs e)
        {
            buttonNext.BackColor = Color.LightGray;
        }

        private void buttonClear_GotFocus(object sender, EventArgs e)
        {
            buttonClear.BackColor = Color.Orange;
        }

        private void buttonClear_LostFocus(object sender, EventArgs e)
        {
            buttonClear.BackColor = Color.LightGray;
        }

        private void textBoxBarcode_GotFocus(object sender, EventArgs e)
        {
            textBoxBarcode.BackColor = Color.LightGray;
        }

        private void textBoxBarcode_LostFocus(object sender, EventArgs e)
        {
            textBoxBarcode.BackColor = Color.WhiteSmoke;
        }

        private void buttonNew_GotFocus(object sender, EventArgs e)
        {
            buttonNew.BackColor = Color.Orange;
        }

        private void buttonNew_LostFocus(object sender, EventArgs e)
        {
            buttonNew.BackColor = Color.LightGray;
        }

        private void buttonClose_GotFocus(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Orange;
        }

        private void buttonClose_LostFocus(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.LightGray;
        }

        private void textBoxBlok_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBlok.Text != "")
            {
                try
                {
                    Convert.ToInt16(textBoxBlok.Text);
                    textBoxBlok.Text = "";
                    textBoxBlok.Focus();
                    MessageBox.Show("Inputan Blok Hanya boleh huruf.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    return;
                }
                catch   
                {
                    //textBoxSubBlok.Focus();
                }
            }
        }

        private void textBoxSubBlok_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSubBlok.Text != "")
            {
                try
                {
                    Convert.ToInt16(textBoxSubBlok.Text);
                }
                catch
                {
                    textBoxSubBlok.Text = "";
                    textBoxSubBlok.Focus();
                    MessageBox.Show("Sub-Blok Hanya boleh angka", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel0.Enabled = true;
            panel1.Enabled = false;
            textBoxNoKapling.Text = "";
            textBoxNoKapling.Focus();
            textBoxBarcode.Text = ""; 
        }
    }
}