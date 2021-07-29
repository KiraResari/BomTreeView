using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView
{
    public class BomDisplayEntries
    {
        public List<BomDisplayEntry> BomEntryList { get; set; }

        public BomDisplayEntries(List<BomDisplayEntry> bomEntryList)
        {
            this.BomEntryList = bomEntryList;
        }

        public BomDisplayEntries(BomDisplayEntry bomDisplayEntry)
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

        public static BomDisplayEntries BuildEmpty()
        {
            List<BomDisplayEntry> bomEntryList = new List<BomDisplayEntry>();
            return new BomDisplayEntries(bomEntryList);
        }

        public DataTable ToDataTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("COMPONENT_NAME", typeof(string));
            dataTable.Columns.Add("PART_NUMBER", typeof(string));
            dataTable.Columns.Add("TITLE", typeof(string));
            dataTable.Columns.Add("QUANTITY", typeof(int));
            dataTable.Columns.Add("TYPE", typeof(string));
            dataTable.Columns.Add("ITEM ", typeof(string));
            dataTable.Columns.Add("MATERIAL", typeof(string));

            foreach (BomDisplayEntry bomDisplayEntry in BomEntryList)
            {
                dataTable.Rows.Add(
                    bomDisplayEntry.ComponentName,
                    bomDisplayEntry.PartNumber,
                    bomDisplayEntry.Title,
                    bomDisplayEntry.Quantity,
                    bomDisplayEntry.Type,
                    bomDisplayEntry.Item,
                    bomDisplayEntry.Material
                );
            }

            return dataTable;
        }
    }
}
