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



public class Plane {
            public const int RowCount = 10;
            public const int SeatPerRow = 6;
            public const int SeatCount = RowCount * SeatPerRow;
            public string TailNumber = "NN8042";
            public string FlightNum
