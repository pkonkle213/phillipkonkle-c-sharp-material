//using EncapsulationLecture.CarExamples;
using EncapsulationLecture.CarExamples;
using EncapsulationLecture.GameExamples;
using System;

namespace EncapsulationLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Player in a Game -------------
            Player myPlayer = new Player("Handsome Jack");

            myPlayer.TakeDamage(10);

            Console.WriteLine("Is the player dead? " + myPlayer.IsDead);
            myPlayer.TakeDamage(25);
            myPlayer.Heal(50);

            Console.WriteLine("Is the player dead? " + myPlayer.IsDead);

            myPlayer.TakeDamage(200);

            Console.WriteLine("Is the player dead? " + myPlayer.IsDead);
        }
    }
}
