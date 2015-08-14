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
    public partial class FormTP_Terima2b : Form
    {
        string KodeKAB = ClassConnection.KodeKAB;
        string radio1 = ClassConnection.radio1;
        string radio2 = ClassConnection.radio2;
        string KodeBKPH = ClassConnection.KodeBKPH;
        string NoPetak = ClassConnection.NoPetak;
        string JenisKayu = ClassConnection.JenisKayu;
        string KodeTPK = ClassConnection.KodeTPK;
        string UnitKPH = ClassConnection.UnitKPH;

        public FormTP_Terima2b()
        {
            InitializeComponent();
        }

        ClassQuery cQuery = new ClassQuery();
        ClassSound cSound = new ClassSound();
        ClassError cError = new ClassError();
        ClassConnection cKoneksi = new ClassConnection();
       
        private void FormTP_Terima2b_Load(object sender, EventArgs e)
        {
            labelTotal.Text = cQuery.hitungtotal("TerimaTP");
            textBoxBarcode.Focus();
            textBoxBarcode.Text = "";
            textBoxNoPohon.Text = "";
            textBoxNoPotongan.Text = "";
            textBoxPanjang.Text = "";
            textBoxDiameter.Text = "";
            statusBar1.Text = "User : " + ClassUser.UserID.ToString() + " | Id Hand Held : " + ClassUser.HandheldID;
        }

        private void Bersih()
        {
            textBoxBarcode.Text = "";
            textBoxNoPohon.Text = "";
            textBoxNoPotongan.Text = "";
            textBoxPanjang.Text = "";
            textBoxDiameter.Text = "";
        }

        private void textBoxBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxBarcode.Text == "")
                {
                    textBoxBarcode.Focus();
                    textBoxBarcode.BackColor = Color.Red;
                    return;
                }
                if (textBoxBarcode.Text.Length < 9)
                {                    
                    MessageBox.Show("Panjang Barcode Tidak Sesuai.\nDigit Kurang dari 9", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    textBoxBarcode.BackColor = Color.Red;
                    textBoxBarcode.Text = "";
                    textBoxBarcode.Focus();
                    return;
                }
                try
                {
                    SqlCeDataReader dr;
                    SqlCeCommand cmd = new SqlCeCommand("Select * from TerimaTP where ScanBarcode ='" + textBoxBarcode.Text + "'", cKoneksi.Con);
                    if (cKoneksi.Con.State == ConnectionState.Closed) { cKoneksi.Con.Open(); }
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        //cSound.suaraError();
                        MessageBox.Show("Duplicate Scan!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

                        textBoxBarcode.Text = "";
                        textBoxBarcode.Focus();
                    }
                    else
                    {
                        textBoxNoPohon.Focus();
                        textBoxBarcode.BackColor = Color.White;

                    }
                    dr.Close();
                    cmd.Dispose();
                    if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
                }
                catch (SqlCeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void textBoxNoPohon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxNoPohon.Text == "")
                {
                    textBoxNoPohon.Focus();
                    textBoxNoPohon.BackColor = Color.Red;
                    return;
                } 
                textBoxNoPohon.BackColor = Color.White;
                textBoxNoPotongan.Focus();
            }
        }

        private void textBoxNoPotongan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                textBoxNoPohon.Focus();
            }
            if (e.KeyChar == 13)
            {
                if (textBoxNoPotongan.Text == "")
                {
                    textBoxNoPotongan.Focus();
                    textBoxNoPotongan.BackColor = Color.Red;
                    return;
                }
                textBoxPanjang.Focus();
                textBoxPanjang.BackColor = Color.White;
            }
        }
        
        private void textBoxPanjang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                textBoxNoPotongan.Focus();
            }

            if (e.KeyChar == 13)
            {

                if (textBoxPanjang.Text == "")
                {
                    textBoxPanjang.Focus();
                    textBoxPanjang.BackColor = Color.Red;
                    return;
                }
                //decimal d;
                //if (Decimal.TryParse(Convert.ToDecimal(textBoxPanjang), out d))
                //{
                //    //valid 
                //}
                //else
                //{
                //    //invalid
                //    MessageBox.Show("Please enter a valid number");
                //    return;
                //}
                if (textBoxPanjang.Text.Contains(".") && textBoxPanjang.Text.Length > 3)
                {
                    Decimal panjang;
                    try
                    {
                        panjang = Convert.ToDecimal(textBoxPanjang.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Format Panjang Harus Desimal(0.40 - 20.00)M", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        textBoxPanjang.Text = "";
                        return;
                    }
                }
                else
                {
                    textBoxPanjang.Text = "";
                    textBoxPanjang.Focus();
                    MessageBox.Show("Format Panjang Harus Desimal(0.40 - 20.00)M", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }

                if (Convert.ToDouble(textBoxPanjang.Text) < 0.40 || Convert.ToDouble(textBoxPanjang.Text) > 20.00)
                {
                    textBoxPanjang.Text = "";
                    MessageBox.Show("Format Panjang Harus Desimal antara(0.40 - 20.00)M", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }

                textBoxDiameter.Focus();
                textBoxPanjang.BackColor = Color.White;
            }
        }
        private void textBoxDiameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                textBoxPanjang.Focus();
            }

            if (e.KeyChar == 13)
            {
                if (textBoxDiameter.Text == "")
                {
                    textBoxDiameter.Focus();
                    textBoxDiameter.BackColor = Color.Red;
                    return;
                }
                int diameter;
                try
                {
                    diameter = Convert.ToInt16(textBoxDiameter.Text);
                }
                catch
                {
                    textBoxDiameter.Text = "";
                    MessageBox.Show("Format Diameter Tidak Sesuai (4 - 110)cm", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                if (Convert.ToInt16(textBoxDiameter.Text) < 4 || Convert.ToInt16(textBoxDiameter.Text) > 110)
                {
                    textBoxDiameter.Text = "";
                    MessageBox.Show("Diameter Tidak Sesuai (4 - 110)cm", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }

                //SAVE
                textBoxDiameter.BackColor = Color.White;
                buttonSave.Focus();
            }
        }        

        private void buttonClear_Click(object sender, EventArgs e)
        {
            FormTP_Terima2b_Load(sender, e);
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxBarcode.Text == "")
            {
                textBoxBarcode.Focus();
                textBoxBarcode.BackColor = Color.Red;
                return;
            }
            textBoxBarcode.BackColor = Color.White;

            if (textBoxNoPohon.Text == "")
            {
                textBoxNoPohon.Focus();
                textBoxNoPohon.BackColor = Color.Red;
                return;
            }
            textBoxNoPohon.BackColor = Color.White;

            if (textBoxNoPotongan.Text == "")
            {
                textBoxNoPotongan.Focus();
                textBoxNoPotongan.BackColor = Color.Red;
                return;
            }
            textBoxNoPotongan.BackColor = Color.White;

            if (textBoxPanjang.Text == "")
            {
                textBoxPanjang.Focus();
                textBoxPanjang.BackColor = Color.Red;
                return;
            }
            if (textBoxPanjang.Text.Contains(".") && textBoxPanjang.Text.Length > 3)
            {
                Decimal panjang;
                try
                {
                    panjang = Convert.ToDecimal(textBoxPanjang.Text);
                }
                catch
                {
                    MessageBox.Show("Format Panjang Harus Desimal(0.40 - 20.00)M");
                    textBoxPanjang.Text = "";
                    return;
                }
            }
            else
            {
                textBoxPanjang.Text = "";
                textBoxPanjang.Focus();
                MessageBox.Show("Format Panjang Harus Desimal(0.40 - 20.00)M");
                return;
            }

            if (Convert.ToDouble(textBoxPanjang.Text) < 0.40 || Convert.ToDouble(textBoxPanjang.Text) > 20.00)
            {
                textBoxPanjang.Text = "";
                MessageBox.Show("Format Panjang Harus Desimal antara(0.40 - 20.00)M");
                return;
            }
            textBoxPanjang.BackColor = Color.White;

            if (textBoxDiameter.Text == "")
            {
                textBoxDiameter.Focus();
                textBoxDiameter.BackColor = Color.Red;
                return;
            }
            int diameter;
            try
            {
                diameter = Convert.ToInt16(textBoxDiameter.Text);
            }
            catch
            {
                textBoxDiameter.Text = "";
                MessageBox.Show("Format Diameter Tidak Sesuai (4 - 110)cm", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if (Convert.ToInt16(textBoxDiameter.Text) < 4 || Convert.ToInt16(textBoxDiameter.Text) > 110)
            {
                textBoxDiameter.Text = "";
                MessageBox.Show("Diameter Tidak Sesuai (4 - 110)cm", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            textBoxDiameter.BackColor = Color.White;

            Simpan();
            labelLastScan.Text = ">> " + textBoxBarcode.Text;
            labelTotal.Text = cQuery.hitungtotal("TerimaTP");
            buttonClear_Click(sender, e);
        }
        public void Simpan()
        {
            //string Tanggal = DateTime.Now.ToString("");
            //string JamTanggal = DateTime.Now.ToString();
            try
            {
                string strSQL = "INSERT INTO TerimaTP VALUES ('" + KodeKAB + "','" + radio1 + "','" + radio2 + "','" + NoPetak + "','" + JenisKayu + "','" + KodeBKPH + "','" + UnitKPH + "','" + KodeTPK + "','" + textBoxBarcode.Text + "','" + textBoxNoPohon.Text + "','" + textBoxNoPotongan.Text + "','" + textBoxPanjang.Text + "','" + textBoxDiameter.Text + "',GetDate())";
                cQuery.Execute(strSQL);
                //cSound.suaraOK();
                //}
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ClassConnection.Status = "back";
            this.Close();  
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClassConnection.Status = "New";
            this.Close();
        }

        private void textBoxBarcode_GotFocus(object sender, EventArgs e)
        {
            textBoxBarcode.BackColor = Color.LightGray;
        }

        private void textBoxBarcode_LostFocus(object sender, EventArgs e)
        {
            textBoxBarcode.BackColor = Color.WhiteSmoke;
        }

        private void textBoxNoPohon_GotFocus(object sender, EventArgs e)
        {
            textBoxNoPohon.BackColor = Color.LightGray;
        }

        private void textBoxNoPohon_LostFocus(object sender, EventArgs e)
        {
            textBoxNoPohon.BackColor = Color.WhiteSmoke;
        }

        private void textBoxNoPotongan_GotFocus(object sender, EventArgs e)
        {
            textBoxNoPotongan.BackColor = Color.LightGray;
        }

        private void textBoxNoPotongan_LostFocus(object sender, EventArgs e)
        {
            textBoxNoPotongan.BackColor = Color.WhiteSmoke;
        }

        private void textBoxPanjang_GotFocus(object sender, EventArgs e)
        {
            textBoxPanjang.BackColor = Color.LightGray;
        }

        private void textBoxPanjang_LostFocus(object sender, EventArgs e)
        {
            textBoxPanjang.BackColor = Color.WhiteSmoke;
        }

        private void textBoxDiameter_GotFocus(object sender, EventArgs e)
        {
            textBoxDiameter.BackColor = Color.LightGray;
        }

        private void textBoxDiameter_LostFocus(object sender, EventArgs e)
        {
            textBoxDiameter.BackColor = Color.WhiteSmoke;
        }

        private void buttonSave_GotFocus(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.Orange;
        }

        private void buttonSave_LostFocus(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.LightGray;
        }

        private void buttonClear_GotFocus(object sender, EventArgs e)
        {
            buttonClear.BackColor = Color.Orange;
        }

        private void buttonClear_LostFocus(object sender, EventArgs e)
        {
            buttonClear.BackColor = Color.LightGray;
        }

        private void buttonNew_GotFocus(object sender, EventArgs e)
        {
            buttonNew.BackColor = Color.Orange;
        }

        private void buttonNew_LostFocus(object sender, EventArgs e)
        {
            buttonNew.BackColor = Color.LightGray;
        }

        private void buttonBack_GotFocus(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.Orange;
        }

        private void buttonBack_LostFocus(object sender, EventArgs e)
        {
            buttonBack.BackColor = Color.LightGray;
        }
    }
}