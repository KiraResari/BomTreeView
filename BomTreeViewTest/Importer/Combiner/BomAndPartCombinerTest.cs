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
        private const string SAMPLE_BOM_FILE_PATH = "../../../bom.csv";
        private const string SAMPLE_PART_FILE_PATH = "../../../part.csv";

        [TestMethod]
        public void CombiningBomAndPartShouldCreateBomDbEntryListWithCorrectNumberOfEntries()
        {
            BomImporter bomImporter = new BomImporter();
            PartImporter partImporter = new PartImporter();
            BomImportResult bomImportResult
                = bomImporter.ImportBomFile(SAMPLE_BOM_FILE_PATH);
            PartImportResult partImportResult
                = partImporter.ImportPartFile(SAMPLE_PART_FILE_PATH);
            BomAndPartCombiner bomAndPartCombiner = new BomAndPartCombiner(
                bomImportResult,
                partImportResult
            );

            BomDbEntryList bomDbEntryList
                = bomAndPartCombiner.CombineBomAndPartImportResults();


            List<BomDbEntry> bomDbEntries
                = bomDbEntryList.BomDbEntries;
            Assert.AreEqual(196, bomDbEntries.Count);
        }
    }
}
