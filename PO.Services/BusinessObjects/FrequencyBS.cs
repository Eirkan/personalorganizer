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
    public class FrequencyBS : BusinessBase
    {
        public void Save(TT_FREQUENCYDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.TT_FREQUENCY);
        }

        public TT_FREQUENCYDataSet SelectAll()
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.TT_FREQUENCY";
            TT_FREQUENCYDataSet ds = new TT_FREQUENCYDataSet();
            dto.GetRecords(ds.TT_FREQUENCY, cmd);
            return ds;
        }
    }
}
