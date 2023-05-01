using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3BProb
{
    public  class StaticConstructor
    {
        //tatic constructor is a special type of constructor
        //that is called only once, automatically, when the class is first used or instantiated.
        //It is used to initialize static fields, perform any other one-time initialization logic, or register events, among other things.
        static int myStaticField;

        static StaticConstructor()
        {
            myStaticField = 42;
            Console.WriteLine("Static constructor called.");
        }

        public void InstanceMethod()
        {
            Console.WriteLine("Instance method called. Static field value: {0}", myStaticField);
        }
    }
}
