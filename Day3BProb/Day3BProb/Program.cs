using Day3BProb.MyNamespace;

namespace Day3BProb
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // default constructor.......................
            //ConstructType DefObj = new ConstructType();
            //Console.WriteLine("Default constructor " + DefObj.num);
            ////Non Parameterized........
            //ConstructType Nonpar = new ConstructType();
            ////Parameterized ...................
            //ConstructType construct = new ConstructType("Mustang", "Red", 1969);
            //ConstructType construct1 = new ConstructType(1001, "Shine");
            //construct1.DisplayConstructor();
            //Console.WriteLine("Parameterized Constructor :" + construct.color + " " + construct.year + " " + construct.model);
            //Console.ReadKey();
            //Private constructor...........................
            //Give error beacsuse private constuctor only access in same class ....
            //PrivateConstructor priCons = new PrivateConstructor();

            //Copy Constructor.....................
            //CopyConstructor copyCons = new CopyConstructor(10,20);
            //Console.WriteLine("Simple Constructor : " + copyCons.numFirst + " " + copyCons.numSecond);

            ////Copy constructor call
            //CopyConstructor copyConstructor= new CopyConstructor(copyCons);
            //Console.WriteLine("Copy Constructor : " + copyConstructor.numFirst + " " + copyConstructor.numSecond);

            //Static Constructor......................
            //StaticConstructor StaticConObject = new StaticConstructor();
            //StaticConObject.InstanceMethod();

            //Access Modifier.................

            MyClass myObject = new MyClass();

            // Access public variable and method
            Console.WriteLine("The value of myPublicVariable is: " + myObject.myPublicVariable);
            myObject.MyPublicMethod();

            // Cannot access private variable and method
            // Console.WriteLine("The value of myPrivateVariable is: " + myObject.myPrivateVariable);
            // myObject.MyPrivateMethod();

            MyDerivedClass myDerivedObject = new MyDerivedClass();

            // Access protected variable and method from derived class
            myDerivedObject.MyDerivedMethod();

            // Cannot access protected variable and method from base class
            // Console.WriteLine("The value of myProtectedVariable is: " + myObject.myProtectedVariable);
            // myObject.MyProtectedMethod();

            // Access internal variable and method within same assembly
            Console.WriteLine("The value of myInternalVariable is: " + myObject.myInternalVariable);
            myObject.MyInternalMethod();

            Console.ReadLine();


        }
    }
}