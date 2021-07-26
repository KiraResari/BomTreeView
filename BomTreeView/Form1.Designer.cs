
namespace BomTreeView
{
    partial class BomDisplayer
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
            this.componentNameDisplay = new System.Windows.Forms.Label();
            this.componentNameLabel = new System.Windows.Forms.Label();
            this.quantityDisplay = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.typeDisplay = new System.Windows.Forms.Label();
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
            // componentNameDisplay
            // 
            this.componentNameDisplay.AutoSize = true;
            this.componentNameDisplay.Location = new System.Drawing.Point(320, 20);
            this.componentNameDisplay.Name = "componentNameDisplay";
            this.componentNameDisplay.Size = new System.Drawing.Size(135, 13);
            this.componentNameDisplay.TabIndex = 1;
            this.componentNameDisplay.Text = "[Component Name Display]";
            // 
            // componentNameLabel
            // 
            this.componentNameLabel.AutoSize = true;
            this.componentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentNameLabel.Location = new System.Drawing.Point(211, 20);
            this.componentNameLabel.Name = "componentNameLabel";
            this.componentNameLabel.Size = new System.Drawing.Size(110, 13);
            this.componentNameLabel.TabIndex = 2;
            this.componentNameLabel.Text = "Component Name:";
            // 
            // quantityDisplay
            // 
            this.quantityDisplay.AutoSize = true;
            this.quantityDisplay.Location = new System.Drawing.Point(320, 40);
            this.quantityDisplay.Name = "quantityDisplay";
            this.quantityDisplay.Size = new System.Drawing.Size(89, 13);
            this.quantityDisplay.TabIndex = 5;
            this.quantityDisplay.Text = "[Quantity Display]";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(275, 60);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(39, 13);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Type:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(263, 40);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantityLabel.Size = new System.Drawing.Size(58, 13);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantity:";
            // 
            // typeDisplay
            // 
            this.typeDisplay.AutoSize = true;
            this.typeDisplay.Location = new System.Drawing.Point(320, 60);
            this.typeDisplay.Name = "typeDisplay";
            this.typeDisplay.Size = new System.Drawing.Size(74, 13);
            this.typeDisplay.TabIndex = 6;
            this.typeDisplay.Text = "[Type Display]";
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
            // 
            // BomDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.childrenLabel);
            this.Controls.Add(this.childrenTable);
            this.Controls.Add(this.typeDisplay);
            this.Controls.Add(this.quantityDisplay);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.componentNameLabel);
            this.Controls.Add(this.componentNameDisplay);
            this.Controls.Add(this.treeView1);
            this.Name = "BomDisplayer";
            this.Text = "BOM Displayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.childrenTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label componentNameDisplay;
        private System.Windows.Forms.Label componentNameLabel;
        private System.Windows.Forms.Label quantityDisplay;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label typeDisplay;
        private System.Windows.Forms.DataGridView childrenTable;
        private System.Windows.Forms.Label childrenLabel;
    }
}

