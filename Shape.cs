using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassShape
{

    interface IRotate
    {
        string Rotate();
    }


    abstract class Shape: IRotate
    {
        public abstract string ClassName();
        public abstract double Area();   

        public abstract double Perimetr();

        public override string ToString()
        {
            string res = "Периметр равен = " + Perimetr() +"\n" + "Площадь равна = " + Area();
            return res;
        }

        public abstract string Rotate();
    }

}
