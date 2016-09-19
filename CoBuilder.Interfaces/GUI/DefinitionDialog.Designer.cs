namespace CoBuilder.Service.GUI
{
    partial class DefinitionDialog
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
            this.GbxCommands = new System.Windows.Forms.GroupBox();
            this.CmbCancel = new System.Windows.Forms.Button();
            this.CmbOK = new System.Windows.Forms.Button();
            this.PbxCoBuilder = new System.Windows.Forms.PictureBox();
            this.D = new System.Windows.Forms.GroupBox();
            this.LblIdentifierValue = new System.Windows.Forms.Label();
            this.LblIdentifier = new System.Windows.Forms.Label();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.LblDisplayName = new System.Windows.Forms.Label();
            this.cbxVisible = new System.Windows.Forms.CheckBox();
            this.GbxCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).BeginInit();
            this.D.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxCommands
            // 
            this.GbxCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxCommands.Controls.Add(this.CmbCancel);
            this.GbxCommands.Controls.Add(this.CmbOK);
            this.GbxCommands.Location = new System.Drawing.Point(11, 201);
            this.GbxCommands.Margin = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Name = "GbxCommands";
            this.GbxCommands.Padding = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Size = new System.Drawing.Size(261, 54);
            this.GbxCommands.TabIndex = 18;
            this.GbxCommands.TabStop = false;
            // 
            // CmbCancel
            // 
            this.CmbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmbCancel.Location = new System.Drawing.Point(171, 17);
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
            this.CmbOK.Location = new System.Drawing.Point(95, 17);
            this.CmbOK.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOK.Name = "CmbOK";
            this.CmbOK.Size = new System.Drawing.Size(72, 24);
            this.CmbOK.TabIndex = 0;
            this.CmbOK.Text = "&OK";
            this.CmbOK.UseVisualStyleBackColor = true;
            this.CmbOK.Click += new System.EventHandler(this.CmbOK_Click);
            // 
            // PbxCoBuilder
            // 
            this.PbxCoBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCoBuilder.Image = global::CoBuilder.Service.Properties.Resources.CoBuilder_logo;
            this.PbxCoBuilder.Location = new System.Drawing.Point(76, 11);
            this.PbxCoBuilder.Margin = new System.Windows.Forms.Padding(2);
            this.PbxCoBuilder.Name = "PbxCoBuilder";
            this.PbxCoBuilder.Size = new System.Drawing.Size(196, 50);
            this.PbxCoBuilder.TabIndex = 19;
            this.PbxCoBuilder.TabStop = false;
            // 
            // D
            // 
            this.D.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.D.Controls.Add(this.LblIdentifierValue);
            this.D.Controls.Add(this.LblIdentifier);
            this.D.Controls.Add(this.txbDisplayName);
            this.D.Controls.Add(this.LblDisplayName);
            this.D.Controls.Add(this.cbxVisible);
            this.D.Location = new System.Drawing.Point(11, 66);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(261, 130);
            this.D.TabIndex = 20;
            this.D.TabStop = false;
            this.D.Text = "Definition Details";
            // 
            // LblIdentifierValue
            // 
            this.LblIdentifierValue.AutoSize = true;
            this.LblIdentifierValue.Location = new System.Drawing.Point(85, 63);
            this.LblIdentifierValue.Name = "LblIdentifierValue";
            this.LblIdentifierValue.Size = new System.Drawing.Size(14, 13);
            this.LblIdentifierValue.TabIndex = 4;
            this.LblIdentifierValue.Text = "A";
            // 
            // LblIdentifier
            // 
            this.LblIdentifier.AutoSize = true;
            this.LblIdentifier.Location = new System.Drawing.Point(7, 63);
            this.LblIdentifier.Name = "LblIdentifier";
            this.LblIdentifier.Size = new System.Drawing.Size(47, 13);
            this.LblIdentifier.TabIndex = 3;
            this.LblIdentifier.Text = "Identifier";
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(85, 25);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(159, 20);
            this.txbDisplayName.TabIndex = 2;
            // 
            // LblDisplayName
            // 
            this.LblDisplayName.AutoSize = true;
            this.LblDisplayName.Location = new System.Drawing.Point(7, 28);
            this.LblDisplayName.Name = "LblDisplayName";
            this.LblDisplayName.Size = new System.Drawing.Size(72, 13);
            this.LblDisplayName.TabIndex = 1;
            this.LblDisplayName.Text = "Display Name";
            // 
            // cbxVisible
            // 
            this.cbxVisible.AutoSize = true;
            this.cbxVisible.Location = new System.Drawing.Point(85, 87);
            this.cbxVisible.Name = "cbxVisible";
            this.cbxVisible.Size = new System.Drawing.Size(56, 17);
            this.cbxVisible.TabIndex = 0;
            this.cbxVisible.Text = "Visible";
            this.cbxVisible.UseVisualStyleBackColor = true;
            // 
            // DefinitionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 266);
            this.Controls.Add(this.D);
            this.Controls.Add(this.PbxCoBuilder);
            this.Controls.Add(this.GbxCommands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DefinitionDialog";
            this.Text = "Definition Editor";
            this.Load += new System.EventHandler(this.DefinitionDialog_Load);
            this.GbxCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).EndInit();
            this.D.ResumeLayout(false);
            this.D.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxCommands;
        private System.Windows.Forms.Button CmbCancel;
        private System.Windows.Forms.Button CmbOK;
        private System.Windows.Forms.PictureBox PbxCoBuilder;
        private System.Windows.Forms.GroupBox D;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label LblDisplayName;
        private System.Windows.Forms.CheckBox cbxVisible;
        private System.Windows.Forms.Label LblIdentifierValue;
        private System.Windows.Forms.Label LblIdentifier;
    }
}