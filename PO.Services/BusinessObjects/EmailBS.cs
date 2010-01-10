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
    public class EmailBS : BusinessBase
    {
        public void Save(EMAILDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.EMAIL);
        }

        public DataTable SelectAll()
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.EMAIL";
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }

        public EMAILDataSet SelectByContactID(Guid pContactID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.EMAIL WHERE ContactID = @ContactID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@ContactID", SqlDbType.UniqueIdentifier, pContactID));
            EMAILDataSet ds = new EMAILDataSet();
            dto.GetRecords(ds.EMAIL, cmd);
            return ds;
        }

        public void DeleteByContactID(Guid pContactID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM PersonelOrganizerDb.dbo.EMAIL
                                WHERE ContactID = @ContactID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@ContactID", SqlDbType.UniqueIdentifier, pContactID));
            dto.ExecuteSqlStatement(cmd);
        }
    }
}
