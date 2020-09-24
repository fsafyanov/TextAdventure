using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi!");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Things must be very confusing for you right now, but don't you worry because they're about to get much worse!");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("But before I tell you about the impeding doom that is about to beset you, how about we get to know each other!");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Sooooooooooo......");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("What's your name?");

            // Character name
            string name = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {name}! Not what I would have chosen for you, but that's ok!");

            // Character job
            Console.WriteLine("What do you do for work?");

            string work = Console.ReadLine();
            System.Threading.Thread.Sleep(5000);

            Console.WriteLine($"Wow....that's great! You {work}, huh?");
            Console.WriteLine("Can't say that's what I would do with my life, but I'm completely fine with you doing that!");
            System.Threading.Thread.Sleep(4000);

            //Character hero level
            Console.WriteLine("Ok well, on a scale from 1-5, how experienced are you with saving the world from impeding doom?");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Let's say 1 is \"Absolute trash\" and 5 is \"I'm a freaking avenger\"");

            string heroLevel = Console.ReadLine();
            

            switch(heroLevel)
            {
                case "1":
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Wow! That's absolutely terrible for what's about to happen! But I like the honest, however I wish you would have lied about that!");
                    break;
                case "2":
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Wow! That's better than one but still worse than 5 but at least you're honest about it!");
                    break;
                case "3":
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Wow! Not great, but not horrible! You're in the middle which basically means nothing but hopefully that'll work!");
                    break;
                case "4":
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Wow! That's ok! So hopefully you'll be able to get through this or we'll both end up vaporized for sure!");
                    break;
                case "5":
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Wow! That's just what we need! Based on my background search on you, you're definitely not lying! I'm extremely confident and scared for what's too come!");
                    break;
                default:
                    Console.WriteLine("That's not an answer I asked you for. You're either a complete moron or one of those rebellious types who lives by their own code. Probably doomed either way!");
                    break;

            }

            
            

        }
        
    }
}
