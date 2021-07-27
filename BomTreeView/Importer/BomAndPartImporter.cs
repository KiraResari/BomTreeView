using BomTreeView.Database;
using BomTreeView.Importer.Bom;
using BomTreeView.Importer.Combiner;
using BomTreeView.Importer.Part;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer
{
    public class BomAndPartImporter
    {
        public BomDbEntryList ImportBom(string bomFilePath, string partFilePath)
        {
            BomImporter bomImporter = new BomImporter();
            PartImporter partImporter = new PartImporter();
            BomImportResult bomImportResult = bomImporter.ImportBomFile(bomFilePath);
            PartImportResult partImportResult = partImporter.ImportPartFile(partFilePath);
            BomAndPartCombiner bomAndPartCombiner = new BomAndPartCombiner(
                bomImportResult,
                partImportResult
            );
            return bomAndPartCombiner.CombineBomAndPartImportResults();
        }
    }
}
