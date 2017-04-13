namespace Red303340
{
    partial class VSGFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.LBFreq = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBcurrentFile = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.BtnRF = new System.Windows.Forms.Button();
            this.timerVSGSync = new System.Windows.Forms.Timer(this.components);
            this.btnMod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnARB = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.txtFixDB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBCurrentDB
            // 
            this.LBCurrentDB.BackColor = System.Drawing.Color.Lime;
            this.LBCurrentDB.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCurrentDB.Location = new System.Drawing.Point(5, 1);
            this.LBCurrentDB.Name = "LBCurrentDB";
            this.LBCurrentDB.Size = new System.Drawing.Size(181, 59);
            this.LBCurrentDB.TabIndex = 1;
            this.LBCurrentDB.Text = "23213.123";
            this.LBCurrentDB.Click += new System.EventHandler(this.LBCurrentDB_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "dBm";
            // 
            // LBFreq
            // 
            this.LBFreq.BackColor = System.Drawing.Color.Lime;
            this.LBFreq.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFreq.Location = new System.Drawing.Point(5, 60);
            this.LBFreq.Name = "LBFreq";
            this.LBFreq.Size = new System.Drawing.Size(181, 59);
            this.LBFreq.TabIndex = 3;
            this.LBFreq.Text = "23213.123";
            this.LBFreq.Click += new System.EventHandler(this.LBFreq_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 59);
            this.label3.TabIndex = 4;
            this.label3.Text = "MHz";
            // 
            // LBcurrentFile
            // 
            this.LBcurrentFile.BackColor = System.Drawing.Color.Lime;
            this.LBcurrentFile.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBcurrentFile.Location = new System.Drawing.Point(5, 124);
            this.LBcurrentFile.Name = "LBcurrentFile";
            this.LBcurrentFile.Size = new System.Drawing.Size(213, 48);
            this.LBcurrentFile.TabIndex = 5;
            this.LBcurrentFile.Text = "23213.123";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(224, 137);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(69, 27);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnRF
            // 
            this.BtnRF.Location = new System.Drawing.Point(310, 67);
            this.BtnRF.Name = "BtnRF";
            this.BtnRF.Size = new System.Drawing.Size(105, 27);
            this.BtnRF.TabIndex = 7;
            this.BtnRF.Text = "RF ON/OFF";
            this.BtnRF.UseVisualStyleBackColor = true;
            this.BtnRF.Click += new System.EventHandler(this.button2_Click);
            // 
            // timerVSGSync
            // 
            this.timerVSGSync.Interval = 1000;
            this.timerVSGSync.Tick += new System.EventHandler(this.timerVSGSync_Tick);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(310, 35);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(105, 27);
            this.btnMod.TabIndex = 8;
            this.btnMod.Text = "Mod ON/OFF";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 64);
            this.button1.TabIndex = 9;
            this.button1.Text = "selectWavForm And play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnARB
            // 
            this.btnARB.Location = new System.Drawing.Point(310, 4);
            this.btnARB.Name = "btnARB";
            this.btnARB.Size = new System.Drawing.Size(105, 27);
            this.btnARB.TabIndex = 10;
            this.btnARB.Text = "ARB ON/OFF";
            this.btnARB.UseVisualStyleBackColor = true;
            this.btnARB.Click += new System.EventHandler(this.BtnARB_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(421, 35);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(66, 27);
            this.btnAuto.TabIndex = 11;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // txtFixDB
            // 
            this.txtFixDB.Location = new System.Drawing.Point(421, 5);
            this.txtFixDB.Name = "txtFixDB";
            this.txtFixDB.Size = new System.Drawing.Size(66, 25);
            this.txtFixDB.TabIndex = 12;
            // 
            // VSGFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 235);
            this.Controls.Add(this.txtFixDB);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnARB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.BtnRF);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.LBcurrentFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBFreq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBCurrentDB);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "VSGFrm";
            this.Text = "VSG Pannel";
            this.Load += new System.EventHandler(this.VSGFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBCurrentDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBFreq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBcurrentFile;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button BtnRF;
        private System.Windows.Forms.Timer timerVSGSync;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnARB;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.TextBox txtFixDB;
    }
}