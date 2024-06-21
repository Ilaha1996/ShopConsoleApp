namespace Shop.Core.Models
{
    public class Product:Base
    {

        private static int _counter;
        private string _name;
        private string _type;
        private int _count;
        private double _purchasePrice;
        private double _salePrice;

        public string Name { get; set; }
        public string Type
        {
            get
            { return Type; }

            set
            {
                if (_type != "Electronics" || _type != "Furniture" || _type!= "Toy")
                {
                    throw new ArgumentException();
                }

                Type = value;
            }

        }
        public int Count { get; set; }  
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public Product(string name, string type, int count, double purchasePrice, double salePrice)
        {
            _name = name;
            _type = type;
            _count = count;
            _purchasePrice = purchasePrice;
            _salePrice = salePrice;
             Id = ++_counter;
        }
    }
}
