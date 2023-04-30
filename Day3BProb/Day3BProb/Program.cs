namespace Day3BProb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //InterFace................
            IAnimal myDog = new Dogs();
            IAnimal myCat = new Cat();

            myDog.MakeSound();
            Console.WriteLine(myDog.GetSpecies());

            myCat.MakeSound();
            Console.WriteLine(myCat.GetSpecies());

        }
    }
}