using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlServerCe;

namespace Perhutani
{
    public partial class FormTP_Terima : Form
    {
        public FormTP_Terima()
        {
            InitializeComponent();
        }

        ClassQuery cQuery = new ClassQuery();
        ClassError cError = new ClassError();
        ClassConnection cKoneksi = new ClassConnection();
        ClassSound cSound = new ClassSound();

        string radio1 = "";
        string radio2 = "";

        private void kondisi1()
        {
            panel1.Enabled = true;
            panel2.Enabled = false;
            panelKDSertifikat.BackColor = Color.Gold;
            panelJenisTebangan.BackColor = Color.Gold;
            textBoxKodeKAB.Focus();
            textBoxKodeKAB.Text = "";
            textBoxNoPetak.Text = "";
            textBoxJenisKayu.Text = "";
            textBoxKodeBKPH.Text = "";
            textBoxUnitKPH.Text = "";
            textBoxKodeTPK.Text = "";

        }

        private void kondisi2()
        {
            panel1.Enabled = false;
            panel2.Enabled = true;
            textBoxBarcode.Focus();
            textBoxBarcode.Text = "";
            textBoxNoPohon.Text = "";
            textBoxNoPotongan.Text = "";
            textBoxPanjang.Text = "";
            textBoxDiameter.Text = "";
        }

        private void Bersih()
        {
            radio1 = "";
            radio2 = "";
            textBoxKodeKAB.Text = "";
            radioButton1_FSC.Checked = false;
            radioButton1A.Checked = false;
            radioButton2_PH.Checked = false;
            radioButton2B.Checked = false;
            radioButton3_CW.Checked = false;
            radioButton3C.Checked = false;
            radioButton4_SVLK.Checked = false;
            radioButton4D.Checked = false;
            radioButton5E.Checked = false;
            radioButton6KAM.Checked = false;
            textBoxNoPetak.Text = "";
            textBoxJenisKayu.Text = "";
            textBoxKodeBKPH.Text = "";
            textBoxUnitKPH.Text = "";
            textBoxKodeTPK.Text = "";
            textBoxBarcode.Text = "";
            textBoxNoPohon.Text = "";
            textBoxNoPotongan.Text = "";
            textBoxPanjang.Text = "";
            textBoxDiameter.Text = "";
        }
        private void FormTP_Terima_Load(object sender, EventArgs e)
        {
            kondisi1();
            statusBar1.Text = "User : " + ClassUser.UserID.ToString() + " | Id Hand Held : " + ClassUser.HandheldID;
        }

        private void textBoxKodeKAB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                if (textBoxKodeKAB.Text == "" || textBoxKodeKAB.Text.Length < 3)
                {
                    textBoxKodeKAB.Focus();
                    return;
                }
                panelKDSertifikat.Focus();
            }
        }
        private void CekRB1()
        {
            if (radioButton1_FSC.Checked) { radio1 = "1"; panelKDSertifikat.BackColor = Color.Gold; }
            else if (radioButton2_PH.Checked) { radio1 = "2"; panelKDSertifikat.BackColor = Color.Gold; }
            else if (radioButton3_CW.Checked) { radio1 = "3"; panelKDSertifikat.BackColor = Color.Gold; }
            else if (radioButton4_SVLK.Checked) { radio1 = "4"; panelKDSertifikat.BackColor = Color.Gold; }
            //else            //{
            //    MessageBox.Show("Harap Pilih Jenis Kode Sertfikat");
            //    //radioButton1_FSC.Focus(); //    return;     //}

        }

        private void CekRB2()
        {
            if (radioButton1A.Checked) { radio2 = "1"; panelJenisTebangan.BackColor = Color.Gold; }
            else if (radioButton2B.Checked) { radio2 = "2"; panelJenisTebangan.BackColor = Color.Gold; }
            else if (radioButton3C.Checked) { radio2 = "3"; panelJenisTebangan.BackColor = Color.Gold; }
            else if (radioButton4D.Checked) { radio2 = "4"; panelJenisTebangan.BackColor = Color.Gold; }
            else if (radioButton5E.Checked) { radio2 = "5"; panelJenisTebangan.BackColor = Color.Gold; }
            else if (radioButton6KAM.Checked) { radio2 = "6"; panelJenisTebangan.BackColor = Color.Gold; }
            //else            //{
            //    MessageBox.Show("Harap Pilih Jenis Tebangan");
            //    //radioButton1A.Focus();  //    return;   //}
        }

        private void textBoxNoPetak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CekRB1();
                CekRB2();
                if (textBoxKodeKAB.Text == "")
                {
                    MessageBox.Show("Lengkapi data");
                    return;
                }
                else if (radio1 == "" && radio2 == "")
                {
                    panelKDSertifikat.BackColor = Color.Red;
                    panelJenisTebangan.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Kode Sertifikat & Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    return;
                }
                else if (radio1 == "")
                {
                    panelKDSertifikat.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Kode Sertifikat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    //panelKDSertifikat.Focus();
                    return;
                }
                else if (radio2 == "")
                {
                    panelJenisTebangan.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    //panelJenisTebangan.Focus();
                    return;
                }
                if (textBoxNoPetak.Text=="")
                {
                    textBoxNoPetak.Focus();
                    return;
                }
                textBoxJenisKayu.Focus();
            }
        }
       

        private void textBoxJenisKayu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CekRB1();
                CekRB2();
                if (textBoxKodeKAB.Text == "")
                {
                    MessageBox.Show("Lengkapi data");
                    return;
                }
                else if (radio1 == "" && radio2 == "")
                {
                    panelKDSertifikat.BackColor = Color.Red;
                    panelJenisTebangan.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Kode Sertifikat & Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    return;
                }
                else if (radio1 == "")
                {
                    panelKDSertifikat.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Kode Sertifikat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    panelKDSertifikat.Focus();
                    return;
                }
                else if (radio2 == "")
                {
                    panelJenisTebangan.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    panelJenisTebangan.Focus();
                    return;
                }
                if (textBoxJenisKayu.Text=="")
                {
                    textBoxJenisKayu.Focus();
                    return;
                }
                textBoxKodeBKPH.Focus();
            }
        }

        private void textBoxKodeBKPH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CekRB1();
                CekRB2();
                if (textBoxKodeKAB.Text == "")
                {
                    MessageBox.Show("Lengkapi data");
                    return;
                }
                else if (radio1 == "" && radio2 == "")
                {
                    panelKDSertifikat.BackColor = Color.Red;
                    panelJenisTebangan.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Kode Sertifikat & Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    return;
                }
                else if (radio1 == "")
                {
                    panelKDSertifikat.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Kode Sertifikat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    panelKDSertifikat.Focus();
                    return;
                }
                else if (radio2 == "")
                {
                    panelJenisTebangan.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    panelJenisTebangan.Focus();
                    return;
                }
                if (textBoxKodeBKPH.Text=="")
                {
                    textBoxKodeBKPH.Focus();
                    return;
                }
                textBoxUnitKPH.Focus();
            }
        }

        private void textBoxUnitKPH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CekRB1();
                CekRB2();
                if (textBoxKodeKAB.Text == "")
                {
                    MessageBox.Show("Lengkapi data");
                    return;
                }
                else if (radio1 == "" && radio2 == "")
                {
                    panelKDSertifikat.BackColor = Color.Red;
                    panelJenisTebangan.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Kode Sertifikat & Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    return;
                }
                else if (radio1 == "")
                {
                    panelKDSertifikat.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Kode Sertifikat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    panelKDSertifikat.Focus();
                    return;
                }
                else if (radio2 == "")
                {
                    panelJenisTebangan.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    panelJenisTebangan.Focus();
                    return;
                }
                if (textBoxUnitKPH.Text=="")
                {
                    textBoxUnitKPH.Focus();
                    return;
                }
                textBoxKodeTPK.Focus();
            }
        }

        private void textBoxKodeTPK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CekRB1();
                CekRB2();
                if (textBoxKodeKAB.Text == "")
                {
                    MessageBox.Show("Lengkapi data");
                    return;
                }
                else if (radio1 == "" && radio2 == "")
                {
                    panelKDSertifikat.BackColor = Color.Red;
                    panelJenisTebangan.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Kode Sertifikat & Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    return;
                }
                else if (radio1 == "")
                {
                    panelKDSertifikat.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Kode Sertifikat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    panelKDSertifikat.Focus();
                    return;
                }
                else if (radio2 == "")
                {
                    panelJenisTebangan.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    panelJenisTebangan.Focus();
                    return;
                }
                if (textBoxKodeTPK.Text=="")
                {
                    textBoxKodeTPK.Focus();
                    return;
                }
                buttonNext.Focus();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            CekRB1();
            CekRB2();
            if (textBoxKodeKAB.Text == "")
            {
                MessageBox.Show("Lengkapi data");
                return;
            }
            else if (radio1 == "" && radio2 == "")
            {
                panelKDSertifikat.BackColor = Color.Red;
                panelJenisTebangan.BackColor = Color.Red;   
                MessageBox.Show("Harap Pilih Kode Sertifikat & Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);                  
                return;
            }
            else if (radio1 == "")
            {
                panelKDSertifikat.BackColor = Color.Red;
                MessageBox.Show("Harap Pilih Kode Sertifikat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                panelKDSertifikat.Focus();
                return;
            }
            else if (radio2 == "")
            {
                panelJenisTebangan.BackColor = Color.Red;
                MessageBox.Show("Harap Pilih Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                panelJenisTebangan.Focus();
                return;
            }
            else if (textBoxNoPetak.Text == "" || textBoxJenisKayu.Text == "" )
            {
                MessageBox.Show("Lengkapi data");
                return;
            }
            else if (textBoxKodeBKPH.Text == "" || textBoxUnitKPH.Text == "" || textBoxKodeTPK.Text == "")
            {
                MessageBox.Show("Lengkapi data");
                return;
            }
            kondisi2();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Bersih();
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
                        dr.Close();
                        cmd.Dispose();
                        if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
                        textBoxBarcode.Text = "";
                        textBoxBarcode.Focus();
                    }
                }
                catch (SqlCeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                textBoxNoPohon.Focus();
                textBoxBarcode.BackColor = Color.White;
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
                textBoxNoPotongan.Focus();
                textBoxNoPohon.BackColor = Color.White;
            }
        }

        private void textBoxNoPotongan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxNoPotongan.Text == "")
                {
                    textBoxNoPotongan.Focus();
                    textBoxNoPotongan.BackColor = Color.Red;
                    return;
                }
                textBoxPanjang.Focus();
                textBoxNoPotongan.BackColor = Color.White;
            }
        }

        private void textBoxPanjang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxPanjang.Text == "")
                {
                    textBoxPanjang.Focus();
                    textBoxPanjang.BackColor = Color.Red;
                    return;
                }
                textBoxDiameter.Focus();
                textBoxPanjang.BackColor = Color.White;
            }
        }

        private void textBoxDiameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxDiameter.Text == "")
                {
                    textBoxDiameter.Focus();
                    textBoxDiameter.BackColor = Color.Red;
                    return;
                }
                //SAVE
                textBoxDiameter.BackColor = Color.White;
                buttonSave.Focus();
            }
        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {
            textBoxBarcode.Focus();
            textBoxBarcode.Text = "";
            textBoxNoPohon.Text = "";
            textBoxNoPotongan.Text = "";
            textBoxPanjang.Text = "";
            textBoxDiameter.Text = "";
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {            
            kondisi1();
            Bersih();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            textBoxPanjang.BackColor = Color.White;

            if (textBoxDiameter.Text == "")
            {
                textBoxDiameter.Focus();
                textBoxDiameter.BackColor = Color.Red;
                return;
            }
            textBoxDiameter.BackColor = Color.White;

            Simpan();
            buttonClear2_Click(sender, e);
        }

        public void Simpan()
        {
            //string Tanggal = DateTime.Now.ToString("");
            //string JamTanggal = DateTime.Now.ToString();
            try
            {
                //SqlCeDataReader dr;
                //SqlCeCommand cmd = new SqlCeCommand("Select * from TerimaTP where ScanBarcode ='" + textBoxBarcode.Text + "'", cKoneksi.Con);
                //if (cKoneksi.Con.State == ConnectionState.Closed) { cKoneksi.Con.Open(); }
                //dr = cmd.ExecuteReader();
                //if (dr.Read())
                //{
                //    cSound.suaraError();
                //    MessageBox.Show("Duplicate Scan!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                //    dr.Close();
                //    cmd.Dispose();
                //    if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
                //    textBoxBarcode.Text = "";
                //    textBoxBarcode.Focus();
                //}
                //else
                //{
                //    dr.Close();
                //    cmd.Dispose();
                string strSQL = "INSERT INTO TerimaTP VALUES ('" + textBoxKodeKAB.Text + "','" + radio1 + "','" + radio2 + "','" + textBoxNoPetak.Text + "','" + textBoxJenisKayu.Text + "','" + textBoxKodeBKPH.Text + "','" + textBoxUnitKPH.Text + "','" + textBoxKodeTPK.Text + "','" + textBoxBarcode.Text + "','" + textBoxNoPohon.Text + "','" + textBoxNoPotongan.Text + "','" + textBoxPanjang.Text + "','" + textBoxDiameter.Text + "',GetDate())";
                cQuery.Execute(strSQL);
                //cSound.suaraOK();
                //}
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void radioButton1_FSC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                radioButton1A.Focus();
            }
        }

        private void radioButton2_PH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                radioButton1A.Focus();
            }
        }

        private void radioButton3_CW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                radioButton1A.Focus();
            }
        }

        private void radioButton4_SVLK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                radioButton1A.Focus();
            }
        }

        private void radioButton1A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxNoPetak.Focus();
            }
        }

        private void radioButton2B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxNoPetak.Focus();
            }
        }

        private void radioButton3C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxNoPetak.Focus();
            }
        }

        private void radioButton4D_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxNoPetak.Focus();
            }
        }

        private void radioButton5E_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxNoPetak.Focus();
            }
        }

        private void radioButton6KAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBoxNoPetak.Focus();
            }
        }

        private void FormTP_Terima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ////Back 1
                //if (radioButton1_FSC.Focus()) { textBoxKodeKAB.Focus(); return; }
                //else if (radioButton2_PH.Focus()) { textBoxKodeKAB.Focus(); return; }
                //else if (radioButton3_CW.Focus()) { textBoxKodeKAB.Focus(); return; }
                //else if (radioButton4_SVLK.Focus()) { textBoxKodeKAB.Focus(); return; }
                if (panelKDSertifikat.Focus()) { textBoxKodeKAB.Focus(); return; }
                //Back 2
                //else if (radioButton1A.Focus()) { panelKDSertifikat.Focus(); return; }
                //else if (radioButton2B.Focus()) { panelKDSertifikat.Focus(); return; }
                //else if (radioButton3C.Focus()) { panelKDSertifikat.Focus(); return; }
                //else if (radioButton4D.Focus()) { panelKDSertifikat.Focus(); return; }
                //else if (radioButton5E.Focus()) { panelKDSertifikat.Focus(); return; }
                //else if (radioButton6KAM.Focus()) { panelKDSertifikat.Focus(); return; }
                else if (panelJenisTebangan.Focus()) { panelKDSertifikat.Focus(); return; }
                //Back 3
                else if (textBoxNoPetak.Focus()) { panelJenisTebangan.Focus(); return; }
                else if (textBoxJenisKayu.Focus()) { textBoxNoPetak.Focus(); return; }
                else if (textBoxKodeBKPH.Focus()) { textBoxJenisKayu.Focus(); return; }
                else if (textBoxUnitKPH.Focus()) { textBoxKodeBKPH.Focus(); return; }
                else if (textBoxKodeTPK.Focus()) { textBoxUnitKPH.Focus(); return; }
                else if (buttonNext.Focus()) { textBoxKodeTPK.Focus(); return; }
                //Back 4
                else if (textBoxNoPohon.Focus()) { textBoxBarcode.Focus(); return; }
                else if (textBoxNoPotongan.Focus()) { textBoxNoPohon.Focus(); return; }
                else if (textBoxPanjang.Focus()) { textBoxNoPotongan.Focus(); return; }
                else if (textBoxDiameter.Focus()) { textBoxPanjang.Focus(); return; }
                else if (buttonNew.Focus()) { textBoxDiameter.Focus(); return; }
            }
        }

        private void panelKDSertifikat_GotFocus(object sender, EventArgs e)
        {
            
        }
    }
}