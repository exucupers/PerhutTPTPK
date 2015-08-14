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
    public partial class FormTPK_Angkut : Form
    {
        public FormTPK_Angkut()
        {
            InitializeComponent();
        }

        ClassConnection cKoneksi = new ClassConnection();
        ClassQuery cQuery = new ClassQuery();
        ClassSound cSound = new ClassSound();

        private void kondisi1()
        {
            panel0.Enabled = true;
            panel1.Enabled = false;
            textBoxNoPolisi.Text = "";
            textBoxNoPolisi.Focus();
            textBoxNoKavling.Text = "";
            textBoxTujuanAngkut.Text = "";
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
                string str = "SELECT [scanbarcode] from AngkutTPK where scanbarcode='" + textBoxBarcode.Text + "'";
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
                    string strSQL = "INSERT into AngkutTPK values('" + textBoxNoPolisi.Text + "','" + textBoxNoKavling.Text + "','" + textBoxTujuanAngkut.Text + "','" + textBoxBarcode.Text + "',GetDate())";
                    cQuery.Execute(strSQL);
                    //cSound.suaraOK();
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void FormTPK_Angkut_Load(object sender, EventArgs e)
        {
            labelTotal.Text = cQuery.hitungtotal("AngkutTPK");
            kondisi1();
            statusBar1.Text = "User : " + ClassUser.UserID.ToString() + " | Id Hand Held : " + ClassUser.HandheldID;
        }

        private void textBoxNoPolisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxNoPolisi.Text == "")
                {
                    textBoxNoPolisi.Focus();
                    textBoxNoPolisi.BackColor = Color.Red;
                    return;
                }
                textBoxNoPolisi.BackColor = Color.White;
                textBoxNoKavling.Focus();
            }
        }

        private void textBoxNoKavling_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                textBoxNoPolisi.Focus();
            }
            if (e.KeyChar == 13)
            {
                if (textBoxNoKavling.Text.Length != 9)
                {
                    textBoxNoKavling.Focus();
                    textBoxNoKavling.BackColor = Color.Red;
                    MessageBox.Show("Panjang No Kavling Tidak Sesuai (*9)", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    textBoxNoKavling.Text = "";
                    return;
                }
                if (textBoxNoKavling.Text == "")
                {
                    textBoxNoKavling.Focus();
                    textBoxNoKavling.BackColor = Color.Red;
                    return;
                }
                textBoxNoKavling.BackColor = Color.White;
                textBoxTujuanAngkut.Focus();
            }
        }

        private void textBoxTujuanAngkut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                textBoxNoKavling.Focus();
            }
            if (e.KeyChar == 13)
            {
                if (textBoxTujuanAngkut.Text == "")
                {
                    textBoxTujuanAngkut.Focus();
                    textBoxTujuanAngkut.BackColor = Color.Red;
                    return;
                }
                textBoxTujuanAngkut.BackColor = Color.White;
                buttonNext.Focus();
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBoxNoKavling.Text == "" || textBoxNoPolisi.Text == "" || textBoxTujuanAngkut.Text == "")
            {
                MessageBox.Show("Lengkapi data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
                    textBoxBarcode.Focus();
                    MessageBox.Show("Panjang Barcode Tidak Sesuai", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    textBoxBarcode.BackColor = Color.Red;
                    textBoxBarcode.Text = "";
                    return;
                }
                if (textBoxBarcode.Text == "")
                {
                    textBoxBarcode.Focus();
                    textBoxBarcode.BackColor = Color.Red;
                    return;
                }
                textBoxBarcode.BackColor = Color.White;
                textBoxBarcode.Focus();
                Save();
                labelLastScan.Text = ">> " + textBoxBarcode.Text;
                textBoxBarcode.Text = "";
                textBoxBarcode.Focus();
                labelTotal.Text = cQuery.hitungtotal("AngkutTPK");
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormTPK_Angkut_Load(sender, e);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNoPolisi.Focus();
            textBoxNoPolisi.Text = "";
            textBoxNoKavling.Text = "";
            textBoxTujuanAngkut.Text = "";
        }

        private void textBoxNoPolisi_GotFocus(object sender, EventArgs e)
        {
            textBoxNoPolisi.BackColor = Color.LightGray;
        }

        private void textBoxNoPolisi_LostFocus(object sender, EventArgs e)
        {
            textBoxNoPolisi.BackColor = Color.WhiteSmoke;
        }

        private void textBoxNoKavling_GotFocus(object sender, EventArgs e)
        {
            textBoxNoKavling.BackColor = Color.LightGray;
        }

        private void textBoxNoKavling_LostFocus(object sender, EventArgs e)
        {
            textBoxNoKavling.BackColor = Color.WhiteSmoke;
        }

        private void textBoxTujuanAngkut_GotFocus(object sender, EventArgs e)
        {
            textBoxTujuanAngkut.BackColor = Color.LightGray;
        }

        private void textBoxTujuanAngkut_LostFocus(object sender, EventArgs e)
        {
            textBoxTujuanAngkut.BackColor = Color.WhiteSmoke;
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
     
        
    }
}