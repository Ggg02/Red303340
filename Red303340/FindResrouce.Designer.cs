namespace Red303340
{
    partial class FindResrouce
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filterStringsListBox = new System.Windows.Forms.ListBox();
            this.filterStringLabel = new System.Windows.Forms.Label();
            this.findResourcesButton = new System.Windows.Forms.Button();
            this.resourceTreeView = new System.Windows.Forms.TreeView();
            this.availableResourcesLabel = new System.Windows.Forms.Label();
            this.findTcpipResourcesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filterStringsListBox
            // 
            this.filterStringsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterStringsListBox.ItemHeight = 15;
            this.filterStringsListBox.Location = new System.Drawing.Point(12, 38);
            this.filterStringsListBox.Name = "filterStringsListBox";
            this.filterStringsListBox.Size = new System.Drawing.Size(312, 139);
            this.filterStringsListBox.TabIndex = 10;
            // 
            // filterStringLabel
            // 
            this.filterStringLabel.Location = new System.Drawing.Point(12, 9);
            this.filterStringLabel.Name = "filterStringLabel";
            this.filterStringLabel.Size = new System.Drawing.Size(87, 22);
            this.filterStringLabel.TabIndex = 11;
            this.filterStringLabel.Text = "Filter String:";
            // 
            // findResourcesButton
            // 
            this.findResourcesButton.Location = new System.Drawing.Point(199, 0);
            this.findResourcesButton.Name = "findResourcesButton";
            this.findResourcesButton.Size = new System.Drawing.Size(125, 31);
            this.findResourcesButton.TabIndex = 12;
            this.findResourcesButton.Text = "Find Resources";
            this.findResourcesButton.Click += new System.EventHandler(this.findResourcesButton_Click);
            // 
            // resourceTreeView
            // 
            this.resourceTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resourceTreeView.FullRowSelect = true;
            this.resourceTreeView.HideSelection = false;
            this.resourceTreeView.LabelEdit = true;
            this.resourceTreeView.Location = new System.Drawing.Point(12, 203);
            this.resourceTreeView.Name = "resourceTreeView";
            this.resourceTreeView.Size = new System.Drawing.Size(290, 182);
            this.resourceTreeView.TabIndex = 14;
            // 
            // availableResourcesLabel
            // 
            this.availableResourcesLabel.Location = new System.Drawing.Point(12, 181);
            this.availableResourcesLabel.Name = "availableResourcesLabel";
            this.availableResourcesLabel.Size = new System.Drawing.Size(183, 22);
            this.availableResourcesLabel.TabIndex = 13;
            this.availableResourcesLabel.Text = "Available Resources Found:";
            // 
            // findTcpipResourcesButton
            // 
            this.findTcpipResourcesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.findTcpipResourcesButton.Location = new System.Drawing.Point(199, 173);
            this.findTcpipResourcesButton.Name = "findTcpipResourcesButton";
            this.findTcpipResourcesButton.Size = new System.Drawing.Size(163, 31);
            this.findTcpipResourcesButton.TabIndex = 15;
            this.findTcpipResourcesButton.Text = "Find TCP/IP Resources";
            this.findTcpipResourcesButton.Click += new System.EventHandler(this.findTcpipResourcesButton_Click);
            // 
            // FindResrouce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 397);
            this.Controls.Add(this.findTcpipResourcesButton);
            this.Controls.Add(this.resourceTreeView);
            this.Controls.Add(this.availableResourcesLabel);
            this.Controls.Add(this.findResourcesButton);
            this.Controls.Add(this.filterStringLabel);
            this.Controls.Add(this.filterStringsListBox);
            this.Name = "FindResrouce";
            this.Text = "FindResrouce";
            this.Load += new System.EventHandler(this.FindResrouce_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox filterStringsListBox;
        private System.Windows.Forms.Label filterStringLabel;
        private System.Windows.Forms.Button findResourcesButton;
        private System.Windows.Forms.TreeView resourceTreeView;
        private System.Windows.Forms.Label availableResourcesLabel;
        private System.Windows.Forms.Button findTcpipResourcesButton;
    }
}