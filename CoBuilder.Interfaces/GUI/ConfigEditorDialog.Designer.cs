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
            this.TrvConfiguration = new System.Windows.Forms.TreeView();
            this.CmbGenerate = new System.Windows.Forms.Button();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.TrvRoot = new System.Windows.Forms.TreeView();
            this.gbxConfigEdit = new System.Windows.Forms.GroupBox();
            this.PbxCoBuilder = new System.Windows.Forms.PictureBox();
            this.GbxDetails = new System.Windows.Forms.GroupBox();
            this.cmdConfigCancel = new System.Windows.Forms.Button();
            this.lblAuthorValue = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.cmdConfigEdit = new System.Windows.Forms.Button();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.GbxCommands = new System.Windows.Forms.GroupBox();
            this.CmbCancel = new System.Windows.Forms.Button();
            this.CmbOK = new System.Windows.Forms.Button();
            this.cmdAddNew = new System.Windows.Forms.Button();
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
            this.SpCForm.Panel1.Controls.Add(this.cmdAddNew);
            this.SpCForm.Panel1.Controls.Add(this.CmdRemove);
            this.SpCForm.Panel1.Controls.Add(this.CmdEdit);
            this.SpCForm.Panel1.Controls.Add(this.TrvConfiguration);
            this.SpCForm.Panel1MinSize = 225;
            // 
            // SpCForm.Panel2
            // 
            this.SpCForm.Panel2.Controls.Add(this.CmbGenerate);
            this.SpCForm.Panel2.Controls.Add(this.CmdAdd);
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
            this.CmdRemove.Location = new System.Drawing.Point(69, 398);
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
            this.CmdEdit.Location = new System.Drawing.Point(6, 398);
            this.CmdEdit.Margin = new System.Windows.Forms.Padding(6);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(51, 27);
            this.CmdEdit.TabIndex = 2;
            this.CmdEdit.Text = "&Edit";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // TrvConfiguration
            // 
            this.TrvConfiguration.AllowDrop = true;
            this.TrvConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrvConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrvConfiguration.Location = new System.Drawing.Point(5, 12);
            this.TrvConfiguration.Margin = new System.Windows.Forms.Padding(6);
            this.TrvConfiguration.Name = "TrvConfiguration";
            this.TrvConfiguration.Size = new System.Drawing.Size(282, 374);
            this.TrvConfiguration.TabIndex = 0;
            this.TrvConfiguration.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.TrvConfiguration.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.TrvConfiguration.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);
            // 
            // CmbGenerate
            // 
            this.CmbGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbGenerate.Location = new System.Drawing.Point(169, 398);
            this.CmbGenerate.Margin = new System.Windows.Forms.Padding(6);
            this.CmbGenerate.Name = "CmbGenerate";
            this.CmbGenerate.Size = new System.Drawing.Size(117, 27);
            this.CmbGenerate.TabIndex = 5;
            this.CmbGenerate.Text = "Generate BaseConfig";
            this.CmbGenerate.UseVisualStyleBackColor = true;
            this.CmbGenerate.Click += new System.EventHandler(this.CmbGenerate_Click);
            // 
            // CmdAdd
            // 
            this.CmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdAdd.Location = new System.Drawing.Point(106, 398);
            this.CmdAdd.Margin = new System.Windows.Forms.Padding(6);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(51, 27);
            this.CmdAdd.TabIndex = 4;
            this.CmdAdd.Text = "&Add";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // TrvRoot
            // 
            this.TrvRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrvRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrvRoot.Location = new System.Drawing.Point(6, 12);
            this.TrvRoot.Margin = new System.Windows.Forms.Padding(6);
            this.TrvRoot.Name = "TrvRoot";
            this.TrvRoot.Size = new System.Drawing.Size(282, 374);
            this.TrvRoot.TabIndex = 1;
            this.TrvRoot.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
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
            this.GbxDetails.Controls.Add(this.cmdConfigCancel);
            this.GbxDetails.Controls.Add(this.lblAuthorValue);
            this.GbxDetails.Controls.Add(this.lblNameValue);
            this.GbxDetails.Controls.Add(this.cmdConfigEdit);
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
            // cmdConfigCancel
            // 
            this.cmdConfigCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdConfigCancel.Location = new System.Drawing.Point(299, 39);
            this.cmdConfigCancel.Margin = new System.Windows.Forms.Padding(6);
            this.cmdConfigCancel.Name = "cmdConfigCancel";
            this.cmdConfigCancel.Size = new System.Drawing.Size(50, 27);
            this.cmdConfigCancel.TabIndex = 7;
            this.cmdConfigCancel.Text = "&Cancel";
            this.cmdConfigCancel.UseVisualStyleBackColor = true;
            this.cmdConfigCancel.Click += new System.EventHandler(this.cmdConfigCancel_Click);
            // 
            // lblAuthorValue
            // 
            this.lblAuthorValue.AutoSize = true;
            this.lblAuthorValue.Location = new System.Drawing.Point(83, 46);
            this.lblAuthorValue.Name = "lblAuthorValue";
            this.lblAuthorValue.Size = new System.Drawing.Size(38, 13);
            this.lblAuthorValue.TabIndex = 6;
            this.lblAuthorValue.Text = "Author";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Location = new System.Drawing.Point(83, 20);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(35, 13);
            this.lblNameValue.TabIndex = 5;
            this.lblNameValue.Text = "Name";
            // 
            // cmdConfigEdit
            // 
            this.cmdConfigEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdConfigEdit.Location = new System.Drawing.Point(244, 39);
            this.cmdConfigEdit.Margin = new System.Windows.Forms.Padding(6);
            this.cmdConfigEdit.Name = "cmdConfigEdit";
            this.cmdConfigEdit.Size = new System.Drawing.Size(51, 27);
            this.cmdConfigEdit.TabIndex = 4;
            this.cmdConfigEdit.Text = "&Edit";
            this.cmdConfigEdit.UseVisualStyleBackColor = true;
            this.cmdConfigEdit.Click += new System.EventHandler(this.cmdConfigEdit_Click);
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAuthor.Location = new System.Drawing.Point(83, 43);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(152, 20);
            this.tbxAuthor.TabIndex = 3;
            // 
            // tbxName
            // 
            this.tbxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxName.Location = new System.Drawing.Point(83, 17);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(266, 20);
            this.tbxName.TabIndex = 2;
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
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(9, 20);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(68, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Config Name";
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
            this.CmbCancel.Click += new System.EventHandler(this.CmbCancel_Click);
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
            this.CmbOK.Click += new System.EventHandler(this.CmbOK_Click);
            // 
            // cmdAddNew
            // 
            this.cmdAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdAddNew.Location = new System.Drawing.Point(137, 398);
            this.cmdAddNew.Margin = new System.Windows.Forms.Padding(6);
            this.cmdAddNew.Name = "cmdAddNew";
            this.cmdAddNew.Size = new System.Drawing.Size(109, 27);
            this.cmdAddNew.TabIndex = 4;
            this.cmdAddNew.Text = "&New Property Set";
            this.cmdAddNew.UseVisualStyleBackColor = true;
            this.cmdAddNew.Click += new System.EventHandler(this.cmdAddNew_Click);
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
            this.Text = "Configuration Editor";
            this.Load += new System.EventHandler(this.ConfigEditorDialog_Load);
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
        private System.Windows.Forms.Button CmdAdd;
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
        private System.Windows.Forms.Label lblAuthorValue;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Button cmdConfigEdit;
        private System.Windows.Forms.Button cmdConfigCancel;
        private System.Windows.Forms.Button CmbGenerate;
        private System.Windows.Forms.Button cmdAddNew;
    }
}