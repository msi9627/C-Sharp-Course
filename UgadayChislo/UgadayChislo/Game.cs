using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UgadayChislo
{
    public class Game
    {
        Random rand = new Random();
        public Player player;
        public int number;

        public Game(Player player)
        {
            this.player = player;
            number = rand.Next(1000, 9999);
            MessageBox.Show($"[ДЛЯ ОТЛАДКИ] Загаданное число: {number.ToString()}");
        }

        public void decreaseAttempts()
        {
            player.decreaseAttempts();
        }

        public int checkNumber(int number)
        {
            decreaseAttempts();
            if (number != this.number)
                return -1;
            return number;
        }
    }
}
