using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;

namespace Perhutani
{
    public class ClassError
    {
        public string ComposeSqlErrorMessage(SqlCeException e)
        {
            SqlCeErrorCollection errorCollection = e.Errors;
            StringBuilder bld = new StringBuilder();

            Exception inner = e.InnerException;
            if ((inner != null))
            {
                bld.Append(("Inner Exception: " + inner.ToString()));
            }

            //SqlCeError err;
            foreach (SqlCeError err in errorCollection)
            {
                bld.Append("\r\n" + "Error:" + err.HResult.ToString("X"));
                bld.Append("\r\n" + err.Message);
                bld.Append("\r\n" + "Native Error:" + err.NativeError);
                bld.Append("\r\n" + err.Source);

                //int numPar;
                foreach (int numPar in err.NumericErrorParameters)
                {
                    if (numPar != 0)
                    {
                        bld.Append("\r\n" + "N-Parm:" + numPar.ToString());
                    }
                }

                //string errPar;
                foreach (string errPar in err.ErrorParameters)
                {
                    if (errPar != String.Empty)
                    {
                        bld.Append("\r\n" + "E-Parm:" + errPar);
                    }
                }
            }
            return bld.ToString();
        }
    }
}
