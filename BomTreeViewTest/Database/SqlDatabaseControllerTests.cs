using Microsoft.VisualStudio.TestTools.UnitTesting;
using BomTreeView.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Database.Tests
{
    [TestClass()]
    public class SqlDatabaseControllerTests
    {
        private static readonly BomDbEntry BOM_DB_ENTRY = new BomDbEntry(
            "Test Component Name",
            "Test Parent Name",
            1,
            "Test String",
            "Test Item",
            "Test Part Number",
            "Test Title",
            "Test Material"
        );
        private static readonly List<BomDbEntry> BOM_DB_ENTRY_LIST = new List<BomDbEntry>() { BOM_DB_ENTRY };
        private static readonly BomDbEntries BOM_DB_ENTRIES = new BomDbEntries(BOM_DB_ENTRY_LIST);

        SqlDatabaseController sqlDatabaseController;

        [TestInitialize]
        public void BeforeEach()
        {
            sqlDatabaseController = new SqlDatabaseController();
            sqlDatabaseController.ClearBomDbEntryTable();
        }

        [TestMethod()]
        public void WriteBomDbEntryListToBomDatabaseShouldNotThrowAnError()
        {
            sqlDatabaseController.WriteBomDbEntryListToBomDatabase(BOM_DB_ENTRIES);
        }

        [TestMethod()]
        public void WriteBomDbEntryListToBomDatabaseShouldCreateCorrectCountOfEntries()
        {
            sqlDatabaseController.WriteBomDbEntryListToBomDatabase(BOM_DB_ENTRIES);

            List<BomDbEntry> allEntries = sqlDatabaseController.ReadAllBomDbEntriesFromDatabase();
            Assert.AreEqual(1, allEntries.Count);
        }
    }
}