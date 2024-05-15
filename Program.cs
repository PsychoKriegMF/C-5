using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace C_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A ad = new A(3, 2.0f);
            Console.WriteLine(ad + 2.4f);
            Console.WriteLine(2.4f + ad);

            Point a = new Point(), b = new Point();
            a.X = 3;
            a.Y = 3;
            b.X = 3;
            b.Y = 3;
            if (a && b)
            {

            }
            Rectangle rectangle = new Rectangle(5, 10);
            Square square = new Square { Length = 7 };
            Rectangle rectSquare = square;

            Shop laptops = new Shop(3);
            laptops[0] = new Laptop
            {
                Vendor = "Samsung",
                Price = 5000
            };
            laptops[1] = new Laptop
            {
                Vendor = "Huawei",
                Price = 3000
            };
            laptops[2] = new Laptop
            {
                Vendor = "Dexp",
                Price = 1000
            };

            Console.WriteLine(laptops[1].ToString());

            Jober jober1 = new Jober("Ivanov Ivan Ivanich", new DateTime(1990, 5, 15), "+79826359875", "Ivanov@mail.ru", "Proger", "Designer", 50000);

            Jober jober2 = new Jober("Alexandrov Alexandr Alexandrovich", new DateTime(1993, 10, 15), "+79826654875", "Alexandrow@mail.ru", "Manager", "Progect Menejment", 45000);

            Console.WriteLine(jober1.ToString());
            Console.WriteLine(jober2.ToString());
            jober2.Salary = jober2 + 5000.0m;
            Console.WriteLine(jober1.Equals(jober2));
        }


    }


    public class A
    {
        public int Abc { get; set; }
        public float Bbc { get; set; }
        public A(int Abc, float Bbc)
        {
            this.Abc = Abc;
            this.Bbc = Bbc;
        }

        public static float operator +(A a, float b) { return a.Abc + b; }
        public static float operator +(float b, A a ) { return b + a.Abc; }
        public static int operator+(A a,A b) { return a.Abc + b.Abc; }
        public static bool operator >(A a, A b)
        {
            if (a.Abc > b.Abc) return false;
            else return true;
        }
        public static bool operator <(A a, A b)
        {
            if (a.Abc < b.Abc) return false;
            else return true;
        }
        public static A operator ++(A a) { a.Abc++; return a; }
        public static A operator --(A a) { a.Abc--; return a; }
        public static A operator -(A a) { a.Abc = -a.Abc; return a;}
        public static bool operator true(A a) { return a.Abc > 0; }
        public static bool operator false(A a) { return a.Abc != 0; }
        public static A operator &(A a, A b) { return a; }
       // public static implicit operator Point(A a) { }  // неявное
       // public static explicit operator Point(A a) { }  // явное

    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point() { }
        public static Point operator &(Point a, Point b)
        {
            if (a.X != 0 && a.Y != 0 && b.X != 0 && b.Y != 0)
            {
                return b;
            }
            return new Point();
        }
        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0 ? true : false;
        }
        public static bool operator false(Point p)
        {
            return p.X == 0 || p.Y == 0 ? true : false;
        }
    }
            
    class Rectangle 
    {
        public int Width {  get; set; }
        public int Height { get; set; }
        public Rectangle(int Width, int Height) 
        {
            this.Width = Width;
            this.Height = Height;
        }
        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.Length * 2,s.Length);
        }
    }
    class Square 
    {
        public int Length {  get; set; }        
        //Тип данных this[ргумента] {get;set;}
    }

    public class Laptop
    {
        public string Vendor { get; set; }
        public int Price { get; set; }

    public override string ToString()
    {
        return $"{Vendor} {Price}";
    }
}
    public class  Shop
    {
        Laptop[] laptopArr;
        public Shop(int size)
        {
            laptopArr = new Laptop[size];
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptopArr.Length)
                {
                    return laptopArr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                laptopArr[index] = value;
            }


        }
    }

}
