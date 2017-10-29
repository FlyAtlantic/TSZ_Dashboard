namespace TSZDashboard.UI
{
    partial class FlightC172Ctrl
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
            this.GridRoutesC172 = new System.Windows.Forms.DataGridView();
            this.btnCloseC172 = new System.Windows.Forms.Button();
            this.txtDepIcao = new System.Windows.Forms.TextBox();
            this.btnFindByDeparture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridRoutesC172)).BeginInit();
            this.SuspendLayout();
            // 
            // GridRoutesC172
            // 
            this.GridRoutesC172.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRoutesC172.Location = new System.Drawing.Point(18, 35);
            this.GridRoutesC172.MultiSelect = false;
            this.GridRoutesC172.Name = "GridRoutesC172";
            this.GridRoutesC172.ReadOnly = true;
            this.GridRoutesC172.Size = new System.Drawing.Size(748, 416);
            this.GridRoutesC172.TabIndex = 20;
            // 
            // btnCloseC172
            // 
            this.btnCloseC172.Location = new System.Drawing.Point(815, 428);
            this.btnCloseC172.Name = "btnCloseC172";
            this.btnCloseC172.Size = new System.Drawing.Size(75, 23);
            this.btnCloseC172.TabIndex = 22;
            this.btnCloseC172.Text = "Close";
            this.btnCloseC172.UseVisualStyleBackColor = true;
            this.btnCloseC172.Click += new System.EventHandler(this.btnCloseC172_Click);
            // 
            // txtDepIcao
            // 
            this.txtDepIcao.Location = new System.Drawing.Point(825, 35);
            this.txtDepIcao.Name = "txtDepIcao";
            this.txtDepIcao.Size = new System.Drawing.Size(65, 20);
            this.txtDepIcao.TabIndex = 23;
            // 
            // btnFindByDeparture
            // 
            this.btnFindByDeparture.Location = new System.Drawing.Point(790, 61);
            this.btnFindByDeparture.Name = "btnFindByDeparture";
            this.btnFindByDeparture.Size = new System.Drawing.Size(100, 23);
            this.btnFindByDeparture.TabIndex = 24;
            this.btnFindByDeparture.Text = "Find by Departure";
            this.btnFindByDeparture.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ICAO";
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(34, 16);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(35, 13);
            this.LBL1.TabIndex = 26;
            this.LBL1.Text = "label2";
            // 
            // FlightC172Ctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindByDeparture);
            this.Controls.Add(this.txtDepIcao);
            this.Controls.Add(this.btnCloseC172);
            this.Controls.Add(this.GridRoutesC172);
            this.Name = "FlightC172Ctrl";
            this.Size = new System.Drawing.Size(914, 481);
            ((System.ComponentModel.ISupportInitialize)(this.GridRoutesC172)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridRoutesC172;
        private System.Windows.Forms.Button btnCloseC172;
        private System.Windows.Forms.TextBox txtDepIcao;
        private System.Windows.Forms.Button btnFindByDeparture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL1;
    }
}
