using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExerc1
{
    public class Car
    {
        public Car()             // Default Constructor
        {
        
        }

        public Car(string makeinput, string modelinput, int yearinput) // Constructor Assigning Make, Model and Year properties
        {
            Make = makeinput;
            Model = modelinput;
            Year = yearinput;

        }


        //property
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }
    }
}
