using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace BomTreeView.Importer.Bom
{
    public class BomImporter
    {
        private const string DUMMY_BOM_CSV_RESOURCE_PATH = "BomTreeView.Resources.bom.csv";

        public BomImportResult ImportBomFile()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream resourceStream = assembly.GetManifestResourceStream(DUMMY_BOM_CSV_RESOURCE_PATH);
            StreamReader streamReader = new StreamReader(resourceStream);
            CsvReader csvReader = new CsvReader(streamReader, new CultureInfo("en-CA"));

            IEnumerable<BomImportEntry> importedBomBaseEntries
                = csvReader.GetRecords<BomImportEntry>();
            return new BomImportResult(importedBomBaseEntries);
        }
    }
}
