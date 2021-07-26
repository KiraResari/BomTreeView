using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView
{
    class BomEntryRepository
    {
        public List<BomEntry> BomEntryList { get; set; }

        public BomEntryRepository(List<BomEntry> bomEntryList)
        {
            this.BomEntryList = bomEntryList;
        }

        public BomEntry GetBomEntryByComponentName(string componentName)
        {
            List<BomEntry> flattenedBomEntryList = GetFlattenedBomEntryList();
            foreach (BomEntry bomEntry in flattenedBomEntryList)
            {
                if (bomEntry.ComponentName == componentName)
                {
                    return bomEntry;
                }
            }
            throw new Exception("Could not find component with name: " + componentName);
        }

        private List<BomEntry> GetFlattenedBomEntryList()
        {
            List<BomEntry> flattenedBomEntryList = new List<BomEntry>();
            foreach (BomEntry bomEntry in BomEntryList)
            {
                flattenedBomEntryList.Add(bomEntry);
                flattenedBomEntryList.AddRange(bomEntry.GetFlattenedChildrenList());
            }
            return flattenedBomEntryList;
        }

        public static BomEntryRepository BuildDummyBomEntryRepository()
        {
            BomEntry body_spool
                = new BomEntry("BODY_SPOOL", "BODY", 1, "PART", "A1", "09204-254878", "BODY SPOOL", "SA-516-GR.70N");
            List<BomEntry> bodyChildren = new List<BomEntry>() { body_spool };
            BomEntry body = new BomEntry(
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
            BomEntry orficeGasket = new BomEntry(
                "ORIFICE_GASKET",
                "VALVE",
                1,
                "PART",
                "M1",
                "01303-254878",
                "ORIFICE GASKET, METAL REINFORCED LAMINATE STYLE GHE\"\"",
                "316SS/GRAFOIL"
            );
            List<BomEntry> valveChildren = new List<BomEntry>() { body, orficeGasket };
            BomEntry valve 
                = new BomEntry("VALVE", "", 1, "ASSEMBLY", "?", "00001-254878", "VALVE ASSEMBLY", "?", valveChildren);
            List<BomEntry> bomEntryList = new List<BomEntry>() { valve };
            return new BomEntryRepository(bomEntryList);
        }
    }
}
