using System;


namespace Laba_7_V_1
{
    public class Product
    {
        private double _price;
        private string _name;
        private string _brand;
        private bool _isPromotional;
        private double _promotionalPrice;

        public Product(double price, string name, string brand, double promotionalPrice=double.NaN)
        {
            Price = price;
            Name = name;
            Brand = brand;
            if (!double.IsNaN(promotionalPrice))
            {
                IsPromotional = true;
                PromotionalPrice = promotionalPrice;
            }
            else
            {
                IsPromotional = false;
            }
        }


        /// <summary>
        ///СВойство цена продукта , возвращает ArgumentOutOfRangeException, если пытаемся присвоить отрицательное значение 
        /// </summary>
        public double Price
        {
            get => _price;
            init
            {
                if (value > 0 )
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        /// <summary>
        /// Свойство название продукта , возвращает ArgumentNullException, если пытаемся присвоить пустую строку
        /// </summary>
        public string Name
        {
            get => _name;
            init
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        /// <summary>
        /// Свойство бренд,фирма продукта , возвращает ArgumentNullException, если пытаемся присвоить пустую строку
        /// </summary>
        public string Brand
        {
            get => _brand;
            init
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _brand = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        /// <summary>
        /// Свойство акционный ли товар 
        /// </summary>
        public bool IsPromotional
        {
            get => _isPromotional;
            init => _isPromotional = value;
        }
        /// <summary>
        ///СВойство акционная цена продукта , возвращает ArgumentOutOfRangeException, если пытаемся присвоить отрицательное значение или значение больше обычной цены
        /// </summary>
        public double PromotionalPrice
        {
            get => _promotionalPrice;
            init
            {
                if (value > 0 && value<Price)
                {
                    _promotionalPrice = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public override string ToString()
        {
            string IspromotionalString = "";
            if (IsPromotional)
            {
                IspromotionalString = $"promotional price= {PromotionalPrice} ;";
            }
            return $"Product(name = {Name} ; brand= {Brand} ;price= {Price} ; {IspromotionalString})\n";
        }
    }
}
