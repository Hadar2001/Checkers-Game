using System;
using System.Windows.Forms;

namespace CheckersGameProject
{
    public static class Program
    {
        public static void Main()
        {
            FormSettings settingsForm = new FormSettings();
            DialogResult result = settingsForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                FormGameBoard gameBoardForm = new FormGameBoard();
                gameBoardForm.ShowDialog();
            }
        }
    }
}



