using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;

namespace Perhutani
{
    class ClassConnection
    {
        //public SqlCeConnection Con = new SqlCeConnection("Data Source=backup/PerhutaniScan.sdf");
        public SqlCeConnection Con = new SqlCeConnection("Data Source=Application/backup/PerhutaniScan.sdf");
        //public SqlCeConnection Con = new SqlCeConnection("Data Source=program files/perhutani/PerhutaniScan.sdf");
        public static string Status, KodeKAB, radio1, radio2, KodeBKPH, NoPetak, JenisKayu, KodeTPK, UnitKPH;
    
    }
}
