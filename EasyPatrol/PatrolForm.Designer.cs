namespace EasyPatrol
{
    partial class patrolWindow
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
            this.currPatrolTime = new System.Windows.Forms.Label();
            this.serverLabel = new System.Windows.Forms.Label();
            this.upperClock = new System.Windows.Forms.Label();
            this.exitWithoutSaving = new System.Windows.Forms.Button();
            this.saveToFile = new System.Windows.Forms.Button();
            this.SaveAndFillLog = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentIdent = new System.Windows.Forms.Label();
            this.currentDept = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.startAndPause = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.serverChooserBox = new System.Windows.Forms.ComboBox();
            this.currentStatus = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.stopPatrol = new System.Windows.Forms.Button();
            this.startDelay = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.enableRideAlongSettings = new System.Windows.Forms.CheckBox();
            this.unitRideAlongWebID = new System.Windows.Forms.TextBox();
            this.unitRideAlongIdent = new System.Windows.Forms.TextBox();
            this.rideAlongUnitText = new System.Windows.Forms.Label();
            this.rideAlongUnitIdentText = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.quitApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currPatrolTime
            // 
            this.currPatrolTime.AutoSize = true;
            this.currPatrolTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currPatrolTime.Location = new System.Drawing.Point(12, 88);
            this.currPatrolTime.Name = "currPatrolTime";
            this.currPatrolTime.Size = new System.Drawing.Size(252, 24);
            this.currPatrolTime.TabIndex = 0;
            this.currPatrolTime.Text = "Current Patrol Time: 00:00:00";
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLabel.Location = new System.Drawing.Point(12, 112);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(277, 24);
            this.serverLabel.TabIndex = 1;
            this.serverLabel.Text = "Current Selected Server: NONE";
            // 
            // upperClock
            // 
            this.upperClock.AutoSize = true;
            this.upperClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperClock.Location = new System.Drawing.Point(208, 9);
            this.upperClock.Name = "upperClock";
            this.upperClock.Size = new System.Drawing.Size(141, 24);
            this.upperClock.TabIndex = 2;
            this.upperClock.Text = "Loading Time...";
            // 
            // exitWithoutSaving
            // 
            this.exitWithoutSaving.Location = new System.Drawing.Point(379, 400);
            this.exitWithoutSaving.Name = "exitWithoutSaving";
            this.exitWithoutSaving.Size = new System.Drawing.Size(128, 38);
            this.exitWithoutSaving.TabIndex = 3;
            this.exitWithoutSaving.Text = "Exit without Saving";
            this.exitWithoutSaving.UseVisualStyleBackColor = true;
            this.exitWithoutSaving.Click += new System.EventHandler(this.exitWithoutSaving_Click);
            // 
            // saveToFile
            // 
            this.saveToFile.Location = new System.Drawing.Point(660, 400);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(128, 38);
            this.saveToFile.TabIndex = 4;
            this.saveToFile.Text = "Save to file...";
            this.saveToFile.UseVisualStyleBackColor = true;
            this.saveToFile.Click += new System.EventHandler(this.saveToFile_Click);
            // 
            // SaveAndFillLog
            // 
            this.SaveAndFillLog.Location = new System.Drawing.Point(513, 400);
            this.SaveAndFillLog.Name = "SaveAndFillLog";
            this.SaveAndFillLog.Size = new System.Drawing.Size(128, 38);
            this.SaveAndFillLog.TabIndex = 5;
            this.SaveAndFillLog.Text = "Save and Fill Log";
            this.SaveAndFillLog.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "User Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Patrol Info";
            // 
            // currentIdent
            // 
            this.currentIdent.AutoSize = true;
            this.currentIdent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentIdent.Location = new System.Drawing.Point(11, 238);
            this.currentIdent.Name = "currentIdent";
            this.currentIdent.Size = new System.Drawing.Size(152, 24);
            this.currentIdent.TabIndex = 8;
            this.currentIdent.Text = "Current Identifier:";
            // 
            // currentDept
            // 
            this.currentDept.AutoSize = true;
            this.currentDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDept.Location = new System.Drawing.Point(11, 262);
            this.currentDept.Name = "currentDept";
            this.currentDept.Size = new System.Drawing.Size(112, 24);
            this.currentDept.TabIndex = 9;
            this.currentDept.Text = "Department:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(368, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Patrol Settings";
            // 
            // startAndPause
            // 
            this.startAndPause.Location = new System.Drawing.Point(370, 88);
            this.startAndPause.Name = "startAndPause";
            this.startAndPause.Size = new System.Drawing.Size(240, 48);
            this.startAndPause.TabIndex = 11;
            this.startAndPause.Text = "Start/Pause Patrol Timer";
            this.startAndPause.UseVisualStyleBackColor = true;
            this.startAndPause.Click += new System.EventHandler(this.startAndPause_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(369, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Selected Server";
            // 
            // serverChooserBox
            // 
            this.serverChooserBox.FormattingEnabled = true;
            this.serverChooserBox.Items.AddRange(new object[] {
            "Server 1",
            "Server 2",
            "Server X"});
            this.serverChooserBox.Location = new System.Drawing.Point(372, 188);
            this.serverChooserBox.Name = "serverChooserBox";
            this.serverChooserBox.Size = new System.Drawing.Size(176, 21);
            this.serverChooserBox.TabIndex = 13;
            this.serverChooserBox.SelectedIndexChanged += new System.EventHandler(this.serverChooserBox_SelectedIndexChanged);
            // 
            // currentStatus
            // 
            this.currentStatus.AutoSize = true;
            this.currentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStatus.Location = new System.Drawing.Point(6, 417);
            this.currentStatus.Name = "currentStatus";
            this.currentStatus.Size = new System.Drawing.Size(158, 24);
            this.currentStatus.TabIndex = 14;
            this.currentStatus.Text = "Current State: Idle";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(12, 149);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(158, 18);
            this.startDateLabel.TabIndex = 15;
            this.startDateLabel.Text = "Patrol Start Time/Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(13, 167);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(153, 18);
            this.endDateLabel.TabIndex = 16;
            this.endDateLabel.Text = "Patrol End Time/Date:";
            // 
            // stopPatrol
            // 
            this.stopPatrol.Location = new System.Drawing.Point(626, 88);
            this.stopPatrol.Name = "stopPatrol";
            this.stopPatrol.Size = new System.Drawing.Size(147, 48);
            this.stopPatrol.TabIndex = 17;
            this.stopPatrol.Text = "Stop Patrol";
            this.stopPatrol.UseVisualStyleBackColor = true;
            this.stopPatrol.Click += new System.EventHandler(this.stopPatrol_Click);
            // 
            // startDelay
            // 
            this.startDelay.Location = new System.Drawing.Point(579, 188);
            this.startDelay.Name = "startDelay";
            this.startDelay.Size = new System.Drawing.Size(181, 20);
            this.startDelay.TabIndex = 18;
            this.startDelay.TextChanged += new System.EventHandler(this.startDelay_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(576, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 18);
            this.label13.TabIndex = 19;
            this.label13.Text = "Start Delay (Seconds)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(368, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 24);
            this.label14.TabIndex = 20;
            this.label14.Text = "Autofill Settings";
            // 
            // enableRideAlongSettings
            // 
            this.enableRideAlongSettings.AutoSize = true;
            this.enableRideAlongSettings.Location = new System.Drawing.Point(372, 269);
            this.enableRideAlongSettings.Name = "enableRideAlongSettings";
            this.enableRideAlongSettings.Size = new System.Drawing.Size(98, 17);
            this.enableRideAlongSettings.TabIndex = 21;
            this.enableRideAlongSettings.Text = "Was in a 10-12";
            this.enableRideAlongSettings.UseVisualStyleBackColor = true;
            this.enableRideAlongSettings.CheckedChanged += new System.EventHandler(this.enableRideAlongSettings_CheckedChanged);
            // 
            // unitRideAlongWebID
            // 
            this.unitRideAlongWebID.Location = new System.Drawing.Point(370, 307);
            this.unitRideAlongWebID.Name = "unitRideAlongWebID";
            this.unitRideAlongWebID.Size = new System.Drawing.Size(151, 20);
            this.unitRideAlongWebID.TabIndex = 22;
            this.unitRideAlongWebID.Visible = false;
            // 
            // unitRideAlongIdent
            // 
            this.unitRideAlongIdent.Location = new System.Drawing.Point(372, 352);
            this.unitRideAlongIdent.Name = "unitRideAlongIdent";
            this.unitRideAlongIdent.Size = new System.Drawing.Size(224, 20);
            this.unitRideAlongIdent.TabIndex = 23;
            this.unitRideAlongIdent.Visible = false;
            // 
            // rideAlongUnitText
            // 
            this.rideAlongUnitText.AutoSize = true;
            this.rideAlongUnitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rideAlongUnitText.Location = new System.Drawing.Point(369, 289);
            this.rideAlongUnitText.Name = "rideAlongUnitText";
            this.rideAlongUnitText.Size = new System.Drawing.Size(106, 16);
            this.rideAlongUnitText.TabIndex = 24;
            this.rideAlongUnitText.Text = "10-12 Unit webID";
            this.rideAlongUnitText.Visible = false;
            // 
            // rideAlongUnitIdentText
            // 
            this.rideAlongUnitIdentText.AutoSize = true;
            this.rideAlongUnitIdentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rideAlongUnitIdentText.Location = new System.Drawing.Point(369, 336);
            this.rideAlongUnitIdentText.Name = "rideAlongUnitIdentText";
            this.rideAlongUnitIdentText.Size = new System.Drawing.Size(227, 13);
            this.rideAlongUnitIdentText.TabIndex = 25;
            this.rideAlongUnitIdentText.Text = "10-12 Unit Name + No. (E.g Tanner S. 2L-403)";
            this.rideAlongUnitIdentText.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(485, 269);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(157, 17);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "Dry Run (Don\'t click submit)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // quitApp
            // 
            this.quitApp.Location = new System.Drawing.Point(16, 9);
            this.quitApp.Name = "quitApp";
            this.quitApp.Size = new System.Drawing.Size(68, 21);
            this.quitApp.TabIndex = 27;
            this.quitApp.Text = "Quit";
            this.quitApp.UseVisualStyleBackColor = true;
            this.quitApp.Click += new System.EventHandler(this.quitApp_Click);
            // 
            // patrolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quitApp);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.rideAlongUnitIdentText);
            this.Controls.Add(this.rideAlongUnitText);
            this.Controls.Add(this.unitRideAlongIdent);
            this.Controls.Add(this.unitRideAlongWebID);
            this.Controls.Add(this.enableRideAlongSettings);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.startDelay);
            this.Controls.Add(this.stopPatrol);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.currentStatus);
            this.Controls.Add(this.serverChooserBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.startAndPause);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.currentDept);
            this.Controls.Add(this.currentIdent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveAndFillLog);
            this.Controls.Add(this.saveToFile);
            this.Controls.Add(this.exitWithoutSaving);
            this.Controls.Add(this.upperClock);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.currPatrolTime);
            this.Name = "patrolWindow";
            this.Text = "EasyPatrol - Patrol";
            this.Shown += new System.EventHandler(this.patrolWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currPatrolTime;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label upperClock;
        private System.Windows.Forms.Button exitWithoutSaving;
        private System.Windows.Forms.Button saveToFile;
        private System.Windows.Forms.Button SaveAndFillLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentIdent;
        private System.Windows.Forms.Label currentDept;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button startAndPause;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox serverChooserBox;
        private System.Windows.Forms.Label currentStatus;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Button stopPatrol;
        private System.Windows.Forms.TextBox startDelay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox enableRideAlongSettings;
        private System.Windows.Forms.TextBox unitRideAlongWebID;
        private System.Windows.Forms.TextBox unitRideAlongIdent;
        private System.Windows.Forms.Label rideAlongUnitText;
        private System.Windows.Forms.Label rideAlongUnitIdentText;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button quitApp;
    }
}