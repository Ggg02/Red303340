namespace Red303340
{
    partial class GVTConfiguration
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
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Device");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("SCPI Comand File");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("ConnectString");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Generator C", new System.Windows.Forms.TreeNode[] {
            treeNode92,
            treeNode93,
            treeNode94});
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Device");
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("SCPI Command File");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("ConnectString");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("PowerMetter", new System.Windows.Forms.TreeNode[] {
            treeNode96,
            treeNode97,
            treeNode98});
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Device");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("SCPI Command FIle");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("ConnectString");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Generator I", new System.Windows.Forms.TreeNode[] {
            treeNode100,
            treeNode101,
            treeNode102});
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("GVT Configuration", new System.Windows.Forms.TreeNode[] {
            treeNode95,
            treeNode99,
            treeNode103});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode92.Name = "Node4";
            treeNode92.Tag = "C1001";
            treeNode92.Text = "Device";
            treeNode93.Name = "Node5";
            treeNode93.Tag = "C1002";
            treeNode93.Text = "SCPI Comand File";
            treeNode94.Name = "Node10";
            treeNode94.Tag = "C1003";
            treeNode94.Text = "ConnectString";
            treeNode95.Name = "Node1";
            treeNode95.Tag = "C1000";
            treeNode95.Text = "Generator C";
            treeNode96.Name = "Node6";
            treeNode96.Tag = "P1001";
            treeNode96.Text = "Device";
            treeNode97.Name = "Node7";
            treeNode97.Tag = "P1002";
            treeNode97.Text = "SCPI Command File";
            treeNode98.Name = "Node11";
            treeNode98.Tag = "P1003";
            treeNode98.Text = "ConnectString";
            treeNode99.Name = "Node2";
            treeNode99.Tag = "P1000";
            treeNode99.Text = "PowerMetter";
            treeNode100.Name = "Node8";
            treeNode100.Tag = "I1001";
            treeNode100.Text = "Device";
            treeNode101.Name = "Node9";
            treeNode101.Tag = "I1002";
            treeNode101.Text = "SCPI Command FIle";
            treeNode102.Name = "Node12";
            treeNode102.Tag = "I1003";
            treeNode102.Text = "ConnectString";
            treeNode103.Name = "Node3";
            treeNode103.Tag = "I1000";
            treeNode103.Text = "Generator I";
            treeNode104.Name = "Node0";
            treeNode104.Tag = "GVT Configuration";
            treeNode104.Text = "GVT Configuration";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode104});
            this.treeView1.Size = new System.Drawing.Size(295, 251);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // GVTConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 426);
            this.Controls.Add(this.treeView1);
            this.Name = "GVTConfiguration";
            this.Text = "GVTConfiguration";
            this.Deactivate += new System.EventHandler(this.GVTConfiguration_Deactivate);
            this.Load += new System.EventHandler(this.GVTConfiguration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}