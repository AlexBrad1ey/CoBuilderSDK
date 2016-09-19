namespace CoBuilder.Service.Domain
{
    public class Connection<TElement> where TElement : class
    {
        private TElement _element;
        private BimProduct _product;

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
        }

        public TElement AppElement { get { return _element; } }

        public BimProduct BimProduct
        {
            get { return _product; }
            internal set
            {
                _product = value;
            }
        }
    }
}