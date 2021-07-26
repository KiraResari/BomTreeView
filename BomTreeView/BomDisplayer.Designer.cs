
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
            this.bomTreeView = new System.Windows.Forms.TreeView();
            this.componentNameDisplay = new System.Windows.Forms.Label();
            this.componentNameLabel = new System.Windows.Forms.Label();
            this.quantityDisplay = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.typeDisplay = new System.Windows.Forms.Label();
            this.childrenTable = new System.Windows.Forms.DataGridView();
            this.childrenLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.partNumberLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.parentLabel = new System.Windows.Forms.Label();
            this.itemDisplay = new System.Windows.Forms.Label();
            this.partNumberDisplay = new System.Windows.Forms.Label();
            this.titleDisplay = new System.Windows.Forms.Label();
            this.materialDisplay = new System.Windows.Forms.Label();
            this.parentDisplay = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.componentOverviewLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.childrenTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bomTreeView
            // 
            this.bomTreeView.Location = new System.Drawing.Point(0, 20);
            this.bomTreeView.Name = "bomTreeView";
            this.bomTreeView.Size = new System.Drawing.Size(200, 390);
            this.bomTreeView.TabIndex = 0;
            this.bomTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.BomTreeView_AfterSelect);
            this.bomTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.BomTreeView_NodeMouseDoubleClick);
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
            this.typeLabel.Location = new System.Drawing.Point(282, 60);
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
            this.childrenTable.Location = new System.Drawing.Point(267, 200);
            this.childrenTable.Name = "childrenTable";
            this.childrenTable.Size = new System.Drawing.Size(800, 250);
            this.childrenTable.TabIndex = 7;
            // 
            // childrenLabel
            // 
            this.childrenLabel.AutoSize = true;
            this.childrenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childrenLabel.Location = new System.Drawing.Point(264, 180);
            this.childrenLabel.Name = "childrenLabel";
            this.childrenLabel.Size = new System.Drawing.Size(57, 13);
            this.childrenLabel.TabIndex = 8;
            this.childrenLabel.Text = "Children:";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(286, 80);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(35, 13);
            this.itemLabel.TabIndex = 9;
            this.itemLabel.Text = "Item:";
            // 
            // partNumberLabel
            // 
            this.partNumberLabel.AutoSize = true;
            this.partNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumberLabel.Location = new System.Drawing.Point(240, 100);
            this.partNumberLabel.Name = "partNumberLabel";
            this.partNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.partNumberLabel.TabIndex = 10;
            this.partNumberLabel.Text = "Part Number:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(285, 120);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(36, 13);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Title:";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(265, 140);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(56, 13);
            this.materialLabel.TabIndex = 12;
            this.materialLabel.Text = "Material:";
            // 
            // parentLabel
            // 
            this.parentLabel.AutoSize = true;
            this.parentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentLabel.Location = new System.Drawing.Point(273, 160);
            this.parentLabel.Name = "parentLabel";
            this.parentLabel.Size = new System.Drawing.Size(48, 13);
            this.parentLabel.TabIndex = 13;
            this.parentLabel.Text = "Parent:";
            // 
            // itemDisplay
            // 
            this.itemDisplay.AutoSize = true;
            this.itemDisplay.Location = new System.Drawing.Point(320, 80);
            this.itemDisplay.Name = "itemDisplay";
            this.itemDisplay.Size = new System.Drawing.Size(70, 13);
            this.itemDisplay.TabIndex = 14;
            this.itemDisplay.Text = "[Item Display]";
            // 
            // partNumberDisplay
            // 
            this.partNumberDisplay.AutoSize = true;
            this.partNumberDisplay.Location = new System.Drawing.Point(320, 100);
            this.partNumberDisplay.Name = "partNumberDisplay";
            this.partNumberDisplay.Size = new System.Drawing.Size(109, 13);
            this.partNumberDisplay.TabIndex = 15;
            this.partNumberDisplay.Text = "[Part Number Display]";
            // 
            // titleDisplay
            // 
            this.titleDisplay.AutoSize = true;
            this.titleDisplay.Location = new System.Drawing.Point(320, 120);
            this.titleDisplay.Name = "titleDisplay";
            this.titleDisplay.Size = new System.Drawing.Size(70, 13);
            this.titleDisplay.TabIndex = 16;
            this.titleDisplay.Text = "[Title Display]";
            // 
            // materialDisplay
            // 
            this.materialDisplay.AutoSize = true;
            this.materialDisplay.Location = new System.Drawing.Point(320, 140);
            this.materialDisplay.Name = "materialDisplay";
            this.materialDisplay.Size = new System.Drawing.Size(87, 13);
            this.materialDisplay.TabIndex = 17;
            this.materialDisplay.Text = "[Material Display]";
            // 
            // parentDisplay
            // 
            this.parentDisplay.AutoSize = true;
            this.parentDisplay.Location = new System.Drawing.Point(320, 160);
            this.parentDisplay.Name = "parentDisplay";
            this.parentDisplay.Size = new System.Drawing.Size(81, 13);
            this.parentDisplay.TabIndex = 18;
            this.parentDisplay.Text = "[Parent Display]";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 427);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(176, 23);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit BOM Displayer";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // componentOverviewLabel
            // 
            this.componentOverviewLabel.AutoSize = true;
            this.componentOverviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentOverviewLabel.Location = new System.Drawing.Point(9, 4);
            this.componentOverviewLabel.Name = "componentOverviewLabel";
            this.componentOverviewLabel.Size = new System.Drawing.Size(127, 13);
            this.componentOverviewLabel.TabIndex = 20;
            this.componentOverviewLabel.Text = "Component Overview";
            // 
            // BomDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.componentOverviewLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.parentDisplay);
            this.Controls.Add(this.materialDisplay);
            this.Controls.Add(this.titleDisplay);
            this.Controls.Add(this.partNumberDisplay);
            this.Controls.Add(this.itemDisplay);
            this.Controls.Add(this.parentLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.partNumberLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.childrenLabel);
            this.Controls.Add(this.childrenTable);
            this.Controls.Add(this.typeDisplay);
            this.Controls.Add(this.quantityDisplay);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.componentNameLabel);
            this.Controls.Add(this.componentNameDisplay);
            this.Controls.Add(this.bomTreeView);
            this.Name = "BomDisplayer";
            this.Text = "BOM Displayer";
            this.Load += new System.EventHandler(this.BomDisplayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.childrenTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView bomTreeView;
        private System.Windows.Forms.Label componentNameDisplay;
        private System.Windows.Forms.Label componentNameLabel;
        private System.Windows.Forms.Label quantityDisplay;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label typeDisplay;
        private System.Windows.Forms.DataGridView childrenTable;
        private System.Windows.Forms.Label childrenLabel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label partNumberLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label parentLabel;
        private System.Windows.Forms.Label itemDisplay;
        private System.Windows.Forms.Label partNumberDisplay;
        private System.Windows.Forms.Label titleDisplay;
        private System.Windows.Forms.Label materialDisplay;
        private System.Windows.Forms.Label parentDisplay;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label componentOverviewLabel;
    }
}

