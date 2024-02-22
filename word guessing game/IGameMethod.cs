using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_guessing_game
{
    internal interface IGameMethod
    {
        string PlayerName { get; set; } 
        int Attempt {  get; set; }   
        void Wordselected();
        void playgame(string name);
        bool WordExist(string input);

    }
}
