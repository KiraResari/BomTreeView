﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using BomTreeView.Importer.Part;

namespace BomTreeViewTest
{
    [TestClass]
    public class PartImporterTest
    {
        private const string SAMPLE_PART_FILE_PATH = "../../../part.csv";

        [TestMethod]
        public void ImportingPartShouldCreatePartImporterResultWithCorrectNumberOfEntries()
        {
            PartImporter partImporter = new PartImporter();

            PartImportResult importResult
                = partImporter.ImportPartFile(SAMPLE_PART_FILE_PATH);

            List<PartImportEntry> importedPartEntryList
                = importResult.ImportedPartEntryList;
            Assert.AreEqual(186, importedPartEntryList.Count);
        }
    }
}
