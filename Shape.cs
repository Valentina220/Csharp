using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassShape
{

    //public interface IRotate
    //{
    //    void Rotate(double angle);
    //}
  

    abstract class Shape
    {
        public abstract string ClassName();
        public abstract double Area();   

        public abstract double Perimetr();

        public override string ToString()
        {
            string res = "Периметр равен = " + Perimetr() +" " + "Площадь равна = " + Area();
            return res;
        }

    }

}
