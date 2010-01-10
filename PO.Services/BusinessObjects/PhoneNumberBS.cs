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
    public class PhoneNumberBS : BusinessBase
    {
        public void Save(PHONE_NUMBERDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.PHONE_NUMBER);
        }

        public DataTable SelectAll()
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.PHONE_NUMBER";
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }

        public PHONE_NUMBERDataSet SelectByContactID(Guid pContactID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.PHONE_NUMBER WHERE ContactID = @ContactID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@ContactID", SqlDbType.UniqueIdentifier, pContactID));
            PHONE_NUMBERDataSet ds = new PHONE_NUMBERDataSet();
            dto.GetRecords(ds.PHONE_NUMBER, cmd);
            return ds;
        }

        public void DeleteByContactID(Guid pContactID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM PersonelOrganizerDb.dbo.PHONE_NUMBER
                                WHERE ContactID = @ContactID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@ContactID", SqlDbType.UniqueIdentifier, pContactID));
            dto.ExecuteSqlStatement(cmd);
        }
    }
}
