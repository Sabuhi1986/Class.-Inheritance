using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Class
{
    public class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }


        public void ProductInfo(Product mehsul1)
        {

            StringBuilder info = new StringBuilder();
      

            Console.WriteLine("Mehsulun adini daxil edin: ");
            mehsul1.Name = Console.ReadLine();
            Console.WriteLine("Mehsulun novunu daxil edin: ");
            mehsul1.Type = Console.ReadLine();
            Console.WriteLine("Mehsulun rengini daxil edin: ");
            mehsul1.Color = Console.ReadLine();
            Console.WriteLine("Mehsulun olcusunu daxil edin: ");
            mehsul1.Size = Console.ReadLine();

            Console.WriteLine("Mehsulun adi:  " + mehsul1.Name   ,   "Mehsulun novu:  " +mehsul1.Type,  "Mehsulun rengi: "   +mehsul1.Color,    "Mehsulun olcusu: "   +mehsul1.Size);
        }
    }

    }

