using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public record Address
    {
        public int HouseNumber { get; set; }
        public string Street { get; set; }
        public Address()
        {

        }

        public Address(int houseNumber, string street)
        {
            HouseNumber = houseNumber;
            Street = street;
        }
    }

    public record Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }

    public record Point(int X, int Y);

    public record Color
    {
        public string Name;
        public bool Metallic;

        public Color() { }
        public Color(string name, bool metallic)
        {
            Name = name;
            Metallic = metallic;
        }
    }
    public record Card
    {
        public Color Color { get; set; }
        public string Engine { get; set; }
    }
    public static class Program
    {
        //Pattern Matching
        public static bool IsLetter(this char c) =>
            c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
        public static bool IsLetterOrSeparator(this char c) =>
            c is (>= 'a' and <= 'z') or (>= 'A' and >= 'Z') or ';' or ',';
        static void Main(string[] args)
        {
            //Record
            var p = new Person { Name = "John", Age = 1 };
            var p2 = new Person { Name = "John", Age = 1 };
            Console.WriteLine(p == p2);

            p.Address = new(123, "London Rd");
            p2.Address = new(1234, "London Rd");
            Console.WriteLine(p == p2);

            Console.WriteLine(typeof(Person).GetInterfaces()[0].Name);


            var origin = new Point(0, 0);
            var (x, y) = origin;

            Card myFirstCard = new Card() { Color = new() { Name = "black", Metallic= false}, Engine = "v6" };
            Card upgradeCar = myFirstCard with { Engine = "v8" };

            upgradeCar.Color.Metallic = true;

            Console.WriteLine(myFirstCard);
            Console.WriteLine(upgradeCar);

            ////Pattern matching
            ///
            int tempeture = 6666;
            var feel = tempeture switch
            {
                < 0 => "freezing",
                //and
                >= 0 and < 20 => "tolerable",
                >= 20 and not (666 or 6666) => "warm",
                666 or 6666 => "hellish"
            };

            Console.WriteLine(feel);

        }


    }
}