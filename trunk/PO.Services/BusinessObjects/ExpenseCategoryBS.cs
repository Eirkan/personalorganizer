using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PO.DataService;
using System.Data;
using System.Data.SqlClient;
using IB.EBakanlik.Services.Tools;
using System.ServiceModel;
using PO.Types.Attributes;
using PO.Types.DataSets;

namespace PO.Services.BusinessObjects
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [DefaultDatabase("PersonelOrganizerDb")]
    public class ExpenseCategoryBS : BusinessBase
    {
        public void Save(TT_EXPENSE_CATEGORYDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.TT_EXPENSE_CATEGORY);
        }

        public TT_EXPENSE_CATEGORYDataSet SelectAll()
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.TT_EXPENSE_CATEGORY";
            TT_EXPENSE_CATEGORYDataSet ds = new TT_EXPENSE_CATEGORYDataSet();
            dto.GetRecords(ds.TT_EXPENSE_CATEGORY, cmd);
            return ds;
        }
    }
}
