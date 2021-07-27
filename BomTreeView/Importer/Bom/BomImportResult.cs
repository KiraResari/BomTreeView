using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer.Bom
{
    class BomImportResult
    {
        public List<BomImportEntry> ImportedBomBaseEntryList { get; set; }

        public BomImportResult(IEnumerable<BomImportEntry> importedBomBaseEntries)
        {
            ImportedBomBaseEntryList = new List<BomImportEntry>(importedBomBaseEntries);
        }
    }
}
