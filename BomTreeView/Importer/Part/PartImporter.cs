using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer.Part
{
    public class PartImporter
    {
        private const string DUMMY_PART_CSV_RESOURCE_PATH = "BomTreeView.Resources.part.csv";

        public PartImportResult ImportPartFile()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream resourceStream = assembly.GetManifestResourceStream(DUMMY_PART_CSV_RESOURCE_PATH);
            StreamReader streamReader = new StreamReader(resourceStream);
            CsvReader csvReader = new CsvReader(streamReader, new CultureInfo("en-CA"));

            IEnumerable<PartImportEntry> importedPartEntries
                = csvReader.GetRecords<PartImportEntry>();
            return new PartImportResult(importedPartEntries);
        }
    }
}
