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
            ((System.ComponentModel.ISupportInitialize)(this.SpCForm)).BeginInit();
            this.SpCForm.Panel1.SuspendLayout();
            this.SpCForm.Panel2.SuspendLayout();
            this.SpCForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpCForm
            // 
            this.SpCForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpCForm.Location = new System.Drawing.Point(0, 0);
            this.SpCForm.Name = "SpCForm";
            // 
            // SpCForm.Panel1
            // 
            this.SpCForm.Panel1.Controls.Add(this.CmdRemove);
            this.SpCForm.Panel1.Controls.Add(this.CmdEdit);
            this.SpCForm.Panel1.Controls.Add(this.CmdConfigAdd);
            this.SpCForm.Panel1.Controls.Add(this.TrvConfiguration);
            // 
            // SpCForm.Panel2
            // 
            this.SpCForm.Panel2.Controls.Add(this.CmdAddtoConfig);
            this.SpCForm.Panel2.Controls.Add(this.TrvRoot);
            this.SpCForm.Size = new System.Drawing.Size(644, 641);
            this.SpCForm.SplitterDistance = 369;
            this.SpCForm.TabIndex = 0;
            // 
            // CmdRemove
            // 
            this.CmdRemove.Location = new System.Drawing.Point(126, 589);
            this.CmdRemove.Name = "CmdRemove";
            this.CmdRemove.Size = new System.Drawing.Size(56, 27);
            this.CmdRemove.TabIndex = 3;
            this.CmdRemove.Text = "&Remove";
            this.CmdRemove.UseVisualStyleBackColor = true;
            this.CmdRemove.Click += new System.EventHandler(this.CmdRemove_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.Location = new System.Drawing.Point(69, 589);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(51, 27);
            this.CmdEdit.TabIndex = 2;
            this.CmdEdit.Text = "&Edit";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdConfigAdd
            // 
            this.CmdConfigAdd.Location = new System.Drawing.Point(12, 589);
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
            this.TrvConfiguration.Location = new System.Drawing.Point(12, 12);
            this.TrvConfiguration.Name = "TrvConfiguration";
            this.TrvConfiguration.Size = new System.Drawing.Size(354, 540);
            this.TrvConfiguration.TabIndex = 0;
            // 
            // CmdAddtoConfig
            // 
            this.CmdAddtoConfig.Location = new System.Drawing.Point(3, 589);
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
            this.TrvRoot.Location = new System.Drawing.Point(3, 12);
            this.TrvRoot.Name = "TrvRoot";
            this.TrvRoot.Size = new System.Drawing.Size(256, 540);
            this.TrvRoot.TabIndex = 1;
            // 
            // ConfigEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 641);
            this.Controls.Add(this.SpCForm);
            this.Name = "ConfigEditorDialog";
            this.Text = "ConfigEditorDialog";
            this.SpCForm.Panel1.ResumeLayout(false);
            this.SpCForm.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpCForm)).EndInit();
            this.SpCForm.ResumeLayout(false);
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
    }
}