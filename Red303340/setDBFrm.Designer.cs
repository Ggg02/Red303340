namespace Red303340
{
    partial class setDBFrm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LBHint = new System.Windows.Forms.Label();
            this.LBCurrent = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 25);
            this.textBox1.TabIndex = 0;
            // 
            // LBHint
            // 
            this.LBHint.AutoSize = true;
            this.LBHint.Location = new System.Drawing.Point(12, 61);
            this.LBHint.Name = "LBHint";
            this.LBHint.Size = new System.Drawing.Size(108, 15);
            this.LBHint.TabIndex = 1;
            this.LBHint.Text = "new dBM setting ";
            // 
            // LBCurrent
            // 
            this.LBCurrent.BackColor = System.Drawing.Color.Lime;
            this.LBCurrent.Font = new System.Drawing.Font("Digital-7", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCurrent.Location = new System.Drawing.Point(9, 9);
            this.LBCurrent.Name = "LBCurrent";
            this.LBCurrent.Size = new System.Drawing.Size(220, 34);
            this.LBCurrent.TabIndex = 2;
            this.LBCurrent.Text = "23213.123";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(235, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(311, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 74);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // setDBFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 98);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBCurrent);
            this.Controls.Add(this.LBHint);
            this.Controls.Add(this.textBox1);
            this.Name = "setDBFrm";
            this.Text = "setDBFrm";
            this.Load += new System.EventHandler(this.setDBFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LBHint;
        private System.Windows.Forms.Label LBCurrent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}