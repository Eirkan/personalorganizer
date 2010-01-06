using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PO.Types.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ServiceConnectionNameAttribute : Attribute
    {
        public string mConnectionName;
        public ServiceConnectionNameAttribute(string pConnectionName)
        {
            mConnectionName = pConnectionName;
        }
    }
}
