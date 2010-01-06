using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient; 


namespace PO.DataService
{
    // ConnectionStringlerin tutulma yerine, Db authentication yontemine gore degisebilir. 
    // Varsayilan => config file da connection string elemanında bulunan PersonelOrganizerDB key'i. 
    public class PODataObjectFactory
    { 
        private static string mDefaultConnectionString;

        static PODataObjectFactory()
        {
            mDefaultConnectionString = ConfigurationManager.ConnectionStrings["PersonelOrganizerDB"].ConnectionString;
        }
        public static IPODataObject GetDataObject(string pDefaultDB, bool pIsTransactional)
        {
            IPODataObject oDataObject = null;
            oDataObject = new PODataObject(mDefaultConnectionString, pDefaultDB , pIsTransactional);
            return oDataObject;
        }

        public static IPODataObject GetAnotherDataObject(string pConnectionStringName, string pDefaultDB, bool pIsTransactional)
        {
            string connectionString = ConfigurationManager.ConnectionStrings[pConnectionStringName].ConnectionString;
            IPODataObject oDataObject = null;
            oDataObject = new PODataObject(connectionString, pDefaultDB, pIsTransactional);
            return oDataObject;
        }

    }
}

