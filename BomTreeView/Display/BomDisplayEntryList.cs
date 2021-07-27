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

        public static BomDisplayEntryList BuildDummyBomEntryRepository()
        {
            BomDisplayEntry body_spool
                = new BomDisplayEntry("BODY_SPOOL", "BODY", 1, "PART", "A1", "09204-254878", "BODY SPOOL", "SA-516-GR.70N");
            List<BomDisplayEntry> bodyChildren = new List<BomDisplayEntry>() { body_spool };
            BomDisplayEntry body = new BomDisplayEntry(
                "BODY",
                "VALVE",
                1,
                "ASSEMBLY",
                "A",
                "09200-254878", 
                "BODY ASSEMBLY",
                "SA-516-GR.70N",
                bodyChildren
            );
            BomDisplayEntry orficeGasket = new BomDisplayEntry(
                "ORIFICE_GASKET",
                "VALVE",
                1,
                "PART",
                "M1",
                "01303-254878",
                "ORIFICE GASKET, METAL REINFORCED LAMINATE STYLE GHE\"\"",
                "316SS/GRAFOIL"
            );
            List<BomDisplayEntry> valveChildren = new List<BomDisplayEntry>() { body, orficeGasket };
            BomDisplayEntry valve 
                = new BomDisplayEntry("VALVE", "", 1, "ASSEMBLY", "?", "00001-254878", "VALVE ASSEMBLY", "?", valveChildren);
            List<BomDisplayEntry> bomEntryList = new List<BomDisplayEntry>() { valve };
            return new BomDisplayEntryList(bomEntryList);
        }
    }
}
