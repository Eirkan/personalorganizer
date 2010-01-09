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
    public class InstallmentBS : BusinessBase
    {
        public void Save(INSTALLMENTDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.INSTALLMENT);
        }

        public INSTALLMENTDataSet SelectByInstallmentID(Guid pInstallmentID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.INSTALLMENT
                                WHERE InstallmentID = @InstallmentID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@InstallmentID", SqlDbType.UniqueIdentifier, pInstallmentID));
            INSTALLMENTDataSet ds = new INSTALLMENTDataSet();
            dto.GetRecords(ds.INSTALLMENT, cmd);
            return ds;
        }

        public void DeleteByInstallmentID(Guid pInstallmentID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM PersonelOrganizerDb.dbo.INSTALLMENT
                                WHERE InstallmentID = @InstallmentID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@InstallmentID", SqlDbType.UniqueIdentifier, pInstallmentID));
            dto.ExecuteSqlStatement(cmd);
        }
    }
}
