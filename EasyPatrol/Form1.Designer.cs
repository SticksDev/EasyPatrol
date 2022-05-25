
namespace EasyPatrol
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startPatrolBttn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fiveMState = new System.Windows.Forms.Label();
            this.tsState = new System.Windows.Forms.Label();
            this.profileState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to EasyPatrol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "v0.0.1 beta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Created by DOJ Member: Tanner S. 2L-403";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Please choose what you\'d like to do today.";
            // 
            // startPatrolBttn
            // 
            this.startPatrolBttn.Location = new System.Drawing.Point(300, 227);
            this.startPatrolBttn.Name = "startPatrolBttn";
            this.startPatrolBttn.Size = new System.Drawing.Size(193, 59);
            this.startPatrolBttn.TabIndex = 4;
            this.startPatrolBttn.Text = "Start Patrol...";
            this.startPatrolBttn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Edit Profile";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fiveMState
            // 
            this.fiveMState.AutoSize = true;
            this.fiveMState.Location = new System.Drawing.Point(-3, 3);
            this.fiveMState.Name = "fiveMState";
            this.fiveMState.Size = new System.Drawing.Size(120, 13);
            this.fiveMState.TabIndex = 6;
            this.fiveMState.Text = "FiveM Status: Waiting...";
            // 
            // tsState
            // 
            this.tsState.AutoSize = true;
            this.tsState.Location = new System.Drawing.Point(-3, 16);
            this.tsState.Name = "tsState";
            this.tsState.Size = new System.Drawing.Size(145, 13);
            this.tsState.TabIndex = 7;
            this.tsState.Text = "Teamspeak status: Waiting...";
            // 
            // profileState
            // 
            this.profileState.AutoSize = true;
            this.profileState.Location = new System.Drawing.Point(-3, 29);
            this.profileState.Name = "profileState";
            this.profileState.Size = new System.Drawing.Size(122, 13);
            this.profileState.TabIndex = 8;
            this.profileState.Text = "Profile Status: Loading...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.profileState);
            this.Controls.Add(this.tsState);
            this.Controls.Add(this.fiveMState);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startPatrolBttn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Easy Patrol - Welcome!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startPatrolBttn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label fiveMState;
        private System.Windows.Forms.Label tsState;
        private System.Windows.Forms.Label profileState;
    }
}

