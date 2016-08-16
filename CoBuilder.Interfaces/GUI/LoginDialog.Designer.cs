namespace CoBuilder.Service.GUI
{
    partial class LoginDialog
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.CbxRemember = new System.Windows.Forms.CheckBox();
            this.CmbLogin = new System.Windows.Forms.Button();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.GrpWorkplace = new System.Windows.Forms.GroupBox();
            this.CmbApply = new System.Windows.Forms.Button();
            this.CboWorkplace = new System.Windows.Forms.ComboBox();
            this.GbxCommands = new System.Windows.Forms.GroupBox();
            this.CmbCancel = new System.Windows.Forms.Button();
            this.CmbOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).BeginInit();
            this.grpLogin.SuspendLayout();
            this.GrpWorkplace.SuspendLayout();
            this.GbxCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbxCoBuilder
            // 
            this.PbxCoBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCoBuilder.Image = global::CoBuilder.Service.Properties.Resources.CoBuilder_logo;
            this.PbxCoBuilder.Location = new System.Drawing.Point(88, 11);
            this.PbxCoBuilder.Margin = new System.Windows.Forms.Padding(2);
            this.PbxCoBuilder.Name = "PbxCoBuilder";
            this.PbxCoBuilder.Size = new System.Drawing.Size(196, 50);
            this.PbxCoBuilder.TabIndex = 13;
            this.PbxCoBuilder.TabStop = false;
            // 
            // grpLogin
            // 
            this.grpLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLogin.Controls.Add(this.CbxRemember);
            this.grpLogin.Controls.Add(this.CmbLogin);
            this.grpLogin.Controls.Add(this.TxbPassword);
            this.grpLogin.Controls.Add(this.LblPassword);
            this.grpLogin.Controls.Add(this.TxbName);
            this.grpLogin.Controls.Add(this.LblName);
            this.grpLogin.Location = new System.Drawing.Point(11, 65);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(2);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(2);
            this.grpLogin.Size = new System.Drawing.Size(273, 156);
            this.grpLogin.TabIndex = 14;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login Authentication";
            // 
            // CbxRemember
            // 
            this.CbxRemember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxRemember.AutoSize = true;
            this.CbxRemember.Location = new System.Drawing.Point(165, 123);
            this.CbxRemember.Margin = new System.Windows.Forms.Padding(2);
            this.CbxRemember.Name = "CbxRemember";
            this.CbxRemember.Size = new System.Drawing.Size(95, 17);
            this.CbxRemember.TabIndex = 6;
            this.CbxRemember.Text = "Remember Me";
            this.CbxRemember.UseVisualStyleBackColor = true;
            // 
            // CmbLogin
            // 
            this.CmbLogin.Location = new System.Drawing.Point(14, 118);
            this.CmbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.CmbLogin.Name = "CmbLogin";
            this.CmbLogin.Size = new System.Drawing.Size(56, 24);
            this.CmbLogin.TabIndex = 4;
            this.CmbLogin.Text = "Login";
            this.CmbLogin.UseVisualStyleBackColor = true;
            // 
            // TxbPassword
            // 
            this.TxbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbPassword.Location = new System.Drawing.Point(14, 87);
            this.TxbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.Size = new System.Drawing.Size(246, 20);
            this.TxbPassword.TabIndex = 3;
            this.TxbPassword.Text = "password";
            this.TxbPassword.UseSystemPasswordChar = true;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(14, 66);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Password";
            // 
            // TxbName
            // 
            this.TxbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbName.Location = new System.Drawing.Point(14, 37);
            this.TxbName.Margin = new System.Windows.Forms.Padding(2);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(246, 20);
            this.TxbName.TabIndex = 1;
            this.TxbName.Text = " cobuilderuk@gmail.com";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 18);
            this.LblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // GrpWorkplace
            // 
            this.GrpWorkplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpWorkplace.Controls.Add(this.CmbApply);
            this.GrpWorkplace.Controls.Add(this.CboWorkplace);
            this.GrpWorkplace.Location = new System.Drawing.Point(11, 225);
            this.GrpWorkplace.Margin = new System.Windows.Forms.Padding(2);
            this.GrpWorkplace.Name = "GrpWorkplace";
            this.GrpWorkplace.Padding = new System.Windows.Forms.Padding(2);
            this.GrpWorkplace.Size = new System.Drawing.Size(273, 65);
            this.GrpWorkplace.TabIndex = 15;
            this.GrpWorkplace.TabStop = false;
            this.GrpWorkplace.Text = "Select Current Work Place";
            // 
            // CmbApply
            // 
            this.CmbApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbApply.Location = new System.Drawing.Point(204, 24);
            this.CmbApply.Margin = new System.Windows.Forms.Padding(2);
            this.CmbApply.Name = "CmbApply";
            this.CmbApply.Size = new System.Drawing.Size(56, 27);
            this.CmbApply.TabIndex = 2;
            this.CmbApply.Text = "Apply";
            this.CmbApply.UseVisualStyleBackColor = true;
            // 
            // CboWorkplace
            // 
            this.CboWorkplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboWorkplace.FormattingEnabled = true;
            this.CboWorkplace.Location = new System.Drawing.Point(14, 28);
            this.CboWorkplace.Margin = new System.Windows.Forms.Padding(2);
            this.CboWorkplace.Name = "CboWorkplace";
            this.CboWorkplace.Size = new System.Drawing.Size(186, 21);
            this.CboWorkplace.TabIndex = 1;
            // 
            // GbxCommands
            // 
            this.GbxCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxCommands.Controls.Add(this.CmbCancel);
            this.GbxCommands.Controls.Add(this.CmbOK);
            this.GbxCommands.Location = new System.Drawing.Point(11, 293);
            this.GbxCommands.Margin = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Name = "GbxCommands";
            this.GbxCommands.Padding = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Size = new System.Drawing.Size(273, 54);
            this.GbxCommands.TabIndex = 16;
            this.GbxCommands.TabStop = false;
            // 
            // CmbCancel
            // 
            this.CmbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmbCancel.Location = new System.Drawing.Point(183, 17);
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
            this.CmbOK.Location = new System.Drawing.Point(107, 17);
            this.CmbOK.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOK.Name = "CmbOK";
            this.CmbOK.Size = new System.Drawing.Size(72, 24);
            this.CmbOK.TabIndex = 0;
            this.CmbOK.Text = "&OK";
            this.CmbOK.UseVisualStyleBackColor = true;
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 358);
            this.Controls.Add(this.GbxCommands);
            this.Controls.Add(this.GrpWorkplace);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.PbxCoBuilder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginDialog";
            this.Text = "CoBuilder Login";
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).EndInit();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.GrpWorkplace.ResumeLayout(false);
            this.GbxCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbxCoBuilder;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.CheckBox CbxRemember;
        private System.Windows.Forms.Button CmbLogin;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.GroupBox GrpWorkplace;
        private System.Windows.Forms.Button CmbApply;
        private System.Windows.Forms.ComboBox CboWorkplace;
        private System.Windows.Forms.GroupBox GbxCommands;
        private System.Windows.Forms.Button CmbCancel;
        private System.Windows.Forms.Button CmbOK;
    }
}