using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer.Part
{
    class PartImportResult
    {
        public List<PartImportEntry> ImportedPartEntryList { get; set; }

        public PartImportResult(IEnumerable<PartImportEntry> importedPartEntries)
        {
            ImportedPartEntryList = new List<PartImportEntry>(importedPartEntries);
        }
    }
}
