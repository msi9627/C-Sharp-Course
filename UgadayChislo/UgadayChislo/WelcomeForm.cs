using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UgadayChislo
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                MessageBox.Show(
                    $"Добро пожаловать в игру, {tbName.Text}!",
                    "Привет!",
                    MessageBoxButtons.OK);
                Form1 form1 = new Form1(new Player(tbName.Text));
                form1.Show();
            }
            else
                MessageBox.Show("Пожалуйста, введите свое имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
