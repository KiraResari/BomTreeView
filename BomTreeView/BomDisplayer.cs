using BomTreeView.Database;
using BomTreeView.Importer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BomTreeView
{
    public partial class BomDisplayer : Form
    {
        private BomDisplayEntryList bomDisplayEntryList;

        public BomDisplayer()
        {
            InitializeComponent();
        }

        private void BomDisplayer_Load(object sender, EventArgs e)
        {
            bomDisplayEntryList = BomDisplayEntryList.BuildEmpty();
            RebuildTreeView();
        }

        private void RebuildTreeView()
        {
            bomTreeView.Nodes.Clear();
            List<BomDisplayEntry> bomEntryList = bomDisplayEntryList.BomEntryList;
            foreach (
                BomDisplayEntry bomEntry in bomEntryList
            )
            {
                bomTreeView.Nodes.Add(bomEntry.ToTreeNode());
            }
        }

        private void BomTreeView_NodeMouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            TreeNode node = bomTreeView.SelectedNode;
            
            MessageBox.Show(string.Format("You selected: {0}", node.Text));
        }

        private void BomTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = bomTreeView.SelectedNode;
            string componentName = selectedNode.Text;
            this.componentNameDisplay.Text = componentName;
            BomDisplayEntry selectedBomEntry 
                = bomDisplayEntryList.GetBomEntryByComponentName(componentName);
            this.quantityDisplay.Text = selectedBomEntry.Quantity.ToString();
            this.typeDisplay.Text = selectedBomEntry.Type;
            this.itemDisplay.Text = selectedBomEntry.Item;
            this.partNumberDisplay.Text = selectedBomEntry.PartNumber;
            this.titleDisplay.Text = selectedBomEntry.Title;
            this.materialDisplay.Text = selectedBomEntry.Material;
            this.parentDisplay.Text = selectedBomEntry.ParentName;
            DisplayChildrenInTableView(selectedBomEntry);
        }

        private void DisplayChildrenInTableView(BomDisplayEntry selectedBomEntry)
        {
            if (selectedBomEntry.HasChildren())
            {
                childrenTable.DataSource = selectedBomEntry.GetChildrenTable();
            }
            else
            {
                childrenTable.DataSource = null;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImportBomDataButton_Click(object sender, EventArgs e)
        {
            BomAndPartImporter bomAndPartImporter = new BomAndPartImporter();
            BomDbEntryList bomDbEntryList = bomAndPartImporter.ImportBom();
            bomDisplayEntryList = bomDbEntryList.ToBomDisplayEntryList();
            RebuildTreeView();
            importBomDataButton.Enabled = false;
        }
    }
}
