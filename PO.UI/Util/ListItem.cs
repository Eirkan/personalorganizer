using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonelOrganizer.Util
{
    public class ListItem
    {
        public string Name = "";
        public Guid Value = Guid.Empty;

        public ListItem(string name, Guid value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
