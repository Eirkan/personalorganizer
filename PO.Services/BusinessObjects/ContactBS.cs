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
    public class ContactBS : BusinessBase
    {
        private void Save(CONTACTDataSet ds)
        {
            IPODataObject dto = GetPODataObject();
            dto.Update(ds.CONTACT);
        }

        public void AddContact(CONTACTDataSet contactDS, EMAILDataSet mailDS, WEBPAGEDataSet pageDS, PHONE_NUMBERDataSet phoneDS, POSTAL_ADDRESSDataSet addressDS)
        {
            IPODataObject dto = null;
            dto = GetPODataObject(true);

            EmailBS mailBS = this.CreateBusinessObject<EmailBS>();
            PhoneNumberBS phoneBS = this.CreateBusinessObject<PhoneNumberBS>();
            WebPageBS webPageBS = this.CreateBusinessObject<WebPageBS>();
            AddressBS addressBS = this.CreateBusinessObject<AddressBS>();

            try
            {
                this.Save(contactDS);
                mailBS.Save(mailDS);
                phoneBS.Save(phoneDS);
                webPageBS.Save(pageDS);
                addressBS.Save(addressDS);
                
                if (IsRoot)
                    dto.CommitTransaction();
            }
            catch (Exception ex)
            {
                if (IsRoot)
                    if (dto != null)
                        dto.RollbackTransaction();

                throw (ex);
            }
        }

        public CONTACTDataSet SelectContactsWithUserID(Guid pUserID)
        {
            IPODataObject dto = GetPODataObject();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"SELECT * FROM PersonelOrganizerDb.dbo.CONTACT
                                WHERE UserID = @UserID";
            cmd.Parameters.Add(ParameterBuilder.CreateSqlParameter("@UserID", SqlDbType.UniqueIdentifier, pUserID));
            CONTACTDataSet con = new CONTACTDataSet();
            dto.GetRecords(con.CONTACT, cmd);
            return con;
        }
    }
}