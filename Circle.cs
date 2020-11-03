using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassShape
{
    class Circle: Shape, IRotate
    {
        private double radius; 
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override string ClassName()
        {
            string name = "Окружность";
            return name;
        }
        public override double Perimetr()
        {
            return  2*Math.PI * radius;          
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string Rotate()
        {
            return "вращение";
        }
    }
}
