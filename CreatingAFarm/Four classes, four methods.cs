using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAFarm
{
    
    public static class Program
    {

        public static void Main(string[] args)
        {
            Rabbits rab = new Rabbits();
            Cows cow = new Cows();
            Sheeps sheep = new Sheeps();
            Chickens chicken = new Chickens();
            Horses horse = new Horses();



            string name = "";
            bool check = false;
            while (check == false)

            {
                Console.WriteLine("\nSelect which animal you would like to know about.\n" + "1.Rabbits" + " 2.Cows" + " 3.Sheeps" + " 4.Chickens" + " 5.Horses" + " 6. Quit");
                Console.Write("\t\tMy option is: ");
                name = Console.ReadLine();
                switch (name)
                {
                    case "1":
                        Console.Clear();
                        rab.Speak();
                        rab.Eat();
                        rab.Produce();
                        rab.Loveto();

                        check = false;
                        break;

                    case "2":
                        Console.Clear();
                        cow.Speak();
                        cow.Eat();
                        cow.Produce();
                        cow.Loveto();


                        check = false;
                        break;

                    case "3":
                        Console.Clear();
                        sheep.Speak();
                        sheep.Eat();
                        sheep.Produce();
                        sheep.Loveto();


                        check = false;
                        break;

                    case "4":
                        Console.Clear();
                        chicken.Speak();
                        chicken.Eat();
                        chicken.Produce();
                        chicken.Loveto();


                        check = false;
                        break;

                    case "5":
                        Console.Clear();
                        horse.Speak();
                        horse.Eat();
                        horse.Produce();
                        horse.Loveto();


                        check = false;
                        break;

                    case "6":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nThanks for playing. Duces (>^_^>) (<^_^<)\n");


                        check = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        check = false;
                        break;
                }

            }

        }
    }

    public class Cows
    {

        public  void Speak()
        {
            Console.WriteLine("\nHello my name is Candie, and I am a Cow.I say Moo.");

        }
        public  void Eat()
        {
            Console.WriteLine("\nHello my name is Candie, and I am a Cow.I eat Grass.");

        }
        public  void Produce()
        {
            Console.WriteLine("\nHello my name is Candie, and I am a Cow.I produce Milk.");

        }
        public  void Loveto()
        {
            Console.WriteLine("\nHello my name is Candie, and I am a Cow.I slove to lick.");
        }


    }

    public class Sheeps
    {

        public  void Speak()
        {
            Console.WriteLine("\nHello my name is Billy, and I am a Sheep.I say Baa.");

        }
        public  void Eat()
        {
            Console.WriteLine("\nHello my name is Billy, and I am a Sheep.I eat Fish.");

        }
        public  void Produce()
        {
            Console.WriteLine("\nHello my name is Billy, and I am a Sheep.I produce Wool.");

        }
        public  void Loveto()
        {
            Console.WriteLine("\nHello my name is Billy, and I am a Sheep.I love to Party like there is no tommorrow.");


        }

    }

    public class Chickens
    {


        public  void Speak()
        {
            Console.WriteLine("\nHello my name is Shelldon, and I am a Chicken. I say Cluck.");

        }
        public  void Eat()
        {
            Console.WriteLine("\nHello my name is Shelldon, and I am a Chicken. I eat Humans.");

        }
        public  void Produce()
        {
            Console.WriteLine("\nHello my name is Shelldon, and I am a Chicken. I produce Chicken.");

        }
        public  void Loveto()
        {
            Console.WriteLine("\nHello my name is Shelldon, and I am a Chicken. I love Try to fly.");
        }


}

    public class Rabbits
    {

        public  void Speak()
        {
            Console.WriteLine("\nHello my name is Bugs Bunny, and I am a Rabbit.I say Boo.");

        }
        public  void Eat()
        {
            Console.WriteLine("\nHello my name is Bugs Bunny, and I am a Rabbit.I eat Carriots.");

        }
        public  void Produce()
        {
            Console.WriteLine("\nHello my name is Bugs Bunny, and I am a Rabbit.I produce Fur.");

        }
    public  void Loveto()
    {
            Console.WriteLine("\nHello my name is Bugs Bunny, and I am a Rabbit.I love to Jump up and down.");
        }


    }

    public class Horses
    {

        public  void Speak()
        {
            Console.WriteLine("\nHello my name is Mr.Ed, and I am a Horse.I say Neigh.");

        }
        public  void Eat()
        {
            Console.WriteLine("\nHello my name is Mr.Ed, and I am a Horse.I eat Hay.");

        }
        public  void Produce()
        {
            Console.WriteLine("\nHello my name is Mr.Ed, and I am a Horse.I am used for Transportation.");

        }
        public  void Loveto()
        {
            Console.WriteLine("\nHello my name is Mr.Ed, and I am a Horse.I love to Dance.");

        }

    }
    
}
