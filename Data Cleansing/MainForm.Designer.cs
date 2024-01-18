namespace Data_Cleansing
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelLogs = new System.Windows.Forms.Panel();
            this.PanelDataCleanse = new System.Windows.Forms.Panel();
            this.PanelDashboard = new System.Windows.Forms.Panel();
            this.LogsBtn = new System.Windows.Forms.Button();
            this.DataCleanseBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardPage1 = new Data_Cleansing.DashboardPage();
            this.dataCleansePage1 = new Data_Cleansing.DataCleansePage();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Dashboard Icon.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LogoutBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 65);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "ESS Data Cleansing System";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(1233, 15);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(114, 37);
            this.LogoutBtn.TabIndex = 1;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.PanelLogs);
            this.panel1.Controls.Add(this.PanelDataCleanse);
            this.panel1.Controls.Add(this.PanelDashboard);
            this.panel1.Controls.Add(this.LogsBtn);
            this.panel1.Controls.Add(this.DataCleanseBtn);
            this.panel1.Controls.Add(this.DashboardBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 664);
            this.panel1.TabIndex = 2;
            // 
            // PanelLogs
            // 
            this.PanelLogs.Location = new System.Drawing.Point(3, 242);
            this.PanelLogs.Name = "PanelLogs";
            this.PanelLogs.Size = new System.Drawing.Size(10, 60);
            this.PanelLogs.TabIndex = 4;
            // 
            // PanelDataCleanse
            // 
            this.PanelDataCleanse.Location = new System.Drawing.Point(3, 176);
            this.PanelDataCleanse.Name = "PanelDataCleanse";
            this.PanelDataCleanse.Size = new System.Drawing.Size(10, 60);
            this.PanelDataCleanse.TabIndex = 4;
            // 
            // PanelDashboard
            // 
            this.PanelDashboard.Location = new System.Drawing.Point(3, 110);
            this.PanelDashboard.Name = "PanelDashboard";
            this.PanelDashboard.Size = new System.Drawing.Size(10, 60);
            this.PanelDashboard.TabIndex = 3;
            // 
            // LogsBtn
            // 
            this.LogsBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogsBtn.FlatAppearance.BorderSize = 0;
            this.LogsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogsBtn.Image = global::Data_Cleansing.Properties.Resources.files__2_;
            this.LogsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogsBtn.Location = new System.Drawing.Point(12, 242);
            this.LogsBtn.Name = "LogsBtn";
            this.LogsBtn.Size = new System.Drawing.Size(188, 60);
            this.LogsBtn.TabIndex = 2;
            this.LogsBtn.Text = "Logs";
            this.LogsBtn.UseVisualStyleBackColor = false;
            this.LogsBtn.Click += new System.EventHandler(this.LogsBtn_Click);
            // 
            // DataCleanseBtn
            // 
            this.DataCleanseBtn.BackColor = System.Drawing.Color.Transparent;
            this.DataCleanseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataCleanseBtn.FlatAppearance.BorderSize = 0;
            this.DataCleanseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataCleanseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataCleanseBtn.Image = global::Data_Cleansing.Properties.Resources.data_cleaning__1_;
            this.DataCleanseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataCleanseBtn.Location = new System.Drawing.Point(12, 176);
            this.DataCleanseBtn.Name = "DataCleanseBtn";
            this.DataCleanseBtn.Size = new System.Drawing.Size(188, 60);
            this.DataCleanseBtn.TabIndex = 1;
            this.DataCleanseBtn.Text = "Data Cleanse";
            this.DataCleanseBtn.UseVisualStyleBackColor = false;
            this.DataCleanseBtn.Click += new System.EventHandler(this.DataCleanseBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.Image = global::Data_Cleansing.Properties.Resources.menu__1_;
            this.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.Location = new System.Drawing.Point(12, 110);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(188, 60);
            this.DashboardBtn.TabIndex = 0;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = false;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Data_Cleansing.Properties.Resources.hamburger;
            this.pictureBox1.Location = new System.Drawing.Point(152, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardPage1
            // 
            this.dashboardPage1.BackColor = System.Drawing.Color.White;
            this.dashboardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPage1.Location = new System.Drawing.Point(200, 65);
            this.dashboardPage1.Name = "dashboardPage1";
            this.dashboardPage1.Size = new System.Drawing.Size(1150, 664);
            this.dashboardPage1.TabIndex = 3;
            this.dashboardPage1.Load += new System.EventHandler(this.dashboardPage1_Load_1);
            // 
            // dataCleansePage1
            // 
            this.dataCleansePage1.BackColor = System.Drawing.Color.White;
            this.dataCleansePage1.Location = new System.Drawing.Point(200, 65);
            this.dataCleansePage1.Name = "dataCleansePage1";
            this.dataCleansePage1.Size = new System.Drawing.Size(1150, 664);
            this.dataCleansePage1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dashboardPage1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataCleansePage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESS Data Cleansing System";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DashboardPage dashboardPage1;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DataCleanseBtn;
        private DataCleansePage dataCleansePage1;
        private System.Windows.Forms.Button LogsBtn;
        private System.Windows.Forms.Panel PanelLogs;
        private System.Windows.Forms.Panel PanelDataCleanse;
        private System.Windows.Forms.Panel PanelDashboard;
    }
}