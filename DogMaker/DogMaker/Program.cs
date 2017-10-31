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
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("You enter a Sand Man Pet Store.\nTheir is a woman on the phone behind the counter.");
            WriteLine("You catch the end of her conversation before she hangs up.");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Yes and make sure to tell them I want the start menue to say");
            WriteLine("'Get all three stats to 5 and you win'");
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("She hangs up the phone and turns to you.");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("Welcome to the Sand Man Pet Store, 'where all your pet needs end'.\nHow can I help you?\n\n");

            ForegroundColor = ConsoleColor.Green;

            WriteLine("1.Yeah I'm here to adopt a new puppy! \n2.I was hoping to buy a bird!\n3.You got any... Horses?...");
            FirstChoice = ReadLine();
            switch (FirstChoice)
            {
                case "1":
                    {
                        Dog Dog1 = new Dog();
                        break;
                    }
                case "2":
                    {
                        Bird Bird1 = new Bird();
                        break;
                    }
                case "3":
                    {
                        Horse Horse1 = new Horse();
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
        } //Introducing the dog
        public void ActivityChoice()
        {
            WriteLine("Why don't you bond with " + Name + "? Try to get all their scores up to 5!");
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
        }//Action choice
        void Talk()
        {
            Happiness++;
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
        } //Happiness up
        void Sniff()
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
        }//Social up
        void Pant()
        {
            ++Fitness;
            switch (Breed)
            {
                case "Westie":
                    {
                        WriteLine("You throw a ball for " + Name + ". They pant happily.");
                        WriteLine(Name + "'s fitness has gone up to ");
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
                        WriteLine("You throw a ball for " + Name + ". They pant happily.");
                        WriteLine(Name + "'s fitness has gone up to ");
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
                        WriteLine("You throw a ball for " + Name + ". They pant happily.");
                        WriteLine(Name + "'s fitness has gone up to ");
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
        }//Fitness up
    }//If they chose dog.
    //All 3 pets are layed out the same, so I have done all my notiation in Dog.
    class Bird : Pet
    {
        int Number;
        string[] Gender = { "He's", "She's" };


        string[] Breeds = { "Parrot", "Parakeet", "Flamingo" };



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
            WriteLine("What would you like to call them?");
            Name = ReadLine();
            WriteLine(Name + ". What a great name!");
            ActivityChoice();
        }
        public void ActivityChoice()
        {


            WriteLine("Why don't you bond with " + Name + "? Try to get all their scores up to 5!");
            WriteLine("1. Play\n2. Sing\n3. Feed");
            switch (ReadLine())
            {
                case "1":
                    {
                        Fly();
                        break;
                    }
                case "2":
                    {
                        Squack();
                        break;
                    }
                case "3":
                    {
                        Peck();
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
        void Fly()
        {
            ++Fitness;
            WriteLine(Name + " plays around their cage with some blkocks. They flap happily.");
            WriteLine(Name + "'s fitness has gone up to ");
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
        }
        void Squack()
        {
            ++Social;
            WriteLine("You sing your favorite song to " + Name + ".\nThey begin to sing along as if they knew the toon.");
            WriteLine(Name + "'s Social has gone up to ");
            ForegroundColor = ConsoleColor.Yellow;
            Write(Social);
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
        }
        void Peck()
        {
            ++Happiness;
            WriteLine(Name + " pecks food out of your hand.\n They ruffle their fur and make a happy noise.");
            WriteLine(Name + "'s Happiness has gone up to ");
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
        }
    }//If they chose bird
    class Horse : Pet
    {
        int Number;
        string[] Gender = { "He's", "She's" };


        string[] Breeds = { "Pinto", "Thoroughbred", "Percheron" };



        DateTime Birthdate = new DateTime();
        Random RandomNumber = new Random();

        public Horse()
        {
            gender = Gender[RandomNumber.Next(Gender.Length)];
            Breed = Breeds[RandomNumber.Next(Breeds.Length)];
            DateTime today = DateTime.Today;
            Number = RandomNumber.Next(35);
            Birthdate = today.AddDays(-Number);
            switch (Breed)
            {
                case "Pinto":
                    {
                        color = "black and white spotted";
                        break;
                    }
                case "Thoroughbred":
                    {
                        color = "grey";
                        break;
                    }
                case "Percheron":
                    {
                        color = "white";
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
            WriteLine("Oh yes! " + gender + " right out back!");
            WriteLine(gender + " a " + color + " " + Breed + " and was born on " + Birthdate);
            WriteLine("What would you like to call them?");
            Name = ReadLine();
            WriteLine(Name + ". What a great name!");
            ActivityChoice();
        }
        public void ActivityChoice()
        {
            WriteLine("Why don't you bond with " + Name + "? Try to get all their scores up to 5!");
            WriteLine("1. Ride\n2. Graze\n3. Brush");
            switch (ReadLine())
            {
                case "1":
                    {
                        Ride();
                        break;
                    }
                case "2":
                    {
                        Graze();
                        break;
                    }
                case "3":
                    {
                        Brush();
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
        void Ride()
        {
            ++Fitness;
            WriteLine("You get on " + Name + "'s back and ride them around the ring. They nicker happily.");
            WriteLine(Name + "'s fitness has gone up to ");
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
        }
        void Graze()
        {
            ++Social;
            WriteLine("You let " + Name + " out to graze. They seem relaxed.");
            WriteLine(Name + "'s Social has gone up to ");
            ForegroundColor = ConsoleColor.Yellow;
            Write(Social);
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
        }
        void Brush()
        {
            ++Happiness;
            WriteLine("You run a brush over " + Name + "'s main. They paw at the ground happily.");
            WriteLine(Name + "'s Happiness has gone up to ");
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
        }
    }//If they chose horse
}