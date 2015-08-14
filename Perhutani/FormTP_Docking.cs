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
    public partial class FormTP_Docking : Form
    {
        public FormTP_Docking()
        {
            InitializeComponent();
        }
        
        ClassConnection cConnection = new ClassConnection();
        ClassQuery cQuery = new ClassQuery();

        private void ConvertTerimaTP()
        {
            try
            {
                SqlCeCommand cmdUp = new SqlCeCommand("SELECT * FROM TerimaTP", cConnection.Con);
                SqlCeDataReader drUp;
                int rec = 0;
                FileStream fs;
                if (File.Exists(@"Application\backup\Transfer\TRMTP" + ClassUser.HandheldID + ".csv"))
                {
                    File.Delete(@"Application\backup\Transfer\TRMTP" + ClassUser.HandheldID + ".csv");
                }
                fs = new FileStream(@"Application\Backup\Transfer\TRMTP" + ClassUser.HandheldID + ".csv", FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                string Teks, KodeKabupaten, KodeSertifikat, JenisTebangan, NoPetak, JenisKayu, KodeBKPH, UnitKPH, KodeTPK, ScanBarcode, NoPohon, NoPotonganDeel, Panjang, Diameter,Tanggal,Jam;
                //sw.WriteLine("KodeKabupaten,KodeSertifikat,JenisTebangan,NoPetak,JenisKayu,KodeBKPH,Unit+KPH,KodeTPK,ScanBarcode,NoPohon,NoPotonganDeel,Panjang,Diameter,DateTimeScan,Operator");
                //"KodeKabupaten;KodeSertifikat;JenisTebangan;NoPetak;JenisKayu;KodeBKPH;Unit+KPH;KodeTPK;
                //ScanBarcode;NoPohon;NoPotonganDeel;Panjang;Diameter;DateTimeScan
                if (cConnection.Con.State == ConnectionState.Closed) { cConnection.Con.Open(); }
                drUp = cmdUp.ExecuteReader();
                CultureInfo myCItrad = new CultureInfo("bg-BG", false);
                while (drUp.Read())
                {
                    KodeKabupaten = drUp["KodeKabupaten"].ToString().PadRight(3, ' ');
                    KodeSertifikat = drUp["KodeSertifikat"].ToString();
                    JenisTebangan = drUp["JenisTebangan"].ToString();
                    NoPetak = drUp["NoPetak"].ToString().PadRight(5, ' ');
                    JenisKayu = drUp["JenisKayu"].ToString().PadRight(2, ' ');
                    KodeBKPH = drUp["KodeBKPH"].ToString().PadRight(2, ' ');
                    UnitKPH = drUp["Unit+KPH"].ToString().PadRight(3, ' ');
                    KodeTPK = drUp["KodeTPK"].ToString().PadRight(2, ' ');
                    ScanBarcode = drUp["ScanBarcode"].ToString().PadRight(9, ' ');
                    NoPohon = drUp["NoPohon"].ToString().PadRight(4, ' ');
                    NoPotonganDeel = drUp["NoPotonganDeel"].ToString().PadRight(2, ' ');
                    Panjang = drUp["Panjang"].ToString().PadRight(5, ' ');
                    Diameter = drUp["Diameter"].ToString().PadRight(3, ' ');
                    Tanggal = Convert.ToDateTime(drUp["DateTimeScan"].ToString()).ToString("MM-dd-yy");
                    Jam = Convert.ToDateTime(drUp["DateTimeScan"].ToString()).ToString("HH:mm:ss");


                    //";;;;;Unit;
                    //;;;;; Barcode; petak;jenis kayu;kode bkkph; kode unit+kph;kode tpk;kode kabupaten;kd sertifikat; jenis tebangan; no pohon; no potongan; panjang; diameter; tanggal; jam; operator

                    //Teks = "" + KodeKabupaten + "," + KodeSertifikat + "," + JenisTebangan + "," + NoPetak + "," + JenisKayu + "," + KodeBKPH + "," + UnitKPH + "," + KodeTPK + "," + ScanBarcode + "," + NoPohon + "," + NoPotonganDeel + "," + Panjang + "," + Diameter + "," + DateTimeScan + "," + ClassUser.UserID + "";
                    Teks = "" + ScanBarcode + "," + NoPetak + "," + JenisKayu + "," + KodeBKPH + "," + UnitKPH + "," + KodeTPK + "," + KodeKabupaten + "," + KodeSertifikat + "," + JenisTebangan + "," + NoPohon + "," + NoPotonganDeel + "," + Panjang + "," + Diameter + "," + Tanggal + "," + Jam + "," + ClassUser.UserID + "";
                    sw.WriteLine(Teks);
                    rec += 1;
                }
                drUp.Close();
                cmdUp.Dispose();
                sw.Close();
                fs.Close();

                Cursor.Current = Cursors.Default;
                MessageBox.Show("Convert Data Terima TP Success (" + rec + " Terima TP Data)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                string strSQL = "DELETE FROM TerimaTP";
                cQuery.Execute(strSQL);
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        
        private void buttonTerimaTP_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Anda Yakin ingin mengconvert data ini?","Konfirmasi",MessageBoxButtons.OKCancel,MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.OK == pesan)
            {
                //convert
                try
                {
                   Cursor.Current = Cursors.WaitCursor;
                   byte count = 0;
                   SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM TerimaTP", cConnection.Con);
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
                       ConvertTerimaTP();

                       Cursor.Current = Cursors.Default;
                   }
                   else
                   {
                       Cursor.Current = Cursors.Default;
                       MessageBox.Show("Tidak ada data Terima TP", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                   }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    Cursor.Current = Cursors.Default;
                }
            }                       
        }

        private void buttonAngkutTP_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Anda Yakin ingin mengconvert data ini?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.OK == pesan)
            {
                //convert
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    byte count = 0;
                    SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM AngkutTP", cConnection.Con);
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
                        ConvertAngkutTP();

                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Tidak ada data Angkut TP", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    Cursor.Current = Cursors.Default;
                }
                
            } 
        }


        private void ConvertAngkutTP()
        {
            try
            {
                SqlCeCommand cmdUp = new SqlCeCommand("SELECT * FROM AngkutTP", cConnection.Con);
                SqlCeDataReader drUp;
                int rec = 0;
                FileStream fs;
                if (File.Exists(@"Application\backup\Transfer\ANGTP" + ClassUser.HandheldID +".csv"))
                {
                    File.Delete(@"Application\backup\Transfer\ANGTP" + ClassUser.HandheldID + ".csv");
                }
                fs = new FileStream(@"Application\Backup\Transfer\ANGTP" + ClassUser.HandheldID + ".csv", FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                CultureInfo myCItrad = new CultureInfo("bg-BG", false);
                string Teks, NoPolisi, NumeratorDK304, NamaTP, ScanBarcode, tanggal,jam;
                //sw.WriteLine("NoPolisi,NumeratorDK304,NamaTP,ScanBarcode,DatetimeScan,Operator");
                //"KodeKabupaten;KodeSertifikat;JenisTebangan;NoPetak;JenisKayu;KodeBKPH;Unit+KPH;KodeTPK;
                //ScanBarcode;NoPohon;NoPotonganDeel;Panjang;Diameter;DateTimeScan
                if (cConnection.Con.State == ConnectionState.Closed) { cConnection.Con.Open(); }
                drUp = cmdUp.ExecuteReader();
                while (drUp.Read())
                {
                    NoPolisi = drUp["NoPolisi"].ToString().PadRight(9,' ');
                    NumeratorDK304 = drUp["NumeratorDK304"].ToString().PadRight(6, ' ') ;
                    NamaTP = drUp["NamaTP"].ToString().PadRight(2, ' ');
                    ScanBarcode = drUp["ScanBarcode"].ToString();
                    //DatetimeScan = drUp["DatetimeScan"].ToString();
                    tanggal = Convert.ToDateTime(drUp["DateTimeScan"].ToString()).ToString("MM-dd-yy");
                    jam = Convert.ToDateTime(drUp["DateTimeScan"].ToString()).ToString("HH:mm:ss");

                    //";;;;;Unit;
                    //;;;;;
                    //Teks = "" + NoPolisi + "," + NumeratorDK304 + "," + NamaTP + "," + ScanBarcode + "," + DatetimeScan + "," + ClassUser.UserID + "";
                    Teks = "" + ScanBarcode + "," + NoPolisi + "," + NumeratorDK304 + "," + NamaTP + "," + tanggal + "," + jam + "," +ClassUser.UserID + "";
                    sw.WriteLine(Teks);
                    rec += 1;
                }
                drUp.Close();
                cmdUp.Dispose();
                sw.Close();
                fs.Close();

                Cursor.Current = Cursors.Default;
                MessageBox.Show("Convert Data Angkut TP Success (" + rec + " Angkut TP Data)", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                string strSQL = "DELETE FROM AngkutTP";
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

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTP_Docking_Load(object sender, EventArgs e)
        {
            statusBar1.Text = "User : " + ClassUser.UserID.ToString() + " | Id Hand Held : " + ClassUser.HandheldID;
        }

        private void buttonTerimaTP_GotFocus(object sender, EventArgs e)
        {
            buttonTerimaTP.BackColor = Color.Orange;
        }

        private void buttonTerimaTP_LostFocus(object sender, EventArgs e)
        {
            buttonTerimaTP.BackColor = Color.Gray;
        }

        private void buttonAngkutTP_GotFocus(object sender, EventArgs e)
        {
            buttonAngkutTP.BackColor = Color.Orange;
        }

        private void buttonAngkutTP_LostFocus(object sender, EventArgs e)
        {
            buttonAngkutTP.BackColor = Color.Gray;
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