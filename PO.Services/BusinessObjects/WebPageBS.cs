﻿using System;
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
    public class WebPageBS : BusinessBase
    {
        public void Save(WEBPAGEDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.WEBPAGE);
        }

        public DataTable SelectAll()
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.WEBPAGE";
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }

        public WEBPAGEDataSet SelectByContactID(Guid pContactID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.WEBPAGE WHERE ContactID = @ContactID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@ContactID", SqlDbType.UniqueIdentifier, pContactID));
            WEBPAGEDataSet ds = new WEBPAGEDataSet();
            dto.GetRecords(ds.WEBPAGE, cmd);
            return ds;
        }

        public void DeleteByContactID(Guid pContactID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM PersonelOrganizerDb.dbo.WEBPAGE
                                WHERE ContactID = @ContactID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@ContactID", SqlDbType.UniqueIdentifier, pContactID));
            dto.ExecuteSqlStatement(cmd);
        }
    }
}
