using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PO.DataService;
using PO.Types.Attributes;
using System.ServiceModel;
using PO.Types.CustomTypes;
using System.Diagnostics;

namespace PO.Services
{
    public abstract class BusinessBase
    {
        private IPODataObject mDataObject;
        private bool mIsRoot = false;
        public int nestedLevel = 1;

        protected bool IsRoot
        {
            get
            {
                if (nestedLevel > 1)
                {
                    nestedLevel = nestedLevel - 1;
                    return false;
                }
                return mIsRoot;
            }
        }

        private string pGetDefaultDB()
        {
            if (this.GetType().IsDefined(typeof(DefaultDatabaseAttribute), false))
            {
                DefaultDatabaseAttribute dbAttribute = (DefaultDatabaseAttribute)this.GetType().GetCustomAttributes(typeof(DefaultDatabaseAttribute), false)[0];
                return dbAttribute.mDatabaseName;
            }
            return string.Empty;
        }

        protected IPODataObject GetPODataObject(bool pIsTransactional)
        {
            if (mDataObject == null)
            {
                mDataObject = PODataObjectFactory.GetDataObject(pGetDefaultDB(), pIsTransactional);
                if (pIsTransactional)
                    mIsRoot = true;
            }
            else
            {
                //ayni BS ten kendi iclerinde transaction olan 2 farkli metodun icice cagrildigi durumlar icin eklendi.
                if (mDataObject.IsDataObjectTransactional && mIsRoot && pIsTransactional)
                {
                    nestedLevel++;
                    return mDataObject;

                }
                if (mDataObject.IsDataObjectTransactional && mIsRoot && !pIsTransactional)
                {
                    return mDataObject;
                }
                else if (mDataObject.IsDataObjectTransactional && !mIsRoot)
                {
                    return mDataObject;
                }
                else
                {
                    mDataObject = PODataObjectFactory.GetDataObject(pGetDefaultDB(), pIsTransactional);
                    if (pIsTransactional)
                        mIsRoot = true;
                }
            }
            return mDataObject;
        }

        //servisin kendisine özel connection bilgisi var ise
        protected IPODataObject GetServicePODataObject(bool pIsTransactional)
        {
            string connectionStringName = "";

            if (this.GetType().IsDefined(typeof(ServiceConnectionNameAttribute), false))
            {
                ServiceConnectionNameAttribute cnAttribute = (ServiceConnectionNameAttribute)this.GetType().GetCustomAttributes(typeof(ServiceConnectionNameAttribute), false)[0];
                connectionStringName = cnAttribute.mConnectionName;
            }

            if (connectionStringName == "")
            {
                return GetPODataObject(pIsTransactional);
            }

            if (mDataObject == null)
            {
                mDataObject = PODataObjectFactory.GetAnotherDataObject(connectionStringName, pGetDefaultDB(), pIsTransactional);
                if (pIsTransactional)
                    mIsRoot = true;
            }
            else
            {
                //ayni BS ten kendi iclerinde transaction olan 2 farkli metodun icice cagrildigi durumlar icin eklendi.
                if (mDataObject.IsDataObjectTransactional && mIsRoot && pIsTransactional)
                {
                    nestedLevel++;
                    return mDataObject;

                }
                if (mDataObject.IsDataObjectTransactional && mIsRoot && !pIsTransactional)
                {
                    return mDataObject;
                }
                else if (mDataObject.IsDataObjectTransactional && !mIsRoot)
                {
                    return mDataObject;
                }
                else
                {
                    mDataObject = PODataObjectFactory.GetAnotherDataObject(connectionStringName, pGetDefaultDB(), pIsTransactional);
                    if (pIsTransactional)
                        mIsRoot = true;
                }
            }
            return mDataObject;
        }

        protected IPODataObject GetPODataObject()
        {
            return GetPODataObject(false);
        }

        protected T CreateBusinessObject<T>() where T : BusinessBase
        {
            T objBusiness = default(T);
            objBusiness = Activator.CreateInstance<T>();
            if ((mDataObject != null) && (mDataObject.IsDataObjectTransactional))
            {
                objBusiness.mDataObject = this.mDataObject;
                objBusiness.mIsRoot = false;
            }
            return objBusiness;
        }
    }
}
