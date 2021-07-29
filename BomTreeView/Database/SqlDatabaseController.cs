using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Database
{
    public class SqlDatabaseController
    {
        
        private BomDatabaseContext BomDatabaseContext { get; set; }

        public SqlDatabaseController()
        {
            BomDatabaseContext = new BomDatabaseContext();
        }

        public void WriteBomDbEntryListToBomDatabase(BomDbEntries bomDbEntries)
        {
            List<BomDbEntry> bomDbEntryList = bomDbEntries.BomDbEntryList;
            BomDatabaseContext.BomDbEntrySet.AddRange(bomDbEntryList);
            BomDatabaseContext.SaveChanges();
        }

        public void ClearBomDbEntryTable()
        {
            List<BomDbEntry> allBomDbEntries = ReadAllBomDbEntriesFromDatabase();
            BomDatabaseContext.BomDbEntrySet.RemoveRange(allBomDbEntries);
            BomDatabaseContext.SaveChanges();
        }

        public List<BomDbEntry> ReadAllBomDbEntriesFromDatabase()
        {
            return BomDatabaseContext.BomDbEntrySet.ToList();
        }
    }
}
