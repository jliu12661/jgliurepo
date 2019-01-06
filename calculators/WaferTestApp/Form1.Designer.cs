namespace WaferTestApp
{
    partial class Form1
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonUnSelect = new System.Windows.Forms.Button();
            this.cbEnableSelect = new System.Windows.Forms.CheckBox();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.waferCtrl1 = new WaferCtrl.WaferCtrl();
            this.textBoxWaferId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Enabled = false;
            this.buttonRun.Location = new System.Drawing.Point(570, 751);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(80, 44);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(192, 751);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(80, 44);
            this.buttonSelectAll.TabIndex = 0;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonUnSelect
            // 
            this.buttonUnSelect.Location = new System.Drawing.Point(297, 750);
            this.buttonUnSelect.Name = "buttonUnSelect";
            this.buttonUnSelect.Size = new System.Drawing.Size(80, 44);
            this.buttonUnSelect.TabIndex = 5;
            this.buttonUnSelect.Text = "DeSelect All";
            this.buttonUnSelect.UseVisualStyleBackColor = true;
            this.buttonUnSelect.Click += new System.EventHandler(this.buttonUnSelect_Click);
            // 
            // cbEnableSelect
            // 
            this.cbEnableSelect.AutoSize = true;
            this.cbEnableSelect.Location = new System.Drawing.Point(69, 765);
            this.cbEnableSelect.Name = "cbEnableSelect";
            this.cbEnableSelect.Size = new System.Drawing.Size(92, 17);
            this.cbEnableSelect.TabIndex = 4;
            this.cbEnableSelect.Text = "Enable Select";
            this.cbEnableSelect.UseVisualStyleBackColor = true;
            this.cbEnableSelect.CheckedChanged += new System.EventHandler(this.cbEnableSelect_CheckedChanged);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Enabled = false;
            this.buttonAbort.Location = new System.Drawing.Point(674, 750);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(80, 44);
            this.buttonAbort.TabIndex = 3;
            this.buttonAbort.Text = "Abort Run";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(466, 751);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(80, 44);
            this.buttonReg.TabIndex = 1;
            this.buttonReg.Text = "Set Origion";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // waferCtrl1
            // 
            this.waferCtrl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.waferCtrl1.Location = new System.Drawing.Point(60, 41);
            this.waferCtrl1.Name = "waferCtrl1";
            this.waferCtrl1.Size = new System.Drawing.Size(694, 692);
            this.waferCtrl1.TabIndex = 6;
            // 
            // textBoxWaferId
            // 
            this.textBoxWaferId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxWaferId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWaferId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWaferId.Location = new System.Drawing.Point(306, 118);
            this.textBoxWaferId.Name = "textBoxWaferId";
            this.textBoxWaferId.Size = new System.Drawing.Size(205, 17);
            this.textBoxWaferId.TabIndex = 7;
            this.textBoxWaferId.Text = "Enter the Wafer ID";
            this.textBoxWaferId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 839);
            this.Controls.Add(this.textBoxWaferId);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.cbEnableSelect);
            this.Controls.Add(this.buttonUnSelect);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.waferCtrl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "XX Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WaferCtrl.WaferCtrl waferCtrl1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonUnSelect;
        private System.Windows.Forms.CheckBox cbEnableSelect;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxWaferId;
    }
}

