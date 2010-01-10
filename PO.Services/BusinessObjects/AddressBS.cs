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
    public class AddressBS : BusinessBase
    {
        public void Save(POSTAL_ADDRESSDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.POSTAL_ADDRESS);
        }

        public DataTable SelectAll()
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.POSTAL_ADDRESS";
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }

        public POSTAL_ADDRESSDataSet SelectByContactID(Guid pContactID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.POSTAL_ADDRESS WHERE ContactID = @ContactID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@ContactID", SqlDbType.UniqueIdentifier, pContactID));
            POSTAL_ADDRESSDataSet ds = new POSTAL_ADDRESSDataSet();
            dto.GetRecords(ds.POSTAL_ADDRESS, cmd);
            return ds;
        }

        public void DeleteByContactID(Guid pContactID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM PersonelOrganizerDb.dbo.POSTAL_ADDRESS
                                WHERE ContactID = @ContactID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@ContactID", SqlDbType.UniqueIdentifier, pContactID));
            dto.ExecuteSqlStatement(cmd);
        }
    }
}
