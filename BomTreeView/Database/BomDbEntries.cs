using System;
using System.Collections.Generic;

namespace BomTreeView.Database
{
    public class BomDbEntries
    {
        public List<BomDbEntry> BomDbEntryList{ get; set; }

        public BomDbEntries(List<BomDbEntry> bomDbEntryList)
        {
            BomDbEntryList = bomDbEntryList;
        }

        public BomDisplayEntryList ToBomDisplayEntryList()
        {
            BomDbEntry topmostEntry = GetTopmostEntry();
            BomDisplayEntry topmostDisplayEntry = BuildBomDisplayEntry(topmostEntry);
            return new BomDisplayEntryList(topmostDisplayEntry);
        }

        private BomDbEntry GetTopmostEntry()
        {
            foreach(BomDbEntry bomDbEntry in BomDbEntryList)
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
            foreach (BomDbEntry potentialChildBomDbEntry in BomDbEntryList)
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
