using System;

namespace Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var district = new Map {Title = "District"};
            district.AddComponent(new MapComponent {Title = "House 1"});
            district.AddComponent(new MapComponent {Title = "House 2"});

            var city = new Map {Title = "New city"};
            city.AddComponent(district);
            city.Draw();

            var house = city.Find("House 1");
            house.Draw();

            Console.ReadLine();
        }
    }
}