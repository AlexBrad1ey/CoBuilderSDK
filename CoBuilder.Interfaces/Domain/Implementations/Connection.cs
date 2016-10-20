using System;

namespace CoBuilder.Service.Domain
{
    public class Connection<TElement> where TElement : class
    {
        private readonly TElement _element;
        private readonly BimProduct _product;

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
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var Item = obj as Connection<TElement>;
            if (Item == null) return false;

            return Item.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            int hc = _element.GetHashCode() ^ _product.Id;
            return hc.GetHashCode();
        }
    }
}