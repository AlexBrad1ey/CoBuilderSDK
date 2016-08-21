namespace CoBuilder.Service.GUI
{
    partial class ConfigEditorDialog
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
            this.SpCForm = new System.Windows.Forms.SplitContainer();
            this.CmdRemove = new System.Windows.Forms.Button();
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdConfigAdd = new System.Windows.Forms.Button();
            this.TrvConfiguration = new System.Windows.Forms.TreeView();
            this.CmdAddtoConfig = new System.Windows.Forms.Button();
            this.TrvRoot = new System.Windows.Forms.TreeView();
            this.gbxConfigEdit = new System.Windows.Forms.GroupBox();
            this.PbxCoBuilder = new System.Windows.Forms.PictureBox();
            this.GbxDetails = new System.Windows.Forms.GroupBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.GbxCommands = new System.Windows.Forms.GroupBox();
            this.CmbCancel = new System.Windows.Forms.Button();
            this.CmbOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpCForm)).BeginInit();
            this.SpCForm.Panel1.SuspendLayout();
            this.SpCForm.Panel2.SuspendLayout();
            this.SpCForm.SuspendLayout();
            this.gbxConfigEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).BeginInit();
            this.GbxDetails.SuspendLayout();
            this.GbxCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpCForm
            // 
            this.SpCForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpCForm.Location = new System.Drawing.Point(3, 16);
            this.SpCForm.Name = "SpCForm";
            // 
            // SpCForm.Panel1
            // 
            this.SpCForm.Panel1.Controls.Add(this.CmdRemove);
            this.SpCForm.Panel1.Controls.Add(this.CmdEdit);
            this.SpCForm.Panel1.Controls.Add(this.CmdConfigAdd);
            this.SpCForm.Panel1.Controls.Add(this.TrvConfiguration);
            this.SpCForm.Panel1MinSize = 225;
            // 
            // SpCForm.Panel2
            // 
            this.SpCForm.Panel2.Controls.Add(this.CmdAddtoConfig);
            this.SpCForm.Panel2.Controls.Add(this.TrvRoot);
            this.SpCForm.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.SpCForm.Panel2MinSize = 225;
            this.SpCForm.Size = new System.Drawing.Size(594, 431);
            this.SpCForm.SplitterDistance = 294;
            this.SpCForm.SplitterIncrement = 10;
            this.SpCForm.TabIndex = 0;
            // 
            // CmdRemove
            // 
            this.CmdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdRemove.Location = new System.Drawing.Point(132, 398);
            this.CmdRemove.Margin = new System.Windows.Forms.Padding(6);
            this.CmdRemove.Name = "CmdRemove";
            this.CmdRemove.Size = new System.Drawing.Size(56, 27);
            this.CmdRemove.TabIndex = 3;
            this.CmdRemove.Text = "&Remove";
            this.CmdRemove.UseVisualStyleBackColor = true;
            this.CmdRemove.Click += new System.EventHandler(this.CmdRemove_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdEdit.Location = new System.Drawing.Point(69, 398);
            this.CmdEdit.Margin = new System.Windows.Forms.Padding(6);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(51, 27);
            this.CmdEdit.TabIndex = 2;
            this.CmdEdit.Text = "&Edit";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdConfigAdd
            // 
            this.CmdConfigAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdConfigAdd.Location = new System.Drawing.Point(6, 398);
            this.CmdConfigAdd.Margin = new System.Windows.Forms.Padding(6);
            this.CmdConfigAdd.Name = "CmdConfigAdd";
            this.CmdConfigAdd.Size = new System.Drawing.Size(51, 27);
            this.CmdConfigAdd.TabIndex = 1;
            this.CmdConfigAdd.Text = "&Add";
            this.CmdConfigAdd.UseVisualStyleBackColor = true;
            this.CmdConfigAdd.Click += new System.EventHandler(this.CmdConfigAdd_Click);
            // 
            // TrvConfiguration
            // 
            this.TrvConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrvConfiguration.Location = new System.Drawing.Point(6, 12);
            this.TrvConfiguration.Margin = new System.Windows.Forms.Padding(6);
            this.TrvConfiguration.Name = "TrvConfiguration";
            this.TrvConfiguration.Size = new System.Drawing.Size(282, 374);
            this.TrvConfiguration.TabIndex = 0;
            // 
            // CmdAddtoConfig
            // 
            this.CmdAddtoConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdAddtoConfig.Location = new System.Drawing.Point(239, 398);
            this.CmdAddtoConfig.Margin = new System.Windows.Forms.Padding(6);
            this.CmdAddtoConfig.Name = "CmdAddtoConfig";
            this.CmdAddtoConfig.Size = new System.Drawing.Size(51, 27);
            this.CmdAddtoConfig.TabIndex = 4;
            this.CmdAddtoConfig.Text = "&Add";
            this.CmdAddtoConfig.UseVisualStyleBackColor = true;
            this.CmdAddtoConfig.Click += new System.EventHandler(this.CmdAddtoConfig_Click);
            // 
            // TrvRoot
            // 
            this.TrvRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrvRoot.Location = new System.Drawing.Point(6, 12);
            this.TrvRoot.Margin = new System.Windows.Forms.Padding(6);
            this.TrvRoot.Name = "TrvRoot";
            this.TrvRoot.Size = new System.Drawing.Size(282, 374);
            this.TrvRoot.TabIndex = 1;
            // 
            // gbxConfigEdit
            // 
            this.gbxConfigEdit.Controls.Add(this.SpCForm);
            this.gbxConfigEdit.Location = new System.Drawing.Point(13, 95);
            this.gbxConfigEdit.Name = "gbxConfigEdit";
            this.gbxConfigEdit.Size = new System.Drawing.Size(600, 450);
            this.gbxConfigEdit.TabIndex = 1;
            this.gbxConfigEdit.TabStop = false;
            this.gbxConfigEdit.Text = "Configuration Editor";
            // 
            // PbxCoBuilder
            // 
            this.PbxCoBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCoBuilder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbxCoBuilder.Image = global::CoBuilder.Service.Properties.Resources.CoBuilder_logo;
            this.PbxCoBuilder.Location = new System.Drawing.Point(376, 15);
            this.PbxCoBuilder.Margin = new System.Windows.Forms.Padding(2);
            this.PbxCoBuilder.Name = "PbxCoBuilder";
            this.PbxCoBuilder.Size = new System.Drawing.Size(237, 59);
            this.PbxCoBuilder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxCoBuilder.TabIndex = 14;
            this.PbxCoBuilder.TabStop = false;
            // 
            // GbxDetails
            // 
            this.GbxDetails.Controls.Add(this.tbxAuthor);
            this.GbxDetails.Controls.Add(this.tbxName);
            this.GbxDetails.Controls.Add(this.LblAuthor);
            this.GbxDetails.Controls.Add(this.LblName);
            this.GbxDetails.Location = new System.Drawing.Point(13, 11);
            this.GbxDetails.Name = "GbxDetails";
            this.GbxDetails.Size = new System.Drawing.Size(358, 78);
            this.GbxDetails.TabIndex = 15;
            this.GbxDetails.TabStop = false;
            this.GbxDetails.Text = "Details";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(9, 20);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(100, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Configuration Name";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Location = new System.Drawing.Point(9, 46);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(38, 13);
            this.LblAuthor.TabIndex = 1;
            this.LblAuthor.Text = "Author";
            // 
            // tbxName
            // 
            this.tbxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxName.Location = new System.Drawing.Point(115, 17);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(237, 20);
            this.tbxName.TabIndex = 2;
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAuthor.Location = new System.Drawing.Point(115, 43);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(237, 20);
            this.tbxAuthor.TabIndex = 3;
            // 
            // GbxCommands
            // 
            this.GbxCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxCommands.Controls.Add(this.CmbCancel);
            this.GbxCommands.Controls.Add(this.CmbOK);
            this.GbxCommands.Location = new System.Drawing.Point(13, 551);
            this.GbxCommands.Margin = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Name = "GbxCommands";
            this.GbxCommands.Padding = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Size = new System.Drawing.Size(600, 54);
            this.GbxCommands.TabIndex = 17;
            this.GbxCommands.TabStop = false;
            // 
            // CmbCancel
            // 
            this.CmbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmbCancel.Location = new System.Drawing.Point(510, 17);
            this.CmbCancel.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCancel.Name = "CmbCancel";
            this.CmbCancel.Size = new System.Drawing.Size(77, 24);
            this.CmbCancel.TabIndex = 1;
            this.CmbCancel.Text = "&Cancel";
            this.CmbCancel.UseVisualStyleBackColor = true;
            // 
            // CmbOK
            // 
            this.CmbOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmbOK.Enabled = false;
            this.CmbOK.Location = new System.Drawing.Point(434, 17);
            this.CmbOK.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOK.Name = "CmbOK";
            this.CmbOK.Size = new System.Drawing.Size(72, 24);
            this.CmbOK.TabIndex = 0;
            this.CmbOK.Text = "&OK";
            this.CmbOK.UseVisualStyleBackColor = true;
            // 
            // ConfigEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 616);
            this.Controls.Add(this.GbxCommands);
            this.Controls.Add(this.GbxDetails);
            this.Controls.Add(this.PbxCoBuilder);
            this.Controls.Add(this.gbxConfigEdit);
            this.Name = "ConfigEditorDialog";
            this.Text = "a|szxq";
            this.SpCForm.Panel1.ResumeLayout(false);
            this.SpCForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpCForm)).EndInit();
            this.SpCForm.ResumeLayout(false);
            this.gbxConfigEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).EndInit();
            this.GbxDetails.ResumeLayout(false);
            this.GbxDetails.PerformLayout();
            this.GbxCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SpCForm;
        private System.Windows.Forms.TreeView TrvConfiguration;
        private System.Windows.Forms.TreeView TrvRoot;
        private System.Windows.Forms.Button CmdRemove;
        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Button CmdConfigAdd;
        private System.Windows.Forms.Button CmdAddtoConfig;
        private System.Windows.Forms.GroupBox gbxConfigEdit;
        private System.Windows.Forms.PictureBox PbxCoBuilder;
        private System.Windows.Forms.GroupBox GbxDetails;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.GroupBox GbxCommands;
        private System.Windows.Forms.Button CmbCancel;
        private System.Windows.Forms.Button CmbOK;
    }
}