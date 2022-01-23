using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture[] arrFurniture = new Furniture[]
            {
                new Furniture ("Элегантность", 112, 80, 65, "Дуб"),
                new Furniture ("Престиж", 101, 70, 55, "Дуб"),
                new Furniture ("Грация", 120, 83, 70, "Ясень"),
                new Furniture ("СуперВау", 114, 79, 68, "Береза"),
                new Furniture ("ПростоСтол", 115, 75, 70, "Сосна")
            };

            foreach (Furniture fur in arrFurniture)
            { fur.Print(); }
            Console.WriteLine();
            arrFurniture[1].Paint();
            arrFurniture[3].Varnish();

        }
    }
}
