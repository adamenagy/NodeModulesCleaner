namespace NodeModulesCleaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.Button();
            this.copyrightText = new System.Windows.Forms.TextBox();
            this.filesToKeep = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.processStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.validatePackages = new System.Windows.Forms.Button();
            this.problemFiles = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "@adsk folder location:";
            // 
            // folderPath
            // 
            this.folderPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderPath.Location = new System.Drawing.Point(139, 3);
            this.folderPath.Name = "folderPath";
            this.folderPath.ReadOnly = true;
            this.folderPath.Size = new System.Drawing.Size(481, 20);
            this.folderPath.TabIndex = 1;
            this.folderPath.Text = "Y:\\Adam\\GitHub\\nagyad\\ConfiguratorTutorial\\configurator\\node_modules\\@adsk";
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(624, 2);
            this.selectFolder.Margin = new System.Windows.Forms.Padding(1, 2, 3, 3);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(26, 23);
            this.selectFolder.TabIndex = 2;
            this.selectFolder.Text = "...";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // copyrightText
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.copyrightText, 3);
            this.copyrightText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyrightText.Location = new System.Drawing.Point(3, 33);
            this.copyrightText.Multiline = true;
            this.copyrightText.Name = "copyrightText";
            this.copyrightText.Size = new System.Drawing.Size(652, 164);
            this.copyrightText.TabIndex = 3;
            this.copyrightText.Text = resources.GetString("copyrightText.Text");
            // 
            // filesToKeep
            // 
            this.filesToKeep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesToKeep.Location = new System.Drawing.Point(3, 203);
            this.filesToKeep.Multiline = true;
            this.filesToKeep.Name = "filesToKeep";
            this.filesToKeep.Size = new System.Drawing.Size(130, 164);
            this.filesToKeep.TabIndex = 4;
            this.filesToKeep.Text = ".min.js\r\ncore-gs.js\r\npackage.json";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(119, 1);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(658, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // processStatus
            // 
            this.processStatus.Name = "processStatus";
            this.processStatus.Size = new System.Drawing.Size(26, 17);
            this.processStatus.Text = "Idle";
            // 
            // validatePackages
            // 
            this.validatePackages.Location = new System.Drawing.Point(3, 1);
            this.validatePackages.Name = "validatePackages";
            this.validatePackages.Size = new System.Drawing.Size(110, 23);
            this.validatePackages.TabIndex = 7;
            this.validatePackages.Text = "Validate packages";
            this.validatePackages.UseVisualStyleBackColor = true;
            this.validatePackages.Click += new System.EventHandler(this.validatePackages_Click);
            // 
            // problemFiles
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.problemFiles, 2);
            this.problemFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.problemFiles.Location = new System.Drawing.Point(139, 203);
            this.problemFiles.Multiline = true;
            this.problemFiles.Name = "problemFiles";
            this.problemFiles.Size = new System.Drawing.Size(516, 164);
            this.problemFiles.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Controls.Add(this.selectFolder, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.problemFiles, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.folderPath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.filesToKeep, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.copyrightText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 408);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.validatePackages);
            this.panel2.Controls.Add(this.start);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 373);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(652, 32);
            this.panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 430);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "Node modules cleaner";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.TextBox copyrightText;
        private System.Windows.Forms.TextBox filesToKeep;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel processStatus;
        private System.Windows.Forms.Button validatePackages;
        private System.Windows.Forms.TextBox problemFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}

