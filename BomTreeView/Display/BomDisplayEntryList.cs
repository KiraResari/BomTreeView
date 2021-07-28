using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView
{
    public class BomDisplayEntryList
    {
        public List<BomDisplayEntry> BomEntryList { get; set; }

        public BomDisplayEntryList(List<BomDisplayEntry> bomEntryList)
        {
            this.BomEntryList = bomEntryList;
        }

        public BomDisplayEntryList(BomDisplayEntry bomDisplayEntry)
        {
            BomEntryList = new List<BomDisplayEntry>() { bomDisplayEntry };
        }

        public BomDisplayEntry GetBomEntryByComponentName(string componentName)
        {
            List<BomDisplayEntry> flattenedBomEntryList = GetFlattenedBomEntryList();
            foreach (BomDisplayEntry bomEntry in flattenedBomEntryList)
            {
                if (bomEntry.ComponentName == componentName)
                {
                    return bomEntry;
                }
            }
            throw new Exception("Could not find component with name: " + componentName);
        }

        public List<BomDisplayEntry> GetFlattenedBomEntryList()
        {
            List<BomDisplayEntry> flattenedBomEntryList = new List<BomDisplayEntry>();
            foreach (BomDisplayEntry bomEntry in BomEntryList)
            {
                flattenedBomEntryList.Add(bomEntry);
                flattenedBomEntryList.AddRange(bomEntry.GetFlattenedChildrenList());
            }
            return flattenedBomEntryList;
        }

        public static BomDisplayEntryList BuildEmpty()
        {
            List<BomDisplayEntry> bomEntryList = new List<BomDisplayEntry>();
            return new BomDisplayEntryList(bomEntryList);
        }
    }
}
