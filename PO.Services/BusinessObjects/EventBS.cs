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
    public class EventBS : BusinessBase
    {
        public void Save(EVENTDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.EVENT);
        }

        public EVENTDataSet SelectByUserID(Guid pUserID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.EVENT WHERE UserID = @UserID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@UserID", SqlDbType.UniqueIdentifier, pUserID));
            EVENTDataSet ds = new EVENTDataSet();
            dto.GetRecords(ds.EVENT, cmd);
            return ds;
        }

        public EVENTDataSet SelectByEventID(Guid pEventID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.EVENT WHERE EventID = @EventID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@EventID", SqlDbType.UniqueIdentifier, pEventID));
            EVENTDataSet ds = new EVENTDataSet();
            dto.GetRecords(ds.EVENT, cmd);
            return ds;
        }

        public EVENTDataSet SelectByUserIDFrequencyType(Guid pUserID, int pFreqType)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.EVENT WHERE UserID = @UserID AND Frequency = @Frequency";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@UserID", SqlDbType.UniqueIdentifier, pUserID));
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@Frequency", SqlDbType.Int, pFreqType));
            EVENTDataSet ds = new EVENTDataSet();
            dto.GetRecords(ds.EVENT, cmd);
            return ds;
        }

        public void DeleteEventByEventID(Guid pEventID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM PersonelOrganizerDb.dbo.EVENT
                                WHERE EventID = @EventID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@EventID", SqlDbType.UniqueIdentifier, pEventID));
            dto.ExecuteSqlStatement(cmd);
        }

        public DataTable ChechkOverlapEvents(DateTime pStartDate, DateTime pEndDate)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"  SELECT E.Subject FROM PersonelOrganizerDb.dbo.EVENT AS E
                                  WHERE @sDate BETWEEN E.StartDateTime AND E.EndDateTime OR
                                        @eDate BETWEEN E.StartDateTime AND E.EndDateTime";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@sDate", SqlDbType.DateTime, pStartDate));
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@eDate", SqlDbType.DateTime, pEndDate));
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }

        public DataTable ChechkOverlapEvents(Guid pEventID, DateTime pStartDate, DateTime pEndDate)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"  SELECT E.Subject FROM PersonelOrganizerDb.dbo.EVENT AS E
                                  WHERE E.EventID <> @EventID AND
	                                    (@sDate BETWEEN E.StartDateTime AND E.EndDateTime OR
                                         @eDate BETWEEN E.StartDateTime AND E.EndDateTime)";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@sDate", SqlDbType.DateTime, pStartDate));
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@eDate", SqlDbType.DateTime, pEndDate));
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@EventID", SqlDbType.UniqueIdentifier, pEventID));
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }
    }
}
