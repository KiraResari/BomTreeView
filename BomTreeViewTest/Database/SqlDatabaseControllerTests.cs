using Microsoft.VisualStudio.TestTools.UnitTesting;
using BomTreeView.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BomTreeView.Importer;

namespace BomTreeView.Database.Tests
{
    [TestClass()]
    public class SqlDatabaseControllerTests
    {
        private static readonly BomDbEntry BOM_DB_ENTRY = new BomDbEntry(
            "Test Component Name",
            "Test Parent Name",
            1,
            "Test Type",
            "Test Item",
            "Test Part Number",
            "Test Title",
            "Test Material"
        );
        private static readonly List<BomDbEntry> BOM_DB_ENTRY_LIST = new List<BomDbEntry>() { BOM_DB_ENTRY };
        private static readonly BomDbEntries BOM_DB_ENTRIES = new BomDbEntries(BOM_DB_ENTRY_LIST);
        private static readonly BomDisplayEntry DUMMY_VALVE_ENTRY = new BomDisplayEntry(
            "VALVE",
            "",
            1,
            "ASSEMBLY",
            "?",
            "00001-254878",
            "VALVE ASSEMBLY",
            "?"
        );

        SqlDatabaseController SqlDatabaseController { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SqlDatabaseController = new SqlDatabaseController();
            SqlDatabaseController.ClearBomDbEntryTable();
        }

        [TestMethod()]
        public void WriteBomDbEntryListToBomDatabaseShouldNotThrowAnError()
        {
            SqlDatabaseController.WriteBomDbEntryListToBomDatabase(BOM_DB_ENTRIES);
        }

        [TestMethod()]
        public void WriteBomDbEntryListToBomDatabaseShouldCreateCorrectCountOfEntries()
        {
            SqlDatabaseController.WriteBomDbEntryListToBomDatabase(BOM_DB_ENTRIES);

            List<BomDbEntry> allEntries = SqlDatabaseController.ReadAllBomDbEntriesFromDatabase();
            Assert.AreEqual(1, allEntries.Count);
        }

        [TestMethod()]
        public void ReadChildrenFromDatabaseShouldReturnCorrectCountOfChildren()
        {
            BomAndPartImporter bomAndPartImporter = new BomAndPartImporter();
            BomDbEntries bomDbEntryList = bomAndPartImporter.ImportBom();
            SqlDatabaseController.WriteBomDbEntryListToBomDatabase(bomDbEntryList);

            BomDbEntries childEntries = SqlDatabaseController.ReadChildrenFromDatabase(DUMMY_VALVE_ENTRY);
            Assert.AreEqual(41, childEntries.BomDbEntryList.Count);
        }
    }
}