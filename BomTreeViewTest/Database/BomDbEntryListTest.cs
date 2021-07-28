using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BomTreeView.Importer.Bom;
using System.Collections.Generic;
using BomTreeView.Importer.Combiner;
using BomTreeView.Importer.Part;
using BomTreeView.Database;
using BomTreeView;

namespace BomTreeViewTest
{
    [TestClass]
    public class BomDbEntryListTest
    {

        [TestMethod]
        public void ConvertingImportedBomDbEntryListToBomDisplayEntryListShouldReturnBomDisplayEntryListWithOneTopLevelEntry()
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
            BomDbEntryList bomDbEntryList
                = bomAndPartCombiner.CombineBomAndPartImportResults();

            BomDisplayEntryList bomDisplayEntryList
                = bomDbEntryList.ToBomDisplayEntryList();

            List<BomDisplayEntry> topLevelEntries
                = bomDisplayEntryList.BomEntryList;
            Assert.AreEqual(1, topLevelEntries.Count);
        }

        [TestMethod]
        public void ConvertingImportedBomDbEntryListToBomDisplayEntryListShouldReturnBomDisplayEntryListWithCorrectEntryCount()
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
            BomDbEntryList bomDbEntryList
                = bomAndPartCombiner.CombineBomAndPartImportResults();

            BomDisplayEntryList bomDisplayEntryList
                = bomDbEntryList.ToBomDisplayEntryList();

            List<BomDisplayEntry> allEntries
                = bomDisplayEntryList.GetFlattenedBomEntryList();
            Assert.AreEqual(196, allEntries.Count);
        }
    }
}
