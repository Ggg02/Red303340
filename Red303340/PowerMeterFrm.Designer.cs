namespace Red303340
{
    partial class PowerMeterFrm
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
            this.components = new System.ComponentModel.Container();
            this.LBCurrentDB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timerPowCach = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LBCurrentDB
            // 
            this.LBCurrentDB.BackColor = System.Drawing.Color.Lime;
            this.LBCurrentDB.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCurrentDB.Location = new System.Drawing.Point(12, 22);
            this.LBCurrentDB.Name = "LBCurrentDB";
            this.LBCurrentDB.Size = new System.Drawing.Size(196, 59);
            this.LBCurrentDB.TabIndex = 0;
            this.LBCurrentDB.Text = "23213.123";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerPowCach
            // 
            this.timerPowCach.Interval = 800;
            this.timerPowCach.Tick += new System.EventHandler(this.timerPowCach_Tick);
            // 
            // PowerMeterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 100);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBCurrentDB);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "PowerMeterFrm";
            this.Text = "PowerMeter Panel";
            this.Load += new System.EventHandler(this.PowerMeterFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBCurrentDB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerPowCach;
    }
}