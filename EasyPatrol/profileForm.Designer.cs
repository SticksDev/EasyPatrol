namespace EasyPatrol
{
    partial class profileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DOJNameEntry = new System.Windows.Forms.TextBox();
            this.DOJUnitEntry = new System.Windows.Forms.TextBox();
            this.DOJWebIDEntry = new System.Windows.Forms.TextBox();
            this.TimezoneEntry = new System.Windows.Forms.TextBox();
            this.saveAndExit = new System.Windows.Forms.Button();
            this.departmentPicker = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOJ Name (w/o unit number)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOJ Unit Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOJ WebID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Timezone (Defaults to EST)";
            // 
            // DOJNameEntry
            // 
            this.DOJNameEntry.Location = new System.Drawing.Point(69, 102);
            this.DOJNameEntry.Name = "DOJNameEntry";
            this.DOJNameEntry.Size = new System.Drawing.Size(171, 20);
            this.DOJNameEntry.TabIndex = 4;
            // 
            // DOJUnitEntry
            // 
            this.DOJUnitEntry.Location = new System.Drawing.Point(69, 169);
            this.DOJUnitEntry.Name = "DOJUnitEntry";
            this.DOJUnitEntry.Size = new System.Drawing.Size(171, 20);
            this.DOJUnitEntry.TabIndex = 5;
            // 
            // DOJWebIDEntry
            // 
            this.DOJWebIDEntry.Location = new System.Drawing.Point(69, 221);
            this.DOJWebIDEntry.Name = "DOJWebIDEntry";
            this.DOJWebIDEntry.Size = new System.Drawing.Size(171, 20);
            this.DOJWebIDEntry.TabIndex = 6;
            // 
            // TimezoneEntry
            // 
            this.TimezoneEntry.Location = new System.Drawing.Point(67, 270);
            this.TimezoneEntry.Name = "TimezoneEntry";
            this.TimezoneEntry.Size = new System.Drawing.Size(173, 20);
            this.TimezoneEntry.TabIndex = 7;
            // 
            // saveAndExit
            // 
            this.saveAndExit.Location = new System.Drawing.Point(69, 361);
            this.saveAndExit.Name = "saveAndExit";
            this.saveAndExit.Size = new System.Drawing.Size(149, 59);
            this.saveAndExit.TabIndex = 8;
            this.saveAndExit.Text = "Save And Exit";
            this.saveAndExit.UseVisualStyleBackColor = true;
            this.saveAndExit.Click += new System.EventHandler(this.saveAndExit_Click);
            // 
            // departmentPicker
            // 
            this.departmentPicker.ForeColor = System.Drawing.SystemColors.WindowText;
            this.departmentPicker.FormattingEnabled = true;
            this.departmentPicker.Items.AddRange(new object[] {
            "LSPD",
            "BSCO",
            "SAHP",
            "LSFD",
            "SACD",
            "CIV"});
            this.departmentPicker.Location = new System.Drawing.Point(69, 45);
            this.departmentPicker.Name = "departmentPicker";
            this.departmentPicker.Size = new System.Drawing.Size(171, 21);
            this.departmentPicker.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DOJ Main Department";
            // 
            // profileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.departmentPicker);
            this.Controls.Add(this.saveAndExit);
            this.Controls.Add(this.TimezoneEntry);
            this.Controls.Add(this.DOJWebIDEntry);
            this.Controls.Add(this.DOJUnitEntry);
            this.Controls.Add(this.DOJNameEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "profileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Current Profile";
            this.Shown += new System.EventHandler(this.profileForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DOJNameEntry;
        private System.Windows.Forms.TextBox DOJUnitEntry;
        private System.Windows.Forms.TextBox DOJWebIDEntry;
        private System.Windows.Forms.TextBox TimezoneEntry;
        private System.Windows.Forms.Button saveAndExit;
        private System.Windows.Forms.ComboBox departmentPicker;
        private System.Windows.Forms.Label label5;
    }
}