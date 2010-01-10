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
    public class IncomeCategoryBS : BusinessBase
    {
        public void Save(TT_INCOME_CATEGORYDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.TT_INCOME_CATEGORY);
        }

        public TT_INCOME_CATEGORYDataSet SelectAll()
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.TT_INCOME_CATEGORY";
            TT_INCOME_CATEGORYDataSet ds = new TT_INCOME_CATEGORYDataSet();
            dto.GetRecords(ds.TT_INCOME_CATEGORY, cmd);
            return ds;
        }
    }
}
