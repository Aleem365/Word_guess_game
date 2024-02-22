using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace word_guessing_game
{

    class GameEasy : Game, IGameMethod
    {
         string selectWord = "";
         int MaxAttempt;
         int coutAttempt = 0;
         string inputWord = "";
         bool cout = false;


        public GameEasy()
        {
            this.MaxAttempt = 3;
            Wordselected(); // genrate random word
           
        }

        public string PlayerName { get; set ; }
        public int Attempt { get; set ; }   
        // method for create random word
        public void Wordselected()
        {
            Random random = new Random();
            int cout = Enum.GetValues(typeof(wordListEasy)).Length;
            int randomNumber = random.Next(cout);
             selectWord = ((wordListEasy)randomNumber).ToString().ToLower();
        }

        // for  main game method
        public void playgame(string name)
        {
            // display word list
            Console.WriteLine("===========================");
            foreach (var value in Enum.GetNames(typeof(wordListEasy)))
            {
                Console.WriteLine($"{value},");
            }
            Console.WriteLine("===========================");


            while (inputWord != selectWord && !cout) //// check condition for correct guess 
            {
                if (coutAttempt < MaxAttempt)// check attempt condition
                {
                    // take input for guess word
                    Console.Write("Keep your word : ");
                    inputWord = Console.ReadLine().ToLower();
                  
                    if (WordExist(inputWord)) // condition for word exist in word list
                    {
                        if (CheckGuessWord(inputWord,selectWord)) // method call for guess word check
                        {
                            Console.WriteLine($"your word ({inputWord}) and guessed ({selectWord}) are successful match");

                        }
                        else { Console.WriteLine("keep try again word"); }
                        coutAttempt++;
                    }
                    else
                    {
                        Console.WriteLine("Input word are not exit in Word list");
                    }
                }
                else
                {
                    cout = true;
                }
            }

            if (cout)
            {
                Console.WriteLine("your attempt is over");
                Attempt = 0;
            }
            else
            {
                Console.WriteLine("your  win the Game");
                Attempt = coutAttempt;
            }
            PlayerName = name;
          
          }
        // create for word exist in word list
        public bool WordExist(string input)
        {
            foreach (var value in Enum.GetNames(typeof(wordListEasy)))
            {
                if (input == value)
                {
                    return true;
                }
            }
            return false;
        }



    }
}
