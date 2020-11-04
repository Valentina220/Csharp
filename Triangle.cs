using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassShape
{
    class Triangle: Shape, IRotate
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
           if (isTriangle(a,b,c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            
        }

        public Triangle(double a)
        {
            this.a = a;
            this.b = a;
            this.c = a;
        }

        private bool isTriangle(double a, double b, double c)
        {
            {
                if (a > 0 && b >0 && c > 0 && a + b > c && a + c > b && b + c > a)
                {
                    //Console.WriteLine("triangle exists");
                    return true;
                }
                else
                {
                    //Console.WriteLine("triangle doesn't exist");
                    return false;
                }
            }
        }

        public string ExistString()
        {            
            string s;
            if (isTriangle(a, b, c))
            {
                s = "Длины сторон треугольника: " + a + "; " + b + "; " + c;
                //string s1 = base.ToString();
            }
            else
            {
                s = "Такого треугольника не существует";
            }
            return s;  //= base.ToString();

        }

        //base.ToString();

        public override string ClassName()
        {            
            string name = "Треугольник";
            return name;
        }
        public override double Perimetr()
        {
           double p = a + b + c;
           return p;
        }
        public override double Area()
        {
            return Math.Sqrt(Perimetr() * (Perimetr() - a) * (Perimetr() - b) * (Perimetr() - c));
        }

        public string Rotate()
        {
            return "вращение";
        }
    }  

    //new public void Show()
    //{
    //    Console.WriteLine(Perimetr());
    //}

    //public override string ToString()
    //{
    //    string res;
    //    res = "Периметр треугольника равен = " + p + "Площадь треугольника равна = " + Area();
    //    return res;
    //}
}
