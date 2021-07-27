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

        public BomImportEntry GetTopmostNode()
        {
            foreach(BomImportEntry bomImportEntry in ImportedBomEntryList)
            {
                if (!bomImportEntry.HasParent())
                {
                    return bomImportEntry;
                }
            }
            throw new Exception("No entry in the imported BOM data could be identified as the topmost entry");
        }

        public List<BomImportEntry> GetChildrenOfBomNode(BomImportEntry bomNode)
        {
            List<BomImportEntry> childrenOfBomNode = new List<BomImportEntry>();
            foreach (BomImportEntry bomImportEntry in ImportedBomEntryList)
            {
                if (bomImportEntry.IsChildOf(bomNode))
                {
                    childrenOfBomNode.Add(bomImportEntry);
                }
            }
            return childrenOfBomNode;
        }
    }
}
