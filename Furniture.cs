using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_Classes
{
    class Furniture
    {
        private string type = "Стол";
        private string name = null;
        private double height;
        private double lenght;
        private double wide;
        private string material;
        private static bool isPainted;
        private static bool isVarnished;

        //методы доступа к закрытым полям
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Material
        {
            get
            {
                return material;
            }
            set
            {
                material = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                lenght = value;
            }
        }
        public double Wide
        {
            get
            {
                return wide;
            }
            set
            {
                wide = value;
            }
        }

        //статические поля
        public static bool IsPainted
        {
            get
            {
                return isPainted;
            }
            set
            {
                isPainted = value;
            }
        }

        public static bool IsVarnished
        {
            get
            {
                return isVarnished;
            }
            set
            {
                isVarnished = value;
            }
        }

        //Конструкторы
        public Furniture() { }
        public Furniture(string name, double height, double lenght, double wide, string material)
        {
            Name = name;
            Type = type;
            Height = height;
            Lenght = lenght;
            Wide = wide;
            Material = material;

        }
        public Furniture(double height, double lenght, double wide, string material, bool isPainted, bool isVarnished)
        {
            Type = type;
            Height = height;
            Lenght = lenght;
            Wide = wide;
            Material = material;
            IsPainted = false;
            IsVarnished = false;
        }
        //статический конструктор
        static Furniture()
        {
            IsPainted = false;
            IsVarnished = false;
        }

       //Методы управления классом

        public void Print ()
        {
            Console.WriteLine($"{type} {name} с размерами: длина {lenght}, ширина {wide}," +
                $" высота {height}, материал исполнения: {material}"); 
        }
        public void Paint ()
        {
            if (IsPainted == true)
            {
                Console.WriteLine("Table has been already painted, sir!");
            }
            Console.WriteLine("Your table is painted, sir");
            IsPainted = true;
        }
        public void Varnish()
        {
            if (IsVarnished == true)
            {
                Console.WriteLine("Table has been already varnished, sir!");
            }
            Console.WriteLine("Your table is varnished, sir");
            IsVarnished = true;
        }

    }
}
