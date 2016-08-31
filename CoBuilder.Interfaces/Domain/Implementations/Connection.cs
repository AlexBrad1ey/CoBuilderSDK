namespace CoBuilder.Service.Domain
{
    public class Connection<TElement> where TElement : class
    {
        private TElement _element;
        private BimProduct _product;
        //private LoadState _state = LoadState.Unconnected;

        public Connection()
        {
        }

        public Connection(TElement element)
        {
            _element = element;
        }

        public Connection(TElement element, BimProduct product)
        {
            _element = element;
            _product = product;
            //_state = LoadState.Loaded;
        }

        public TElement AppElement { get { return _element; } }

        public BimProduct BimProduct
        {
            get { return _product; }
            internal set
            {
                _product = value;
                //_state = LoadState.Loaded;
            }
        }


        /* public LoadState State
        {
            get { return _state; }
            set { _state = value; }
        }

        public bool IsLoaded => _state == LoadState.Loaded;
        */
    }
}