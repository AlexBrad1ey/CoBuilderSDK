using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Helpers;

namespace CoBuilder.Service.GUI
{
    public partial class ProductDialog : Form
    {
        private readonly ProductsRepository _productsRepo;
        private readonly Settings _settings;
        private ObservableCollection<BimProduct> _productProxy = new ObservableCollection<BimProduct>();
        private ObservableCollection<string> _supplierProxy = new ObservableCollection<string>();

        public ProductDialog(ProductsRepository productsRepo, Settings settings)
        {
            _productsRepo = productsRepo;
            _settings = settings;
            InitializeComponent();
            UserInitializeComponent();
        }

        public BimProduct SelectedProduct { get; protected set; }
        private void UserInitializeComponent()
        {
            _productProxy.CollectionChanged += Products_CollectionChanged;
            _supplierProxy.CollectionChanged += Suppliers_CollectionChanged;
        }

        private void ProductDialog_Load(object sender, EventArgs e)
        {
            try
            {
                Filters_Changed(sender, e);

                _supplierProxy = new ObservableCollection<string>(_productsRepo.GetAllSupplierList());
                Suppliers_CollectionChanged(sender, e);

                GBxProducts.Text = "Select Product from current Work Place.";
                CboSupplier.Text = "ALL";
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _settings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void Products_CollectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (_productProxy != null && _productProxy.Count != 0)
                {
                    CboProduct.Items.Clear();
                    foreach (var product in _productProxy)
                    {
                        CboProduct.Items.Add(product);
                    }
                    CboProduct.DisplayMember = "Name";
                    CboProduct.ValueMember = "Id";
                }
                else
                {
                    CboProduct.Text = "No Products Found";
                }
                LblProducts.Text = "Product Name (" + CboProduct.Items.Count + " available)";
            }
            catch (Exception exception)
            {
                _settings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void Suppliers_CollectionChanged(object sender, EventArgs e)
        {
            try
            {
                string msg;
                if (_supplierProxy != null && _supplierProxy.Count != 0)
                {
                    CboSupplier.Items.Clear();
                    foreach (var supplier in _supplierProxy)
                    {
                        CboSupplier.Items.Add(supplier);
                    }
                    msg = "Apply Supplier Name Filter (" + _supplierProxy.Count + " Supplier" +
                          (_supplierProxy.Count > 1 ? "s)" : ")");
                }
                else
                {
                    CboSupplier.Text = "No Suppliers Found";
                    msg = "No Suppliers Found";
                }
                CbxApplySupplierFilter.Text = msg;
            }
            catch (Exception exception)
            {
                _settings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void Filters_Changed(object sender, EventArgs e)
        {
            try
            {
                _productProxy = new ObservableCollection<BimProduct>(
                    _productsRepo.GetAll()
                        .Where(
                            bp =>
                                (!CbxApplySupplierFilter.Checked || bp.SupplierName == CboSupplier.Text) &&
                                (!CbxProductFilter.Checked ||
                                 bp.Name.IndexOf(TxbFilter.Text, StringComparison.InvariantCultureIgnoreCase) >= 0))
                        );
                Products_CollectionChanged(sender, e);
                CboProduct.SelectedIndex = CboProduct.Items.Count <= 0 ? -1 : 0;
                UpdateProductData();
            }
            catch (Exception exception)
            {
                _settings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void CboProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                UpdateProductData();
            }
            catch (Exception exception)
            {
                _settings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        private void CmbNavigate_Click(object sender, EventArgs e)
        {
            Settings.WebLaunch(TxbLink.Text);
        }

        private void CmbCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            SelectedProduct = null;
            Close();
        }

        private void CmbOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SelectedProduct = CboProduct.SelectedItem as BimProduct;
            Close();
        }

        private void UpdateProductData()
        {
            try
            {
                if (CboProduct.Items.Count == 0)
                {
                    CboSupplier.Text = "Not Found";
                    TxbLink.Text = "Not Found";
                }
                else
                {
                    try
                    {
                        var bimProduct = CboProduct.SelectedItem as BimProduct;

                        if (bimProduct != null)
                        {
                            CboSupplier.Text = bimProduct.SupplierName;
                            TxbLink.Text = bimProduct.Link;
                        }
                    }
                    catch (Exception exception)
                    {
                        _settings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
                    }
                }
                LblProducts.Text = "Product Name (" + CboProduct.Items.Count + " available)";
            }
            catch (Exception exception)
            {
                _settings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
            }
        }
    }
}