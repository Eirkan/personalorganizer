using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PO.Services.Tools
{
    internal static class ParameterBuilder
    {
        internal static SqlParameter CreateSqlParameter(string pParamName, SqlDbType pSqltype, object pValue)
        {
            SqlParameter mParam = new SqlParameter(pParamName, pSqltype);

            if (pValue == null)
                mParam.Value = DBNull.Value;
            //aramalarda boş string gonderirken dbnulla cevirilmesi kapatılmıştır. Aramalarda boş gonderilirse hepsi gelsin anlamını taşıyor.
            //else if(pValue.GetType() == typeof(string) && string.IsNullOrEmpty(pValue.ToString()))
            //    mParam.Value = DBNull.Value;
            else
                mParam.Value = pValue;

            return mParam;
        }

        internal static SqlParameter CreateSqlParameter(string pParamName, SqlDbType pSqltype, object pValue, int pParameterSize)
        {
            SqlParameter mParam = new SqlParameter(pParamName, pSqltype, pParameterSize);

            if (pValue == null)
                mParam.Value = DBNull.Value;
            //aramalarda boş string gonderirken dbnulla cevirilmesi kapatılmıştır. Aramalarda boş gonderilirse hepsi gelsin anlamını taşıyor.
            //else if(pValue.GetType() == typeof(string) && string.IsNullOrEmpty(pValue.ToString()))
            //    mParam.Value = DBNull.Value;
            else
                mParam.Value = pValue;

            return mParam;
        }

    }
}
