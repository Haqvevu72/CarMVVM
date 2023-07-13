using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    internal class Car
    {
        public string? Image { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Year { get; set; }
        
        public Car(string? image, string? make, string? model, string? year)
        {
            Image = image;
            Make = make;
            Model = model;
            Year = year;
        }

    }
}
