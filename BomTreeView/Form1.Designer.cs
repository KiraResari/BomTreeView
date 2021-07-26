
namespace BomTreeView
{
    partial class CharacterDisplayer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.characterNameDisplay = new System.Windows.Forms.Label();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.speciesDisplay = new System.Windows.Forms.Label();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.speciesLabel = new System.Windows.Forms.Label();
            this.weaponDisplay = new System.Windows.Forms.Label();
            this.childrenTable = new System.Windows.Forms.DataGridView();
            this.childrenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.childrenTable)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(200, 450);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseDoubleClick);
            // 
            // characterNameDisplay
            // 
            this.characterNameDisplay.AutoSize = true;
            this.characterNameDisplay.Location = new System.Drawing.Point(320, 20);
            this.characterNameDisplay.Name = "characterNameDisplay";
            this.characterNameDisplay.Size = new System.Drawing.Size(127, 13);
            this.characterNameDisplay.TabIndex = 1;
            this.characterNameDisplay.Text = "[Character Name Display]";
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterNameLabel.Location = new System.Drawing.Point(220, 20);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(102, 13);
            this.characterNameLabel.TabIndex = 2;
            this.characterNameLabel.Text = "Character Name:";
            // 
            // speciesDisplay
            // 
            this.speciesDisplay.AutoSize = true;
            this.speciesDisplay.Location = new System.Drawing.Point(320, 40);
            this.speciesDisplay.Name = "speciesDisplay";
            this.speciesDisplay.Size = new System.Drawing.Size(88, 13);
            this.speciesDisplay.TabIndex = 5;
            this.speciesDisplay.Text = "[Species Display]";
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponLabel.Location = new System.Drawing.Point(264, 60);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(58, 13);
            this.weaponLabel.TabIndex = 4;
            this.weaponLabel.Text = "Weapon:";
            // 
            // speciesLabel
            // 
            this.speciesLabel.AutoSize = true;
            this.speciesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speciesLabel.Location = new System.Drawing.Point(266, 40);
            this.speciesLabel.Name = "speciesLabel";
            this.speciesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.speciesLabel.Size = new System.Drawing.Size(56, 13);
            this.speciesLabel.TabIndex = 3;
            this.speciesLabel.Text = "Species:";
            // 
            // weaponDisplay
            // 
            this.weaponDisplay.AutoSize = true;
            this.weaponDisplay.Location = new System.Drawing.Point(320, 60);
            this.weaponDisplay.Name = "weaponDisplay";
            this.weaponDisplay.Size = new System.Drawing.Size(88, 13);
            this.weaponDisplay.TabIndex = 6;
            this.weaponDisplay.Text = "[Species Display]";
            // 
            // childrenTable
            // 
            this.childrenTable.AllowUserToAddRows = false;
            this.childrenTable.AllowUserToDeleteRows = false;
            this.childrenTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childrenTable.Location = new System.Drawing.Point(267, 96);
            this.childrenTable.Name = "childrenTable";
            this.childrenTable.Size = new System.Drawing.Size(423, 150);
            this.childrenTable.TabIndex = 7;
            // 
            // childrenLabel
            // 
            this.childrenLabel.AutoSize = true;
            this.childrenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childrenLabel.Location = new System.Drawing.Point(264, 80);
            this.childrenLabel.Name = "childrenLabel";
            this.childrenLabel.Size = new System.Drawing.Size(57, 13);
            this.childrenLabel.TabIndex = 8;
            this.childrenLabel.Text = "Children:";
            this.childrenLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CharacterDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.childrenLabel);
            this.Controls.Add(this.childrenTable);
            this.Controls.Add(this.weaponDisplay);
            this.Controls.Add(this.speciesDisplay);
            this.Controls.Add(this.weaponLabel);
            this.Controls.Add(this.speciesLabel);
            this.Controls.Add(this.characterNameLabel);
            this.Controls.Add(this.characterNameDisplay);
            this.Controls.Add(this.treeView1);
            this.Name = "CharacterDisplayer";
            this.Text = "Character Displayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.childrenTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label characterNameDisplay;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.Label speciesDisplay;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.Label speciesLabel;
        private System.Windows.Forms.Label weaponDisplay;
        private System.Windows.Forms.DataGridView childrenTable;
        private System.Windows.Forms.Label childrenLabel;
    }
}

