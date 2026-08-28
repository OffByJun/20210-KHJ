using System;
using Monsters;

class Program
{
    static void Main(string[] args)
    {
        
        Entity player = new Skeleton();
        Entity enemy = new Zombie();
        bool isEnemyDead = false;

        while (!isEnemyDead)
        {
            string input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    interactionResult result1 = player.Attack(enemy);
                    PrintStasis(result1);
                    break;
                case "2":
                    interactionResult result2 = player.Regenerate(player);
                    PrintStasis(result2);
                    break;
            }

            if (enemy.isDead())
            {
                break;
            }
        }
        
        Console.WriteLine("Enemy is Dead");
    }

    public static void PrintStasis(interactionResult msg)
    {
        Console.WriteLine($"행동 대상: {msg.target}");
        Console.WriteLine($"행동 값: {msg.value}");
    }
}