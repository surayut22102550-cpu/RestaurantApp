using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DDer");
            Console.WriteLine("Week2");

            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                new Restaurant(4, "Huguosi Snacks", "Snacks", 4.2),
                new Restaurant(5, "Quanjude Roast Duck", "Beijing Cuisine", 4.5)
            };

            Console.WriteLine("=== Restaurant List ===");
            foreach (var r in restaurants)
            {
                Console.WriteLine($"ID: {r.Id} | Name: {r.Name} | Category: {r.Category} | Score: {r.Score}");
            }

            Console.ReadLine();
        }
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Score { get; set; }

        public Restaurant(int id, string name, string category, double score)
        {
            Id = id;
            Name = name;
            Category = category;
            Score = score;
        }
    }
}
