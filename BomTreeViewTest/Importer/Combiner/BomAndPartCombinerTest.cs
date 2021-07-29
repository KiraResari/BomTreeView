using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BomTreeView.Importer.Bom;
using System.Collections.Generic;
using BomTreeView.Importer.Part;
using BomTreeView.Importer.Combiner;
using BomTreeView.Database;

namespace BomTreeViewTest
{
    [TestClass]
    public class BomAndPartCombinerTest
    {

        [TestMethod]
        public void CombiningBomAndPartShouldCreateBomDbEntryListWithCorrectNumberOfEntries()
        {
            BomImporter bomImporter = new BomImporter();
            PartImporter partImporter = new PartImporter();
            BomImportResult bomImportResult
                = bomImporter.ImportBomFile();
            PartImportResult partImportResult
                = partImporter.ImportPartFile();
            BomAndPartCombiner bomAndPartCombiner = new BomAndPartCombiner(
                bomImportResult,
                partImportResult
            );

            BomDbEntries bomDbEntryList
                = bomAndPartCombiner.CombineBomAndPartImportResults();

            List<BomDbEntry> bomDbEntries
                = bomDbEntryList.BomDbEntryList;
            Assert.AreEqual(196, bomDbEntries.Count);
        }
    }
}
