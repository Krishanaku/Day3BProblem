using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3BProb
{
    public  class ConstructType
    {
        //default constructor.............
        public int num = 10;
        //Non parmeterized constructor.....................
        public ConstructType()
        {
            Console.WriteLine("This is non Parameterized Constructor");
        }
        //parmeterized constructor.....................
        public int modelnum;
        public string modelname;

        public ConstructType(int ModelNum, string ModelName)
        {
            modelnum = ModelNum;
            modelname = ModelName;
        }
        //parmeterized constructor.....................
        public string model;
        public string color;
        public int year;
        public ConstructType(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
        public void DisplayConstructor()
        {
            Console.WriteLine($"Car mode Number {modelnum} and Name {modelname}");
        }
    }
}
