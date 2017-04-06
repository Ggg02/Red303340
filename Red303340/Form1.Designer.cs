namespace Red303340
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sensitivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjacentChannelSelectivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overloadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CongurationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findResourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.testToolStripMenuItem,
            this.findResourceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensitivityToolStripMenuItem,
            this.adjacentChannelSelectivityToolStripMenuItem,
            this.blockingToolStripMenuItem,
            this.overloadingToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(82, 24);
            this.toolStripMenuItem1.Text = "TestCase";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(75, 24);
            this.toolStripMenuItem2.Text = "widows";
            // 
            // sensitivityToolStripMenuItem
            // 
            this.sensitivityToolStripMenuItem.Name = "sensitivityToolStripMenuItem";
            this.sensitivityToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.sensitivityToolStripMenuItem.Text = "Sensitivity";
            // 
            // adjacentChannelSelectivityToolStripMenuItem
            // 
            this.adjacentChannelSelectivityToolStripMenuItem.Name = "adjacentChannelSelectivityToolStripMenuItem";
            this.adjacentChannelSelectivityToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.adjacentChannelSelectivityToolStripMenuItem.Text = "Adjacent channel selectivity";
            // 
            // blockingToolStripMenuItem
            // 
            this.blockingToolStripMenuItem.Name = "blockingToolStripMenuItem";
            this.blockingToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.blockingToolStripMenuItem.Text = "Blocking";
            // 
            // overloadingToolStripMenuItem
            // 
            this.overloadingToolStripMenuItem.Name = "overloadingToolStripMenuItem";
            this.overloadingToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.overloadingToolStripMenuItem.Text = "Overloading";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CongurationMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // CongurationMenuItem
            // 
            this.CongurationMenuItem.Name = "CongurationMenuItem";
            this.CongurationMenuItem.Size = new System.Drawing.Size(205, 26);
            this.CongurationMenuItem.Text = "GVT Conguration";
            this.CongurationMenuItem.Click += new System.EventHandler(this.CongurationMenuItem_Click);
            // 
            // findResourceToolStripMenuItem
            // 
            this.findResourceToolStripMenuItem.Name = "findResourceToolStripMenuItem";
            this.findResourceToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.findResourceToolStripMenuItem.Text = "FindResource";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 255);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sensitivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjacentChannelSelectivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overloadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CongurationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findResourceToolStripMenuItem;
    }
}

