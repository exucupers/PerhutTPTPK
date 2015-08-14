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
    public partial class FormDockingTP : Form
    {
        public FormDockingTP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult pesan;
                pesan = MessageBox.Show("Convert To Report.csv ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (DialogResult.OK == pesan)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    byte count = 0;
                    SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM TrScan", cConnection.con);
                    SqlCeDataReader dr;
                    if (cConnection.con.State == ConnectionState.Closed) { cConnection.con.Open(); }
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
                    if (cConnection.con.State == ConnectionState.Open) { cConnection.con.Close(); }
                    if (count != 0)
                    {
                        SqlCeCommand cmdUp = new SqlCeCommand("SELECT * FROM TrScan", cConnection.con);
                        SqlCeDataReader drUp;
                        int rec = 0;
                        FileStream fs;
                        if (File.Exists(@"SD Card\backup\Report.csv"))
                        {
                            File.Delete(@"SD Card\backup\Report.csv");
                        }
                        fs = new FileStream(@"Backup\Report.csv", FileMode.Create, FileAccess.ReadWrite);
                        StreamWriter sw = new StreamWriter(fs);
                        string Teks, Teks2, OBD, MATERIAL, JUMLAH, BATCH_1, BATCH_2, STATUS, OK_QTY, ERROR_QTY, USER, DATE_SCAN, TIME_SCAN;
                        sw.WriteLine("OBD;MATERIAL;BATCH_1;BATCH_2;STATUS;USER;DATE_SCAN;TIME_SCAN");
                        if (cConnection.con.State == ConnectionState.Closed) { cConnection.con.Open(); }
                        drUp = cmdUp.ExecuteReader();
                        while (drUp.Read())
                        {
                            OBD = drUp["OBD"].ToString();
                            MATERIAL = drUp["MATERIAL"].ToString();
                            BATCH_1 = drUp["BATCH_1"].ToString();
                            BATCH_2 = drUp["BATCH_2"].ToString();
                            STATUS = drUp["STATUS"].ToString();
                            USER = drUp["UserID"].ToString();
                            DATE_SCAN = drUp["DATE_SCAN"].ToString();
                            TIME_SCAN = drUp["TIME_SCAN"].ToString();
                            Teks = "" + OBD + ";" + MATERIAL + ";" + BATCH_1 + ";" + BATCH_2 + ";" + STATUS + ";" + USER + ";" + DATE_SCAN + ";" + TIME_SCAN + "";
                            sw.WriteLine(Teks);
                            rec += 1;
                        }
                        drUp.Close();
                        cmdUp.Dispose();
                        SqlCeCommand cmd2 = new SqlCeCommand("SELECT OBD,MATERIAL,JUMLAH, SUM (OK_QTY) as OK_QTY, SUM (ERROR_QTY) as ERROR_QTY, UserID from TrScan group by OBD , MATERIAL,JUMLAH,UserID ", cConnection.con);
                        SqlCeDataReader dr2;
                        int rec2 = 0;
                        //fs = new FileStream(@"Backup\report.csv", FileMode.Create, FileAccess.ReadWrite);
                        //sw = new StreamWriter(fs);
                        sw.WriteLine("");
                        sw.WriteLine("OBD;Material;JUMLAH;OK_QTY;ERROR_QTY;USER");
                        if (cConnection.con.State == ConnectionState.Closed) { cConnection.con.Open(); }
                        dr2 = cmd2.ExecuteReader();
                        while (dr2.Read())
                        {
                            OBD = dr2["OBD"].ToString();
                            MATERIAL = dr2["MATERIAL"].ToString();
                            JUMLAH = dr2["JUMLAH"].ToString();
                            OK_QTY = dr2["OK_QTY"].ToString();
                            ERROR_QTY = dr2["ERROR_QTY"].ToString();
                            USER = dr2["UserID"].ToString();
                            Teks2 = "" + OBD + ";" + MATERIAL + ";" + JUMLAH + ";" + OK_QTY + ";" + ERROR_QTY + ";" + USER + "";
                            sw.WriteLine(Teks2);
                            rec2 += 1;
                        }
                        sw.Close();
                        fs.Close();
                        dr2.Close();
                        cmd2.Dispose();
                        if (cConnection.con.State == ConnectionState.Open) { cConnection.con.Close(); }

                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Convert " + rec + " OBD Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        string strSQL = "DELETE FROM TrScan";
                        cQuery.Execute(strSQL);
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Data is empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                Cursor.Current = Cursors.Default;
            }
        }
    }
}