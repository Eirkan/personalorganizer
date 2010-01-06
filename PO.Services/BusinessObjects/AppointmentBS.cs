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
    public class AppointmentBS : BusinessBase
    {
        public void KaydetGuncelle(APPOINTMENTDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.APPOINTMENT);
        }

        public DataTable SelectAll()
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.APPOINTMENT";
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }

    }
}
