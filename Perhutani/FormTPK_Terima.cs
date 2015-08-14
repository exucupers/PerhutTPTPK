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
    public partial class FormTPK_Terima : Form
    {
        public FormTPK_Terima()
        {
            InitializeComponent();
        }

        ClassConnection cKoneksi = new ClassConnection();
        ClassQuery cQuery = new ClassQuery();
        ClassSound cSound = new ClassSound();
        string radioMutu = "";
        string radioStatus = "";
        string radioCacatKayu = "";
        bool isstatus = true;
        bool isstatus2 = true;

        private void FormTPK_Terima_Load(object sender, EventArgs e)
        {
            labelTotal.Text = cQuery.hitungtotal("TerimaTPK");
            statusBar1.Text = "User : " + ClassUser.UserID.ToString() + " | Id Hand Held : " + ClassUser.HandheldID;
            textBoxBarcode.Focus();
        }
        private void cekradioMutu()
        {
            if (radioButtonMutu1U.Checked == false && radioButtonMutu2P.Checked == false && radioButtonMutu3D.Checked == false && radioButtonMutu4T.Checked == false && radioButtonMutu5M.Checked == false && radioButtonMutu6L.Checked == false && radioButtonMutu7N.Checked == false && radioButtonMutu8KBP.Checked == false)
            {
                panel0.BackColor = Color.Red;
                isstatus = false;
                return;
            }
            //1: UT, 2: P, 3:  D, 4    T , 5    M, 6    L, 7    N, 8    KBP
            else if (radioButtonMutu1U.Checked) { radioMutu = "1"; panel0.BackColor = Color.PaleTurquoise; isstatus = true; }
            else if (radioButtonMutu2P.Checked) { radioMutu = "2"; panel0.BackColor = Color.PaleTurquoise; isstatus = true; }
            else if (radioButtonMutu3D.Checked) { radioMutu = "3"; panel0.BackColor = Color.PaleTurquoise; isstatus = true; }
            else if (radioButtonMutu4T.Checked) { radioMutu = "4"; panel0.BackColor = Color.PaleTurquoise; isstatus = true; }
            
            else if (radioButtonMutu5M.Checked) { radioMutu = "5"; panel0.BackColor = Color.PaleTurquoise; isstatus = true; }
            else if (radioButtonMutu6L.Checked) { radioMutu = "6"; panel0.BackColor = Color.PaleTurquoise; isstatus = true; }
            else if (radioButtonMutu7N.Checked) { radioMutu = "7"; panel0.BackColor = Color.PaleTurquoise; isstatus = true; } 
            else if (radioButtonMutu8KBP.Checked) { radioMutu = "8"; panel0.BackColor = Color.PaleTurquoise; isstatus = true; }

        }

        private void cekradioStatus()
        {
            if (radioButtonStatus1Lok.Checked == false && radioButtonStatus2H.Checked == false && radioButtonStatus3V.Checked == false && radioButtonStatus4In.Checked == false)
            {
                panel1.BackColor = Color.Red;
                isstatus2 = false;
                return;
            }           
                //1 Lok (Lokal), 2 H(Hara), 3 V(Vinir), 4 In (Industri)
            else if (radioButtonStatus1Lok.Checked)
            {
                radioStatus = "1";
                panel1.BackColor = Color.PaleTurquoise;
                isstatus2 = true;
            }
            else if (radioButtonStatus2H.Checked)
            {
                radioStatus = "2";
                panel1.BackColor = Color.PaleTurquoise;
                isstatus2 = true;
            }
            else if (radioButtonStatus3V.Checked)
            {
                radioStatus = "3";
                panel1.BackColor = Color.PaleTurquoise;
                isstatus2 = true;
            }
            else if (radioButtonStatus4In.Checked)
            {
                radioStatus = "4";
                panel1.BackColor = Color.PaleTurquoise;
                isstatus2 = true;
            }
        }

        private void cekradioCacatKayu()
        {
            if (radioButtonCacat0.Checked == false && radioButtonCacat1DR.Checked == false && radioButtonCacat2BC.Checked == false && radioButtonCacat3GR.Checked == false && radioButtonCacat4LPK.Checked == false && radioButtonCacat5GBT.Checked == false && radioButtonCacat6OLG.Checked == false && radioButtonCacat7PTH.Checked == false && radioButtonCacat8ALM.Checked == false && radioButtonCacat9QuareI.Checked == false)
            {
                radioCacatKayu = "0";
                return;
            }
            // //1 DR (Doreng), 2    BC (Buncak), 3    GR (Growong), 4    LPK (Lapuk), 5    GBT (Gubal Tebal), 6    OLG (Oleng-Oleng), 7    PTH (Putihan), 8    ALM (Alur Minyak), 9    Quare I
            else if (radioButtonCacat1DR.Checked)
            { radioCacatKayu = "1"; }
            else if (radioButtonCacat2BC.Checked)
            { radioCacatKayu = "2"; }
            else if (radioButtonCacat3GR.Checked)
            { radioCacatKayu = "3"; }
            else if (radioButtonCacat4LPK.Checked)
            { radioCacatKayu = "4"; }
            else if (radioButtonCacat5GBT.Checked)
            { radioCacatKayu = "5"; }
            else if (radioButtonCacat6OLG.Checked)
            { radioCacatKayu = "6"; }
            else if (radioButtonCacat7PTH.Checked)
            { radioCacatKayu = "7"; }
            else if (radioButtonCacat8ALM.Checked)
            { radioCacatKayu = "8"; }
            else if (radioButtonCacat9QuareI.Checked)
            { radioCacatKayu = "9"; }
            else
            {
                radioCacatKayu = "0";
            }
        }

        private void cekradio()
        {
            cekradioMutu();
            cekradioStatus();
            cekradioCacatKayu();
        }
        private void Save()
        {
            try
            {
                if (cKoneksi.Con.State == ConnectionState.Closed) { cKoneksi.Con.Open(); }
                string strSQL = "INSERT into TerimaTPK values('" + textBoxBarcode.Text + "','" + radioMutu + "','" + radioStatus + "','" + radioCacatKayu + "',getdate())";
                cQuery.Execute(strSQL); 
                //cSound.suaraOK();
                if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
                
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
            }
        }

        private void textBoxBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 09)
            {
                buttonGo_Click(sender, e);
            }
            if (e.KeyChar == 13)
            {
                if (textBoxBarcode.Text == "")
                {
                    MessageBox.Show("Harap Scan Barcode", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    textBoxBarcode.Focus();
                    textBoxBarcode.BackColor = Color.Red;
                    return;
                }
                if (textBoxBarcode.Text.Length != 9)
                {
                    MessageBox.Show("Panjang Barcode Tidak Sesuai", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    textBoxBarcode.Focus();
                    textBoxBarcode.Text = "";
                    textBoxBarcode.BackColor = Color.Red;
                    return;
                }
                try
                {
                    SqlCeDataReader dr;
                    string str = "SELECT [scanbarcode] from TerimaTPK where scanbarcode='" + textBoxBarcode.Text + "'";
                    SqlCeCommand cmd = new SqlCeCommand(str, cKoneksi.Con);
                    if (cKoneksi.Con.State == ConnectionState.Closed) { cKoneksi.Con.Open(); }
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        cmd.Dispose();
                        //cSound.suaraError();
                        if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
                        MessageBox.Show("Duplicate Scan!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        textBoxBarcode.Text = "";
                        textBoxBarcode.Focus();
                        textBoxBarcode.BackColor = Color.Red;
                        textBoxBarcode.Text = "";
                    }
                    else
                    {
                        dr.Close();
                        cmd.Dispose();
                        if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
                        
                        textBoxBarcode.BackColor = Color.White;
                        buttonGo_Click(sender, e);
                    }
                }

                catch (SqlCeException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
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
                MessageBox.Show("Harap Scan Barcode", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                textBoxBarcode.Focus();
                return;
            }
            textBoxBarcode.BackColor = Color.White;

            cekradio();
            if (isstatus == false && isstatus2 == false)
            {
                panel0.BackColor = Color.Red;
                panel1.BackColor = Color.Red;
                MessageBox.Show("Silahkan Pilih Mutu dan Status", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            panel0.BackColor = Color.PaleTurquoise;
            panel1.BackColor = Color.PaleTurquoise;

            if (isstatus == false)
            {
                panel0.BackColor = Color.Red;
                MessageBox.Show("Silahkan Pilih Mutu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            panel0.BackColor = Color.PaleTurquoise;

            if (isstatus2 == false)
            {
                panel1.BackColor = Color.Red;
                MessageBox.Show("Silahkan Pilih Status", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            panel1.BackColor = Color.PaleTurquoise;

            if (isstatus == true && isstatus2 == true)
            {
                Save();
                labelLastScan.Text = ">> " + textBoxBarcode.Text;
                labelTotal.Text = cQuery.hitungtotal("TerimaTPK");
                textBoxBarcode.Focus();
                //bersih();
            }
            else
            {
                MessageBox.Show("Lengkapi data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                //FormTPK_Terima_Load(sender, e);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bersih()
        {
            panel0.BackColor = Color.PaleTurquoise;
            panel1.BackColor = Color.PaleTurquoise;
            panel2.BackColor = Color.PaleTurquoise;

            textBoxBarcode.Text = "";
            textBoxBarcode.Focus();

            radioButtonMutu1U.Checked = false;
            radioButtonMutu2P.Checked = false;
            radioButtonMutu3D.Checked = false;
            radioButtonMutu4T.Checked = false;
            radioButtonMutu5M.Checked = false;
            radioButtonMutu6L.Checked = false;
            radioButtonMutu7N.Checked = false;
            radioButtonMutu8KBP.Checked = false;

            radioButtonStatus1Lok.Checked = false;
            radioButtonStatus2H.Checked = false;
            radioButtonStatus3V.Checked = false;
            radioButtonStatus4In.Checked = false;

            radioButtonCacat0.Checked = false;
            radioButtonCacat1DR.Checked = false;
            radioButtonCacat2BC.Checked = false;
            radioButtonCacat3GR.Checked = false;
            radioButtonCacat4LPK.Checked = false;
            radioButtonCacat5GBT.Checked = false;
            radioButtonCacat6OLG.Checked = false;
            radioButtonCacat7PTH.Checked = false;
            radioButtonCacat8ALM.Checked = false;
            radioButtonCacat9QuareI.Checked = false;
            

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            bersih();
        }                

        private void FormTPK_Terima_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void Mutu(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 49)
            {
                radioButtonMutu1U.Focus();
                radioButtonMutu1U.Checked = true;
            }
            else if (e.KeyChar == 50)
            {
                radioButtonMutu2P.Focus();
                radioButtonMutu2P.Checked = true;
            }
            else if (e.KeyChar == 51)
            {
                radioButtonMutu3D.Focus();
                radioButtonMutu3D.Checked = true;
            }
            else if (e.KeyChar == 52)
            {
                radioButtonMutu4T.Focus();
                radioButtonMutu4T.Checked = true;
            }
            else if (e.KeyChar == 53)
            {
                radioButtonMutu5M.Focus();
                radioButtonMutu5M.Checked = true;
            }
            else if (e.KeyChar == 54)
            {
                radioButtonMutu6L.Focus();
                radioButtonMutu6L.Checked = true;
            }

            else if (e.KeyChar == 55)
            {
                radioButtonMutu7N.Focus();
                radioButtonMutu7N.Checked = true;
            }
            else if (e.KeyChar == 56)
            {
                radioButtonMutu8KBP.Focus();
                radioButtonMutu8KBP.Checked = true;
            }
            //ESC
            else if (e.KeyChar == 27)
            {
                textBoxBarcode.Focus();
            }
            //Enter
            else if (e.KeyChar == 13 || e.KeyChar == 09)
            {
                if (radioButtonStatus1Lok.Checked)
                {
                    radioButtonStatus1Lok.Focus();
                }
                else if (radioButtonStatus2H.Checked)
                {
                    radioButtonStatus2H.Focus();
                }
                else if (radioButtonStatus3V.Checked)
                {
                    radioButtonStatus3V.Focus();
                }
                else if (radioButtonStatus4In.Checked)
                {
                    radioButtonStatus4In.Focus();
                }
                else
                {
                    radioButtonStatus1Lok.Focus();
                    radioButtonStatus1Lok.Checked = true;
                }
            }
        }
        private void radioButtonMutu1U_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mutu(sender, e);
        }

        private void radioButtonMutu2P_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mutu(sender, e);
        }
       
        private void radioButtonMutu3D_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mutu(sender, e);
        }

        private void radioButtonMutu4T_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mutu(sender, e);
        }
        
        //
        //RadioStatus
        //
        private void Status(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 49) //1
            {
                radioButtonStatus1Lok.Focus();
                radioButtonStatus1Lok.Checked = true;
            }
            else if (e.KeyChar == 50) //2
            {
                radioButtonStatus2H.Focus();
                radioButtonStatus2H.Checked = true;
            }
            else if (e.KeyChar == 51) //3
            {
                radioButtonStatus3V.Focus();
                radioButtonStatus3V.Checked = true;
            }
            else if (e.KeyChar == 52) //4
            {
                radioButtonStatus4In.Focus();
                radioButtonStatus4In.Checked = true;
            }
            //ESC
            else if (e.KeyChar == 27)
            {
                if (radioButtonMutu1U.Checked)
                {
                    radioButtonMutu1U.Focus();
                }
                else if (radioButtonMutu2P.Checked)
                {
                    radioButtonMutu2P.Focus();
                }
                else if (radioButtonMutu3D.Checked)
                {
                    radioButtonMutu3D.Focus();
                }
                else if (radioButtonMutu4T.Checked)
                {
                    radioButtonMutu4T.Focus();
                }
                else if (radioButtonMutu5M.Checked)
                {
                    radioButtonMutu5M.Focus();
                }
                else if (radioButtonMutu6L.Checked)
                {
                    radioButtonMutu6L.Focus();
                }
                else if (radioButtonMutu7N.Checked)
                {
                    radioButtonMutu7N.Focus();
                }
                else if (radioButtonMutu8KBP.Checked)
                {
                    radioButtonMutu8KBP.Focus();
                }
                else
                {
                    radioButtonMutu1U.Focus();
                    radioButtonMutu1U.Checked = true;
                }
            }
            //Enter
            else if (e.KeyChar == 13 || e.KeyChar == 09)
            {
                if (radioButtonCacat1DR.Checked)
                {
                    radioButtonCacat1DR.Focus();
                }
                else if (radioButtonCacat2BC.Checked)
                {
                    radioButtonCacat2BC.Focus();
                }
                else if (radioButtonCacat3GR.Checked)
                {
                    radioButtonCacat3GR.Focus();
                }
                else if (radioButtonCacat4LPK.Checked)
                {
                    radioButtonCacat4LPK.Focus();
                }
                else if (radioButtonCacat5GBT.Checked)
                {
                    radioButtonCacat5GBT.Focus();
                }
                else if (radioButtonCacat6OLG.Checked)
                {
                    radioButtonCacat6OLG.Focus();
                }
                else if (radioButtonCacat7PTH.Checked)
                {
                    radioButtonCacat7PTH.Focus();
                }
                else if (radioButtonCacat8ALM.Checked)
                {
                    radioButtonCacat8ALM.Focus();
                }
                else if (radioButtonCacat9QuareI.Checked)
                {
                    radioButtonCacat9QuareI.Focus();
                }
                else
                {
                    radioButtonCacat0.Focus();
                    radioButtonCacat0.Checked = true;
                }
            }
        }

        private void radioButtonStatus1Lok_KeyPress(object sender, KeyPressEventArgs e)
        {
            Status(sender,e);
        }

        private void radioButtonStatus2H_KeyPress(object sender, KeyPressEventArgs e)
        {
            Status(sender, e);
        }

        private void radioButtonStatus3V_KeyPress(object sender, KeyPressEventArgs e)
        {
            Status(sender, e);
        }

        private void radioButtonStatus4In_KeyPress(object sender, KeyPressEventArgs e)
        {
            Status(sender, e);
        }

        //
        //Cacat kayu
        //
        private void Cacat(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 48)
            {
                radioButtonCacat0.Focus();
                radioButtonCacat0.Checked = true;
            }
            else if (e.KeyChar == 49)
            {
                radioButtonCacat1DR.Focus();
                radioButtonCacat1DR.Checked = true;
            }
            else if (e.KeyChar == 50)
            {
                radioButtonCacat2BC.Focus();
                radioButtonCacat2BC.Checked = true;
            }
            else if (e.KeyChar == 51)
            {
                radioButtonCacat3GR.Focus();
                radioButtonCacat3GR.Checked = true;
            }
            else if (e.KeyChar == 52)
            {
                radioButtonCacat4LPK.Focus();
                radioButtonCacat4LPK.Checked = true;
            }
            else if (e.KeyChar == 53)
            {
                radioButtonCacat5GBT.Focus();
                radioButtonCacat5GBT.Checked = true;
            }
            else if (e.KeyChar == 54)
            {
                radioButtonCacat6OLG.Focus();
                radioButtonCacat6OLG.Checked = true;
            }
            else if (e.KeyChar == 55)
            {
                radioButtonCacat7PTH.Focus();
                radioButtonCacat7PTH.Checked = true;
            }
            else if (e.KeyChar == 56)
            {
                radioButtonCacat8ALM.Focus();
                radioButtonCacat8ALM.Checked = true;
            }
            else if (e.KeyChar == 57)
            {
                radioButtonCacat9QuareI.Focus();
                radioButtonCacat9QuareI.Checked = true;
            }

            else if (e.KeyChar == 13 || e.KeyChar == 09)
            {
                buttonSave.Focus();
            }
            else if (e.KeyChar == 27)
            {
                if (radioButtonStatus1Lok.Checked)
                {
                    radioButtonStatus1Lok.Focus();
                }
                else if (radioButtonStatus2H.Checked)
                {
                    radioButtonStatus2H.Focus();
                }
                else if (radioButtonStatus3V.Checked)
                {
                    radioButtonStatus3V.Focus();
                }
                else if (radioButtonStatus4In.Checked)
                {
                    radioButtonStatus4In.Focus();
                }
            }
        }
        private void radioButtonCacat0_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cacat(sender, e);
        }

        private void radioButtonCacat1DR_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cacat(sender, e);
        }

        private void radioButtonCacat2BC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cacat(sender, e);
        }

        private void radioButtonCacat3GR_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cacat(sender, e);
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (radioButtonMutu1U.Checked)
            {
                radioButtonMutu1U.Focus();
            }
            else if (radioButtonMutu2P.Checked)
            {
                radioButtonMutu2P.Focus();
            }
            else if (radioButtonMutu3D.Checked)
            {
                radioButtonMutu3D.Focus();
            }
            else if (radioButtonMutu4T.Checked)
            {
                radioButtonMutu4T.Focus();
            }
            else
            {
                radioButtonMutu1U.Focus();
                radioButtonMutu1U.Checked = true;
            } 
        }
        private void buttonGo_GotFocus(object sender, EventArgs e)
        {
            if (radioButtonMutu1U.Checked)
            {
                radioButtonMutu1U.Focus();
            }
            else if (radioButtonMutu2P.Checked)
            {
                radioButtonMutu2P.Focus();
            }
            else if (radioButtonMutu3D.Checked)
            {
                radioButtonMutu3D.Focus();
            }
            else if (radioButtonMutu4T.Checked)
            {
                radioButtonMutu4T.Focus();
            }
            else
            {
                radioButtonMutu1U.Focus();
                radioButtonMutu1U.Checked = true;
            }
        }

        private void textBoxBarcode_GotFocus(object sender, EventArgs e)
        {
            textBoxBarcode.BackColor = Color.LightGray;
        }

        private void textBoxBarcode_LostFocus(object sender, EventArgs e)
        {
            textBoxBarcode.BackColor = Color.WhiteSmoke;
        }
        //mutu get focus
        private void mgf()
        {
            panel0.BackColor = Color.LightGray;
        }
        //mutu lost focus
        private void mlf()
        {
            panel0.BackColor = Color.PaleTurquoise;
        }

        private void radioButtonMutu1U_GotFocus(object sender, EventArgs e)
        {
            mgf();
        }

        private void radioButtonMutu1U_LostFocus(object sender, EventArgs e)
        {
            mlf();
        }

        private void radioButtonMutu2P_GotFocus(object sender, EventArgs e)
        {
            mgf();
        }

        private void radioButtonMutu2P_LostFocus(object sender, EventArgs e)
        {
            mlf();
        }

        private void radioButtonMutu3D_GotFocus(object sender, EventArgs e)
        {
            mgf();
        }

        private void radioButtonMutu3D_LostFocus(object sender, EventArgs e)
        {
            mlf();
        }

        private void radioButtonMutu4T_GotFocus(object sender, EventArgs e)
        {
            mgf();
        }

        private void radioButtonMutu4T_LostFocus(object sender, EventArgs e)
        {
            mlf();
        }
        //status get focus
        private void sgf()
        {
            panel1.BackColor = Color.LightGray;
        }
        //status lost focus
        private void slf()
        {
            panel1.BackColor = Color.PaleTurquoise;
        }


        private void radioButtonStatus1Lok_GotFocus(object sender, EventArgs e)
        {
            sgf();
        }

        private void radioButtonStatus1Lok_LostFocus(object sender, EventArgs e)
        {
            slf();
        }

        private void radioButtonStatus2H_GotFocus(object sender, EventArgs e)
        {
            sgf();
        }

        private void radioButtonStatus2H_LostFocus(object sender, EventArgs e)
        {
            slf();
        }

        private void radioButtonStatus3V_GotFocus(object sender, EventArgs e)
        {
            sgf();
        }

        private void radioButtonStatus3V_LostFocus(object sender, EventArgs e)
        {
            slf();
        }

        private void radioButtonStatus4In_GotFocus(object sender, EventArgs e)
        {
            sgf();
        }

        private void radioButtonStatus4In_LostFocus(object sender, EventArgs e)
        {
            slf();
        }

        //cacat got focus
        private void cgf()
        {
            panel2.BackColor = Color.LightGray;
        }

        private void clf()
        {
            panel2.BackColor = Color.PaleTurquoise;
        }

        private void radioButtonCacat0_GotFocus(object sender, EventArgs e)
        {
            cgf();
        }

        private void radioButtonCacat0_LostFocus(object sender, EventArgs e)
        {
            clf();
        }

        private void radioButtonCacat1DR_GotFocus(object sender, EventArgs e)
        {
            cgf();
        }

        private void radioButtonCacat1DR_LostFocus(object sender, EventArgs e)
        {
            clf();
        }

        private void radioButtonCacat2BC_GotFocus(object sender, EventArgs e)
        {
            cgf();
        }

        private void radioButtonCacat2BC_LostFocus(object sender, EventArgs e)
        {
            clf();
        }

        private void radioButtonCacat3GR_GotFocus(object sender, EventArgs e)
        {
            cgf();
        }

        private void radioButtonCacat3GR_LostFocus(object sender, EventArgs e)
        {
            clf();
        }

        private void buttonSave_GotFocus(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.Orange;
        }

        private void buttonSave_LostFocus(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.LightGray;
        }

        private void buttonCancel_GotFocus(object sender, EventArgs e)
        {
            buttonCancel.BackColor = Color.Orange;
        }

        private void buttonCancel_LostFocus(object sender, EventArgs e)
        {
            buttonCancel.BackColor = Color.LightGray;
        }

        private void buttonClose_GotFocus(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Orange;
        }

        private void buttonClose_LostFocus(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.LightGray;
        }

        private void buttonClose_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 09)
            {
                textBoxBarcode.Focus();
            }
        }

        private void radioButtonMutu5M_GotFocus(object sender, EventArgs e)
        {
            mgf();
        }

        private void radioButtonMutu5M_KeyPress(object sender, KeyPressEventArgs e)
        {

            Mutu(sender, e);
        }

        private void radioButtonMutu5M_LostFocus(object sender, EventArgs e)
        {
            mlf();
        }

        private void radioButtonMutu6L_GotFocus(object sender, EventArgs e)
        {
            mgf();
        }

        private void radioButtonMutu6L_KeyPress(object sender, KeyPressEventArgs e)
        {

            Mutu(sender, e);
        }

        private void radioButtonMutu6L_LostFocus(object sender, EventArgs e)
        {
            mlf();
        }

        private void radioButtonMutu7N_GotFocus(object sender, EventArgs e)
        {
            mgf();
        }

        private void radioButtonMutu7N_KeyPress(object sender, KeyPressEventArgs e)
        {

            Mutu(sender, e);
        }

        private void radioButtonMutu7N_LostFocus(object sender, EventArgs e)
        {
            mlf();
        }

        private void radioButtonMutu8KBP_GotFocus(object sender, EventArgs e)
        {
            mgf();
        }

        private void radioButtonMutu8KBP_KeyPress(object sender, KeyPressEventArgs e)
        {

            Mutu(sender, e);
        }

        private void radioButtonMutu8KBP_LostFocus(object sender, EventArgs e)
        {
            mlf();
        }

        private void radioButtonCacat4LPK_GotFocus(object sender, EventArgs e)
        {
            cgf();
        }

        private void radioButtonCacat4LPK_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cacat(sender, e);
        }

        private void radioButtonCacat4LPK_LostFocus(object sender, EventArgs e)
        {
            clf();
        }

        private void radioButtonCacat5GBT_GotFocus(object sender, EventArgs e)
        {
            cgf();
        }

        private void radioButtonCacat5GBT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cacat(sender, e);
        }

        private void radioButtonCacat5GBT_LostFocus(object sender, EventArgs e)
        {
            clf();
        }

        private void radioButton6OLG_GotFocus(object sender, EventArgs e)
        {
            cgf();
        }

        private void radioButton6OLG_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cacat(sender, e);
        }

        private void radioButton6OLG_LostFocus(object sender, EventArgs e)
        {
            clf();
        }

        private void radioButton7PTH_GotFocus(object sender, EventArgs e)
        {
            cgf();
        }

        private void radioButton7PTH_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cacat(sender, e);
        }

        private void radioButton7PTH_LostFocus(object sender, EventArgs e)
        {
            clf();
        }

        private void radioButtonCacat8ALM_GotFocus(object sender, EventArgs e)
        {
            cgf();
        }

        private void radioButtonCacat8ALM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cacat(sender, e);
        }

        private void radioButtonCacat8ALM_LostFocus(object sender, EventArgs e)
        {
            clf();
        }

        private void radioButton9QuareI_GotFocus(object sender, EventArgs e)
        {
            cgf();
        }

        private void radioButton9QuareI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cacat(sender, e);
        }

        private void radioButton9QuareI_LostFocus(object sender, EventArgs e)
        {
            clf();
        }

        private void buttonCancel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 09)
            {
                buttonClose.Focus();
            }
        }




    }
}