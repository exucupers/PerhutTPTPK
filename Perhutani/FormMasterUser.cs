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
    public partial class FormMasterUser : Form
    {
        public FormMasterUser()
        {
            InitializeComponent();
        }

        int pos;

        ClassConnection cKoneksi = new ClassConnection();
        ClassQuery cQuery = new ClassQuery();
        ClassError cError = new ClassError();

        private void FormMasterUser_Load(object sender, EventArgs e)
        {
            statusBar1.Text = "User : " + ClassUser.UserID.ToString() + " | Id Hand Held : " + ClassUser.HandheldID;
            try
            {
                DataSet ds = new DataSet();
                string strSQL = "SELECT * FROM Users";
                SqlCeDataAdapter da = new SqlCeDataAdapter(strSQL, cKoneksi.Con);
                da.Fill(ds, "Users");
                dataGridMasterUser.DataSource = ds.Tables[0];

                DataGridTableStyle ts = new DataGridTableStyle();
                dataGridMasterUser.TableStyles.Clear();
                ts.MappingName = "Users";

                DataGridTextBoxColumn col1 = new DataGridTextBoxColumn();
                col1.HeaderText = "Username";
                col1.MappingName = "Userid";
                col1.Width = 70;
                ts.GridColumnStyles.Add(col1);

                DataGridTextBoxColumn col2 = new DataGridTextBoxColumn();
                col2.HeaderText = "Password";
                col2.MappingName = "Password";
                col2.Width = 60;
                ts.GridColumnStyles.Add(col2);

                DataGridTextBoxColumn col3 = new DataGridTextBoxColumn();
                col3.HeaderText = "TP";
                col3.MappingName = "TP";
                col3.Width = 38;
                ts.GridColumnStyles.Add(col3);

                DataGridTextBoxColumn col4 = new DataGridTextBoxColumn();
                col4.HeaderText = "TPK";
                col4.MappingName = "TPK";
                col4.Width = 38;
                ts.GridColumnStyles.Add(col4);


                dataGridMasterUser.TableStyles.Add(ts);
                dataGridMasterUser.Refresh();

                ds.Tables.Clear();
                da.Dispose();
                ds.Dispose();
                dataGridMasterUser.Enabled = true;
                textBoxUser.Text = "";
                textBoxUser.Enabled = false;
                textBoxPass.Text = "";
                textBoxPass.Enabled = false;
                checkBoxTP.Enabled = false;
                checkBoxTPK.Enabled = false;
                buttonCancel.Enabled = false;
                buttonSave.Enabled = false;
                buttonInsert.Enabled = true;
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;

                SelectUser(0);
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(cError.ComposeSqlErrorMessage(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }

        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxUser.Text == "")
                {
                    textBoxUser.Focus();
                    textBoxUser.BackColor = Color.Red;
                    return;
                }
                textBoxUser.BackColor = Color.White;
                textBoxPass.Focus();
            }
        }

        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (textBoxPass.Text == "")
                {
                    textBoxPass.Focus();
                    textBoxPass.BackColor = Color.Red;
                    return;
                }
                textBoxPass.BackColor = Color.White;
                checkBoxTP.Focus();
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            dataGridMasterUser.Enabled = false;
            textBoxUser.Enabled = true;
            textBoxUser.Text = "";
            textBoxUser.Focus();
            textBoxPass.Enabled = true;
            textBoxPass.Text = "";
            checkBoxTP.Enabled = true;
            checkBoxTP.Checked = false;
            checkBoxTPK.Enabled = true;
            checkBoxTP.Checked = false;
            buttonInsert.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = true;
            buttonCancel.Enabled = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "")
            {
                MessageBox.Show("Pilih User Untuk Update", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                return;
            }
            dataGridMasterUser.Enabled = false;
            textBoxUser.Enabled = false;
            textBoxPass.Enabled = true;
            textBoxPass.Text = "";
            textBoxPass.Focus();
            checkBoxTP.Enabled = true;
            checkBoxTPK.Enabled = true;
            buttonInsert.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = true;
            buttonCancel.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text != "")
            {
                try
                {
                    DialogResult pesan;
                    pesan = MessageBox.Show("Hapus UserId (" + textBoxUser.Text.ToString() + ") ?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (pesan == DialogResult.OK)
                    {
                        string strSQL = "DELETE FROM Users WHERE UserID = '" + textBoxUser.Text + "'";
                        cQuery.Execute(strSQL);
                        FormMasterUser_Load(sender, e);
                    }
                }
                catch (SqlCeException ex)
                {
                    MessageBox.Show(cError.ComposeSqlErrorMessage(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Pilih User ID untuk di hapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                if (textBoxUser.Text == "")
                {
                    textBoxUser.Focus();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Simpan();
                FormMasterUser_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }
        private void Simpan()
        {
            if (textBoxUser.Enabled == true)
            {
                SqlCeDataReader dr;
                string str = "select * from users where userid='" + textBoxUser.Text + "'";
                SqlCeCommand cmd = new SqlCeCommand(str, cKoneksi.Con);
                if (cKoneksi.Con.State == ConnectionState.Closed) { cKoneksi.Con.Open(); }
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    cmd.Dispose();
                    if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
                    MessageBox.Show("" + textBoxUser.Text + " Sudah ada", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    dr.Close();
                    cmd.Dispose();
                    if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
                    string strSQL = "Insert into USERS values ('" + textBoxUser.Text + "','" + textBoxPass.Text + "','" + checkBoxTP.Checked + "','" + checkBoxTPK.Checked + "')";
                    cQuery.Execute(strSQL);
                    MessageBox.Show("Tambah User Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
            }
            if (textBoxUser.Enabled == false)
            {
                string strSQL = "Update USERS SET Password ='" + textBoxPass.Text + "', TP='" + checkBoxTP.Checked + "', TPK='" + checkBoxTPK.Checked + "' where UserID = '" + textBoxUser.Text + "'";
                cQuery.Execute(strSQL);
                MessageBox.Show("Update User Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormMasterUser_Load(sender, e);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridMasterUser_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                pos = dataGridMasterUser.CurrentRowIndex;
                SelectUser(pos);
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(cError.ComposeSqlErrorMessage(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }

        private void dataGridmasterUser_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                pos = dataGridMasterUser.CurrentRowIndex;
                SelectUser(pos);
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(cError.ComposeSqlErrorMessage(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }

        public void SelectUser(int x)
        {
            try
            {
                byte count = 0;
                SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Users", cKoneksi.Con);
                SqlCeDataReader dr;
                if (cKoneksi.Con.State == ConnectionState.Closed) { cKoneksi.Con.Open(); }
                dr = cmd.ExecuteReader();
                if (dr.Read()) { count = 1; } else { count = 0; }
                dr.Close(); cmd.Dispose(); if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
                if (count != 0)
                {
                    DataSet ds = new DataSet();
                    SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM Users", cKoneksi.Con);
                    da.Fill(ds, "Users");
                    textBoxUser.Text = ds.Tables["Users"].Rows[x][0].ToString();
                    textBoxPass.Text = ds.Tables["Users"].Rows[x][1].ToString();
                    checkBoxTP.Checked = Convert.ToBoolean(ds.Tables["Users"].Rows[x][2]); 
                    checkBoxTPK.Checked = Convert.ToBoolean(ds.Tables["Users"].Rows[x][3]);

                    ds.Dispose();
                    da.Dispose();
                }
                else
                {
                    MessageBox.Show("Data User Kosong", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    buttonClose.Focus();
                }
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(cError.ComposeSqlErrorMessage(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }

        private void checkBoxTP_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void checkBoxTPK_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        
            //if (e.KeyCode == Keys.F1)
            //{
            //    if (textBoxPass.Focus())
            //    {
            //        textBoxUser.Focus();
            //    }
            //    if (checkBoxTP.Focus())
            //    {
            //        textBoxPass.Focus();
            //    }
            //    if (checkBoxTPK.Focus())
            //    {
            //        checkBoxTP.Focus();
            //    }
            //}
        
    }
}