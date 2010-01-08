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
        public void Save(APPOINTMENTDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.APPOINTMENT);
        }

        public DataTable SelectAll()
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT 
	                                A.AppointmentID
	                                , E.* 
	                                , C.[Name]
	                                , C.Surname
                                    , C.ContactID
                                FROM PersonelOrganizerDb.dbo.APPOINTMENT AS A 
	                                INNER JOIN PersonelOrganizerDb.dbo.EVENT AS E ON A.EventID = E.EventID 
	                                INNER JOIN PersonelOrganizerDb.dbo.CONTACT AS C ON A.ContactID = C.ContactID";
            DataTable dt = new DataTable();
            dto.GetRecords(dt, cmd);
            return dt;
        }

        public APPOINTMENTDataSet SelectByAppointmentID(Guid pAppointmentID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.APPOINTMENT
                                WHERE AppointmentID = @AppointmentID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@AppointmentID", SqlDbType.UniqueIdentifier, pAppointmentID));
            APPOINTMENTDataSet ds = new APPOINTMENTDataSet();
            dto.GetRecords(ds.APPOINTMENT, cmd);
            return ds;
        }

        public void DeleteByAppointmentID(Guid pAppointmentID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"DELETE FROM PersonelOrganizerDb.dbo.APPOINTMENT
                                WHERE AppointmentID = @AppointmentID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@AppointmentID", SqlDbType.UniqueIdentifier, pAppointmentID));
            dto.ExecuteSqlStatement(cmd);
        }
    }
}
