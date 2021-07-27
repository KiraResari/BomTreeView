using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer.Part
{
    public class PartImportEntry
    {
        [Name("NAME")]
        public string Name { get; set; }
        [Name("TYPE")]
        public string Type { get; set; }
        [Name("ITEM")]
        public string Item { get; set; }
        [Name("PART_NUMBER")]
        public string PartNumber { get; set; }
        [Name("TITLE")]
        public string Title { get; set; }
        [Name("MATERIAL")]
        public string Material { get; set; }

    }
}
