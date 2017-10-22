namespace TSZDashboard
{
    partial class Dashboard
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
            this.tabPilotList = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPilots = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabControl();
            this.tabProfileInformation = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pilotCtrl1 = new TSZDashboard.UI.PilotCtrl();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPilotList.SuspendLayout();
            this.tabPilots.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.tabProfileInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPilotList
            // 
            this.tabPilotList.Controls.Add(this.tabPage1);
            this.tabPilotList.Controls.Add(this.tabPilots);
            this.tabPilotList.Location = new System.Drawing.Point(12, 35);
            this.tabPilotList.Name = "tabPilotList";
            this.tabPilotList.SelectedIndex = 0;
            this.tabPilotList.Size = new System.Drawing.Size(1044, 677);
            this.tabPilotList.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1036, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPilots
            // 
            this.tabPilots.Controls.Add(this.tabProfile);
            this.tabPilots.Location = new System.Drawing.Point(4, 22);
            this.tabPilots.Name = "tabPilots";
            this.tabPilots.Padding = new System.Windows.Forms.Padding(3);
            this.tabPilots.Size = new System.Drawing.Size(1036, 651);
            this.tabPilots.TabIndex = 1;
            this.tabPilots.Text = "Pilots";
            this.tabPilots.UseVisualStyleBackColor = true;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.tabProfileInformation);
            this.tabProfile.Controls.Add(this.tabPage3);
            this.tabProfile.Location = new System.Drawing.Point(0, 0);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.SelectedIndex = 0;
            this.tabProfile.Size = new System.Drawing.Size(1040, 655);
            this.tabProfile.TabIndex = 0;
            // 
            // tabProfileInformation
            // 
            this.tabProfileInformation.Controls.Add(this.btnSave);
            this.tabProfileInformation.Controls.Add(this.pilotCtrl1);
            this.tabProfileInformation.Location = new System.Drawing.Point(4, 22);
            this.tabProfileInformation.Name = "tabProfileInformation";
            this.tabProfileInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfileInformation.Size = new System.Drawing.Size(1032, 629);
            this.tabProfileInformation.TabIndex = 0;
            this.tabProfileInformation.Text = "Profile";
            this.tabProfileInformation.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(192, 74);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pilotCtrl1
            // 
            this.pilotCtrl1.Location = new System.Drawing.Point(0, 0);
            this.pilotCtrl1.Name = "pilotCtrl1";
            this.pilotCtrl1.Size = new System.Drawing.Size(587, 120);
            this.pilotCtrl1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(921, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 54);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 724);
            this.Controls.Add(this.tabPilotList);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.tabPilotList.ResumeLayout(false);
            this.tabPilots.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabProfileInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPilotList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPilots;
        private System.Windows.Forms.TabControl tabProfile;
        private System.Windows.Forms.TabPage tabProfileInformation;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSave;
        private UI.PilotCtrl pilotCtrl1;
    }
}