namespace Red303340
{
    partial class frmSelectWM
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
            this.listFilebox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listFilebox
            // 
            this.listFilebox.FormattingEnabled = true;
            this.listFilebox.ItemHeight = 15;
            this.listFilebox.Location = new System.Drawing.Point(10, 22);
            this.listFilebox.Name = "listFilebox";
            this.listFilebox.Size = new System.Drawing.Size(248, 94);
            this.listFilebox.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(352, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 74);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(276, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 74);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSelectWM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 130);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listFilebox);
            this.Name = "frmSelectWM";
            this.Text = "frmSelectWM";
            this.Load += new System.EventHandler(this.frmSelectWM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listFilebox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}