namespace Raiding
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<BaseHero, int> heroes = new Dictionary<BaseHero, int>();
            while (heroes.Count != n)
            { 
                string name = Console.ReadLine();
                string heroType = Console.ReadLine();
                
                

                if (heroType == "Druid")
                {
                    Druid druid = new Druid(name);
                    heroes.Add(druid, druid.Power);
                }
                else if (heroType == "Paladin")
                {
                    Paladin paladin = new Paladin(name);
                    heroes.Add(paladin, paladin.Power);
                }
                else if (heroType == "Rogue")
                {
                    Rogue rogue = new Rogue(name);
                    heroes.Add(rogue, rogue.Power);
                }
                else if (heroType == "Warrior")
                {
                    Warrior warrior = new Warrior(name);
                    heroes.Add(warrior, warrior.Power);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }
            int bossPower = int.Parse(Console.ReadLine());
            int heroesPowerSum = 0;
            
            foreach (var hero in heroes.Keys)
            {
                Console.WriteLine(hero.CastAbility());
                heroesPowerSum += hero.Power;
            }
            if (heroesPowerSum >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}