using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Database
{
    public class BomDbEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ComponentName { get; set; }
        public string ParentName { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public string Item { get; set; }
        public string PartNumber { get; set; }
        public string Title { get; set; }
        public string Material { get; set; }

        public BomDbEntry(
            string componentName,
            string parentName,
            int quantity,
            string type,
            string item,
            string partNumber,
            string title,
            string material
        ) {
            this.ComponentName = componentName;
            this.ParentName = parentName;
            this.Quantity = quantity;
            this.Type = type;
            this.Item = item;
            this.PartNumber = partNumber;
            this.Title = title;
            this.Material = material;
        }

        public BomDbEntry()
        {

        }

        public bool HasParent()
        {
            if (ParentName == null)
            {
                return false;
            }
            return !(ParentName == "");
        }

        internal bool IsChildOf(BomDbEntry bomDbEntry)
        {
            if (!HasParent())
            {
                return false;
            }
            return ParentName == bomDbEntry.ComponentName;
        }
    }
}
