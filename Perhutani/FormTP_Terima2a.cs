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
    public partial class FormTP_Terima2a : Form
    {
        public FormTP_Terima2a()
        {
            InitializeComponent();
        }

        ClassQuery cQuery = new ClassQuery();
        ClassSound cSound = new ClassSound();
        ClassError cError = new ClassError();
        ClassConnection cKoneksi = new ClassConnection();

        private void FormTP_Terima2a_Load(object sender, EventArgs e)
        {
            textBoxKodeKAB.Focus();
            textBoxKodeKAB.Text = "";
            textBoxNoPetak.Text = "";
            textBoxJenisKayu.Text = "";
            textBoxKodeBKPH.Text = "";
            textBoxUnitKPH.Text = "";
            textBoxKodeTPK.Text = "";
            statusBar1.Text = "User : " + ClassUser.UserID.ToString() + " | Id Hand Held : " + ClassUser.HandheldID;
        }

        private void Bersih()
        {

            ClassConnection.radio1 = "";
            ClassConnection.radio2 = "";
            textBoxKodeKAB.Text = "";
            textBoxKodeKAB.Focus();
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
        }
        private void textBoxKodeKAB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxKodeKAB.Text != "")
            {
                if (e.KeyChar == 09)
                {
                    if (radioButton1_FSC.Checked)
                    {
                        radioButton1_FSC.Focus();
                    }
                    else if (radioButton2_PH.Checked)
                    {
                        radioButton2_PH.Focus();
                    }
                    else if (radioButton3_CW.Checked)
                    {
                        radioButton3_CW.Focus();
                    }
                    else if (radioButton4_SVLK.Checked)
                    {
                        radioButton4_SVLK.Focus();
                    }
                    else
                    {
                        radioButton1_FSC.Focus();
                        radioButton1_FSC.Checked = true;
                    }
                }
                else if (e.KeyChar == 13)
                {
                    int kdKab;
                    try
                    {
                        kdKab = Convert.ToInt16(textBoxKodeKAB.Text.Substring(0, 1));
                    }
                    catch
                    {
                        MessageBox.Show("Hanya Input Nomor", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        textBoxKodeKAB.Focus();
                        textBoxKodeKAB.Text = "";
                        return;
                    }
                    if (textBoxKodeKAB.Text == "")
                    {
                        MessageBox.Show("Input Kode Kabupaten", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        textBoxKodeKAB.Focus();
                        return;
                    }
                    else if (kdKab > 3)
                    {
                        MessageBox.Show("Digit Pertama Tidak Boleh Lebih dari 3","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
                        textBoxKodeKAB.Focus();
                        textBoxKodeKAB.Text = "";
                        return;
                    }
                    else
                    {
                        if (radioButton1_FSC.Checked)
                        {
                            radioButton1_FSC.Focus();
                        }
                        else if (radioButton2_PH.Checked)
                        {
                            radioButton2_PH.Focus();
                        }
                        else if (radioButton3_CW.Checked)
                        {
                            radioButton3_CW.Focus();
                        }
                        else if (radioButton4_SVLK.Checked)
                        {
                            radioButton4_SVLK.Focus();
                        }
                        else
                        {
                            radioButton1_FSC.Focus();
                            radioButton1_FSC.Checked = true;
                        }
                    }
                }
            }
        }

        private void CekRB1()
        {
            if (radioButton1_FSC.Checked) { ClassConnection.radio1 = "1"; }
            else if (radioButton2_PH.Checked) { ClassConnection.radio1 = "2"; }
            else if (radioButton3_CW.Checked) { ClassConnection.radio1 = "3"; }
            else if (radioButton4_SVLK.Checked) { ClassConnection.radio1 = "4"; }
            else { ClassConnection.radio1 = ""; }
        }

        private void CekRB2()
        {
            if (radioButton1A.Checked) { ClassConnection.radio2 = "1"; }
            else if (radioButton2B.Checked) { ClassConnection.radio2 = "2"; }
            else if (radioButton3C.Checked) { ClassConnection.radio2 = "3"; }
            else if (radioButton4D.Checked) { ClassConnection.radio2 = "4"; }
            else if (radioButton5E.Checked) { ClassConnection.radio2 = "5"; }
            else if (radioButton6KAM.Checked) { ClassConnection.radio2 = "6"; }
            else { ClassConnection.radio2 = ""; }
        }

        private void kodesertivikat(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 09 || e.KeyChar == 11)//tab
            {
                if (radioButton1A.Checked)
                {
                    radioButton1A.Focus();
                }
                else if (radioButton2B.Checked)
                {
                    radioButton2B.Focus();
                }
                else if (radioButton3C.Checked)
                {
                    radioButton3C.Focus();
                }
                else if (radioButton4D.Checked)
                {
                    radioButton4D.Focus();
                }
                else if (radioButton5E.Checked)
                {
                    radioButton5E.Focus();
                }
                else if (radioButton6KAM.Checked)
                {
                    radioButton6KAM.Focus();
                }
                else
                {
                    radioButton1A.Focus();
                    radioButton1A.Checked = true;
                }
            }
            if (e.KeyChar == 49)
            {
                radioButton1_FSC.Focus();
                radioButton1_FSC.Checked = true;
            }
            else if (e.KeyChar == 50)
            {
                radioButton2_PH.Focus();
                radioButton2_PH.Checked = true;
            }
            else if (e.KeyChar == 51)
            {
                radioButton3_CW.Focus();
                radioButton3_CW.Checked = true;
            }
            else if (e.KeyChar == 52)
            {
                radioButton4_SVLK.Focus();
                radioButton4_SVLK.Checked = true;
            }
            //ESC
            else if (e.KeyChar == 27)
            {
                textBoxKodeKAB.Focus();
            }
            //Enter
            else if (e.KeyChar == 13 || e.KeyChar == 09 || e.KeyChar == 11)
            {
                if (radioButton1A.Checked)
                {
                    radioButton1A.Focus();
                }
                else if (radioButton2B.Checked)
                {
                    radioButton2B.Focus();
                }
                else if (radioButton3C.Checked)
                {
                    radioButton3C.Focus();
                }
                else if (radioButton4D.Checked)
                {
                    radioButton4D.Focus();
                }
                else if (radioButton5E.Checked)
                {
                    radioButton5E.Focus();
                }
                else if (radioButton6KAM.Checked)
                {
                    radioButton6KAM.Focus();
                }
                else
                {
                    radioButton1A.Focus();
                    radioButton1A.Checked = true;
                }
            }
        }
        
        private void radioButton1_FSC_KeyPress(object sender, KeyPressEventArgs e)
        {
            kodesertivikat(sender,e);
        }

        private void radioButton2_PH_KeyPress(object sender, KeyPressEventArgs e)
        {
            kodesertivikat(sender, e);
        }

        private void radioButton3_CW_KeyPress(object sender, KeyPressEventArgs e)
        {
            kodesertivikat(sender, e);
        }

        private void radioButton4_SVLK_KeyPress(object sender, KeyPressEventArgs e)
        {
            kodesertivikat(sender, e);
        }

        private void jenistebangan(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 09 || e.KeyChar == 11) //tab horizontal
            {
                textBoxNoPetak.Focus();
            }
            if (e.KeyChar == 49)
            {
                radioButton1A.Focus();
                radioButton1A.Checked = true;
            }
            else if (e.KeyChar == 50)
            {
                radioButton2B.Focus();
                radioButton2B.Checked = true;
            }
            else if (e.KeyChar == 51)
            {
                radioButton3C.Focus();
                radioButton3C.Checked = true;
            }
            else if (e.KeyChar == 52)
            {
                radioButton4D.Focus();
                radioButton4D.Checked = true;
            }
            else if (e.KeyChar == 53)
            {
                radioButton5E.Focus();
                radioButton5E.Checked = true;
            }
            else if (e.KeyChar == 54)
            {
                radioButton6KAM.Focus();
                radioButton6KAM.Checked = true;
            }
            //ESC
            else if (e.KeyChar == 27)
            {
                if (radioButton1_FSC.Checked)
                {
                    radioButton1_FSC.Focus();
                }
                else if (radioButton2_PH.Checked)
                {
                    radioButton2_PH.Focus();
                }
                else if (radioButton3_CW.Checked)
                {
                    radioButton3_CW.Focus();
                }
                else if (radioButton4_SVLK.Checked)
                {
                    radioButton4_SVLK.Focus();
                }
                else
                {
                    radioButton1_FSC.Focus();
                    radioButton1_FSC.Checked = true;
                }
            }
            //Enter
            else if (e.KeyChar == 13)
            {
                textBoxNoPetak.Focus();
            }
        }

        private void radioButton1A_KeyPress(object sender, KeyPressEventArgs e)
        {
            jenistebangan(sender, e);
        }

        private void radioButton2B_KeyPress(object sender, KeyPressEventArgs e)
        {
            jenistebangan(sender, e);
        }

        private void radioButton3C_KeyPress(object sender, KeyPressEventArgs e)
        {
            jenistebangan(sender, e);
        }

        private void radioButton4D_KeyPress(object sender, KeyPressEventArgs e)
        {
            jenistebangan(sender, e);
        }
        
        private void radioButton5E_KeyPress(object sender, KeyPressEventArgs e)
        {
            jenistebangan(sender, e);
        }

        private void radioButton6KAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            jenistebangan(sender, e);
        }


        private void textBoxNoPetak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (radioButton1A.Checked)
                {
                    radioButton1A.Focus();
                }
                else if (radioButton2B.Checked)
                {
                    radioButton2B.Focus();
                }
                else if (radioButton3C.Checked)
                {
                    radioButton3C.Focus();
                }
                else if (radioButton4D.Checked)
                {
                    radioButton4D.Focus();
                }
                else if (radioButton5E.Checked)
                {
                    radioButton5E.Focus();
                }
                else if (radioButton6KAM.Checked)
                {
                    radioButton6KAM.Focus();
                }
                else
                {
                    radioButton1A.Focus();
                    radioButton1A.Checked = true;
                }
            }
            if (e.KeyChar == 13)
            {
                CekRB1();
                CekRB2();
                if (textBoxKodeKAB.Text == "")
                {
                    MessageBox.Show("Lengkapi data");
                    return;
                }
                else if (ClassConnection.radio1 == "" && ClassConnection.radio2 == "")
                {
                    panelKDSertifikat.BackColor = Color.Red;
                    panelKDSertifikat.Focus();
                    radioButton1_FSC.Focus();
                    panelJenisTebangan.BackColor = Color.Red;
                    MessageBox.Show("Harap Pilih Kode Sertifikat & Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    return;
                }

                else if (ClassConnection.radio1 == "")
                {
                    panelKDSertifikat.BackColor = Color.Red;
                    panelKDSertifikat.Focus();
                    radioButton1_FSC.Focus();
                    MessageBox.Show("Harap Pilih Kode Sertifikat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    panelKDSertifikat.Focus();
                    return;
                }
                else if (ClassConnection.radio2 == "")
                {
                    panelJenisTebangan.BackColor = Color.Red;
                    panelJenisTebangan.Focus();
                    radioButton1A.Focus();
                    MessageBox.Show("Harap Pilih Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    panelJenisTebangan.Focus();
                    return;
                }
                else if (textBoxNoPetak.Text == "")
                {
                    MessageBox.Show("Input Kode No Petak", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    textBoxNoPetak.Focus();
                    return;
                }
                panelKDSertifikat.BackColor = Color.Tomato;
                panelJenisTebangan.BackColor = Color.Tomato;
                textBoxJenisKayu.Focus();
            }
        }

        private void textBoxJenisKayu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxJenisKayu.Text == "")
                {
                    MessageBox.Show("Input Jenis Kayu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    textBoxJenisKayu.Focus();
                    return;
                }
                textBoxKodeBKPH.Focus();
            }
            else if (e.KeyChar == 27)
            {
                textBoxNoPetak.Focus();
            }
        }

        private void textBoxKodeBKPH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxKodeBKPH.Text == "")
                {
                    MessageBox.Show("Input Kode BKPH", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    textBoxKodeBKPH.Focus();
                    return;
                }
                textBoxUnitKPH.Focus();
            }
            else if (e.KeyChar == 27)
            {
                textBoxJenisKayu.Focus();
            }
        }

        private void textBoxUnitKPH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxUnitKPH.Text == "")
                {
                    MessageBox.Show("Input Unit + KPH");
                    textBoxUnitKPH.Focus();
                    return;
                }
                if (Convert.ToInt16(textBoxUnitKPH.Text.Substring(0, 1)) > 3)
                {
                    MessageBox.Show("Unit + KPH tidak Sesuai.Digit Pertama(" + textBoxUnitKPH.Text.Substring(0,1) + " > 3)");
                    textBoxUnitKPH.Focus();
                    return;
                }
                textBoxKodeTPK.Focus();
            }
            else if (e.KeyChar == 27)
            {
                textBoxKodeBKPH.Focus();
            }
        }

        private void textBoxKodeTPK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxKodeTPK.Text == "")
                {
                    MessageBox.Show("Input Kode TPK");
                    textBoxKodeTPK.Focus();
                    return;
                }
                buttonNext.Focus();
            }
            else if (e.KeyChar == 27)
            {
                textBoxUnitKPH.Focus();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            CekRB1();
            CekRB2();
            if (textBoxKodeKAB.Text == "")
            {
                textBoxKodeKAB.Focus();
                MessageBox.Show("Input Kode Kabupaten");
                return;
            }
            else if (ClassConnection.radio1 == "" && ClassConnection.radio2 == "")
            {
                panelKDSertifikat.BackColor = Color.Red;
                panelKDSertifikat.Focus();
                radioButton1_FSC.Focus();
                panelJenisTebangan.BackColor = Color.Red;
                MessageBox.Show("Harap Pilih Kode Sertifikat & Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            else if (ClassConnection.radio1 == "")
            {
                panelKDSertifikat.BackColor = Color.Red;
                panelKDSertifikat.Focus();
                radioButton1_FSC.Focus();
                MessageBox.Show("Harap Pilih Kode Sertifikat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                panelKDSertifikat.Focus();
                return;
            }
            else if (ClassConnection.radio2 == "")
            {
                panelJenisTebangan.BackColor = Color.Red;
                panelJenisTebangan.Focus();
                radioButton1A.Focus();
                MessageBox.Show("Harap Pilih Jenis Tebangan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                panelJenisTebangan.Focus();
                return;
            }
            else if (textBoxNoPetak.Text == "")
            {
                textBoxNoPetak.Focus();
                MessageBox.Show("Lengkapi data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            else if (textBoxJenisKayu.Text == "")
            {
                textBoxJenisKayu.Focus();
                MessageBox.Show("Lengkapi data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            else if (textBoxKodeBKPH.Text == "")
            {
                textBoxKodeBKPH.Focus();
                MessageBox.Show("Lengkapi data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            else if (textBoxUnitKPH.Text == "")
            {
                textBoxUnitKPH.Focus();
                MessageBox.Show("Lengkapi data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            else if (textBoxKodeTPK.Text == "")
            {
                textBoxKodeTPK.Focus();
                MessageBox.Show("Lengkapi data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                ClassConnection.KodeKAB = textBoxKodeKAB.Text;
                ClassConnection.KodeBKPH = textBoxKodeBKPH.Text;
                ClassConnection.NoPetak = textBoxNoPetak.Text;
                ClassConnection.JenisKayu = textBoxJenisKayu.Text;
                ClassConnection.KodeTPK = textBoxKodeTPK.Text;
                ClassConnection.UnitKPH = textBoxUnitKPH.Text;
                panelKDSertifikat.BackColor = Color.Silver;
                panelJenisTebangan.BackColor = Color.Silver;
                FormTP_Terima2b FTP2b = new FormTP_Terima2b();
                FTP2b.ShowDialog();
                if (ClassConnection.Status == "New")
                {
                    Bersih();
                    textBoxKodeKAB.Focus();
                }
                else
                {
                    buttonClose.Focus();
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Bersih();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxKodeKAB_GotFocus(object sender, EventArgs e)
        {
            textBoxKodeKAB.BackColor = Color.LightGray;
        }

        private void textBoxKodeKAB_LostFocus(object sender, EventArgs e)
        {
            textBoxKodeKAB.BackColor = Color.White;
        }

        private void panelKDSertifikat_GotFocus(object sender, EventArgs e)
        {
            panelKDSertifikat.BackColor = Color.LightGray;
        }

        private void panelKDSertifikat_LostFocus(object sender, EventArgs e)
        {
            panelKDSertifikat.BackColor = Color.Tomato;
        }

        private void ksf()
        {
            panelKDSertifikat.BackColor = Color.LightGray; 
        }     

        private void ksnf()
        {
            panelKDSertifikat.BackColor = Color.Tomato;
        }

        private void radioButton1_FSC_GotFocus(object sender, EventArgs e)
        {
            ksf();
        }

        private void radioButton1_FSC_LostFocus(object sender, EventArgs e)
        {
            ksnf();
        }

        private void radioButton2_PH_GotFocus(object sender, EventArgs e)
        {
            ksf();
        }

        private void radioButton2_PH_LostFocus(object sender, EventArgs e)
        {
            ksnf();
        }

        private void radioButton3_CW_GotFocus(object sender, EventArgs e)
        {
            ksf();
        }

        private void radioButton3_CW_LostFocus(object sender, EventArgs e)
        {
            ksnf();
        }

        private void radioButton4_SVLK_GotFocus(object sender, EventArgs e)
        {
            ksf();
        }

        private void radioButton4_SVLK_LostFocus(object sender, EventArgs e)
        {
            ksnf();
        }

        private void jtf()
        {
            panelJenisTebangan.BackColor = Color.LightGray;
        }
        private void jtnf()
        {
            panelJenisTebangan.BackColor = Color.Tomato;
        }
    
        private void radioButton1A_GotFocus(object sender, EventArgs e)
        {
            jtf();
        }        

        private void radioButton1A_LostFocus(object sender, EventArgs e)
        {
            jtnf();
        }

        private void radioButton2B_GotFocus(object sender, EventArgs e)
        {
            jtf();
        }

        private void radioButton2B_LostFocus(object sender, EventArgs e)
        {
            jtnf();
        }

        private void radioButton3C_GotFocus(object sender, EventArgs e)
        {
            jtf();
        }

        private void radioButton3C_LostFocus(object sender, EventArgs e)
        {
            jtnf();
        }

        private void radioButton4D_GotFocus(object sender, EventArgs e)
        {
            jtf();
        }

        private void radioButton4D_LostFocus(object sender, EventArgs e)
        {
            jtnf();
        }

        private void radioButton5E_GotFocus(object sender, EventArgs e)
        {
            jtf();
        }

        private void radioButton5E_LostFocus(object sender, EventArgs e)
        {
            jtnf();
        }

        private void radioButton6KAM_GotFocus(object sender, EventArgs e)
        {
            jtf();
        }

        private void radioButton6KAM_LostFocus(object sender, EventArgs e)
        {

        }

        private void textBoxNoPetak_GotFocus(object sender, EventArgs e)
        {
            textBoxNoPetak.BackColor = Color.LightGray;
        }

        private void textBoxNoPetak_LostFocus(object sender, EventArgs e)
        {
            textBoxNoPetak.BackColor = Color.WhiteSmoke;
        }

        private void textBoxJenisKayu_GotFocus(object sender, EventArgs e)
        {
            textBoxJenisKayu.BackColor = Color.LightGray;
        }

        private void textBoxJenisKayu_LostFocus(object sender, EventArgs e)
        {
            textBoxJenisKayu.BackColor = Color.WhiteSmoke;
        }

        private void textBoxKodeBKPH_GotFocus(object sender, EventArgs e)
        {
            textBoxKodeBKPH.BackColor = Color.LightGray;
        }

        private void textBoxKodeBKPH_LostFocus(object sender, EventArgs e)
        {
            textBoxKodeBKPH.BackColor = Color.WhiteSmoke;
        }

        private void textBoxUnitKPH_GotFocus(object sender, EventArgs e)
        {
            textBoxUnitKPH.BackColor = Color.LightGray;
        }

        private void textBoxUnitKPH_LostFocus(object sender, EventArgs e)
        {
            textBoxUnitKPH.BackColor = Color.WhiteSmoke;
        }

        private void textBoxKodeTPK_GotFocus(object sender, EventArgs e)
        {
            textBoxKodeTPK.BackColor = Color.LightGray;
        }

        private void textBoxKodeTPK_LostFocus(object sender, EventArgs e)
        {
            textBoxKodeTPK.BackColor = Color.WhiteSmoke;
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