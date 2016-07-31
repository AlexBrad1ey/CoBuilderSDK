namespace CoBuilder.Service.Domain
{
    public class Connection<TElement> where TElement : class
    {
        private Core.Domain.BimProduct _product;
        private int _productId;
        //private LoadState _state = LoadState.Unconnected;

        public Connection()
        {
        }

        public Connection(TElement element)
        {
            AppElement = element;
        }

        public Connection(TElement element, Core.Domain.BimProduct product)
        {
            AppElement = element;
            _product = product;
            _productId = product.Id;
            //_state = LoadState.Loaded;
        }

        public Connection(TElement element, int productId)
        {
            AppElement = element;
            _productId = productId;
            //_state = LoadState.NotLoaded;
        }

        public TElement AppElement { get; set; }

        public Core.Domain.BimProduct BimProduct
        {
            get { return _product; }
            internal set
            {
                _product = value;
                _productId = value.Id;
                //_state = LoadState.Loaded;
            }
        }

        public int BimProductId
        {
            get { return _productId; }
            internal set
            {
                if (value != _productId)
                    //_state = LoadState.NotLoaded;

                    _productId = value;
            }
        }

        public int WorkplaceId { get; set; }

        /* public LoadState State
        {
            get { return _state; }
            set { _state = value; }
        }

        public bool IsLoaded => _state == LoadState.Loaded;
        */
    }
}