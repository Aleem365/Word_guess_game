namespace word_guessing_game
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to game");
            Game gameData = new Game();
            IGameMethod game;
            bool again = false;
            while (!again)
            {
                Console.Write("Enter user name:");
                string name = Console.ReadLine();
                fl: flg: Console.WriteLine("Press 1 for easy level");
                Console.WriteLine("Press 2 for meduim level");
                Console.WriteLine("Press 3 for hard level");
                Console.Write("Enter your choice : ");
                bool check = int.TryParse(Console.ReadLine(),out int  choice);
                
                if (check)
                {
                    choice = choice;
                }
                else
                {
                    Console.WriteLine("Enter integer value!");
                    goto fl;
                }
                switch (choice)
                {
                    case 1: // easy level
                            game = new GameEasy();
                            game.playgame(name); // call play game 
                            gameData.PlayerList.Add(new Modal_Data(game.PlayerName, game.Attempt)); // store user detail
                        break;
                    case 2:// medium level
                            game = new GameMeduim();
                            game.playgame(name); // call play game
                            gameData.PlayerList.Add(new Modal_Data(game.PlayerName, game.Attempt)); ; // store user detail
                         break;
                    case 3: // hard level
                            game = new GameHard();
                            game.playgame (name); // call play game
                            gameData.PlayerList.Add(new Modal_Data(game.PlayerName, game.Attempt)); // store user detail
                        break;
                    default:
                        Console.WriteLine("enter valid number!");
                        goto flg;
                }
                // play again statement
                con: Console.Write("Do you want to continue….y/n : ");
                char str = Convert.ToChar(Console.ReadLine()[0]);
                str = Char.ToLower(str);
                if (str == 'y')
                {
                    again = false;
                }
                else if (str == 'n')
                {
                    again = true;
                }
                else
                {
                    Console.WriteLine("Enter correct value y or n");
                    goto con;
                }
                // show user detail
                Console.WriteLine("======================");
                foreach (var data in gameData.PlayerList)
                {
                    if (data.Attempt == 0)
                    {
                        Console.WriteLine($"{data.Name} and you game  loose");
                    }
                    else
                    {
                        Console.WriteLine($"{data.Name} and Its Attemp:{data.Attempt}");
                    }
                }
                Console.WriteLine("======================");
            }

        }
    }
}
