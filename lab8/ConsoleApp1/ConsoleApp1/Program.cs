using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        Store store = new Store();
        store.AddAbsDiscountProduct("Product1", 1000, 100);
        store.AddNoDiscountProduct("Product2", 1500);
        store.AddAbsDiscountProduct("Product3", 2000, 200);

        Console.WriteLine("Общая стоимость продуктов: " + store.GetTotalPrice());
    }
}