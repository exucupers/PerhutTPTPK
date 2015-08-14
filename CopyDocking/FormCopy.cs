using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenNETCF.Desktop.Communication;
using System.IO;

namespace CopyDocking
{
    public partial class FormCopy : Form
    {
        public FormCopy()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult pesan;
                pesan = MessageBox.Show("Download data dari PDT?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (pesan == DialogResult.OK)
                {
                    label1.Text = "";
                    using (RAPI MyRapi = new RAPI())
                    if (MyRapi.DevicePresent)
                    {
                        int x = 0;
                        MyRapi.Connect(true);
                        string pc = @"" + textBox2.Text;
                        string pdt = @"\Application\Backup\Transfer\";
                        var fl = MyRapi.EnumFiles(pdt + @"\*");
                        if (fl == null)
                        {
                            MessageBox.Show("File Tidak Ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            return;
                        }
                        bool Hapus = false;
                        if (checkBox1.Checked == true)
                        {
                            Hapus = true;
                        }
                        //DialogResult dr = MessageBox.Show("Delete Data di PDT ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        //if (DialogResult.Yes == dr)
                        //{
                        //    Hapus = true;
                        //}
                        foreach (FileInformation file in fl)
                        {
                            if (File.Exists(pc + "\\" + file.FileName))
                            {
                                File.Delete(pc + "\\" + file.FileName);
                            }
                            MyRapi.CopyFileFromDevice(pc + "\\" + file.FileName, pdt + "\\" + file.FileName);
                            if (Hapus)
                            {
                                MyRapi.DeleteDeviceFile(pdt + "\\" + file.FileName);
                            }
                            
                            x++;
                            label1.Text = "Mohon Tunggu";
                        }

                        MyRapi.Disconnect();

                        if (x != 0)
                        {
                            label1.Text = "Copy Berhasil";
                            MessageBox.Show("Copy file to "+textBox2.Text+" berhasil.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        label1.Text = "Please Connect to the Mobile Device";
                        MessageBox.Show("Please Connect to the Mobile Device", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }                           
        }

        private void FormCopy_Load(object sender, EventArgs e)
        {

        }

    }
}
