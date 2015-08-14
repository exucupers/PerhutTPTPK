using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;

namespace Perhutani
{
    public class ClassQuery
    {
        ClassConnection cKoneksi = new ClassConnection();

        public void Execute(string strSQL)
        {
            SqlCeCommand cmd = new SqlCeCommand(strSQL, cKoneksi.Con);
            if (cKoneksi.Con.State == ConnectionState.Closed) { cKoneksi.Con.Open(); }
            cmd.ExecuteNonQuery();
            if (cKoneksi.Con.State == ConnectionState.Open) { cKoneksi.Con.Close(); }
            cmd.Dispose();
        }
        public string hitungtotal(string NamaTabel)
        {
            string x="0";
            SqlCeDataReader dr;
            string sql = "select count (*) from "+NamaTabel+"";
            SqlCeCommand cmd = new SqlCeCommand(sql, cKoneksi.Con);
            if (cKoneksi.Con.State == ConnectionState.Closed) { cKoneksi.Con.Open(); }
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                x = "Total Scan : " + dr[0].ToString();
            }
            dr.Close();
            cmd.Dispose();     
            if (cKoneksi.Con.State == ConnectionState.Closed) { cKoneksi.Con.Open(); }
            return x;
        }
    }
}
