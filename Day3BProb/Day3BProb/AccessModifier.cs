using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3BProb
{
    using System;

    namespace MyNamespace
    {
        public class MyClass
        {
            public int myPublicVariable = 10;
            private int myPrivateVariable = 20;
            protected int myProtectedVariable = 30;
            internal int myInternalVariable = 40;

            public void MyPublicMethod()
            {
                Console.WriteLine("This is a public method.");
            }

            // Same class U can Access ............
            private void MyPrivateMethod()
            {
                Console.WriteLine("This is a private method.");
            }

            protected void MyProtectedMethod()
            {
                Console.WriteLine("This is a protected method.");
            }

            internal void MyInternalMethod()
            {
                Console.WriteLine("This is an internal method.");
            }
        }

        public class MyDerivedClass : MyClass
        {
            public void MyDerivedMethod()
            {
                // Access myProtectedVariable and MyProtectedMethod here
                Console.WriteLine("The value of myProtectedVariable is: " + myProtectedVariable);
                MyProtectedMethod();
            }
        }

     
    }

}
