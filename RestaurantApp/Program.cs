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
