using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassShape
{
    class Quadrate: Shape, IRotate
    {
        private double a;

        public Quadrate (double a)
        {
            this.a = a;
        }

        public override string ClassName()
        {
            string name = "Квадрат";
            return name;
        }
        public override double Perimetr()
        {
            return 4 * a;
        }
        public override double Area()
        {
            return Math.Pow(a, 2);
        }

        public string Rotate()
        {
            return "вращение";
        }
    }
}
