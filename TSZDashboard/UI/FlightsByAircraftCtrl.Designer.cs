namespace TSZDashboard.UI
{
    partial class FlightsByAircraftCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridAllTyperatings = new System.Windows.Forms.DataGridView();
            this.GridAllQualifications = new System.Windows.Forms.DataGridView();
            this.btnFindByAircraft = new System.Windows.Forms.Button();
            this.cboxAircrafts = new System.Windows.Forms.ComboBox();
            this.flightC172Ctrl = new TSZDashboard.UI.FlightC172Ctrl();
            ((System.ComponentModel.ISupportInitialize)(this.GridAllTyperatings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAllQualifications)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAllTyperatings
            // 
            this.GridAllTyperatings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAllTyperatings.Location = new System.Drawing.Point(25, 157);
            this.GridAllTyperatings.MultiSelect = false;
            this.GridAllTyperatings.Name = "GridAllTyperatings";
            this.GridAllTyperatings.ReadOnly = true;
            this.GridAllTyperatings.Size = new System.Drawing.Size(465, 430);
            this.GridAllTyperatings.TabIndex = 19;
            // 
            // GridAllQualifications
            // 
            this.GridAllQualifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAllQualifications.Location = new System.Drawing.Point(538, 157);
            this.GridAllQualifications.MultiSelect = false;
            this.GridAllQualifications.Name = "GridAllQualifications";
            this.GridAllQualifications.ReadOnly = true;
            this.GridAllQualifications.Size = new System.Drawing.Size(465, 430);
            this.GridAllQualifications.TabIndex = 20;
            // 
            // btnFindByAircraft
            // 
            this.btnFindByAircraft.Location = new System.Drawing.Point(334, 20);
            this.btnFindByAircraft.Name = "btnFindByAircraft";
            this.btnFindByAircraft.Size = new System.Drawing.Size(109, 23);
            this.btnFindByAircraft.TabIndex = 0;
            this.btnFindByAircraft.Text = "Find By Aircraft";
            this.btnFindByAircraft.UseVisualStyleBackColor = true;
            this.btnFindByAircraft.Click += new System.EventHandler(this.btnFlightC172_Click);
            // 
            // cboxAircrafts
            // 
            this.cboxAircrafts.FormattingEnabled = true;
            this.cboxAircrafts.Location = new System.Drawing.Point(207, 22);
            this.cboxAircrafts.Name = "cboxAircrafts";
            this.cboxAircrafts.Size = new System.Drawing.Size(121, 21);
            this.cboxAircrafts.TabIndex = 22;
            // 
            // flightC172Ctrl
            // 
            this.flightC172Ctrl.Location = new System.Drawing.Point(0, 62);
            this.flightC172Ctrl.Name = "flightC172Ctrl";
            this.flightC172Ctrl.Size = new System.Drawing.Size(1044, 544);
            this.flightC172Ctrl.TabIndex = 23;
            // 
            // FlightsByAircraftCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flightC172Ctrl);
            this.Controls.Add(this.cboxAircrafts);
            this.Controls.Add(this.GridAllQualifications);
            this.Controls.Add(this.GridAllTyperatings);
            this.Controls.Add(this.btnFindByAircraft);
            this.Name = "FlightsByAircraftCtrl";
            this.Size = new System.Drawing.Size(1044, 606);
            ((System.ComponentModel.ISupportInitialize)(this.GridAllTyperatings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAllQualifications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GridAllTyperatings;
        private System.Windows.Forms.DataGridView GridAllQualifications;
        private System.Windows.Forms.Button btnFindByAircraft;
        private System.Windows.Forms.ComboBox cboxAircrafts;
        private FlightC172Ctrl flightC172Ctrl;
    }
}
