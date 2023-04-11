using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
   public class TestClass
    {
        public double x;
        private double y;
        public static double Urjikh(double x, double y)
        {
            double urjver = x * y;
            return urjver;
        }
    }
    //Second Class нь TestClass -аас удамшина 
    public class SecondClass : TestClass
    {
        private double y { get; set; }
    }

    public abstract class ThirdClass:TestClass
    {
        public double z { get; set; }
        public abstract double huvaah(double x, double y);
    }

    public class fourthclass : ThirdClass
    {
        public override double huvaah(double x, double y)
        {
            double noogdvor = x / y;
            return noogdvor;
        }
    }
}
