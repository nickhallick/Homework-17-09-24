namespace enterdata
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            // Output a pyramid of asteriks 
            Console.WriteLine("   *");
            Console.WriteLine("  ***");
            Console.WriteLine(" *****");
            Console.WriteLine("*******");

            // Using escape words to be able to output double quotes 
            Console.WriteLine("\"I have written my first computer program\" the pupil said to the teacher.");


            //Task 2 
            //Ask what your favourite film is and how many times you have watched it to output it into a sentence 
            Console.WriteLine("What is your favourite film");
            string Fav_Film = Console.ReadLine();
            Console.WriteLine("How many times have you watched it?");
            int Times = int.Parse(Console.ReadLine());
            Console.WriteLine("Your favourite film is {0} and you have seen it {1} times", Fav_Film, Times);
            // Enter name and age and output them five times each 
            Console.WriteLine("What is your name");
            string Name = Console.ReadLine();
            Console.WriteLine(Name + " " + Name + " " + Name + " " + Name + " " + Name);
            Console.WriteLine("How old are you");
            string age = Console.ReadLine();
            Console.WriteLine(age + " " + age + " " + age + " " + age + " " + age);

            // Enter 5 words and output them in reverse order
            Console.WriteLine("Enter 1st word");
            string first = Console.ReadLine();
            Console.WriteLine("Enter 2nd word");
            string second = Console.ReadLine();
            Console.WriteLine("Enter 3rd word");
            string third = Console.ReadLine();
            Console.WriteLine("Enter 4th word");
            string fourth = Console.ReadLine();
            Console.WriteLine("Enter 5th word");
            string fifth = Console.ReadLine();
            Console.WriteLine("The sentence is\n" + fifth + " " + fourth + " " + third + " " + second + " " + first);

            // Task 3 
            // Inputs the value of each of the sides of a cuboid to then calculate volume
            Console.WriteLine("Enter the height of the cuboid:");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the cuboid:");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the cuboid:");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("The volume of the cuboid is" + (height * width * length) + " centimetres cubed");

            // Program that asks for a number then displays its times tables up to 5
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"1 times {num} is {num}");
            Console.WriteLine($"2 time {num} is {num * 2}");
            Console.WriteLine($"3 times {num} is {num * 3}");
            Console.WriteLine($"4 times {num} is {num * 4}");
            Console.WriteLine($"5 times {num} is {num * 5}");

            //Program that writes a story using the users inputs.
            Console.WriteLine("How many children are there?");
            int children = int.Parse(Console.ReadLine());
            Console.WriteLine("How many sweets do they each have?");
            int sweetsChildren = int.Parse(Console.ReadLine());
            Console.WriteLine("How many ducks were there");
            int ducks = int.Parse(Console.ReadLine());
            Console.WriteLine("How many sweets did each child give each duck");
            int sweetsForDuck = int.Parse(Console.ReadLine());
            Console.WriteLine($"There were {children} children each with a bag containing {sweetsChildren} sweets. They walked pasts {ducks} ducks. Each child gave {sweetsForDuck} sweets to each of the ducks and ate one themself. They decided to put the rest into a pile. They counted the pile and found it contained {(sweetsChildren * children) - sweetsForDuck - children} sweets. ");




            // Task 4 
            // Program that asks for radius and height of a cylinder and then calculates volume and area
            Console.WriteLine("Enter radius of the cylinder:");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height of cylinder:");
            double Height2 = double.Parse(Console.ReadLine());
            double Pi = 3.14159;
            double volume = Pi * Math.Pow(radius,2) * Height2;
            double area = ((2 * Pi * Math.Pow(radius, 2)) + (2 * Pi * radius * Height2));
            Console.WriteLine("The area of the cylinder is {0} centimetres and the volume is {1} centimetres", area, volume);

            //Average of 5 numbers
            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a third number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a fourth number");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a fifth number");
            int num5 = int.Parse(Console.ReadLine());
            double average = ((num1 + num2 + num3 + num4 + num5) / 5);
            Console.WriteLine("Average of your five numbers is {0}", average);

            //Pythagoras' theorem
            Console.WriteLine("Enter side a of the triangle");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side b of the triangle");
            double sideB = double.Parse(Console.ReadLine());
            double Hypotenuse = (Math.Sqrt((Math.Pow(sideA, 2)) + (Math.Pow(sideB, 2))));
            Console.WriteLine($"The hypotenuse of your triangle is {Hypotenuse}");
        }    
    }
}