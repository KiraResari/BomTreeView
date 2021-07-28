using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BomTreeView.Importer.Bom;
using System.Collections.Generic;

namespace BomTreeViewTest
{
    [TestClass]
    public class BomImporterTest
    {

        [TestMethod]
        public void ImportingBomShouldCreateBomImporterResultWithCorrectNumberOfEntries()
        {
            BomImporter bomImporter = new BomImporter();

            BomImportResult importResult
                = bomImporter.ImportBomFile();

            List<BomImportEntry> importedBomBaseEntryList
                = importResult.ImportedBomEntryList;
            Assert.AreEqual(196, importedBomBaseEntryList.Count);
        }
    }
}
