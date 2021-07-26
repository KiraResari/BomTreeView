using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer.Part
{
    class PartImporter
    {
        public PartImportResult ImportPartFile(string partFileName)
        {
            StreamReader streamReader = File.OpenText(partFileName);
            CsvReader csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);

            IEnumerable<PartEntry> importedPartEntries
                = csvReader.GetRecords<PartEntry>();
            return new PartImportResult(importedPartEntries);
        }
    }
}
