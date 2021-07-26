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
    public partial class CharacterDisplayer : Form
    {
        public CharacterDisplayer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(
                GameCharacter gameCharacter in GameCharacterRepository.sampleGameCharacters
            )
            {
                AddNodeForGameCharacter(gameCharacter);
            }
        }

        private void AddNodeForGameCharacter(GameCharacter gameCharacter)
        {
            treeView1.Nodes.Add(gameCharacter.ToTreeNode());
        }

        private void TreeView1_NodeMouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            TreeNode node = treeView1.SelectedNode;
            
            MessageBox.Show(string.Format("You selected: {0}", node.Text));
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = treeView1.SelectedNode;
            string characterName = selectedNode.Text;
            this.characterNameDisplay.Text = characterName;
            GameCharacter selectedCharacter
                = GameCharacterRepository.GetCharacterByName(characterName);
            this.speciesDisplay.Text = selectedCharacter.Species;
            this.weaponDisplay.Text = selectedCharacter.Weapon;
            DisplayChildrenInTableView(selectedCharacter);
        }

        private void DisplayChildrenInTableView(GameCharacter selectedCharacter)
        {
            if (selectedCharacter.HasChildren())
            {
                childrenTable.DataSource = selectedCharacter.GetChildrenTable();
            }
            else
            {
                childrenTable.DataSource = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
