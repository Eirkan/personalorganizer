using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PO.Types.Attributes;
using PO.DataService;
using PO.Types.DataSets;
using System.Data.SqlClient;
using System.Data;
using PO.Services.Tools;

namespace PO.Services.BusinessObjects
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [DefaultDatabase("PersonelOrganizerDb")]
    public class BudgetBS : BusinessBase
    {
        public DataTable SelectTransactions(DateTime dtStart, DateTime dtFinish)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"WITH LISTE AS 
                                (
	                                SELECT 
		                                I.[Subject]
		                                , I.[Date]
                                        , IC.IncomeCategoryName AS CategoryName
		                                , I.Amount
	                                FROM PersonelOrganizerDB.dbo.INCOME AS I
                                        INNER JOIN PersonelOrganizerDB.dbo.TT_INCOME_CATEGORY AS IC ON IC.IncomeCategoryID = I.IncomeCategoryID 
	                                WHERE I.[Date] BETWEEN @dtStart AND @dtFinish
	                                UNION ALL
	                                SELECT 
		                                E.[Subject]
		                                , E.DueDate
                                        , EC.ExpenseCategoryName AS CategoryName
		                                , E.Amount * -1 AS Amount
	                                FROM PersonelOrganizerDB.dbo.EXPENSE_BILL AS E
                                          INNER JOIN PersonelOrganizerDB.dbo.TT_EXPENSE_CATEGORY AS EC ON EC.ExpenseCategoryID = E.ExpenseCategory
	                                WHERE E.DueDate BETWEEN @dtStart AND @dtFinish
                                )
                                , TOPLAM AS
                                (
	                                SELECT	
		                                'TOPLAM' AS [Subject]
		                                , NULL AS [Date]
	                                    , NULL AS CategoryName
		                                , SUM(Amount) AS Amount
	                                FROM LISTE
                                )
                                SELECT * FROM LISTE 
                                UNION ALL
                                SELECT * FROM TOPLAM";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@dtStart", SqlDbType.DateTime, dtStart));
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@dtFinish", SqlDbType.DateTime, dtFinish));
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }

        public DataTable SelectMonthlyBudget(int pMonth, int pCategory)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"WITH LISTE AS 
                                (
	                                SELECT 
		                                I.[Subject]
		                                , I.[Date]
                                        , IC.IncomeCategoryName AS CategoryName  
		                                , I.Amount
	                                FROM PersonelOrganizerDB.dbo.INCOME AS I
                                        INNER JOIN PersonelOrganizerDB.dbo.TT_INCOME_CATEGORY AS IC ON IC.IncomeCategoryID = I.IncomeCategoryID 
	                                WHERE (@Category = 0 OR I.IncomeCategoryID = @Category) AND
		                                  MONTH(I.[Date]) = @Month
	                                UNION ALL
	                                SELECT 
		                                E.[Subject]
		                                , E.DueDate
                                        , EC.ExpenseCategoryName AS CategoryName
		                                , E.Amount * -1 AS Amount
	                                FROM PersonelOrganizerDB.dbo.EXPENSE_BILL AS E
                                        INNER JOIN PersonelOrganizerDB.dbo.TT_EXPENSE_CATEGORY AS EC ON EC.ExpenseCategoryID = E.ExpenseCategory
	                                WHERE (@Category = 0 OR E.ExpenseCategory = @Category) AND
		                                  MONTH(E.DueDate) = @Month
                                )
                                , TOPLAM AS
                                (
	                                SELECT	
		                                'TOPLAM' AS [Subject]
		                                , NULL AS [Date]
	                                    , NULL AS CategoryName
		                                , SUM(Amount) AS Amount
	                                FROM LISTE
                                )
                                SELECT * FROM LISTE 
                                UNION ALL
                                SELECT * FROM TOPLAM";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@Category", SqlDbType.Int, pCategory));
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@Month", SqlDbType.Int, pMonth));
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }
    }
}
