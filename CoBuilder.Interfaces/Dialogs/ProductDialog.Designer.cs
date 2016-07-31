using System.Windows.Forms;

namespace CoBuilder.Service.Dialogs
{
    partial class ProductDialog
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
            this.GBxProducts = new System.Windows.Forms.GroupBox();
            this.LblProducts = new System.Windows.Forms.Label();
            this.LblSupplier = new System.Windows.Forms.Label();
            this.CbxApplySupplierFilter = new System.Windows.Forms.CheckBox();
            this.CboSupplier = new System.Windows.Forms.ComboBox();
            this.CboProduct = new System.Windows.Forms.ComboBox();
            this.GbxProperties = new System.Windows.Forms.GroupBox();
            this.CmbNavigate = new System.Windows.Forms.Button();
            this.TxbLink = new System.Windows.Forms.TextBox();
            this.LblLink = new System.Windows.Forms.Label();
            this.CmbOK = new System.Windows.Forms.Button();
            this.CmbCancel = new System.Windows.Forms.Button();
            this.GbxCommands = new System.Windows.Forms.GroupBox();
            this.GbxFilter = new System.Windows.Forms.GroupBox();
            this.CbxProductFilter = new System.Windows.Forms.CheckBox();
            this.TxbFilter = new System.Windows.Forms.TextBox();
            this.GbxSelected = new System.Windows.Forms.GroupBox();
            this.PbxCoBuilder = new System.Windows.Forms.PictureBox();
            this.LblType = new System.Windows.Forms.Label();
            this.LblFamily = new System.Windows.Forms.Label();
            this.LblCatagoryName = new System.Windows.Forms.Label();
            this.LblFamilyName = new System.Windows.Forms.Label();
            this.LblCategory = new System.Windows.Forms.Label();
            this.LblTypeName = new System.Windows.Forms.Label();
            this.GBxProducts.SuspendLayout();
            this.GbxProperties.SuspendLayout();
            this.GbxCommands.SuspendLayout();
            this.GbxFilter.SuspendLayout();
            this.GbxSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).BeginInit();
            this.SuspendLayout();
            // 
            // GBxProducts
            // 
            this.GBxProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBxProducts.Controls.Add(this.LblProducts);
            this.GBxProducts.Controls.Add(this.LblSupplier);
            this.GBxProducts.Controls.Add(this.CbxApplySupplierFilter);
            this.GBxProducts.Controls.Add(this.CboSupplier);
            this.GBxProducts.Controls.Add(this.CboProduct);
            this.GBxProducts.Location = new System.Drawing.Point(10, 173);
            this.GBxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.GBxProducts.Name = "GBxProducts";
            this.GBxProducts.Padding = new System.Windows.Forms.Padding(2);
            this.GBxProducts.Size = new System.Drawing.Size(388, 115);
            this.GBxProducts.TabIndex = 0;
            this.GBxProducts.TabStop = false;
            this.GBxProducts.Text = "Select Product from current Work Place";
            // 
            // LblProducts
            // 
            this.LblProducts.AutoSize = true;
            this.LblProducts.Location = new System.Drawing.Point(5, 15);
            this.LblProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProducts.Name = "LblProducts";
            this.LblProducts.Size = new System.Drawing.Size(75, 13);
            this.LblProducts.TabIndex = 7;
            this.LblProducts.Text = "Product Name";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.Location = new System.Drawing.Point(5, 58);
            this.LblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(76, 13);
            this.LblSupplier.TabIndex = 6;
            this.LblSupplier.Text = "Supplier Name";
            // 
            // CbxApplySupplierFilter
            // 
            this.CbxApplySupplierFilter.AutoSize = true;
            this.CbxApplySupplierFilter.Location = new System.Drawing.Point(117, 57);
            this.CbxApplySupplierFilter.Name = "CbxApplySupplierFilter";
            this.CbxApplySupplierFilter.Size = new System.Drawing.Size(149, 17);
            this.CbxApplySupplierFilter.TabIndex = 2;
            this.CbxApplySupplierFilter.Text = "Apply Supplier Name Filter";
            this.CbxApplySupplierFilter.UseVisualStyleBackColor = true;
            
            // 
            // CboSupplier
            // 
            this.CboSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSupplier.FormattingEnabled = true;
            this.CboSupplier.Location = new System.Drawing.Point(4, 80);
            this.CboSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.CboSupplier.Name = "CboSupplier";
            this.CboSupplier.Size = new System.Drawing.Size(378, 21);
            this.CboSupplier.TabIndex = 0;
            // 
            // CboProduct
            // 
            this.CboProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProduct.FormattingEnabled = true;
            this.CboProduct.Location = new System.Drawing.Point(4, 31);
            this.CboProduct.Margin = new System.Windows.Forms.Padding(2);
            this.CboProduct.Name = "CboProduct";
            this.CboProduct.Size = new System.Drawing.Size(378, 21);
            this.CboProduct.TabIndex = 0;
            // 
            // GbxProperties
            // 
            this.GbxProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxProperties.Controls.Add(this.CmbNavigate);
            this.GbxProperties.Controls.Add(this.TxbLink);
            this.GbxProperties.Controls.Add(this.LblLink);
            this.GbxProperties.Location = new System.Drawing.Point(10, 290);
            this.GbxProperties.Margin = new System.Windows.Forms.Padding(2);
            this.GbxProperties.Name = "GbxProperties";
            this.GbxProperties.Padding = new System.Windows.Forms.Padding(2);
            this.GbxProperties.Size = new System.Drawing.Size(388, 70);
            this.GbxProperties.TabIndex = 1;
            this.GbxProperties.TabStop = false;
            this.GbxProperties.Text = "Product Properties";
            // 
            // CmbNavigate
            // 
            this.CmbNavigate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmbNavigate.Location = new System.Drawing.Point(307, 35);
            this.CmbNavigate.Margin = new System.Windows.Forms.Padding(2);
            this.CmbNavigate.Name = "CmbNavigate";
            this.CmbNavigate.Size = new System.Drawing.Size(75, 24);
            this.CmbNavigate.TabIndex = 23;
            this.CmbNavigate.Text = "&Navigate";
            this.CmbNavigate.UseVisualStyleBackColor = true;
            // 
            // TxbLink
            // 
            this.TxbLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbLink.Location = new System.Drawing.Point(7, 38);
            this.TxbLink.Margin = new System.Windows.Forms.Padding(2);
            this.TxbLink.Name = "TxbLink";
            this.TxbLink.Size = new System.Drawing.Size(296, 20);
            this.TxbLink.TabIndex = 21;
            // 
            // LblLink
            // 
            this.LblLink.AutoSize = true;
            this.LblLink.Location = new System.Drawing.Point(7, 23);
            this.LblLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(27, 13);
            this.LblLink.TabIndex = 15;
            this.LblLink.Text = "Link";
            // 
            // CmbOK
            // 
            this.CmbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmbOK.Location = new System.Drawing.Point(86, 17);
            this.CmbOK.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOK.Name = "CmbOK";
            this.CmbOK.Size = new System.Drawing.Size(75, 24);
            this.CmbOK.TabIndex = 2;
            this.CmbOK.Text = "&OK";
            this.CmbOK.UseVisualStyleBackColor = true;
            
            // 
            // CmbCancel
            // 
            this.CmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmbCancel.Location = new System.Drawing.Point(243, 17);
            this.CmbCancel.Margin = new System.Windows.Forms.Padding(2);
            this.CmbCancel.Name = "CmbCancel";
            this.CmbCancel.Size = new System.Drawing.Size(75, 24);
            this.CmbCancel.TabIndex = 3;
            this.CmbCancel.Text = "&Cancel";
            this.CmbCancel.UseVisualStyleBackColor = true;
            
            // 
            // GbxCommands
            // 
            this.GbxCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxCommands.Controls.Add(this.CmbOK);
            this.GbxCommands.Controls.Add(this.CmbCancel);
            this.GbxCommands.Location = new System.Drawing.Point(10, 364);
            this.GbxCommands.Margin = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Name = "GbxCommands";
            this.GbxCommands.Padding = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Size = new System.Drawing.Size(391, 51);
            this.GbxCommands.TabIndex = 4;
            this.GbxCommands.TabStop = false;
            this.GbxCommands.Text = "Commands";
            // 
            // GbxFilter
            // 
            this.GbxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxFilter.Controls.Add(this.CbxProductFilter);
            this.GbxFilter.Controls.Add(this.TxbFilter);
            this.GbxFilter.Location = new System.Drawing.Point(10, 95);
            this.GbxFilter.Margin = new System.Windows.Forms.Padding(2);
            this.GbxFilter.Name = "GbxFilter";
            this.GbxFilter.Padding = new System.Windows.Forms.Padding(2);
            this.GbxFilter.Size = new System.Drawing.Size(388, 74);
            this.GbxFilter.TabIndex = 5;
            this.GbxFilter.TabStop = false;
            this.GbxFilter.Text = "Selection FIlters";
            // 
            // CbxProductFilter
            // 
            this.CbxProductFilter.AutoSize = true;
            this.CbxProductFilter.Location = new System.Drawing.Point(12, 26);
            this.CbxProductFilter.Margin = new System.Windows.Forms.Padding(2);
            this.CbxProductFilter.Name = "CbxProductFilter";
            this.CbxProductFilter.Size = new System.Drawing.Size(172, 17);
            this.CbxProductFilter.TabIndex = 5;
            this.CbxProductFilter.Text = "Apply Product Name Text Filter";
            this.CbxProductFilter.UseVisualStyleBackColor = true;
            
            // 
            // TxbFilter
            // 
            this.TxbFilter.Location = new System.Drawing.Point(12, 48);
            this.TxbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.TxbFilter.Name = "TxbFilter";
            this.TxbFilter.Size = new System.Drawing.Size(295, 20);
            this.TxbFilter.TabIndex = 4;
            
            // 
            // GbxSelected
            // 
            this.GbxSelected.Controls.Add(this.PbxCoBuilder);
            this.GbxSelected.Controls.Add(this.LblType);
            this.GbxSelected.Controls.Add(this.LblFamily);
            this.GbxSelected.Controls.Add(this.LblCatagoryName);
            this.GbxSelected.Controls.Add(this.LblFamilyName);
            this.GbxSelected.Controls.Add(this.LblCategory);
            this.GbxSelected.Controls.Add(this.LblTypeName);
            this.GbxSelected.Location = new System.Drawing.Point(10, 11);
            this.GbxSelected.Margin = new System.Windows.Forms.Padding(2);
            this.GbxSelected.Name = "GbxSelected";
            this.GbxSelected.Padding = new System.Windows.Forms.Padding(2);
            this.GbxSelected.Size = new System.Drawing.Size(387, 81);
            this.GbxSelected.TabIndex = 6;
            this.GbxSelected.TabStop = false;
            this.GbxSelected.Text = "Selected Element  on Screen Information";
            // 
            // PbxCoBuilder
            // 
            this.PbxCoBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCoBuilder.Image = Properties.Resources.CoBuilder_logo;
            this.PbxCoBuilder.Location = new System.Drawing.Point(192, 17);
            this.PbxCoBuilder.Margin = new System.Windows.Forms.Padding(2);
            this.PbxCoBuilder.Name = "PbxCoBuilder";
            this.PbxCoBuilder.Size = new System.Drawing.Size(191, 50);
            this.PbxCoBuilder.TabIndex = 12;
            this.PbxCoBuilder.TabStop = false;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(125, 60);
            this.LblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(45, 13);
            this.LblType.TabIndex = 5;
            this.LblType.Text = "LblType";
            this.LblType.Visible = false;
            // 
            // LblFamily
            // 
            this.LblFamily.AutoSize = true;
            this.LblFamily.Location = new System.Drawing.Point(125, 42);
            this.LblFamily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFamily.Name = "LblFamily";
            this.LblFamily.Size = new System.Drawing.Size(50, 13);
            this.LblFamily.TabIndex = 4;
            this.LblFamily.Text = "LblFamily";
            this.LblFamily.Visible = false;
            // 
            // LblCatagoryName
            // 
            this.LblCatagoryName.AutoSize = true;
            this.LblCatagoryName.Location = new System.Drawing.Point(4, 23);
            this.LblCatagoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCatagoryName.Name = "LblCatagoryName";
            this.LblCatagoryName.Size = new System.Drawing.Size(117, 13);
            this.LblCatagoryName.TabIndex = 3;
            this.LblCatagoryName.Text = "Revit Category Name =";
            this.LblCatagoryName.Visible = false;
            // 
            // LblFamilyName
            // 
            this.LblFamilyName.AutoSize = true;
            this.LblFamilyName.Location = new System.Drawing.Point(4, 42);
            this.LblFamilyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFamilyName.Name = "LblFamilyName";
            this.LblFamilyName.Size = new System.Drawing.Size(116, 13);
            this.LblFamilyName.TabIndex = 2;
            this.LblFamilyName.Text = "Revit Family Name     =";
            this.LblFamilyName.Visible = false;
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Location = new System.Drawing.Point(124, 23);
            this.LblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(49, 13);
            this.LblCategory.TabIndex = 1;
            this.LblCategory.Text = "Category";
            this.LblCategory.Visible = false;
            // 
            // LblTypeName
            // 
            this.LblTypeName.AutoSize = true;
            this.LblTypeName.Location = new System.Drawing.Point(5, 61);
            this.LblTypeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTypeName.Name = "LblTypeName";
            this.LblTypeName.Size = new System.Drawing.Size(117, 13);
            this.LblTypeName.TabIndex = 0;
            this.LblTypeName.Text = "Revit Type Name       =";
            this.LblTypeName.Visible = false;
            // 
            // LinkDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.CmbCancel;
            this.ClientSize = new System.Drawing.Size(410, 423);
            this.Controls.Add(this.GbxSelected);
            this.Controls.Add(this.GbxFilter);
            this.Controls.Add(this.GbxCommands);
            this.Controls.Add(this.GbxProperties);
            this.Controls.Add(this.GBxProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(424, 462);
            this.Name = "LinkDialog";
            this.Text = "Cobuilder Product Selector";
            this.GBxProducts.ResumeLayout(false);
            this.GBxProducts.PerformLayout();
            this.GbxProperties.ResumeLayout(false);
            this.GbxProperties.PerformLayout();
            this.GbxCommands.ResumeLayout(false);
            this.GbxFilter.ResumeLayout(false);
            this.GbxFilter.PerformLayout();
            this.GbxSelected.ResumeLayout(false);
            this.GbxSelected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GBxProducts;
        private ComboBox CboProduct;
        private GroupBox GbxProperties;
        private TextBox TxbLink;
        private Label LblLink;
        private Button CmbOK;
        private Button CmbCancel;
        private GroupBox GbxCommands;
        private GroupBox GbxFilter;
        private TextBox TxbFilter;
        private CheckBox CbxApplySupplierFilter;
        private ComboBox CboSupplier;
        private GroupBox GbxSelected;
        private Label LblCategory;
        private Label LblTypeName;
        private Label LblCatagoryName;
        private Label LblFamilyName;
        private Label LblType;
        private Label LblFamily;
        private CheckBox CbxProductFilter;
        private PictureBox PbxCoBuilder;
        private Label LblSupplier;
        private Label LblProducts;
        private Button CmbNavigate;
    }
}