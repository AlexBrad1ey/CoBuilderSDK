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
            this.GbxCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxCommands
            // 
            this.GbxCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxCommands.Controls.Add(this.CmbCancel);
            this.GbxCommands.Controls.Add(this.CmbOK);
            this.GbxCommands.Location = new System.Drawing.Point(11, 228);
            this.GbxCommands.Margin = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Name = "GbxCommands";
            this.GbxCommands.Padding = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Size = new System.Drawing.Size(364, 54);
            this.GbxCommands.TabIndex = 18;
            this.GbxCommands.TabStop = false;
            // 
            // CmbCancel
            // 
            this.CmbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmbCancel.Location = new System.Drawing.Point(274, 17);
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
            this.CmbOK.Location = new System.Drawing.Point(198, 17);
            this.CmbOK.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOK.Name = "CmbOK";
            this.CmbOK.Size = new System.Drawing.Size(72, 24);
            this.CmbOK.TabIndex = 0;
            this.CmbOK.Text = "&OK";
            this.CmbOK.UseVisualStyleBackColor = true;
            // 
            // DefinitionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 293);
            this.Controls.Add(this.GbxCommands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DefinitionDialog";
            this.Text = "Definition Editor";
            this.Load += new System.EventHandler(this.DefinitionDialog_Load);
            this.GbxCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxCommands;
        private System.Windows.Forms.Button CmbCancel;
        private System.Windows.Forms.Button CmbOK;
    }
}