namespace CoBuilder.Service.GUI
{
    partial class WorkplaceDialog
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
            this.GbxCommands = new System.Windows.Forms.GroupBox();
            this.CmbCancel = new System.Windows.Forms.Button();
            this.CmbOK = new System.Windows.Forms.Button();
            this.GrpWorkplace = new System.Windows.Forms.GroupBox();
            this.CboWorkplace = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).BeginInit();
            this.GbxCommands.SuspendLayout();
            this.GrpWorkplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbxCoBuilder
            // 
            this.PbxCoBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCoBuilder.Image = global::CoBuilder.Service.Properties.Resources.CoBuilder_logo;
            this.PbxCoBuilder.Location = new System.Drawing.Point(97, 11);
            this.PbxCoBuilder.Margin = new System.Windows.Forms.Padding(2);
            this.PbxCoBuilder.Name = "PbxCoBuilder";
            this.PbxCoBuilder.Size = new System.Drawing.Size(196, 50);
            this.PbxCoBuilder.TabIndex = 13;
            this.PbxCoBuilder.TabStop = false;
            // 
            // GbxCommands
            // 
            this.GbxCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxCommands.Controls.Add(this.CmbCancel);
            this.GbxCommands.Controls.Add(this.CmbOK);
            this.GbxCommands.Location = new System.Drawing.Point(11, 143);
            this.GbxCommands.Margin = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Name = "GbxCommands";
            this.GbxCommands.Padding = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Size = new System.Drawing.Size(282, 54);
            this.GbxCommands.TabIndex = 15;
            this.GbxCommands.TabStop = false;
            // 
            // CmbCancel
            // 
            this.CmbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmbCancel.Location = new System.Drawing.Point(170, 17);
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
            this.CmbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmbOK.Location = new System.Drawing.Point(31, 17);
            this.CmbOK.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOK.Name = "CmbOK";
            this.CmbOK.Size = new System.Drawing.Size(72, 24);
            this.CmbOK.TabIndex = 0;
            this.CmbOK.Text = "&OK";
            this.CmbOK.UseVisualStyleBackColor = true;
            this.CmbOK.Click += new System.EventHandler(this.CmbOK_Click);
            // 
            // GrpWorkplace
            // 
            this.GrpWorkplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpWorkplace.Controls.Add(this.CboWorkplace);
            this.GrpWorkplace.Location = new System.Drawing.Point(11, 75);
            this.GrpWorkplace.Margin = new System.Windows.Forms.Padding(2);
            this.GrpWorkplace.Name = "GrpWorkplace";
            this.GrpWorkplace.Padding = new System.Windows.Forms.Padding(2);
            this.GrpWorkplace.Size = new System.Drawing.Size(282, 64);
            this.GrpWorkplace.TabIndex = 14;
            this.GrpWorkplace.TabStop = false;
            this.GrpWorkplace.Text = "Select Current Work Place";
            // 
            // CboWorkplace
            // 
            this.CboWorkplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboWorkplace.FormattingEnabled = true;
            this.CboWorkplace.Location = new System.Drawing.Point(14, 27);
            this.CboWorkplace.Margin = new System.Windows.Forms.Padding(2);
            this.CboWorkplace.Name = "CboWorkplace";
            this.CboWorkplace.Size = new System.Drawing.Size(251, 21);
            this.CboWorkplace.TabIndex = 1;
            // 
            // WorkplaceDialog
            // 
            this.AcceptButton = this.CmbOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CmbOK;
            this.ClientSize = new System.Drawing.Size(304, 208);
            this.Controls.Add(this.GbxCommands);
            this.Controls.Add(this.GrpWorkplace);
            this.Controls.Add(this.PbxCoBuilder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WorkplaceDialog";
            this.Text = "CoBuilder Login";
            this.Load += new System.EventHandler(this.WorkplaceDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).EndInit();
            this.GbxCommands.ResumeLayout(false);
            this.GrpWorkplace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxCoBuilder;
        private System.Windows.Forms.GroupBox GbxCommands;
        private System.Windows.Forms.Button CmbCancel;
        private System.Windows.Forms.Button CmbOK;
        private System.Windows.Forms.GroupBox GrpWorkplace;
        private System.Windows.Forms.ComboBox CboWorkplace;
    }
}