using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace word_guessing_game
{
    enum wordListEasy
    {
        ability,
        air,
        programming,
        animal,
        anyone
    } 
    
    enum wordListMedium
    {
        ability12,
        air47,
        progr65amming,
        animal135,
        anyone478,
      

    }
    enum wordListHard
    {
        [Description("The course starts next Sunday")]
        Test1,
        [Description("She swims every morning")]
        Test2,
        [Description("He goes to school")]
        Test3,
        [Description("I love my new pet")]
        Test4,
        [Description("We live in Texas")]
        Test5,
        [Description("we are happy with this task")]
        Test6,
    }
}
