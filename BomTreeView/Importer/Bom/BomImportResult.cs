using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer.Bom
{
    class BomImportResult
    {
        public List<BomBaseEntry> ImportedBomBaseEntryList { get; set; }

        public BomImportResult(IEnumerable<BomBaseEntry> importedBomBaseEntries)
        {
            ImportedBomBaseEntryList = new List<BomBaseEntry>(importedBomBaseEntries);
        }
    }
}
