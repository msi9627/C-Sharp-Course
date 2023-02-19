using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgadayChislo
{
    public class Player
    {
        private string name;
        private int attempts;

        public Player(string name)
        {
            this.name = name;
            this.attempts = 3;
        }

        public int decreaseAttempts()
        {
            if (this.attempts > 0)
                this.attempts -= 1;
            return this.attempts;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int Attempts
        {
            get { return this.attempts; }
        }
    }
}
