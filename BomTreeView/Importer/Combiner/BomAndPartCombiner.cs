using BomTreeView.Database;
using BomTreeView.Importer.Bom;
using BomTreeView.Importer.Part;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer.Combiner
{
    public class BomAndPartCombiner
    {
        private BomImportResult BomImportResult { get;  set; }
        private PartImportResult PartImportResult { get;  set; }

        public BomAndPartCombiner(
            BomImportResult bomImportResult,
            PartImportResult partImportResult
        ) {
            BomImportResult = bomImportResult;
            PartImportResult = partImportResult;
        }

        public BomDbEntryList CombineBomAndPartImportResults() {
            BomImportEntry topmostNode = BomImportResult.GetTopmostNode();
            List<BomDbEntry> combinedBomAndPartEntryList
                = BuildEntryForBomNodeAndChildren(topmostNode);
            return new BomDbEntryList(combinedBomAndPartEntryList);
        }

        private List<BomDbEntry> BuildEntryForBomNodeAndChildren(
            BomImportEntry bomNode
        ) {
            BomDbEntry combinedBomAndPartEntry = BuildEntryForBomNode(bomNode);
            List<BomDbEntry> combinedBomAndPartEntryList
                = BuildEntryForChildrenOfBomNode(bomNode);
            combinedBomAndPartEntryList.Add(combinedBomAndPartEntry);
            return combinedBomAndPartEntryList;
        }

        private BomDbEntry BuildEntryForBomNode(BomImportEntry bomNode)
        {
            PartImportEntry partNode = PartImportResult.GetEntryForBomNode(bomNode);
            return new BomDbEntry(
                bomNode.ComponentName,
                bomNode.ParentName,
                bomNode.Quantity,
                partNode.Type,
                partNode.Item,
                partNode.PartNumber,
                partNode.Title,
                partNode.Material
            );
        }

        private List<BomDbEntry> BuildEntryForChildrenOfBomNode(BomImportEntry bomNode)
        {
            List<BomImportEntry> childrenOfBomNode
                = BomImportResult.GetChildrenOfBomNode(bomNode);
            List<BomDbEntry> bomAndPartEntriesOfChildren = new List<BomDbEntry>();
            foreach(BomImportEntry childOfBomNode in childrenOfBomNode)
            {
                List<BomDbEntry> bomAndPartEntryOfChildAndDescendants
                    = BuildEntryForBomNodeAndChildren(childOfBomNode);
                bomAndPartEntriesOfChildren.AddRange(bomAndPartEntryOfChildAndDescendants);
            }
            return bomAndPartEntriesOfChildren;
        }
    }
}
