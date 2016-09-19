using System.Windows.Forms;

namespace CoBuilder.Service.GUI
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
            this.PbxCoBuilder = new System.Windows.Forms.PictureBox();
            this.GBxProducts.SuspendLayout();
            this.GbxProperties.SuspendLayout();
            this.GbxCommands.SuspendLayout();
            this.GbxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCoBuilder)).BeginInit();
            this.SuspendLayout();
            // 
            // GBxProducts
            // 
            this.GBxProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBxProducts.Controls.Add(this.LblProducts);
            this.GBxProducts.Controls.Add(this.LblSupplier);
            this.GBxProducts.Controls.Add(this.CbxApplySupplierFilter);
            this.GBxProducts.Controls.Add(this.CboSupplier);
            this.GBxProducts.Controls.Add(this.CboProduct);
            this.GBxProducts.Location = new System.Drawing.Point(11, 156);
            this.GBxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.GBxProducts.Name = "GBxProducts";
            this.GBxProducts.Padding = new System.Windows.Forms.Padding(2);
            this.GBxProducts.Size = new System.Drawing.Size(463, 129);
            this.GBxProducts.TabIndex = 0;
            this.GBxProducts.TabStop = false;
            this.GBxProducts.Text = "Select Product from current Work Place";
            // 
            // LblProducts
            // 
            this.LblProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblProducts.AutoSize = true;
            this.LblProducts.Location = new System.Drawing.Point(12, 19);
            this.LblProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProducts.Name = "LblProducts";
            this.LblProducts.Size = new System.Drawing.Size(75, 13);
            this.LblProducts.TabIndex = 7;
            this.LblProducts.Text = "Product Name";
            // 
            // LblSupplier
            // 
            this.LblSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.Location = new System.Drawing.Point(11, 71);
            this.LblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(76, 13);
            this.LblSupplier.TabIndex = 6;
            this.LblSupplier.Text = "Supplier Name";
            // 
            // CbxApplySupplierFilter
            // 
            this.CbxApplySupplierFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxApplySupplierFilter.AutoSize = true;
            this.CbxApplySupplierFilter.Location = new System.Drawing.Point(306, 68);
            this.CbxApplySupplierFilter.Name = "CbxApplySupplierFilter";
            this.CbxApplySupplierFilter.Size = new System.Drawing.Size(149, 17);
            this.CbxApplySupplierFilter.TabIndex = 2;
            this.CbxApplySupplierFilter.Text = "Apply Supplier Name Filter";
            this.CbxApplySupplierFilter.UseVisualStyleBackColor = true;
            this.CbxApplySupplierFilter.CheckedChanged += new System.EventHandler(this.Filters_Changed);
            // 
            // CboSupplier
            // 
            this.CboSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSupplier.FormattingEnabled = true;
            this.CboSupplier.Location = new System.Drawing.Point(8, 90);
            this.CboSupplier.Margin = new System.Windows.Forms.Padding(6);
            this.CboSupplier.Name = "CboSupplier";
            this.CboSupplier.Size = new System.Drawing.Size(447, 21);
            this.CboSupplier.TabIndex = 0;
            this.CboSupplier.SelectionChangeCommitted += new System.EventHandler(this.Filters_Changed);
            // 
            // CboProduct
            // 
            this.CboProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProduct.FormattingEnabled = true;
            this.CboProduct.Location = new System.Drawing.Point(8, 38);
            this.CboProduct.Margin = new System.Windows.Forms.Padding(6);
            this.CboProduct.Name = "CboProduct";
            this.CboProduct.Size = new System.Drawing.Size(447, 21);
            this.CboProduct.TabIndex = 0;
            this.CboProduct.SelectionChangeCommitted += new System.EventHandler(this.CboProduct_SelectionChangeCommitted);
            // 
            // GbxProperties
            // 
            this.GbxProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxProperties.Controls.Add(this.CmbNavigate);
            this.GbxProperties.Controls.Add(this.TxbLink);
            this.GbxProperties.Controls.Add(this.LblLink);
            this.GbxProperties.Location = new System.Drawing.Point(11, 289);
            this.GbxProperties.Margin = new System.Windows.Forms.Padding(2);
            this.GbxProperties.Name = "GbxProperties";
            this.GbxProperties.Padding = new System.Windows.Forms.Padding(2);
            this.GbxProperties.Size = new System.Drawing.Size(463, 63);
            this.GbxProperties.TabIndex = 1;
            this.GbxProperties.TabStop = false;
            this.GbxProperties.Text = "Product Properties";
            // 
            // CmbNavigate
            // 
            this.CmbNavigate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CmbNavigate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmbNavigate.Location = new System.Drawing.Point(375, 32);
            this.CmbNavigate.Margin = new System.Windows.Forms.Padding(6);
            this.CmbNavigate.Name = "CmbNavigate";
            this.CmbNavigate.Size = new System.Drawing.Size(75, 24);
            this.CmbNavigate.TabIndex = 23;
            this.CmbNavigate.Text = "&Navigate";
            this.CmbNavigate.UseVisualStyleBackColor = true;
            this.CmbNavigate.Click += new System.EventHandler(this.CmbNavigate_Click);
            // 
            // TxbLink
            // 
            this.TxbLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbLink.Location = new System.Drawing.Point(8, 35);
            this.TxbLink.Margin = new System.Windows.Forms.Padding(6);
            this.TxbLink.Name = "TxbLink";
            this.TxbLink.Size = new System.Drawing.Size(355, 20);
            this.TxbLink.TabIndex = 21;
            // 
            // LblLink
            // 
            this.LblLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLink.AutoSize = true;
            this.LblLink.Location = new System.Drawing.Point(11, 20);
            this.LblLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(27, 13);
            this.LblLink.TabIndex = 15;
            this.LblLink.Text = "Link";
            // 
            // CmbOK
            // 
            this.CmbOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CmbOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmbOK.Location = new System.Drawing.Point(292, 17);
            this.CmbOK.Margin = new System.Windows.Forms.Padding(2);
            this.CmbOK.Name = "CmbOK";
            this.CmbOK.Size = new System.Drawing.Size(75, 24);
            this.CmbOK.TabIndex = 2;
            this.CmbOK.Text = "&OK";
            this.CmbOK.UseVisualStyleBackColor = true;
            this.CmbOK.Click += new System.EventHandler(this.CmbOK_Click);
            // 
            // CmbCancel
            // 
            this.CmbCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CmbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmbCancel.Location = new System.Drawing.Point(375, 17);
            this.CmbCancel.Margin = new System.Windows.Forms.Padding(6);
            this.CmbCancel.Name = "CmbCancel";
            this.CmbCancel.Size = new System.Drawing.Size(75, 24);
            this.CmbCancel.TabIndex = 3;
            this.CmbCancel.Text = "&Cancel";
            this.CmbCancel.UseVisualStyleBackColor = true;
            this.CmbCancel.Click += new System.EventHandler(this.CmbCancel_Click);
            // 
            // GbxCommands
            // 
            this.GbxCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxCommands.Controls.Add(this.CmbOK);
            this.GbxCommands.Controls.Add(this.CmbCancel);
            this.GbxCommands.Location = new System.Drawing.Point(11, 356);
            this.GbxCommands.Margin = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Name = "GbxCommands";
            this.GbxCommands.Padding = new System.Windows.Forms.Padding(2);
            this.GbxCommands.Size = new System.Drawing.Size(463, 56);
            this.GbxCommands.TabIndex = 4;
            this.GbxCommands.TabStop = false;
            // 
            // GbxFilter
            // 
            this.GbxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxFilter.Controls.Add(this.CbxProductFilter);
            this.GbxFilter.Controls.Add(this.TxbFilter);
            this.GbxFilter.Location = new System.Drawing.Point(11, 71);
            this.GbxFilter.Margin = new System.Windows.Forms.Padding(2);
            this.GbxFilter.Name = "GbxFilter";
            this.GbxFilter.Padding = new System.Windows.Forms.Padding(2);
            this.GbxFilter.Size = new System.Drawing.Size(463, 81);
            this.GbxFilter.TabIndex = 5;
            this.GbxFilter.TabStop = false;
            this.GbxFilter.Text = "Selection FIlters";
            // 
            // CbxProductFilter
            // 
            this.CbxProductFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CbxProductFilter.AutoSize = true;
            this.CbxProductFilter.Location = new System.Drawing.Point(8, 24);
            this.CbxProductFilter.Margin = new System.Windows.Forms.Padding(2);
            this.CbxProductFilter.Name = "CbxProductFilter";
            this.CbxProductFilter.Size = new System.Drawing.Size(172, 17);
            this.CbxProductFilter.TabIndex = 5;
            this.CbxProductFilter.Text = "Apply Product Name Text Filter";
            this.CbxProductFilter.UseVisualStyleBackColor = true;
            this.CbxProductFilter.CheckedChanged += new System.EventHandler(this.Filters_Changed);
            // 
            // TxbFilter
            // 
            this.TxbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbFilter.Location = new System.Drawing.Point(8, 49);
            this.TxbFilter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 10);
            this.TxbFilter.Name = "TxbFilter";
            this.TxbFilter.Size = new System.Drawing.Size(447, 20);
            this.TxbFilter.TabIndex = 4;
            this.TxbFilter.TextChanged += new System.EventHandler(this.Filters_Changed);
            // 
            // PbxCoBuilder
            // 
            this.PbxCoBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCoBuilder.Image = global::CoBuilder.Service.Properties.Resources.CoBuilder_logo;
            this.PbxCoBuilder.Location = new System.Drawing.Point(283, 11);
            this.PbxCoBuilder.Margin = new System.Windows.Forms.Padding(2);
            this.PbxCoBuilder.Name = "PbxCoBuilder";
            this.PbxCoBuilder.Size = new System.Drawing.Size(191, 50);
            this.PbxCoBuilder.TabIndex = 12;
            this.PbxCoBuilder.TabStop = false;
            // 
            // ProductDialog
            // 
            this.AcceptButton = this.CmbOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.CmbCancel;
            this.ClientSize = new System.Drawing.Size(485, 423);
            this.Controls.Add(this.PbxCoBuilder);
            this.Controls.Add(this.GbxFilter);
            this.Controls.Add(this.GbxCommands);
            this.Controls.Add(this.GbxProperties);
            this.Controls.Add(this.GBxProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(424, 462);
            this.Name = "ProductDialog";
            this.Text = "Cobuilder Product Selector";
            this.Load += new System.EventHandler(this.ProductDialog_Load);
            this.GBxProducts.ResumeLayout(false);
            this.GBxProducts.PerformLayout();
            this.GbxProperties.ResumeLayout(false);
            this.GbxProperties.PerformLayout();
            this.GbxCommands.ResumeLayout(false);
            this.GbxFilter.ResumeLayout(false);
            this.GbxFilter.PerformLayout();
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
        private CheckBox CbxProductFilter;
        private PictureBox PbxCoBuilder;
        private Label LblSupplier;
        private Label LblProducts;
        private Button CmbNavigate;
    }
}