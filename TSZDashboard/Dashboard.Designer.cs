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
            this.pilotCtrl1 = new TSZDashboard.UI.PilotCtrl();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.tabLogBook = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.tabPilotList.SuspendLayout();
            this.tabPilots.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.tabProfileInformation.SuspendLayout();
            this.tabLogBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPilotList
            // 
            this.tabPilotList.Controls.Add(this.tabPage1);
            this.tabPilotList.Controls.Add(this.tabPilots);
            this.tabPilotList.Controls.Add(this.tabPage2);
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
            this.tabProfile.Controls.Add(this.tabLogBook);
            this.tabProfile.Controls.Add(this.tabPage4);
            this.tabProfile.Location = new System.Drawing.Point(0, 0);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.SelectedIndex = 0;
            this.tabProfile.Size = new System.Drawing.Size(1040, 655);
            this.tabProfile.TabIndex = 0;
            // 
            // tabProfileInformation
            // 
            this.tabProfileInformation.Controls.Add(this.pilotCtrl1);
            this.tabProfileInformation.Controls.Add(this.btnSaveProfile);
            this.tabProfileInformation.Location = new System.Drawing.Point(4, 22);
            this.tabProfileInformation.Name = "tabProfileInformation";
            this.tabProfileInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfileInformation.Size = new System.Drawing.Size(1032, 629);
            this.tabProfileInformation.TabIndex = 0;
            this.tabProfileInformation.Text = "Profile";
            this.tabProfileInformation.UseVisualStyleBackColor = true;
            // 
            // pilotCtrl1
            // 
            this.pilotCtrl1.Location = new System.Drawing.Point(6, 6);
            this.pilotCtrl1.Name = "pilotCtrl1";
            this.pilotCtrl1.Size = new System.Drawing.Size(587, 120);
            this.pilotCtrl1.TabIndex = 9;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(921, 24);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(75, 54);
            this.btnSaveProfile.TabIndex = 1;
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // tabLogBook
            // 
            this.tabLogBook.Controls.Add(this.button2);
            this.tabLogBook.Controls.Add(this.dataGridView1);
            this.tabLogBook.Location = new System.Drawing.Point(4, 22);
            this.tabLogBook.Name = "tabLogBook";
            this.tabLogBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogBook.Size = new System.Drawing.Size(1032, 629);
            this.tabLogBook.TabIndex = 1;
            this.tabLogBook.Text = "LogBook";
            this.tabLogBook.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(919, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(873, 617);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1032, 629);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1036, 651);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(563, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(457, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 20);
            this.txtFind.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 724);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tabPilotList);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.tabPilotList.ResumeLayout(false);
            this.tabPilots.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabProfileInformation.ResumeLayout(false);
            this.tabLogBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPilotList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPilots;
        private System.Windows.Forms.TabControl tabProfile;
        private System.Windows.Forms.TabPage tabProfileInformation;
        private System.Windows.Forms.TabPage tabLogBook;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnFind;
        private UI.PilotCtrl pilotCtrl1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}