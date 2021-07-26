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
        private BomEntryRepository bomEntryRepository;

        public BomDisplayer()
        {
            InitializeComponent();
        }

        private void BomDisplayer_Load(object sender, EventArgs e)
        {
            bomEntryRepository = BomEntryRepository.BuildDummyBomEntryRepository();
            List<BomEntry> bomEntryList = bomEntryRepository.BomEntryList;
            foreach (
                BomEntry bomEntry in bomEntryList
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
            BomEntry selectedBomEntry 
                = bomEntryRepository.GetBomEntryByComponentName(componentName);
            this.quantityDisplay.Text = selectedBomEntry.Quantity.ToString();
            this.typeDisplay.Text = selectedBomEntry.Type;
            this.itemDisplay.Text = selectedBomEntry.Item;
            this.partNumberDisplay.Text = selectedBomEntry.PartNumber;
            this.titleDisplay.Text = selectedBomEntry.Title;
            this.materialDisplay.Text = selectedBomEntry.Material;
            this.parentDisplay.Text = selectedBomEntry.ParentName;
            DisplayChildrenInTableView(selectedBomEntry);
        }

        private void DisplayChildrenInTableView(BomEntry selectedBomEntry)
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
    }
}
