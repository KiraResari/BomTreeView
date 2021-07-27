using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer.Bom
{
    public class BomImportEntry
    {
        [Name("PARENT_NAME")]
        public string ParentName { get; set; }
        [Name("QUANTITY")]
        public int Quantity { get; set; }
        [Name("COMPONENT_NAME")]
        public string ComponentName { get; set; }

        public bool HasParent()
        {
            if(ParentName == null)
            {
                return false;
            }
            return !(ParentName == "");
        }

        internal bool IsChildOf(BomImportEntry bomNode)
        {
            if (!HasParent())
            {
                return false;
            }
            return ParentName == bomNode.ComponentName;
        }
    }
}
