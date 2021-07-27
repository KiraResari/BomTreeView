using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Database
{
    public class BomDbEntryList
    {
        public List<BomDbEntry> BomDbEntries{ get; set; }

        public BomDbEntryList(List<BomDbEntry> bomDbEntryList)
        {
            BomDbEntries = bomDbEntryList;
        }

        public BomDisplayEntryList ToBomDisplayEntryList()
        {
            BomDbEntry topmostEntry = GetTopmostEntry();
            BomDisplayEntry topmostDisplayEntry = BuildBomDisplayEntry(topmostEntry);
            return new BomDisplayEntryList(topmostDisplayEntry);
        }

        private BomDbEntry GetTopmostEntry()
        {
            foreach(BomDbEntry bomDbEntry in BomDbEntries)
            {
                if (!bomDbEntry.HasParent())
                {
                    return bomDbEntry;
                }
            }
            throw new Exception("No entry in the BomDbEntryList could be identified as the topmost entry");
        }

        private BomDisplayEntry BuildBomDisplayEntry(BomDbEntry bomDbEntry)
        {
            List<BomDisplayEntry> children = BuildChildBomDisplayEntriesOf(bomDbEntry);
            return new BomDisplayEntry(
                bomDbEntry.ComponentName,
                bomDbEntry.ParentName,
                bomDbEntry.Quantity,
                bomDbEntry.Type,
                bomDbEntry.Item,
                bomDbEntry.PartNumber,
                bomDbEntry.Title,
                bomDbEntry.Material,
                children
            );
        }

        private List<BomDisplayEntry> BuildChildBomDisplayEntriesOf(BomDbEntry bomDbEntry)
        {
            List<BomDisplayEntry> childBomDisplayEntries = new List<BomDisplayEntry>();
            List<BomDbEntry> childBomDbEntries = GetChildBomDbEntriesOf(bomDbEntry);
            foreach(BomDbEntry childBomDbEntry in childBomDbEntries)
            {
                BomDisplayEntry childBomDisplayEntry = BuildBomDisplayEntry(childBomDbEntry);
                childBomDisplayEntries.Add(childBomDisplayEntry);
            }
            return childBomDisplayEntries;
        }

        private List<BomDbEntry> GetChildBomDbEntriesOf(BomDbEntry bomDbEntry)
        {
            List<BomDbEntry> childBomDbEntries = new List<BomDbEntry>();
            foreach (BomDbEntry potentialChildBomDbEntry in BomDbEntries)
            {
                if (potentialChildBomDbEntry.IsChildOf(bomDbEntry))
                {
                    childBomDbEntries.Add(potentialChildBomDbEntry);
                }
            }
            return childBomDbEntries;
        }
    }
}
