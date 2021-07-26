using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BomTreeView
{
    class BomEntry
    {
        public string ComponentName { get; set; }
        public string ParentName { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public string Item { get; set; }
        public string PartNumber { get; set; }
        public string Title { get; set; }
        public string Material { get; set; }
        private List<BomEntry> Children { get; set; } = new List<BomEntry>();

        public BomEntry(
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


        public BomEntry(
            string componentName,
            string parentName,
            int quantity,
            string type,
            string item,
            string partNumber,
            string title,
            string material,
            List<BomEntry> children
        ) : this(
            componentName,
            parentName,
            quantity,
            type, item,
            partNumber,
            title,
            material
        ) {
            this.Children = children;
        }

        public bool HasChildren()
        {
            if (Children == null)
            {
                return false;
            }
            return Children.Any();
        }

        public TreeNode ToTreeNode()
        {
            if (HasChildren())
            {
                TreeNode[] childrenNodes = GetChildrenNodes();
                return new TreeNode(ComponentName, childrenNodes);
            }
            return new TreeNode(ComponentName);
        }

        private TreeNode[] GetChildrenNodes()
        {
            List<TreeNode> childrenNodeList = new List<TreeNode>();
            foreach (BomEntry childCharacter in Children)
            {
                TreeNode childNode = childCharacter.ToTreeNode();
                childrenNodeList.Add(childNode);
            }
            return childrenNodeList.ToArray();
        }

        public List<BomEntry> GetFlattenedChildrenList()
        {
            List<BomEntry> flattenedChildrenList = new List<BomEntry>();
            foreach(BomEntry bomEntry in Children)
            {
                flattenedChildrenList.Add(bomEntry);
                flattenedChildrenList.AddRange(bomEntry.GetFlattenedChildrenList());
            }
            return flattenedChildrenList;
        }

        public DataTable GetChildrenTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("COMPONENT_NAME", typeof(string));
            dataTable.Columns.Add("PART_NUMBER", typeof(string));
            dataTable.Columns.Add("TITLE", typeof(string));
            dataTable.Columns.Add("QUANTITY", typeof(int));
            dataTable.Columns.Add("TYPE", typeof(string));
            dataTable.Columns.Add("ITEM ", typeof(string));
            dataTable.Columns.Add("MATERIAL", typeof(string));

            foreach (BomEntry child in Children)
            {
                dataTable.Rows.Add(
                    child.ComponentName,
                    child.PartNumber,
                    child.Title,
                    child.Quantity,
                    child.Type,
                    child.Item,
                    child.Material
                );
            }

            return dataTable;
        }
    }
}
