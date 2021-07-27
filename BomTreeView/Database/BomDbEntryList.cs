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
    }
}
