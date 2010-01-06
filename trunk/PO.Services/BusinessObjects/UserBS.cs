using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PO.Types.Attributes;
using PO.Types.DataSets;
using PO.DataService;
using System.Data;
using System.Data.SqlClient;
using IB.EBakanlik.Services.Tools;

namespace PO.Services.BusinessObjects
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [DefaultDatabase("PersonelOrganizerDb")]
    public class UserBS : BusinessBase
    {
        public void KaydetGuncelle(PO_USERDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.PO_USER);
        }

        public DataTable SelectAll()
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.PO_USER";
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }

        public Guid IsUserValid(string pUserName, string pPassword)
        {
            Guid pUserId = Guid.Empty;
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.PO_USER
                                WHERE Password = @Password AND UserName = @UserName";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@UserName", SqlDbType.VarChar, pUserName));
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@Password", SqlDbType.VarChar, pPassword));
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["UserID"] != DBNull.Value)
                    pUserId = new Guid(dt.Rows[0]["UserID"].ToString());
            }

            return pUserId;
        }

    }
}
