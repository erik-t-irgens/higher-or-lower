using System;
using System.Collections.Generic;


// 



public class Program
{
    public static void Main()
    {
        Random r = new Random();
        

        Console.WriteLine("Would you like to play higher or lower? (Yes/No)");
        string yesOrNo = Console.ReadLine();
        if (yesOrNo == "Yes" || yesOrNo == "yes" || yesOrNo == "YES")
        {
            bool Higher(string userResponse)
            {
                return (userResponse == "Higher");
            }
            bool Lower(string userResponse)
            {
                return (userResponse == "Lower");
            }
            bool Correct(string userResponse)
            {
                return (userResponse == "Correct");
            }
            int adder = 50;
            int subtractor = 52;
            int rng = r.Next(1, 100);
            int randomNumber = rng;

            Console.WriteLine("I will only be able to make 20 guesses. Sounds like a lot, doesn't it?");
            Console.WriteLine("Pick a number. Any whole number between 1 and 100! Keep it in your mind.");
            for (int i = 20; i > 0; i--)
            {
                Console.WriteLine("Is your number " + randomNumber + "? (Higher/Lower/Correct");
                string userAnswer = Console.ReadLine();
                if (Correct(userAnswer))
                {
                    Console.WriteLine("I win!");
                    return;
                } 
                else if (Higher(userAnswer))
                {
                    randomNumber = randomNumber + adder;
                    if (adder > 1)
                    {
                     adder = adder/2;
                    }
                    else if (adder <= 1)
                    {
                      adder = adder*2;  
                    } else {

                    }
                }
                else if (Lower(userAnswer))
                {
                    randomNumber = randomNumber - subtractor;
                     if (subtractor > 1)
                    {
                     subtractor = subtractor/2;
                    }
                    else if (subtractor <= 1)
                    {
                      subtractor = subtractor*2;  
                    } else {
                        
                    }
                    
                }
                else
                {
                    Console.WriteLine("I lose!");
                    Main();
                }

            }
            Console.WriteLine("I give up!");
        }
        else{
            Console.WriteLine("Exiting...");
        }
    }
}