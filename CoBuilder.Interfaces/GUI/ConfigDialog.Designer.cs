namespace CoBuilder.Service.GUI
{
    partial class ConfigDialog
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
            this.PbxCoBuilder = new System.Windows.Forms.PictureBox();
            this.GbxCurrent = new System.Windows.Forms.GroupBox();
            this.lblAuthorValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LstConfig = new System.Windows.Forms.ListBox();
            this.CmbEdit = new System.Windows.Forms.Button();
            this.CmbNew = new System.Windows.Forms.Button();
            this.CmbImport = new System.Windows.Forms.Button();
            this.CmbExport = new System.Windows.Forms.Button();
            this.GbxCommands = new System.Windows.Forms.GroupBox();
            this.CmbCancel = new System.Windows.Forms.Button();
            this.CmbSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).BeginInit();
            this.GbxCurrent.SuspendLayout();
            this.GbxCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbxCoBuilder
            // 
            this.PbxCoBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCoBuilder.Image = global::CoBuilder.Service.Properties.Resources.CoBuilder_logo;
            this.PbxCoBuilder.Location = new System.Drawing.Point(67, 11);
            this.PbxCoBuilder.Margin = new System.Windows.Forms.Padding(2);
            this.PbxCoBuilder.Name = "PbxCoBuilder";
            this.PbxCoBuilder.Size = new System.Drawing.Size(196, 50);
            this.PbxCoBuilder.TabIndex = 14;
            this.PbxCoBuilder.TabStop = false;
            // 
            // GbxCurrent
            // 
            this.GbxCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxCurrent.Controls.Add(this.lblAuthorValue);
            this.GbxCurrent.Controls.Add(this.lblNameValue);
            this.GbxCurrent.Controls.Add(this.LblAuthor);
            this.GbxCurrent.Controls.Add(this.LblName);
            this.GbxCurrent.Location = new System.Drawing.Point(12, 66);
            this.GbxCurrent.Name = "GbxCurrent";
            this.GbxCurrent.Size = new System.Drawing.Size(250, 67);
            this.GbxCurrent.TabIndex = 16;
            this.GbxCurrent.TabStop = false;
            this.GbxCurrent.Text = "Current Configuration";
            // 
            // lblAuthorValue
            // 
            this.lblAuthorValue.AutoSize = true;
            this.lblAuthorValue.Location = new System.Drawing.Point(70, 40);
            this.lblAuthorValue.Name = "lblAuthorValue";
            this.lblAuthorValue.Size = new System.Drawing.Size(38, 13);
            this.lblAuthorValue.TabIndex = 6;
            this.lblAuthorValue.Text = "Author";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Location = new System.Drawing.Point(70, 20);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(35, 13);
            this.lblNameValue.TabIndex = 5;
            this.lblNameValue.Text = "Name";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Location = new System.Drawing.Point(6, 40);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(38, 13);
            this.LblAuthor.TabIndex = 1;
            this.LblAuthor.Text = "Author";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(9, 20);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // LstConfig
            // 
            this.LstConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstConfig.FormattingEnabled = true;
            this.LstConfig.Location = new System.Drawing.Point(12, 139);
            this.LstConfig.Name = "LstConfig";
            this.LstConfig.Size = new System.Drawing.Size(172, 173);
            this.LstConfig.TabIndex = 17;
            this.LstConfig.SelectedIndexChanged += new System.EventHandler(this.LstConfig_SelectedIndexChanged);
            // 
            // CmbEdit
            // 
            this.CmbEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbEdit.Location = new System.Drawing.Point(190, 189);
            this.CmbEdit.Name = "CmbEdit";
            this.CmbEdit.Size = new System.Drawing.Size(72, 24);
            this.CmbEdit.TabIndex = 18;
            this.CmbEdit.Text = "&Edit";
            this.CmbEdit.UseVisualStyleBackColor = true;
            this.CmbEdit.Click += new System.EventHandler(this.CmbEdit_Click);
            // 
            // CmbNew
            // 
            this.CmbNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbNew.Location = new System.Drawing.Point(190, 219);
            this.CmbNew.Name = "CmbNew";
            this.CmbNew.Size = new System.Drawing.Size(72, 24);
            this.CmbNew.TabIndex = 19;
            this.CmbNew.Text = "&New";
            this.CmbNew.UseVisualStyleBackColor = true;
            this.CmbNew.Click += new System.EventHandler(this.CmbNew_Click);
            // 
            // CmbImport
            // 
            this.CmbImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbImport.Enabled = false;
            this.CmbImport.Location = new System.Drawing.Point(190, 249);
            this.CmbImport.Name = "CmbImport";
            this.CmbImport.Size = new System.Drawing.Size(72, 24);
            this.CmbImport.TabIndex = 20;
            this.CmbImport.Text = "&Import...";
            this.CmbImport.UseVisualStyleBackColor = true;
            this.CmbImport.Click += new System.EventHandler(this.CmbImport_Click);
            // 
            // CmbExport
            // 
            this.CmbExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbExport.Enabled = false;
            this.CmbExport.Location = new System.Drawing.Point(190, 279);
            this.CmbExport.Name = "CmbExport";
            this.CmbExport.Size = new System.Drawing.Size(72, 24);
            this.CmbExport.TabIndex = 21;
            this.CmbExport.Text = "&Export...";
            this.CmbExport.UseVisualStyleBackColor = true;
            this.CmbExport.Click += new System.EventHandler(this.CmbExport_Click);
            // 
            // GbxCommands
            // 
            this.GbxCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxCommands.Controls.Add(this.CmbCancel);
            this.GbxCommands.Controls.Add(this.CmbSelect);
            this.GbxCommands.Location = new System.Drawing.Point(11, 318);
            this.GbxCommands.Margin = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Name = "GbxCommands";
            this.GbxCommands.Padding = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Size = new System.Drawing.Size(251, 54);
            this.GbxCommands.TabIndex = 22;
            this.GbxCommands.TabStop = false;
            // 
            // CmbCancel
            // 
            this.CmbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmbCancel.Location = new System.Drawing.Point(161, 17);
            this.CmbCancel.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCancel.Name = "CmbCancel";
            this.CmbCancel.Size = new System.Drawing.Size(77, 24);
            this.CmbCancel.TabIndex = 1;
            this.CmbCancel.Text = "&Cancel";
            this.CmbCancel.UseVisualStyleBackColor = true;
            this.CmbCancel.Click += new System.EventHandler(this.CmbCancel_Click);
            // 
            // CmbSelect
            // 
            this.CmbSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmbSelect.Enabled = false;
            this.CmbSelect.Location = new System.Drawing.Point(85, 17);
            this.CmbSelect.Margin = new System.Windows.Forms.Padding(2);
            this.CmbSelect.Name = "CmbSelect";
            this.CmbSelect.Size = new System.Drawing.Size(72, 24);
            this.CmbSelect.TabIndex = 0;
            this.CmbSelect.Text = "&Select";
            this.CmbSelect.UseVisualStyleBackColor = true;
            this.CmbSelect.Click += new System.EventHandler(this.CmbSelect_Click);
            // 
            // ConfigDialog
            // 
            this.AcceptButton = this.CmbSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CmbCancel;
            this.ClientSize = new System.Drawing.Size(274, 383);
            this.Controls.Add(this.GbxCommands);
            this.Controls.Add(this.CmbExport);
            this.Controls.Add(this.CmbImport);
            this.Controls.Add(this.CmbNew);
            this.Controls.Add(this.CmbEdit);
            this.Controls.Add(this.LstConfig);
            this.Controls.Add(this.GbxCurrent);
            this.Controls.Add(this.PbxCoBuilder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigDialog";
            this.Text = "Configuration Select";
            this.Load += new System.EventHandler(this.ConfigDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).EndInit();
            this.GbxCurrent.ResumeLayout(false);
            this.GbxCurrent.PerformLayout();
            this.GbxCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxCoBuilder;
        private System.Windows.Forms.GroupBox GbxCurrent;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label lblAuthorValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.ListBox LstConfig;
        private System.Windows.Forms.Button CmbEdit;
        private System.Windows.Forms.Button CmbNew;
        private System.Windows.Forms.Button CmbImport;
        private System.Windows.Forms.Button CmbExport;
        private System.Windows.Forms.GroupBox GbxCommands;
        private System.Windows.Forms.Button CmbCancel;
        private System.Windows.Forms.Button CmbSelect;
    }
}