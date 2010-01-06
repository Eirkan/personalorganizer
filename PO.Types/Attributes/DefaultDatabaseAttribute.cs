using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PO.Types.Attributes
{
    [AttributeUsage (AttributeTargets.Class)]  
    public class DefaultDatabaseAttribute : Attribute 
    {
        public string mDatabaseName;
        public DefaultDatabaseAttribute(string pDatabaseName)
        {
            mDatabaseName = pDatabaseName;
        }
    }
}
