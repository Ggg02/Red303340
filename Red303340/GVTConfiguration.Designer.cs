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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Device");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("SCPI Comand File");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ConnectString");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Generator C", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Device");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("SCPI Command File");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ConnectString");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("PowerMetter", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Device");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("SCPI Command FIle");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("ConnectString");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Generator I", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("GVT Configuration", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(12, 34);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Tag = "C1001";
            treeNode1.Text = "Device";
            treeNode2.Name = "Node5";
            treeNode2.Tag = "C1002";
            treeNode2.Text = "SCPI Comand File";
            treeNode3.Name = "Node10";
            treeNode3.Tag = "C1003";
            treeNode3.Text = "ConnectString";
            treeNode4.Name = "Node1";
            treeNode4.Tag = "C1000";
            treeNode4.Text = "Generator C";
            treeNode5.Name = "Node6";
            treeNode5.Tag = "P1001";
            treeNode5.Text = "Device";
            treeNode6.Name = "Node7";
            treeNode6.Tag = "P1002";
            treeNode6.Text = "SCPI Command File";
            treeNode7.Name = "Node11";
            treeNode7.Tag = "P1003";
            treeNode7.Text = "ConnectString";
            treeNode8.Name = "Node2";
            treeNode8.Tag = "P1000";
            treeNode8.Text = "PowerMetter";
            treeNode9.Name = "Node8";
            treeNode9.Tag = "I1001";
            treeNode9.Text = "Device";
            treeNode10.Name = "Node9";
            treeNode10.Tag = "I1002";
            treeNode10.Text = "SCPI Command FIle";
            treeNode11.Name = "Node12";
            treeNode11.Tag = "I1003";
            treeNode11.Text = "ConnectString";
            treeNode12.Name = "Node3";
            treeNode12.Tag = "I1000";
            treeNode12.Text = "Generator I";
            treeNode13.Name = "Node0";
            treeNode13.Tag = "GVT Configuration";
            treeNode13.Text = "GVT Configuration";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(326, 257);
            this.treeView1.TabIndex = 7;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GVTConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(350, 303);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "GVTConfiguration";
            this.Text = "GVTConfiguration";
            this.Deactivate += new System.EventHandler(this.GVTConfiguration_Deactivate);
            this.Load += new System.EventHandler(this.GVTConfiguration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
    }
}