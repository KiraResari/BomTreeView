using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace BomTreeView.Importer.Bom
{
    class BomImporter
    {
        public BomImportResult ImportBomFile(string bomFileName)
        {
            StreamReader streamReader = File.OpenText(bomFileName);
            CsvReader csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);

            IEnumerable<BomImportEntry> importedBomBaseEntries
                = csvReader.GetRecords<BomImportEntry>();
            return new BomImportResult(importedBomBaseEntries);
        }
    }
}
