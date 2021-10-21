using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kit_Up.Models
{
    public class Cart
    {
        private List<CartLine> _cardLines = new List<CartLine>();
        public List<CartLine> CardLines
        {
            get{ return _cardLines; }
        }
        public void AddProduct(Urun product, int quantity)
        {
            var line = _cardLines.Where(i => i.Product.UrunId == product.UrunId).FirstOrDefault();
            if (line == null)
            {
                _cardLines.Add(new CartLine() {Product = product, Quantity = quantity });
            }else
            {
                line.Quantity += quantity;
            }
        }

        public void DeleteProduct(Urun product)
        {
            _cardLines.RemoveAll(i => i.Product.UrunId == product.UrunId);
        }
    
        public double Total()
        {
            return _cardLines.Sum(i=>i.Product.UrunFiyat * i.Quantity);
        }
        
        public void Clear()
        {
            _cardLines.Clear();
        }
    }
    public class CartLine
    {
        public Urun Product { get; set; }
        public int Quantity { get; set; }
    }
}