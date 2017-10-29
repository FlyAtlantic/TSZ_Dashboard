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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabTypeRatings = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxTyperatingsname = new System.Windows.Forms.ComboBox();
            this.btnInsertTyperating = new System.Windows.Forms.Button();
            this.GridTypeRatings = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.tabQualifications = new System.Windows.Forms.TabPage();
            this.GridQualificatioms = new System.Windows.Forms.DataGridView();
            this.tabPilotList.SuspendLayout();
            this.tabPilots.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.tabProfileInformation.SuspendLayout();
            this.tabLogBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabTypeRatings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTypeRatings)).BeginInit();
            this.tabQualifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridQualificatioms)).BeginInit();
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
            this.tabPilotList.Size = new System.Drawing.Size(1048, 677);
            this.tabPilotList.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1040, 651);
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
            this.tabPilots.Size = new System.Drawing.Size(1040, 651);
            this.tabPilots.TabIndex = 1;
            this.tabPilots.Text = "Pilots";
            this.tabPilots.UseVisualStyleBackColor = true;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.tabProfileInformation);
            this.tabProfile.Controls.Add(this.tabLogBook);
            this.tabProfile.Controls.Add(this.tabTypeRatings);
            this.tabProfile.Controls.Add(this.tabQualifications);
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
            this.pilotCtrl1.Location = new System.Drawing.Point(-1, 0);
            this.pilotCtrl1.Name = "pilotCtrl1";
            this.pilotCtrl1.Size = new System.Drawing.Size(680, 283);
            this.pilotCtrl1.TabIndex = 2;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(701, 23);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(75, 54);
            this.btnSaveProfile.TabIndex = 1;
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // tabLogBook
            // 
            this.tabLogBook.Controls.Add(this.dataGridView1);
            this.tabLogBook.Location = new System.Drawing.Point(4, 22);
            this.tabLogBook.Name = "tabLogBook";
            this.tabLogBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogBook.Size = new System.Drawing.Size(1032, 629);
            this.tabLogBook.TabIndex = 1;
            this.tabLogBook.Text = "LogBook";
            this.tabLogBook.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1033, 617);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabTypeRatings
            // 
            this.tabTypeRatings.Controls.Add(this.label1);
            this.tabTypeRatings.Controls.Add(this.cboxTyperatingsname);
            this.tabTypeRatings.Controls.Add(this.btnInsertTyperating);
            this.tabTypeRatings.Controls.Add(this.GridTypeRatings);
            this.tabTypeRatings.Location = new System.Drawing.Point(4, 22);
            this.tabTypeRatings.Name = "tabTypeRatings";
            this.tabTypeRatings.Padding = new System.Windows.Forms.Padding(3);
            this.tabTypeRatings.Size = new System.Drawing.Size(1032, 629);
            this.tabTypeRatings.TabIndex = 2;
            this.tabTypeRatings.Text = "TypeRatings";
            this.tabTypeRatings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(884, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insert New Typerating";
            // 
            // cboxTyperatingsname
            // 
            this.cboxTyperatingsname.FormattingEnabled = true;
            this.cboxTyperatingsname.Location = new System.Drawing.Point(879, 42);
            this.cboxTyperatingsname.Name = "cboxTyperatingsname";
            this.cboxTyperatingsname.Size = new System.Drawing.Size(121, 21);
            this.cboxTyperatingsname.TabIndex = 3;
            // 
            // btnInsertTyperating
            // 
            this.btnInsertTyperating.Location = new System.Drawing.Point(901, 69);
            this.btnInsertTyperating.Name = "btnInsertTyperating";
            this.btnInsertTyperating.Size = new System.Drawing.Size(75, 23);
            this.btnInsertTyperating.TabIndex = 2;
            this.btnInsertTyperating.Text = "Insert";
            this.btnInsertTyperating.UseVisualStyleBackColor = true;
            this.btnInsertTyperating.Click += new System.EventHandler(this.btnInsertTyperating_Click);
            // 
            // GridTypeRatings
            // 
            this.GridTypeRatings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTypeRatings.Location = new System.Drawing.Point(0, 6);
            this.GridTypeRatings.Name = "GridTypeRatings";
            this.GridTypeRatings.Size = new System.Drawing.Size(844, 617);
            this.GridTypeRatings.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1040, 651);
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
            // tabQualifications
            // 
            this.tabQualifications.Controls.Add(this.GridQualificatioms);
            this.tabQualifications.Location = new System.Drawing.Point(4, 22);
            this.tabQualifications.Name = "tabQualifications";
            this.tabQualifications.Padding = new System.Windows.Forms.Padding(3);
            this.tabQualifications.Size = new System.Drawing.Size(1032, 629);
            this.tabQualifications.TabIndex = 3;
            this.tabQualifications.Text = "Qualifications";
            this.tabQualifications.UseVisualStyleBackColor = true;
            // 
            // GridQualificatioms
            // 
            this.GridQualificatioms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridQualificatioms.Location = new System.Drawing.Point(0, 0);
            this.GridQualificatioms.Name = "GridQualificatioms";
            this.GridQualificatioms.Size = new System.Drawing.Size(844, 617);
            this.GridQualificatioms.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 724);
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
            this.tabTypeRatings.ResumeLayout(false);
            this.tabTypeRatings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTypeRatings)).EndInit();
            this.tabQualifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridQualificatioms)).EndInit();
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
        private System.Windows.Forms.TabPage tabTypeRatings;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView GridTypeRatings;
        private System.Windows.Forms.Button btnInsertTyperating;
        private System.Windows.Forms.ComboBox cboxTyperatingsname;
        private System.Windows.Forms.Label label1;
        private UI.PilotCtrl pilotCtrl1;
        private System.Windows.Forms.TabPage tabQualifications;
        private System.Windows.Forms.DataGridView GridQualificatioms;
    }
}