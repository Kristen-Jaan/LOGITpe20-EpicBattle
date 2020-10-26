using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            string[] heroes = { "Harry potter", "Luke SkyWalker", "Squidward", "Shrek", "Garfield" };
            string[] villains = { "Voldemort", "Darth Vader", "Plankton", "Lord Farquad", "Jon" };

            string hero = GetCharacter(heroes);
            string villain = GetCharacter(villains);
            

           
            int heroHP = GenerateHP();
            int villainHP = GenerateHP();
            Console.WriteLine($"{hero} with {heroHP} HP will fight {villain} " + $"{villainHP} HP");
                 

            while (heroHP > 0 && villainHP > 0)
            {
                //Random rnd = new Random();
                //heroHP = heroHP - rnd.Next(0, 4);
                //villainHP = villainHP - rnd.Next(0, 4);
                heroHP = heroHP - Hit(hero);
                villainHP = villainHP - Hit(villain);
            }
            GetWinner(heroHP, villainHP);
            
            
        }

        public static string GetCharacter(string[] array)
        {
            Random rnd = new Random();
            string randomString = array[rnd.Next(0, array.Length)];
            return randomString;
        }
        public static int GenerateHP()
        {
            Random rnd = new Random();
            int HP = rnd.Next(5, 11);
            return HP;
        }
        public static int Hit(string Character)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, 4);
            Console.WriteLine($"{Character} hit {strike}!");
            if(strike == 3)
            {
                Console.WriteLine($"Awesome! {Character} made a critical hit!");
            }
            else if(strike == 0)
            {
                Console.WriteLine($"Bad luck! {Character} missed the target!");
            }
            return strike;
            
            
        }
        public static void GetWinner(int heroHP, int villainHP)
        {
            if(heroHP == 0)
            {
                Console.WriteLine("Dark Side wins! Fatality");
            }
            else
            {
                Console.WriteLine("Hero saves the day!");
            }
        }

    }
}
