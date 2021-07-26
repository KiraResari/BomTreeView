using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer.Part
{
    class PartImportResult
    {
        public List<PartEntry> ImportedPartEntryList { get; set; }

        public PartImportResult(IEnumerable<PartEntry> importedPartEntries)
        {
            ImportedPartEntryList = new List<PartEntry>(importedPartEntries);
        }
    }
}
