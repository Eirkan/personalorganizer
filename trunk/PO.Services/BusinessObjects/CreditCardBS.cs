using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PO.Types.Attributes;
using PO.DataService;
using PO.Types.DataSets;
using System.Data.SqlClient;
using IB.EBakanlik.Services.Tools;
using System.Data;

namespace PO.Services.BusinessObjects
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [DefaultDatabase("PersonelOrganizerDb")]
    public class CreditCardBS : BusinessBase
    {
        public void Save(CREDIT_CARDDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.CREDIT_CARD);
        }

        public DataTable SelectByUserID(Guid pUserID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT 
                                  C.*
                                  , B.BankName
                                FROM PersonelOrganizerDb.dbo.CREDIT_CARD AS C INNER JOIN PersonelOrganizerDb.dbo.TT_BANK AS B
                                ON C.BankID = B.BankID
                                WHERE UserID = @UserID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@UserID", SqlDbType.UniqueIdentifier, pUserID));
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }

        public CREDIT_CARDDataSet SelectDataSetByUserID(Guid pUserID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT *
                                FROM PersonelOrganizerDb.dbo.CREDIT_CARD AS C 
                                WHERE UserID = @UserID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@UserID", SqlDbType.UniqueIdentifier, pUserID));
            CREDIT_CARDDataSet ds = new CREDIT_CARDDataSet();
            dto.GetRecords(ds.CREDIT_CARD, cmd);
            return ds;
        }

        public void DeleteByCreditCardID(Guid pCreditCard)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM PersonelOrganizerDb.dbo.CREDIT_CARD
                                WHERE CreditCardID = @CreditCardID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@CreditCardID", SqlDbType.UniqueIdentifier, pCreditCard));
            dto.ExecuteSqlStatement(cmd);
        }
    }
}
