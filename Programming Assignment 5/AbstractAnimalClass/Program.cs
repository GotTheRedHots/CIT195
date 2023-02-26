
namespace Animals
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();

        public string whatAmI()
        {
            return "I am an animal";
        }
    }
    class Pig : Animal
    {
        public override string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public override string Describe()
        {
            return $"{Name} is a {Age} year old {Color} pig";
        }

        public Pig() { Name = ""; Color = ""; Age = 0; }

        public Pig(string name, string color, int age)
        {
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Pig onePig = new Pig();
            onePig.Name = "Jorge";
            onePig.Color = "brown";
            onePig.Age = 10;

            Pig twoPig = new Pig("Bruce", "white", 3);

            Console.WriteLine(onePig.Describe());
            Console.WriteLine(onePig.whatAmI());
            Console.WriteLine(twoPig.Describe());
            Console.WriteLine(twoPig.whatAmI());
        }
    }
}