using System;
using static System.Console; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstChoice;

            ForegroundColor = ConsoleColor.Magenta;

            WriteLine("Welcome to the Sand Man Pet Store, 'where all your pet needs end', how can I help you?\n\n");

            ForegroundColor = ConsoleColor.Green;

            WriteLine("1.Yeah I'm here to adopt a new puppy! \n2.I was hoping to buy a bird!\n3.I...uh... sorry wrong store.");
            FirstChoice = ReadLine();
            switch (FirstChoice)
            {
                case "1":
                    {
                        Dog Dog1 = new Dog();
                        ReadLine();

                        break;

                    }
                case "2":
                    {
                        Bird Bird1 = new Bird();
                        ReadLine();
                        break;
                    }

            }
        }
    } //Opening
    class Pet
    {
        public int Happiness;
        public int Social;
        public int Fitness;

        public string Name;
        public string Size;
        public float Weight;
        public string Breed;
        string[] Breeds = { };
        public string color;
        public bool Asleep;
        public bool Hungry;
        public string gender;
        public void Eat()
        {

        }
        public void Sleep()
        {

        }
        public void Die()
        {

        }
        public void Play()
        {

        }
        public void Poop()
        {

        }
        public void Talk()
        {

        }
    }
    class Dog : Pet
    {
        int Number;
        string[] Gender = { "He's", "She's" };


        string[] Breeds = { "Westie", "Lab", "Pitbull" };



        DateTime Birthdate = new DateTime();
        Random RandomNumber = new Random();

        public Dog()
        {
            gender = Gender[RandomNumber.Next(Gender.Length)];
            Breed = Breeds[RandomNumber.Next(Breeds.Length)];
            DateTime today = DateTime.Today;
            Number = RandomNumber.Next(35);
            Birthdate = today.AddDays(-Number);
            switch (Breed)
            {
                case "Westie":
                    {
                        color = "White";
                        break;
                    }
                case "Lab":
                    {
                        color = "Yellow";
                        break;
                    }
                case "Pitbull":
                    {
                        color = "Black";
                        break;
                    }
                default:
                    {
                        color = "Black";
                        break;
                    }
            }
            Clear();
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Oh yes! " + gender + " right here!");
            WriteLine(gender + " a " + color + " " + Breed + " and was born on " + Birthdate);
            WriteLine("What would you like to call them?");
            Name = ReadLine();
            WriteLine(Name + ". What a great name!");
            ActivityChoice();
        }
        public void ActivityChoice()
        {
            WriteLine("What would you like to do with " + Name + "?");
            WriteLine("1. Talk\n2. Pet\n3. Play");
            switch (ReadLine())
            {
                case "1":
                    {
                        Talk();
                        break;
                    }
                case "2":
                    {
                        Sniff();
                        break;
                    }
                case "3":
                    {
                        Pant();
                        break;
                    }
                default:
                    {
                        WriteLine("Okay... well... I guess you can just go. Thanks for coming!");
                        ReadKey();
                        break;
                    }
            }
        }
        void Talk()
        {
            Happiness ++;
            switch (Breed)
            {
                case "Westie":
                    {
                        WriteLine("You say hello to " + Name + ". They yip back at you.");
                        WriteLine(Name + "'s happiness has gone up to ");
                        ForegroundColor = ConsoleColor.Yellow;
                        Write(Happiness);
                        ForegroundColor = ConsoleColor.Magenta;
                        WriteLine("Would you like to go?\n1. Yes\n2. No");
                        switch (ReadLine())
                        {
                            case "1":
                                {
                                    WriteLine("Okay, bye!");
                                    ReadKey();
                                    break;
                                }
                            case "2":
                                {
                                    Clear();
                                    ActivityChoice();
                                    break;
                                }
                        }
                        break;
                    }
                case "Lab":
                    {
                        WriteLine("You say hello to " + Name + ". They bark back at you.");
                        WriteLine(Name + "'s happiness has gone up to ");
                        ForegroundColor = ConsoleColor.Yellow;
                        Write(Happiness);
                        ForegroundColor = ConsoleColor.Magenta;
                        WriteLine("Would you like to go?\n1. Yes\n2. No");
                        switch (ReadLine())
                        {
                            case "1":
                                {
                                    WriteLine("Okay, bye!");
                                    ReadKey();
                                    break;
                                }
                            case "2":
                                {
                                    Clear();
                                    ActivityChoice();
                                    break;
                                }
                        }
                        break;
                    }
                case "Pitbull":
                    {
                        WriteLine("You say hello to " + Name + ". They bark back at you.");
                        WriteLine(Name + "'s happiness has gone up to ");
                        ForegroundColor = ConsoleColor.Yellow;
                        Write(Happiness);
                        ForegroundColor = ConsoleColor.Magenta;
                        WriteLine("Would you like to go?\n1. Yes\n2. No");
                        switch (ReadLine())
                        {
                            case "1":
                                {
                                    WriteLine("Okay, bye!");
                                    ReadKey();
                                    break;
                                }
                            case "2":
                                {
                                    Clear();
                                    ActivityChoice();
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
        void Sniff() //still working on
        {
            Social++;
            switch (Breed)
            {
                case "Westie":
                    {
                        WriteLine("You rub " + Name + "'s somach. Their legs run ");
                        WriteLine(Name + "'s happiness has gone up to ");
                        ForegroundColor = ConsoleColor.Yellow;
                        Write(Happiness);
                        ForegroundColor = ConsoleColor.Magenta;
                        WriteLine("Would you like to go?\n1. Yes\n2. No");
                        switch (ReadLine())
                        {
                            case "1":
                                {
                                    WriteLine("Okay, bye!");
                                    ReadKey();
                                    break;
                                }
                            case "2":
                                {
                                    Clear();
                                    ActivityChoice();
                                    break;
                                }
                        }
                        break;
                    }
                case "Lab":
                    {
                        WriteLine("You say hello to " + Name + ". They bark back at you.");
                        WriteLine(Name + "'s happiness has gone up to ");
                        ForegroundColor = ConsoleColor.Yellow;
                        Write(Happiness);
                        ForegroundColor = ConsoleColor.Magenta;
                        WriteLine("Would you like to go?\n1. Yes\n2. No");
                        switch (ReadLine())
                        {
                            case "1":
                                {
                                    WriteLine("Okay, bye!");
                                    ReadKey();
                                    break;
                                }
                            case "2":
                                {
                                    Clear();
                                    ActivityChoice();
                                    break;
                                }
                        }
                        break;
                    }
                case "Pitbull":
                    {
                        WriteLine("You say hello to " + Name + ". They bark back at you.");
                        WriteLine(Name + "'s happiness has gone up to ");
                        ForegroundColor = ConsoleColor.Yellow;
                        Write(Happiness);
                        ForegroundColor = ConsoleColor.Magenta;
                        WriteLine("Would you like to go?\n1. Yes\n2. No");
                        switch (ReadLine())
                        {
                            case "1":
                                {
                                    WriteLine("Okay, bye!");
                                    ReadKey();
                                    break;
                                }
                            case "2":
                                {
                                    Clear();
                                    ActivityChoice();
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
        void Pant()
        {

        }
    }//If they chose dog
    class Bird : Pet
    {
        int Number;
        string[] Gender = { "He's", "She's" };


        string[] Breeds = { "parrot", "parakeet", "flamingo" };



        DateTime Birthdate = new DateTime();
        Random RandomNumber = new Random();

        public Bird()
        {
            gender = Gender[RandomNumber.Next(Gender.Length)];
            Breed = Breeds[RandomNumber.Next(Breeds.Length)];
            DateTime today = DateTime.Today;
            Number = RandomNumber.Next(35);
            Birthdate = today.AddDays(-Number);
            switch (Breed)
            {
                case "parrot":
                    {
                        color = "red";
                        break;
                    }
                case "parakeet":
                    {
                        color = "green";
                        break;
                    }
                case "flamingo":
                    {
                        color = "pink";
                        break;
                    }
                default:
                    {
                        color = "Black";
                        break;
                    }
            }
            Clear();
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Oh yes! " + gender + " right here!");
            WriteLine(gender + " a " + color + " " + Breed + " and was born on " + Birthdate);
        }
        void Fly()
        {

        }
        void Squack()
        {

        }
        void Peck()
        {

        }
    }//If they chose bird
}