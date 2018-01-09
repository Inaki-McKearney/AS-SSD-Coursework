using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_Quiz
{
    public class Player
    {
        private string Name;      

        public Player (string name)
        {
            Name = name;           
        }

        public string GetPlayerName()
        {
            return Name;
        }        
    }
}
