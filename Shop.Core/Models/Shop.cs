using System.Diagnostics.Metrics;

namespace Shop.Core.Models
{
    public class Shop:Base
    {
        private string _name;
        private double _minSalary;
        private double _budget;

        private static int _counter;
        public string Name { get; set; }
        public double MinSalary { get; set; }
        public double Budget { get; set; }
        public Shop(string name, double salary, double budget)
        {
            Id = ++_counter;
            _name = name;
            _minSalary = salary;   
            _budget = budget;

        }

    }
}
