using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PO.Types.CustomTypes
{
    public class CDataSetMetaData
    {
        public string dataSetTypeName;
        public string fullTableName;
        public string autoIncrementColumnName;
        public string insertCommand;
        public SqlParameter[] insertParameterList;
        public string updateCommand;
        public SqlParameter[] updateParameterList;
        public string deleteCommand;
        public SqlParameter[] deleteParameterList;

        public CDataSetMetaData()
        {
            dataSetTypeName = string.Empty;
            fullTableName = string.Empty;
            autoIncrementColumnName = string.Empty;
            insertCommand = string.Empty;
            updateCommand = string.Empty;
            deleteCommand = string.Empty;

        }

    }
}
