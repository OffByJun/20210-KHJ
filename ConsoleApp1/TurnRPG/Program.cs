using System;
using Microsoft.VisualBasic;
using Monsters;

class Program
{
    static void Main(string[] args)
    {
        Entity player = new Skeleton();
        Entity enemy = new Zombie();
        bool isEnemyDead = false;
        
        Console.WriteLine("적이 나타났다! 무엇을 하면 좋을까? \n1. 공격\n2. 회복");

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
                Console.WriteLine("Enemy is Dead");
                break;
            }
        }
    }

    public static void PrintStasis(interactionResult msg)
    {
        Console.WriteLine($"{msg.actingType.ToString()} 대상: {msg.target}");
        Console.WriteLine($"행동 값: {msg.value}"); 
        Console.WriteLine($"남은 체력: {msg.target.hp}");
    }
}