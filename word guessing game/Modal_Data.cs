using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_guessing_game
{
    class Modal_Data
    {
        string name;
        int attempt;
        public Modal_Data(string name, int attemp)
        {
            this.name = name;
            this.attempt = attemp;
        }
        public string Name
        {
            get { return name; }
        }
        public int Attempt
        {
            get { return attempt; }
        }
    }
}
