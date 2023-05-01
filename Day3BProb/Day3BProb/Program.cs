namespace Day3BProb
{
    public class Program
    {
        public static void Main1(string[] args)
        {
            ////InterFace................
            //IAnimal myDog = new Dogs();
            //IAnimal myCat = new Cat();

            //myDog.MakeSound();
            //Console.WriteLine(myDog.GetSpecies());

            //myCat.MakeSound();
            //Console.WriteLine(myCat.GetSpecies());

            // default constructor.......................
            ConstructType DefObj= new ConstructType();
            Console.WriteLine("Default constructor "+DefObj.num);
            //Non Parameterized........
            ConstructType Nonpar= new ConstructType();
            //Parameterized ...................
            ConstructType construct = new ConstructType("Mustang", "Red", 1969);
            ConstructType construct1 = new ConstructType(1001, "Shine");
            construct1.DisplayConstructor();
            Console.WriteLine( "Parameterized Constructor :"+construct.color + " " + construct.year + " " + construct.model);
            Console.ReadKey(); 

        }
    }
}