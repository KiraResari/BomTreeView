using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer.Bom
{
    public class BomImportResult
    {
        public List<BomImportEntry> ImportedBomEntryList { get; set; }

        public BomImportResult(IEnumerable<BomImportEntry> importedBomBaseEntries)
        {
            ImportedBomEntryList = new List<BomImportEntry>(importedBomBaseEntries);
        }
    }
}
