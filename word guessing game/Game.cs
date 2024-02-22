using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace word_guessing_game
{
     class Game
    {
        // list for store data
        public List<Modal_Data> PlayerList = new List<Modal_Data>();
        public bool CheckGuessWord(string inputWord, string randomWord)
        {
            if (inputWord == randomWord)
            {
                return true;
            }
            return false;
        }
    }
}
