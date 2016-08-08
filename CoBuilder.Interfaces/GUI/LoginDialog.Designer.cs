using System.Windows.Forms;

namespace CoBuilder.Service.Dialogs
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.CbxRemember = new System.Windows.Forms.CheckBox();
            this.CmbLogin = new System.Windows.Forms.Button();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.GrpWorkplace = new System.Windows.Forms.GroupBox();
            this.CmbApply = new System.Windows.Forms.Button();
            this.CboWorkplace = new System.Windows.Forms.ComboBox();
            this.LblWorkSpace = new System.Windows.Forms.Label();
            this.GrpCommands = new System.Windows.Forms.GroupBox();
            this.CmbCancel = new System.Windows.Forms.Button();
            this.CmbOK = new System.Windows.Forms.Button();
            this.PbxCoBuilder = new System.Windows.Forms.PictureBox();
            this.Lblcobuilder = new System.Windows.Forms.Label();
            this.grpLogin.SuspendLayout();
            this.GrpWorkplace.SuspendLayout();
            this.GrpCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).BeginInit();
            this.SuspendLayout();
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
            this.grpLogin.Controls.Add(this.LblUserName);
            this.grpLogin.Location = new System.Drawing.Point(8, 63);
            this.grpLogin.Margin = new System.Windows.Forms.Padding(2);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Padding = new System.Windows.Forms.Padding(2);
            this.grpLogin.Size = new System.Drawing.Size(250, 162);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login Authentication";
            // 
            // CbxRemember
            // 
            this.CbxRemember.AutoSize = true;
            this.CbxRemember.Location = new System.Drawing.Point(143, 124);
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
            this.TxbPassword.Size = new System.Drawing.Size(222, 20);
            this.TxbPassword.TabIndex = 3;
            this.TxbPassword.Text = "hKkSVQ2U";
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
            this.TxbName.Size = new System.Drawing.Size(222, 20);
            this.TxbName.TabIndex = 1;
            this.TxbName.Text = " cobuilderuk@gmail.com";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(12, 18);
            this.LblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(35, 13);
            this.LblUserName.TabIndex = 0;
            this.LblUserName.Text = "Name";
            // 
            // GrpWorkplace
            // 
            this.GrpWorkplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpWorkplace.Controls.Add(this.CmbApply);
            this.GrpWorkplace.Controls.Add(this.CboWorkplace);
            this.GrpWorkplace.Controls.Add(this.LblWorkSpace);
            this.GrpWorkplace.Location = new System.Drawing.Point(8, 230);
            this.GrpWorkplace.Margin = new System.Windows.Forms.Padding(2);
            this.GrpWorkplace.Name = "GrpWorkplace";
            this.GrpWorkplace.Padding = new System.Windows.Forms.Padding(2);
            this.GrpWorkplace.Size = new System.Drawing.Size(250, 81);
            this.GrpWorkplace.TabIndex = 1;
            this.GrpWorkplace.TabStop = false;
            this.GrpWorkplace.Text = "Select Current Work Place";
            // 
            // CmbApply
            // 
            this.CmbApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbApply.Location = new System.Drawing.Point(181, 32);
            this.CmbApply.Margin = new System.Windows.Forms.Padding(2);
            this.CmbApply.Name = "CmbApply";
            this.CmbApply.Size = new System.Drawing.Size(56, 37);
            this.CmbApply.TabIndex = 2;
            this.CmbApply.Text = "Apply";
            this.CmbApply.UseVisualStyleBackColor = true;
            // 
            // CboWorkplace
            // 
            this.CboWorkplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboWorkplace.FormattingEnabled = true;
            this.CboWorkplace.Location = new System.Drawing.Point(14, 50);
            this.CboWorkplace.Margin = new System.Windows.Forms.Padding(2);
            this.CboWorkplace.Name = "CboWorkplace";
            this.CboWorkplace.Size = new System.Drawing.Size(150, 21);
            this.CboWorkplace.TabIndex = 1;
            // 
            // LblWorkSpace
            // 
            this.LblWorkSpace.AutoSize = true;
            this.LblWorkSpace.Location = new System.Drawing.Point(14, 25);
            this.LblWorkSpace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblWorkSpace.Name = "LblWorkSpace";
            this.LblWorkSpace.Size = new System.Drawing.Size(91, 13);
            this.LblWorkSpace.TabIndex = 0;
            this.LblWorkSpace.Text = "coBuilder PRO ID";
            // 
            // GrpCommands
            // 
            this.GrpCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpCommands.Controls.Add(this.CmbCancel);
            this.GrpCommands.Controls.Add(this.CmbOK);
            this.GrpCommands.Location = new System.Drawing.Point(9, 316);
            this.GrpCommands.Margin = new System.Windows.Forms.Padding(2);
            this.GrpCommands.Name = "GrpCommands";
            this.GrpCommands.Padding = new System.Windows.Forms.Padding(2);
            this.GrpCommands.Size = new System.Drawing.Size(250, 54);
            this.GrpCommands.TabIndex = 2;
            this.GrpCommands.TabStop = false;
            this.GrpCommands.Text = "Commands";
            // 
            // CmbCancel
            // 
            this.CmbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmbCancel.Location = new System.Drawing.Point(138, 17);
            this.CmbCancel.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCancel.Name = "CmbCancel";
            this.CmbCancel.Size = new System.Drawing.Size(77, 24);
            this.CmbCancel.TabIndex = 1;
            this.CmbCancel.Text = "&Cancel";
            this.CmbCancel.UseVisualStyleBackColor = true;
            // 
            // CmbOK
            // 
            this.CmbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmbOK.Enabled = false;
            this.CmbOK.Location = new System.Drawing.Point(31, 17);
            this.CmbOK.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOK.Name = "CmbOK";
            this.CmbOK.Size = new System.Drawing.Size(72, 24);
            this.CmbOK.TabIndex = 0;
            this.CmbOK.Text = "&OK";
            this.CmbOK.UseVisualStyleBackColor = true;
            // 
            // PbxCoBuilder
            // 
            this.PbxCoBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCoBuilder.Image = Properties.Resources.CoBuilder_logo;
            this.PbxCoBuilder.Location = new System.Drawing.Point(62, 6);
            this.PbxCoBuilder.Margin = new System.Windows.Forms.Padding(2);
            this.PbxCoBuilder.Name = "PbxCoBuilder";
            this.PbxCoBuilder.Size = new System.Drawing.Size(196, 50);
            this.PbxCoBuilder.TabIndex = 12;
            this.PbxCoBuilder.TabStop = false;
            // 
            // Lblcobuilder
            // 
            this.Lblcobuilder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lblcobuilder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.Lblcobuilder.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcobuilder.Location = new System.Drawing.Point(8, 376);
            this.Lblcobuilder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lblcobuilder.Name = "Lblcobuilder";
            this.Lblcobuilder.Size = new System.Drawing.Size(251, 19);
            this.Lblcobuilder.TabIndex = 13;
            this.Lblcobuilder.Text = "Http://www.coBuilder.com";
            // 
            // LoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CmbCancel;
            this.ClientSize = new System.Drawing.Size(269, 403);
            this.Controls.Add(this.Lblcobuilder);
            this.Controls.Add(this.PbxCoBuilder);
            this.Controls.Add(this.GrpCommands);
            this.Controls.Add(this.GrpWorkplace);
            this.Controls.Add(this.grpLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(285, 442);
            this.Name = "LoginDialog";
            this.Text = "coBuilder - Login";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.GrpWorkplace.ResumeLayout(false);
            this.GrpWorkplace.PerformLayout();
            this.GrpCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpLogin;
        private CheckBox CbxRemember;
        private Button CmbLogin;
        private TextBox TxbPassword;
        private Label LblPassword;
        private TextBox TxbName;
        private Label LblUserName;
        private GroupBox GrpWorkplace;
        private Button CmbApply;
        private ComboBox CboWorkplace;
        private Label LblWorkSpace;
        private GroupBox GrpCommands;
        private Button CmbCancel;
        private Button CmbOK;
        private PictureBox PbxCoBuilder;
        private Label Lblcobuilder;
    }
}