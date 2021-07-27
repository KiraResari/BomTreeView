using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BomTreeView.Importer.Bom;
using System.Collections.Generic;

namespace BomTreeViewTest
{
    [TestClass]
    public class BomImporterTest
    {
        private const string SAMPLE_BOM_FILE_PATH = "../../../bom.csv";

        [TestMethod]
        public void ImportingBomShouldCreateBomImporterResultWithCorrectNumberOfEntries()
        {
            BomImporter bomImporter = new BomImporter();

            BomImportResult importResult
                = bomImporter.ImportBomFile(SAMPLE_BOM_FILE_PATH);

            List<BomImportEntry> importedBomBaseEntryList
                = importResult.ImportedBomEntryList;
            Assert.AreEqual(196, importedBomBaseEntryList.Count);
        }
    }
}
