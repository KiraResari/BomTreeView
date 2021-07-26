using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer.Part
{
    class PartEntry
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Item { get; set; }
        public string PartNumber { get; set; }
        public string Title { get; set; }
        public string Material { get; set; }

        public PartEntry(string name, string type, string item, string partNumber, string title, string material)
        {
            this.Name = name;
            this.Type = type;
            this.Item = item;
            this.PartNumber = partNumber;
            this.Title = title;
            this.Material = material;
        }
    }
}
