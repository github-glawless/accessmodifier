using System;

namespace accessmodifier
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class  Vehicle    { 
        public int    ModelYear = 2015;
        public string Type = "Car" ;
        
    }
    public class Car : Vehicle {
        protected string CarBrand = "Tesla";
        protected string CarModel = "Roadster" ;

    }
    public class Semi : Vehicle {
        protected string SemiBrand = "Mack";
        protected string SemiModel = "5280";

    }

}


