using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace CreatingAFarm
{
    /*
    public class Program
    {

        public static void Main()
        {
            Rabbits rab = new Rabbits();
            Cows cow = new Cows();
            Sheeps sheep = new Sheeps();
            Chickens chicken = new Chickens();
            Horses horse = new Horses();

            */


            /*
            Console.WriteLine($"Names of Rabbits: {rab.rabbit1}, {rab.rabbit2}, {rab.rabbit3} and {rab.rabbit4}.");
            Console.WriteLine($"\nNames of Cows: {cow.cow1}, {cow.cow2}, {cow.cow3} and {cow.cow4}.");
            Console.WriteLine($"\nNamess of Sheeps: {sheep.sheep1}, {sheep.sheep2}, {sheep.sheep3} and {sheep.sheep4}.");
            Console.WriteLine($"\nNames of Chickens: {chicken.chicken1}, {chicken.chicken2}, {chicken.chicken3} and {chicken.chicken4}.");
            Console.WriteLine($"\nNames of Horses: {horse.horse1}, {horse.horse2}, {horse.horse3} and {horse.horse4}.\n");
            Console.ReadKey();
            */
            /*

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
                        Console.WriteLine($"\nNames of Rabbits: {rab.rabbit1}, {rab.rabbit2}, {rab.rabbit3} and {rab.rabbit4}.");
                        Console.WriteLine($"\nHello my name is {rab.rabbit1}, and I am a Rabbit. I say {rab.speak}.");
                        Console.WriteLine($"\nHello my name is {rab.rabbit2}, and I am a Rabbit. I eat {rab.eat}.");
                        Console.WriteLine($"\nHello my name is {rab.rabbit3}, and I am a Rabbit. I am used for {rab.produce}.");
                        Console.WriteLine($"\nHello my name is {rab.rabbit4}, and I am a Rabbit. I love to {rab.loveToDo}.");

                        check = false;
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine($"\nNames of Cows: {cow.cow1}, {cow.cow2}, {cow.cow3} and {cow.cow4}.");
                        Console.WriteLine($"\nHello my name is {cow.cow1}, and I am a Cow. I say {cow.speak}.");
                        Console.WriteLine($"\nHello my name is {cow.cow2}, and I am a Cow. I eat {cow.eat}.");
                        Console.WriteLine($"\nHello my name is {cow.cow3}, and I am a Cow. I am used for {cow.produce}.");
                        Console.WriteLine($"\nHello my name is {cow.cow4}, and I am a Cow. I love to {cow.loveToDo}.");

                        check = false;
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine($"\nNamess of Sheeps: {sheep.sheep1}, {sheep.sheep2}, {sheep.sheep3} and {sheep.sheep4}.");
                        Console.WriteLine($"\nHello my name is {sheep.sheep1}, and I am a Sheep. I say {sheep.speak}.");
                        Console.WriteLine($"\nHello my name is {sheep.sheep2}, and I am a Sheep. I eat {sheep.eat}.");
                        Console.WriteLine($"\nHello my name is {sheep.sheep3}, and I am a SheepSheep. I am used for {sheep.produce}.");
                        Console.WriteLine($"\nHello my name is {sheep.sheep4}, and I am a horse. I love to {sheep.loveToDo}.");

                        check = false;
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine($"\nNames of Chickens: {chicken.chicken1}, {chicken.chicken2}, {chicken.chicken3} and {chicken.chicken4}.");
                        Console.WriteLine($"\nHello my name is {chicken.chicken1}, and I am a Chicken. I say {chicken.speak}.");
                        Console.WriteLine($"\nHello my name is {chicken.chicken2}, and I am a Chicken. I eat {chicken.eat}.");
                        Console.WriteLine($"\nHello my name is {chicken.chicken3}, and I am a Chicken. I am used for {chicken.produce}.");
                        Console.WriteLine($"\nHello my name is {chicken.chicken4}, and I am a Chicken. I love to {chicken.loveToDo}.");

                        check = false;
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine($"\nNames of Horses: {horse.horse1}, {horse.horse2}, {horse.horse3} and {horse.horse4}.");
                        Console.WriteLine($"\nHello my name is {horse.horse2}, and I am a horse. I say {horse.speak}.");
                        Console.WriteLine($"\nHello my name is {horse.horse1}, and I am a horse. I eat {horse.eat}.");
                        Console.WriteLine($"\nHello my name is {horse.horse3}, and I am a horse. I am used for {horse.produce}.");
                        Console.WriteLine($"\nHello my name is {horse.horse4}, and I am a horse. I love to {horse.loveToDo}.");

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
        public String cow1 = "Candie";
        public String cow2 = "Bully";
        public String cow3 = "Homer";
        public String cow4 = "Angus";

        public string speak = "Moo";
        public string eat = "Grass";
        public string produce = "Milk";
        public string loveToDo = "Lick";
    }

    public class Sheeps
    {
        public String sheep1 = "Billy";
        public String sheep2 = "Nanny";
        public String sheep3 = "Wooly";
        public String sheep4 = "Scape Goat";

        public string speak = "Baa";
        public string eat = "Fish";
        public string produce = "Wool";
        public string loveToDo = "Party like there is no tommorrow";
    }

    public class Chickens
    {
        public String chicken1 = "Shelldon";
        public String chicken2 = "Crispy";
        public String chicken3 = "Cooper";
        public String chicken4 = "Rocky";

        public string speak = "Cluck";
        public string eat = "Humans";
        public string produce = "Chicken";
        public string loveToDo = "Try to fly";
    }

    public class Rabbits
    {
        public String rabbit1 = "Bugs Bunny";
        public String rabbit2 = "Roger Rabbit";
        public String rabbit3 = "Thumper";
        public String rabbit4 = "Peter Cottontail";

        public string speak = "Boo";
        public string eat = "Carriots";
        public string produce = "Fur";
        public string loveToDo = "Jump up and down";
    
    }

    public class Horses
    {
        public String horse1 = "Ajax";
        public String horse2 = "Mr. Ed";
        public String horse3 = "Huckleberry";
        public String horse4 = "Mo Maba";

        public string speak = "Neigh";
        public string eat = "Hay";
        public string produce = "Transportation";
        public string loveToDo = "Dance";
    }
    */

    
}
*/