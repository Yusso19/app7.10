using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7._10._25.Models
{
    abstract class Product
    {

        public int Id { get; set; }

        public string Name { get; set; }
         
        public double Price { get; set; }

        public int Count { get; set; }

        public double TotalPrice { get; set; }

        public abstract void Sell();

        public abstract void ShowInfo();
        
    }
}
