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
        public string Name { get; set; } = "[Not Set]";
        [Name("TYPE")]
        public string Type { get; set; } = "[Not Set]";
        [Name("ITEM")]
        public string Item { get; set; } = "[Not Set]";
        [Name("PART_NUMBER")]
        public string PartNumber { get; set; } = "[Not Set]";
        [Name("TITLE")]
        public string Title { get; set; } = "[Not Set]";
        [Name("MATERIAL")]
        public string Material { get; set; } = "[Not Set]";
    }
}
