using System;

namespace Laba_7_V_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(price: 10.33, name: "bread", brand: "OMXA",promotionalPrice:9.3);
            Product product2 = new Product(price: 10.33, name: "dress", brand: "VS", promotionalPrice: 3.3);
            Product product3 = new Product(price: 100000000000000, name: "car", brand: "OPEL");
            Product product4 = new Product(price: 700.450, name: "iphone", brand: "Apple", promotionalPrice: 600);
            Product product5 = new Product(price: 9.99, name: "cup", brand: "My Home", promotionalPrice: 9.3);
            Product product6 = new Product(price: 6501.33, name: "t-short", brand: "lives");

            ShoppingList shoppingList = new ShoppingList(product3);
            //Добавление елементов product6,product2,product1,product5
            shoppingList.AddElement(product6);
            shoppingList.AddElement(product2);
            shoppingList.AddElement(product1);
            shoppingList.AddElement(product5);
            Console.WriteLine("Shopping list:");
            Console.WriteLine(shoppingList);
            //Удаление елемента по индексу 3 
            shoppingList.RemoveElementByIndex(3);
            Console.WriteLine("Shopping list:");
            Console.WriteLine(shoppingList);
            //Удаление елемента product2 и product5
            shoppingList.RemoveElementByProduct(product2);
            shoppingList.RemoveElementByProduct(product5);
            Console.WriteLine("Shopping list:");
            Console.WriteLine(shoppingList);

        }
    }
}
