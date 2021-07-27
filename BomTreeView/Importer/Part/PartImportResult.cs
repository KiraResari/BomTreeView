using BomTreeView.Importer.Bom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer.Part
{
    public class PartImportResult
    {
        public List<PartImportEntry> ImportedPartEntryList { get; set; }

        public PartImportResult(IEnumerable<PartImportEntry> importedPartEntries)
        {
            ImportedPartEntryList = new List<PartImportEntry>(importedPartEntries);
        }

        internal PartImportEntry GetEntryForBomNode(BomImportEntry bomNode)
        {
            string componentName = bomNode.ComponentName;
            foreach(PartImportEntry partImportEntry in ImportedPartEntryList)
            {
                if(partImportEntry.Name == componentName)
                {
                    return partImportEntry;
                }
            }
            return new PartImportEntry();
        }
    }
}
