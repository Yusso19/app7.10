using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App7._10._25.Exceptions;

namespace App7._10._25.Models
{
    internal class Book : Product
    {
        public string Author { get; set; }
        public int PageCount { get; set; }






        public override void Sell()
        {
            if (Count <= 0)
            {
                throw new ProductCountIsZeroException("Product count is zero");
            }

            }

        public override void ShowInfo()
        {
            Console.WriteLine( $"Id: {Id}, Name: {Name}, Price: {Price}, Count: {Count}, TotalPrice: {TotalPrice}, Author: {Author}, PageCount: {PageCount}");
        }
    }
}
