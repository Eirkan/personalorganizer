using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PO.Types.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AutoIncColNameAttribute : Attribute
    {
        public string AutoIncColName;
        public AutoIncColNameAttribute(string pAutoIncColName)
        {
            AutoIncColName = pAutoIncColName;
        }
    }
}
