using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace _4
{
    class TriangleRead
    {
        private int x1, y1, x2, y2, x3, y3;
        private List<int> array = new List<int>() { };
        private double a, b, c;
        public void read()
        {
            using (StreamReader sr = new StreamReader("file6"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        array.Add(Convert.ToInt32(line));
                    }
                    catch
                    {
                        Console.WriteLine("error");
                        break;
                    }
                }
            }
            foreach (int i in array)
            {
                Console.WriteLine($"element array={i}");
            }
            x1 = array[0];
            y1 = array[1];
            x2 = array[2];
            y2 = array[3];
            x3 = array[4];
            y3 = array[5];
            Console.WriteLine("----------------");
            a = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            b = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            c = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            if (a + b > c & b + c > a & a + c > b)
            {
                Console.WriteLine("такой триугольник существует");
                double s, r, R;
                double P = (a + b + c);
                double p = P / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));


                r = Math.Sqrt(p * (p - a) * (p - b) * (p - c) / p);

                R = a * b * c / 4 * Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine($"s={s},p={p}");
                Console.WriteLine($"r={r},R={R}");
                Console.WriteLine("----------------");
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует!");

            }

        }

    }
    class Treadgelvoid
    {
        private int x1, y1, x2, y2, x3, y3;

        public int X1
        {
            set
            {
                x1 = value;
            }
            get
            {
                return x1;
            }
        }
        public int Y1
        {
            set
            {
                y1 = value;
            }
            get
            {
                return y1;
            }
        }
        public int X2
        {
            set
            {
                x2 = value;
            }
            get
            {
                return x2;
            }
        }
        public int Y2
        {
            set
            {
                y2 = value;
            }
            get
            {
                return y2;
            }
        }
        public int X3
        {
            set
            {
                x3 = value;
            }
            get
            {
                return x3;
            }
        }
        public int Y3
        {
            set
            {
                y3 = value;
            }
            get
            {
                return y3;
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int x1, y1, x2, y2, x3, y3;
            double a, b, c;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int k;
            while (true)
            {
                try
                {
                    Console.WriteLine("якщо ви хочете считувати точки з файлу нажміть 1 ,якщо хочете вводити точик з клавіатури то нажміть 2:");
                    k = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("erro");
                }
            }
            if (k == 1)
            {
                TriangleRead abc = new TriangleRead();
                abc.read();
            }
            else
            {
                if (k == 2)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("ведіть х1");
                            x1 = int.Parse(Console.ReadLine());
                            Treadgelvoid x = new Treadgelvoid();
                            x.X1 = x1;
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("неправильно ввели x1");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("ведіть y1");
                            y1 = int.Parse(Console.ReadLine());
                            Treadgelvoid y = new Treadgelvoid();
                            y.Y1 = y1;
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("неправильно ввели y1");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("ведіть х2");
                            x2 = int.Parse(Console.ReadLine());
                            Treadgelvoid x = new Treadgelvoid();
                            x.X2 = x2;
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("неправильно ввели x2");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("ведіть y2");
                            y2 = int.Parse(Console.ReadLine());
                            Treadgelvoid x = new Treadgelvoid();
                            x.Y2 = y2;
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("неправильно ввели y2");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("ведіть х3");
                            x3 = int.Parse(Console.ReadLine());
                            Treadgelvoid x = new Treadgelvoid();
                            x.X3 = x3;
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("неправильно ввели x3");
                        }
                    }
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("ведіть y3");
                            y3 = int.Parse(Console.ReadLine());
                            Treadgelvoid x = new Treadgelvoid();
                            x.Y3 = y3;
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("неправильно ввели y3");
                        }
                    }

                    Console.WriteLine("----------------");
                    Console.WriteLine($"x1={x1};y1={y1}; x2={x2}; y2={y2};x3={x3};y3={y3}");
                    a = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
                    b = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
                    c = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
                    if (a + b > c & b + c > a & a + c > b)
                    {
                        Console.WriteLine("такой триугольник существует");
                        double s, r, R;
                        double P = (a + b + c);
                        double p = P / 2;
                        s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));


                        r = Math.Sqrt(p * (p - a) * (p - b) * (p - c) / p);

                        R = a * b * c / 4 * Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                        Console.WriteLine($"s={s},p={p}");
                        Console.WriteLine($"r={r},R={R}");
                        Console.WriteLine("----------------");
                    }
                    else
                    {
                        Console.WriteLine("Такого треугольника не существует!");

                    }
                }
                else
                {
                    Console.WriteLine("вы не выбрали правильное значение!");
                }
            }
        }

    }
}