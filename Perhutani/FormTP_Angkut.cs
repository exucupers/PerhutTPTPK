using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Media;

namespace Perhutani
{
    public partial class FormTP_Angkut : Form
    {
        public FormTP_Angkut()
        {
            InitializeComponent();
        }

        ClassConnection cKoneksi = new ClassConnection();
        ClassQuery cQuery = new ClassQuery();
        ClassError cError = new ClassError();
        ClassSound cSound = new ClassSound();

        private void kondisi1()
        {
            panelAtas.Enabled = true;
            panelBawah.Enabled = false;
            textBoxNoPolisi.Focus();
            textBoxNoPolisi.Text = "";
            textBoxNamaTP.Text = "";
            textBoxNomorator.Text = "";
        }

        private void kondisi2()
        {
            panelAtas.Enabled = false;
            panelBawah.Enabled = true;
            textBoxBarcode.Focus();
            textBoxBarcode.Text = "";

        }
        
        private void bersih()
        {
            textBoxNamaTP.Text = "";
            textBoxNomorator.Text = "";
            textBoxBarcode.Text = "";
            textBoxNoPolisi.Text = "";
        }

        private void FormTP_Angkut_Load(object sender, EventArgs e)
        {
            labelTotal.Text = cQuery.hitungtotal("AngkutTP");
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
                    MessageBox.Show("Input No Polisi","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Asterisk,MessageBoxDefaultButton.Button1);
                    return;
                }

                textBoxNoPolisi.BackColor = Color.White;
                textBoxNomorator.Focus();
            }
        }

        private void textBoxNomorator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                textBoxNoPolisi.BackColor = Color.White;
                textBoxNoPolisi.Focus();

            }
            else if (e.KeyChar == 13)
            {
                //if (textBoxNomorator.Text.Length != 6)
                //{
                //    textBoxNomorator.Focus();
                //    textBoxNomorator.BackColor = Color.Red;
                //    return;
                //}
                if (textBoxNomorator.Text == "")
                {
                    textBoxNomorator.Focus();
                    textBoxNomorator.BackColor = Color.Red;
                    MessageBox.Show("Input Nomorator", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    return;
                }
                textBoxNomorator.BackColor = Color.White;
                textBoxNamaTP.Focus();
            }
        }

        private void textBoxNamaTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                textBoxNomorator.BackColor = Color.White;
                textBoxNomorator.Focus();
            }
            if (e.KeyChar == 13)
            {
                //if (textBoxNamaTP.Text.Length != 2)
                //{
                //    textBoxNamaTP.Focus();
                //    textBoxNamaTP.BackColor = Color.Red;
                //    return;
                //}
                if (textBoxNamaTP.Text == "")
                {
                    textBoxNamaTP.Focus();
                    textBoxNamaTP.BackColor = Color.Red;
                    MessageBox.Show("Input Nama TP", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    return;
                }
                buttonNext.Focus();
                textBoxNamaTP.BackColor = Color.White;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBoxNamaTP.Text == ""|| textBoxNomorator.Text == ""||textBoxNoPolisi.Text =="")
            {
                MessageBox.Show("Lengkapi data","Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            kondisi2();            
        }

        private void textBoxBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxBarcode.Text=="")
                {
                    textBoxBarcode.Focus();
                    textBoxBarcode.BackColor = Color.Red;
                    return;
                }
                if (textBoxBarcode.Text.Length < 9)
                {
                    textBoxBarcode.Focus();
                    textBoxBarcode.BackColor = Color.Red;
                    MessageBox.Show("Barcode Kurang Dari 9", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    textBoxBarcode.Text = "";
                    textBoxBarcode.Focus();
                    return;
                }

                Simpan();
                labelLastScan.Text = ">> " + textBoxBarcode.Text;
                labelTotal.Text = cQuery.hitungtotal("AngkutTP");
                textBoxBarcode.BackColor = Color.White;
                textBoxBarcode.Text = "";
                textBoxBarcode.Focus();
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            kondisi1();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public void suaraOK()
        //{
        //    SoundPlayer playOK = new SoundPlayer(@"Backup\doorbell.wav");
        //    playOK.Play();
        //}
        //public void suaraError()
        //{
        //    SoundPlayer playError = new SoundPlayer(@"Backup\sirentone.WAV");
        //    playError.Play();
        //}

        public void Simpan()
        {
            //string Tanggal = DateTime.Now.ToString("dd/MM/yyyy");
            //string JamTanggal = DateTime.Now.ToString();
            try
            {
                SqlCeDataReader dr;
                SqlCeCommand cmd = new SqlCeCommand("Select * from AngkutTP where ScanBarcode ='" + textBoxBarcode.Text + "'", cKoneksi.Con);
                if (cKoneksi.Con.State == ConnectionState.Closed) { cKoneksi.Con.Open(); }
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //cSound.suaraError();
                    MessageBox.Show("Duplicate Scan!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    dr.Close();
                    cmd.Dispose();
                    if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
                    textBoxBarcode.Text = "";
                    textBoxBarcode.Focus();
                }
                else
                {
                    dr.Close();
                    cmd.Dispose();
                    string strSQL = "INSERT INTO AngkutTP VALUES('" + textBoxNoPolisi.Text + "','" + textBoxNomorator.Text + "','" + textBoxNamaTP.Text + "','" + textBoxBarcode.Text + "',GetDate())";
                    cQuery.Execute(strSQL);
                    //cSound.suaraOK();
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNamaTP.Text = "";
            textBoxNomorator.Text = "";
            textBoxNoPolisi.Text = "";
            textBoxNoPolisi.Focus();
        }


        private void textBoxNoPolisi_GotFocus(object sender, EventArgs e)
        {
            textBoxNoPolisi.BackColor = Color.LightGray;
        }

        private void textBoxNoPolisi_LostFocus(object sender, EventArgs e)
        {
            textBoxNoPolisi.BackColor = Color.White;
        }

        private void textBoxNomorator_GotFocus(object sender, EventArgs e)
        {
            textBoxNomorator.BackColor = Color.LightGray;
        }

        private void textBoxNomorator_LostFocus(object sender, EventArgs e)
        {
            textBoxNomorator.BackColor = Color.White;
        }

        private void textBoxNamaTP_GotFocus(object sender, EventArgs e)
        {
            textBoxNamaTP.BackColor = Color.LightGray;
        }

        private void textBoxNamaTP_LostFocus(object sender, EventArgs e)
        {
            textBoxNamaTP.BackColor = Color.White;
        }

        private void buttonNext_GotFocus(object sender, EventArgs e)
        {
            buttonNext.BackColor = Color.Orange;
        }

        private void buttonNext_LostFocus(object sender, EventArgs e)
        {
            buttonNext.BackColor = Color.LightGray;
        }

        private void textBoxBarcode_GotFocus(object sender, EventArgs e)
        {
            textBoxBarcode.BackColor = Color.LightGray;
        }

        private void textBoxBarcode_LostFocus(object sender, EventArgs e)
        {
            textBoxBarcode.BackColor = Color.White;
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

        private void buttonClear_GotFocus(object sender, EventArgs e)
        {
            buttonClear.BackColor = Color.Orange;
        }

        private void buttonClear_LostFocus(object sender, EventArgs e)
        {
            buttonClear.BackColor = Color.LightGray;
        }

    }
}