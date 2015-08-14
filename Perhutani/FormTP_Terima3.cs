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
    public partial class FormTP_Terima3 : Form
    {
        public FormTP_Terima3()
        {
            InitializeComponent();
            tabPage1.AutoScroll = true;
        }

        void Kondisi1()
        {
            tabPage1.Show();
            tabPage2.Hide();
        }
        void Kondisi2()
        {
            tabPage1.Hide();
            tabPage2.Show();
        }

        private void buttonClear2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDiameter_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPanjang_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxNoPotongan_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxNoPohon_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKodeTPK_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxUnitKPH_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
            Kondisi2();
            textBoxBarcode.Focus();
        }

        private void FormTP_Terima3_Load(object sender, EventArgs e)
        {
            Kondisi1();
            textBoxKodeKAB.Focus();
        }



        private void textBoxKodeKAB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}