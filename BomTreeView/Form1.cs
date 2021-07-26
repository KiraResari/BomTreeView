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

        private void Form1_Load(object sender, EventArgs e)
        {
            bomEntryRepository = BomEntryRepository.BuildDummyBomEntryRepository();
            List<BomEntry> bomEntryList = bomEntryRepository.BomEntryList;
            foreach (
                BomEntry bomEntry in bomEntryList
            )
            {
                treeView1.Nodes.Add(bomEntry.ToTreeNode());
            }
        }

        private void TreeView1_NodeMouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            TreeNode node = treeView1.SelectedNode;
            
            MessageBox.Show(string.Format("You selected: {0}", node.Text));
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            string componentName = selectedNode.Text;
            this.componentNameDisplay.Text = componentName;
            BomEntry selectedBomEntry 
                = bomEntryRepository.GetBomEntryByComponentName(componentName);
            this.quantityDisplay.Text = selectedBomEntry.Quantity.ToString();
            this.typeDisplay.Text = selectedBomEntry.Type;
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
