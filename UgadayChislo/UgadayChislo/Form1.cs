using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UgadayChislo
{
    public partial class Form1 : Form
    {
        Game game;

        public Form1(Player player)
        {
            InitializeComponent();
            game = new Game(player);
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            spinner.Value = trackBar.Value;
        }

        private void spinner_ValueChanged(object sender, EventArgs e)
        {
            trackBar.Value = (int)spinner.Value;
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            int number = (int)spinner.Value;
            if (game.checkNumber(number) == -1)
            {
                if (game.player.Attempts == 0)
                {
                    btCheck.Enabled = false;
                    MessageBox.Show($"{game.player.Name}, попытки закончились! Вы не отгадали загаданное число {game.number}");
                    return;
                }
                MessageBox.Show($"{game.player.Name}, Вы не отгадали число. Осталость попыток: {game.player.Attempts}");
            }
            else
            {
                btCheck.Enabled = false;
                pictureBox1.Visible = true;
                MessageBox.Show($"{game.player.Name}, Вы отгадали число с {3 - game.player.Attempts} попытки!");
            }
        }
    }
}
