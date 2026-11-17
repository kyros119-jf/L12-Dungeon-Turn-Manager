
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Queue stores the order of heroes taking turns.
        Queue<Hero> heroes = new Queue<Hero>();

        // Stack stores completed actions for undo.
        Stack<string> history = new Stack<string>();

        heroes.Enqueue(new Hero("Aria", "Mage", 100));
        heroes.Enqueue(new Hero("Borin", "Warrior", 120));
        heroes.Enqueue(new Hero("Lyra", "Rogue", 90));

        for (int turn = 1; turn <= 6; turn++)
        {
            Hero currentHero = heroes.Dequeue();

            Console.WriteLine($"\nTurn {turn}");
            Console.WriteLine($"{currentHero.Name} the {currentHero.Class} takes a turn!");

            // Create and save the hero's action.
            string action = $"{currentHero.Name} attacked for 10 damage";

            Console.WriteLine(action);
            history.Push(action);

            // Return the hero to the back of the queue.
            heroes.Enqueue(currentHero);

            // Allow the user to continue or undo.
            Console.WriteLine("\nPress ENTER to continue, or type 'undo' to undo last action:");
            string input = Console.ReadLine() ?? "";

            if (input.ToLower() == "undo")
            {
                if (history.Count > 0)
                {
                    string lastAction = history.Pop();
                    Console.WriteLine("Undoing: " + lastAction);
                }
                else
                {
                    Console.WriteLine("No actions to undo.");
                }
            }
        }

        Console.WriteLine("\nBattle complete!");
    }
}
