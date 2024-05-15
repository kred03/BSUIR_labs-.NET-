using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Hotel hotel = new Hotel();

        hotel.AddRoom(new Room("101", 1000, new DiscountPriceStrategy(10)));
        hotel.AddRoom(new Room("102", 1500, new RegularPriceStrategy()));
        hotel.AddRoom(new Room("103", 2000, new DiscountPriceStrategy(20)));

        Console.WriteLine("Средняя стоимость номеров: " + hotel.GetAveragePrice());
    }
}
