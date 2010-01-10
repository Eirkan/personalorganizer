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
    public class BankBS : BusinessBase
    {
        public void Save(TT_BANKDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.TT_BANK);
        }

        public TT_BANKDataSet SelectAll()
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.TT_BANK";
            TT_BANKDataSet ds = new TT_BANKDataSet();
            dto.GetRecords(ds.TT_BANK, cmd);
            return ds;
        }
    }
}
