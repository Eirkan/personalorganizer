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
    public class ExpenseBillBS : BusinessBase
    {
        public void Save(EXPENSE_BILLDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.EXPENSE_BILL);
        }

        public DataTable SelectByUserID(Guid pUserID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT 
                                    E.*
	                                , EC.ExpenseCategoryName
                                    , I.NumberOfInstallment
	                                , I.TotalAmount
                                FROM PersonelOrganizerDb.dbo.EXPENSE_BILL AS E
                                  LEFT OUTER JOIN PersonelOrganizerDB.dbo.TT_EXPENSE_CATEGORY AS EC ON E.ExpenseCategory = EC.ExpenseCategoryID
                                  LEFT OUTER JOIN PersonelOrganizerDB.dbo.INSTALLMENT AS I ON I.InstallmentID = E.InstallmentID 
                                WHERE E.UserID = @UserID
                                ORDER BY E.Subject, E.DueDate";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@UserID", SqlDbType.UniqueIdentifier, pUserID));
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }

        public EXPENSE_BILLDataSet SelectDataSetByExpenseID(Guid pExpenseID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.EXPENSE_BILL
                                WHERE ExpenseBillID = @ExpenseBillID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@ExpenseBillID", SqlDbType.UniqueIdentifier, pExpenseID));
            EXPENSE_BILLDataSet ds = new EXPENSE_BILLDataSet();
            dto.GetRecords(ds.EXPENSE_BILL, cmd);
            return ds;
        }

        public void DeleteByExpenseBillID(Guid pExpenseBillID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM PersonelOrganizerDb.dbo.EXPENSE_BILL
                                WHERE ExpenseBillID = @ExpenseBillID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@ExpenseBillID", SqlDbType.UniqueIdentifier, pExpenseBillID));
            dto.ExecuteSqlStatement(cmd);
        }

        public void DeleteByInstallmentID(Guid pInstallmentID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"
                                BEGIN TRAN;
                                
                                DELETE FROM PersonelOrganizerDb.dbo.EXPENSE_BILL
                                WHERE InstallmentID = @InstallmentID

                                DELETE FROM PersonelOrganizerDb.dbo.INSTALLMENT
                                WHERE InstallmentID = @InstallmentID
    
                                COMMIT TRAN;";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@InstallmentID", SqlDbType.UniqueIdentifier, pInstallmentID));
            dto.ExecuteSqlStatement(cmd);
        }

        public int SelectCreditCardID(Guid pCreditCardID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT SUM(Amount) AS Limit
                                FROM PersonelOrganizerDb.dbo.EXPENSE_BILL 
                                WHERE CreditCardID = @CreditCardID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@CreditCardID", SqlDbType.UniqueIdentifier, pCreditCardID));
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            if (dt.Rows[0]["Limit"] != DBNull.Value)
                return Convert.ToInt32(dt.Rows[0]["Limit"]);

            return 0;
        }
    }
}
