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
using System.Globalization;

namespace Perhutani
{
    public partial class FormTPK_Docking : Form
    {
        public FormTPK_Docking()
        {
            InitializeComponent();
        }

        ClassConnection cConnection = new ClassConnection();
        ClassQuery cQuery = new ClassQuery();

        private void buttonTerimaTPK_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Anda Yakin ingin mengconvert data ini?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.OK == pesan)
            {
                //convert
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    byte count = 0;
                    SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM TerimaTPK", cConnection.Con);
                    SqlCeDataReader dr;
                    if (cConnection.Con.State == ConnectionState.Closed) { cConnection.Con.Open(); }
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        count = 1;
                    }
                    else
                    {
                        count = 0;
                    }
                    dr.Close();
                    cmd.Dispose();

                    if (cConnection.Con.State == ConnectionState.Open) { cConnection.Con.Close(); }
                    if (count != 0)
                    {
                        ConvertTerimaTPK();

                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Tidak ada data Terima TPK", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    Cursor.Current = Cursors.Default;
                }

            } 
        }

        private void ConvertTerimaTPK()
        {
            try
            {
                SqlCeCommand cmdUp = new SqlCeCommand("SELECT * FROM TerimaTPK", cConnection.Con);
                SqlCeDataReader drUp;
                int rec = 0;
                FileStream fs;
                if (File.Exists(@"Application\backup\Transfer\TRTPK" + ClassUser.HandheldID + ".csv"))
                {
                    File.Delete(@"Application\backup\Transfer\TRTPK" + ClassUser.HandheldID + ".csv");
                }
                fs = new FileStream(@"Application\backup\Transfer\TRTPK" + ClassUser.HandheldID +".csv", FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                string Teks, ScanBarcode, Mutu, Status, CacatKayu,tanggal,jam;
                //sw.WriteLine("ScanBarcode,Mutu,Status,CacatKayu,DateTimeScan,Operator");
                //"KodeKabupaten;KodeSertifikat;JenisTebangan;NoPetak;JenisKayu;KodeBKPH;Unit+KPH;KodeTPK;
                //ScanBarcode;NoPohon;NoPotonganDeel;Panjang;Diameter;DateTimeScan
                if (cConnection.Con.State == ConnectionState.Closed) { cConnection.Con.Open(); }
                drUp = cmdUp.ExecuteReader();
                while (drUp.Read())
                {
                    ScanBarcode = drUp["ScanBarcode"].ToString();
                    Mutu = drUp["Mutu"].ToString();
                    Status = drUp["Status"].ToString();
                    CacatKayu = drUp["CacatKayu"].ToString();

                    tanggal = Convert.ToDateTime(drUp["DateTimeScan"].ToString()).ToString("MM-dd-yy");
                    jam = Convert.ToDateTime(drUp["DateTimeScan"].ToString()).ToString("HH:mm:ss");

                
                    //";;;;;Unit;
                    //;;;;;
                    Teks = "" + ScanBarcode + "," + Mutu + "," + Status + "," + CacatKayu + "," + tanggal + "," + jam + "," + ClassUser.UserID + "";
                    sw.WriteLine(Teks);
                    rec += 1;
                }

                drUp.Close();
                cmdUp.Dispose();
                sw.Close();
                fs.Close();

                Cursor.Current = Cursors.Default;
                MessageBox.Show("Convert Data Terima TPK Success (" + rec + " Terima TPK Data)", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                string strSQL = "DELETE FROM TerimaTPK";
                cQuery.Execute(strSQL);
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void buttoKavlingTPK_Click(object sender, EventArgs e)
        
        {
            DialogResult pesan = MessageBox.Show("Anda Yakin ingin mengconvert data ini?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.OK == pesan)
            {
                //convert
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    byte count = 0;
                    SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Kavling", cConnection.Con);
                    SqlCeDataReader dr;
                    if (cConnection.Con.State == ConnectionState.Closed) { cConnection.Con.Open(); }
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        count = 1;
                    }
                    else
                    {
                        count = 0;
                    }
                    dr.Close();
                    cmd.Dispose();

                    if (cConnection.Con.State == ConnectionState.Open) { cConnection.Con.Close(); }
                    if (count != 0)
                    {
                        ConvertKavling();

                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Tidak ada data Kavling TPK", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    Cursor.Current = Cursors.Default;
                }

            } 
        }

        private void ConvertKavling()
        {
            try
            {
                SqlCeCommand cmdUp = new SqlCeCommand("SELECT * FROM Kavling", cConnection.Con);
                SqlCeDataReader drUp;
                int rec2 = 0;
                FileStream fs;
                if (File.Exists(@"Application\backup\Transfer\KATPK" + ClassUser.HandheldID +".csv"))
                {
                    File.Delete(@"Application\backup\Transfer\KATPK" + ClassUser.HandheldID + ".csv");
                }
                fs = new FileStream(@"Application\Backup\Transfer\KATPK" + ClassUser.HandheldID + ".csv", FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                string Teks, Blok, SubBlok, NoKavling, ScanBarcode,tanggal,jam;
                //sw.WriteLine("Blok,SubBlok,NoKavling,ScanBarcode,DateTimeScan,Operator");
                
                if (cConnection.Con.State == ConnectionState.Closed) { cConnection.Con.Open(); }
                drUp = cmdUp.ExecuteReader();
                while (drUp.Read())
                {
                    Blok = drUp["Blok"].ToString();
                    SubBlok = drUp["SubBlok"].ToString();
                    NoKavling = drUp["NoKavling"].ToString().PadRight(9, ' ');
                    ScanBarcode = drUp["ScanBarcode"].ToString();

                    tanggal = Convert.ToDateTime(drUp["DateTimeScan"].ToString()).ToString("MM-dd-yy");
                    jam = Convert.ToDateTime(drUp["DateTimeScan"].ToString()).ToString("HH:mm:ss");

                    Teks = "" + ScanBarcode + "," + Blok + "," + SubBlok + "," + NoKavling + "," + tanggal + "," + jam + "," + ClassUser.UserID + "";
                    sw.WriteLine(Teks);
                    rec2 += 1;
                }
                drUp.Close();
                cmdUp.Dispose();
                sw.Close();
                fs.Close();

                Cursor.Current = Cursors.Default;
                MessageBox.Show("Convert Data Kavling TPK Success (" + rec2 + " Kavling TPK Data)", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                string strSQL = "DELETE FROM Kavling";
                cQuery.Execute(strSQL);
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonAngkutTPK_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Anda Yakin ingin mengconvert data ini?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.OK == pesan)
            {
                //convert
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    byte count = 0;
                    SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM AngkutTPK", cConnection.Con);
                    SqlCeDataReader dr;
                    if (cConnection.Con.State == ConnectionState.Closed) { cConnection.Con.Open(); }
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        count = 1;
                    }
                    else
                    {
                        count = 0;
                    }
                    dr.Close();
                    cmd.Dispose();

                    if (cConnection.Con.State == ConnectionState.Open) { cConnection.Con.Close(); }
                    if (count != 0)
                    {
                        ConvertAngkutTPK();

                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Tidak ada data Angkut TPK", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    Cursor.Current = Cursors.Default;
                }

            } 
        }

        private void ConvertAngkutTPK()
        {
            try
            {
                SqlCeCommand cmdUp = new SqlCeCommand("SELECT * FROM AngkutTPK", cConnection.Con);
                SqlCeDataReader drUp;
                int rec3 = 0;
                FileStream fs;
                if (File.Exists(@"Application\backup\Transfer\ANTPK" + ClassUser.HandheldID + ".csv"))
                {
                    File.Delete(@"Application\backup\Transfer\ANTPK" + ClassUser.HandheldID + ".csv");
                }
                fs = new FileStream(@"Application\Backup\Transfer\ANTPK" + ClassUser.HandheldID + ".csv", FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                string Teks, NoPolisi, NoKavling, TujuanAngkut, ScanBarcode,tanggal,jam;
                //sw.WriteLine("NoPolisi,NoKavling,TujuanAngkut,ScanBarcode,DateTimeScan,Operator");
                CultureInfo myCItrad = new CultureInfo("bg-BG", false);
                if (cConnection.Con.State == ConnectionState.Closed) { cConnection.Con.Open(); }
                drUp = cmdUp.ExecuteReader();
                while (drUp.Read())
                {
                    NoPolisi = drUp["NoPolisi"].ToString().PadRight(9, ' ');
                    NoKavling = drUp["NoKavling"].ToString().PadRight(9, ' ');
                    TujuanAngkut = drUp["TujuanAngkut"].ToString().PadRight(6, ' ');
                    ScanBarcode = drUp["ScanBarcode"].ToString();

                    tanggal = Convert.ToDateTime(drUp["DateTimeScan"].ToString()).ToString("MM-dd-yy");
                    jam = Convert.ToDateTime(drUp["DateTimeScan"].ToString()).ToString("HH:mm:ss");

                    Teks = "" + ScanBarcode + "," + NoPolisi + "," + NoKavling + "," + TujuanAngkut + "," + tanggal + "," + jam + "," + ClassUser.UserID + "";
                    sw.WriteLine(Teks);
                    rec3 += 1;
                }
                drUp.Close();
                cmdUp.Dispose();
                sw.Close();
                fs.Close();

                Cursor.Current = Cursors.Default;
                MessageBox.Show("Convert Data Angkut TPK Success (" + rec3 + " Angkut TPK Data)", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                string strSQL = "DELETE FROM AngkutTPK";
                cQuery.Execute(strSQL);
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTPK_Docking_Load(object sender, EventArgs e)
        {
            statusBar1.Text = "User : " + ClassUser.UserID.ToString() + " | Id Hand Held : " + ClassUser.HandheldID;
        }

        private void buttonTerimaTPK_GotFocus(object sender, EventArgs e)
        {
            buttonTerimaTPK.BackColor = Color.Orange;
        }

        private void buttonTerimaTPK_LostFocus(object sender, EventArgs e)
        {
            buttonTerimaTPK.BackColor = Color.Gray;
        }

        private void buttoKavlingTPK_GotFocus(object sender, EventArgs e)
        {
            buttoKavlingTPK.BackColor = Color.Orange;
        }

        private void buttoKavlingTPK_LostFocus(object sender, EventArgs e)
        {
            buttoKavlingTPK.BackColor = Color.Gray;
        }

        private void buttonAngkutTPK_GotFocus(object sender, EventArgs e)
        {
            buttonAngkutTPK.BackColor = Color.Orange;
        }

        private void buttonAngkutTPK_LostFocus(object sender, EventArgs e)
        {
            buttonAngkutTPK.BackColor = Color.Gray;
        }

        private void buttonClose_GotFocus(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Orange;
        }

        private void buttonClose_LostFocus(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Gray;
        }
    }
}