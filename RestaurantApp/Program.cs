
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                new Restaurant(4, "Huguosi Snacks", "Snacks", 4.2),
                new Restaurant(5, "Quanjude Roast Duck", "Beijing Cuisine", 4.5)
            };

            Console.WriteLine("========================================");
            Console.WriteLine("          RESTAURANT MANAGEMENT");
            Console.WriteLine("========================================");

            Console.WriteLine("\n=== Restaurant List ===");

            foreach (var r in restaurants)
            {
                Console.WriteLine(
                    $"ID: {r.Id,-3} | Name: {r.Name,-25} | Category: {r.Category,-18} | Score: {r.Score:F1}");
            }

            Console.WriteLine("\n========================================");
            Console.WriteLine("          RESTAURANT SUMMARY");
            Console.WriteLine("========================================");

            Console.WriteLine($"Total Restaurants : {restaurants.Count}");

            double averageScore = restaurants.Average(r => r.Score);
            Console.WriteLine($"Average Score     : {averageScore:F2}");

            Console.WriteLine("========================================");

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
