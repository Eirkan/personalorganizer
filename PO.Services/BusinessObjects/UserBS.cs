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
using PO.Services.Tools;

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

        public void IsUserValid(out Guid pUserID, string pUserName, string pPassword, out string pName, out string pSurame)
        {
            pUserID = Guid.Empty;
            pName = String.Empty;
            pSurame = String.Empty;
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.PO_USER
                                WHERE Password = @Password AND UserName = @UserName";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@UserName", SqlDbType.VarChar, pUserName));
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@Password", SqlDbType.VarChar, pPassword));
            PO_USERDataSet ds = new PO_USERDataSet();
            dto.GetRecords(ds.PO_USER, cmd);
            if (ds.PO_USER.Rows.Count > 0)
            {
                PO_USERDataSet.PO_USERRow row = ds.PO_USER[0];
                pUserID = row.UserID;
                if (!row.IsNameNull())
                    pName = row.Name;
                if (!row.IsSurnameNull())
                    pSurame = row.Surname;
            }
        }

    }
}
