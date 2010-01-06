using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PO.DataService
{
    public interface IPODataObject
    {
        bool IsDataObjectTransactional
        { get; }
        void CommitTransaction();
        void RollbackTransaction();
        int ExecuteSqlStatement(SqlCommand pCommand);
        void GetRecords(DataTable pDataTable, SqlCommand pCommand);
        void GetRecords(DataTable pDataTable, SqlCommand pCommand, bool ignoreSchema);
        void GetRecords(DataTable pDataTable, SqlCommand pCommand, bool ignoreSchema, LoadOption? pLoadOption);
        void Update(DataTable pDataTable, SqlCommand pCommand);
        void Update(DataTable pDataTable);
        void Update(DataTable pDataTable, bool pAcceptChangesDuringUpdate, bool pContinueUpdateonError);
        object ExecuteScalar(SqlCommand pCommand);
    }
}

