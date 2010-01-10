using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PO.DataService;
using System.Data;
using System.Data.SqlClient;
using PO.Services.Tools;
using System.ServiceModel;
using PO.Types.Attributes;
using PO.Types.DataSets;

namespace PO.Services.BusinessObjects
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [DefaultDatabase("PersonelOrganizerDb")]
    public class IncomeBS : BusinessBase
    {
        public void Save(INCOMEDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.INCOME);
        }

        public DataTable SelectByUserID(Guid pUserID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT 
                                    I.*
	                                , IC.IncomeCategoryName 
                                FROM PersonelOrganizerDb.dbo.INCOME AS I
                                    INNER JOIN PersonelOrganizerDB.dbo.TT_INCOME_CATEGORY AS IC ON I.IncomeCategoryID = IC.IncomeCategoryID
                                WHERE I.UserID = @UserID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@UserID", SqlDbType.UniqueIdentifier, pUserID));
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }

        public INCOMEDataSet SelectDataSetByUserID(Guid pUserID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.INCOME
                                WHERE UserID = @UserID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@UserID", SqlDbType.UniqueIdentifier, pUserID));
            INCOMEDataSet ds = new INCOMEDataSet();
            dto.GetRecords(ds.INCOME, cmd);
            return ds;
        }

        public void DeleteByIncomeID(Guid pIncomeID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM PersonelOrganizerDb.dbo.INCOME
                                WHERE IncomeID = @IncomeID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@IncomeID", SqlDbType.UniqueIdentifier, pIncomeID));
            dto.ExecuteSqlStatement(cmd);
        }
    }
}
