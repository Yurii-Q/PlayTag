using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomField playField = new RandomField();
            displayInfo();
            playField.displayField();

            while (true)
            {
                ConsoleKeyInfo inputKey = Console.ReadKey(true);
                if (inputKey.Key == ConsoleKey.Escape) break;

                if (inputKey.KeyChar == 'w' || inputKey.Key == ConsoleKey.UpArrow)
                    playField.swapNumberByI(playField.indexI0 + 1);
                if (inputKey.KeyChar == 's' || inputKey.Key == ConsoleKey.DownArrow)
                    playField.swapNumberByI(playField.indexI0 - 1);
                if (inputKey.KeyChar == 'a' || inputKey.Key == ConsoleKey.LeftArrow)
                    playField.swapNumberByJ(playField.indexJ0 + 1);
                if (inputKey.KeyChar == 'd' || inputKey.Key == ConsoleKey.RightArrow)
                    playField.swapNumberByJ(playField.indexJ0 - 1);

                Console.Clear();
                displayInfo();

                playField.displayField();

                if (playField.checkedField1() || playField.checkedField2())
                {
                    Console.WriteLine("You win!");
                    break;
                }
            }

            void displayInfo()
            {
                Console.WriteLine("Play tag");
                Console.WriteLine("Esc - exit");
                Console.WriteLine("W A S D or Arrowes - control\n");
            }

        }//End Main        

    }//End class Program    
}//End namespace PlayTag

