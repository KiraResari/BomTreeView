﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Importer.Bom
{
    class BomImportEntry
    {
        public string ParentName { get; set; }
        public int Quantity { get; set; }
        public string ComponentName { get; set; }

        public BomImportEntry(string parentName, int quantity, string componentName)
        {
            this.ParentName = parentName;
            this.Quantity = quantity;
            this.ComponentName = componentName;
        }
    }
}