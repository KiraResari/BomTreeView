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

    }
}
