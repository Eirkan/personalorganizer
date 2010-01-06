using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PO.Types.Attributes
{
    [AttributeUsage(AttributeTargets.Class )  ]
    public class FullTableNameAttribute : Attribute 
    {
        public string FullTableName;
        public FullTableNameAttribute(string pFullTableName)
        {
            FullTableName  = pFullTableName ;
        }
    }
}
