using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace MenuConsolaInteractivo
{
    public class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;
        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }
        public void DisplayOptions()
        {
            WriteLine(Prompt);
            for(int i=0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if(i == SelectedIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;

                }
                WriteLine($"{prefix} << {currentOption} >>");
            }
            ResetColor();
        }

        public void DisplayOption(int option)
        {

        }


        public int Run()
        {
            Clear();
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            Console.CursorVisible = false;
            ConsoleKey keyPressed;
            do{
                Console.CursorLeft = x;
                Console.CursorTop = y;
                DisplayOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if(keyPressed == ConsoleKey.UpArrow)
                {
                    if(SelectedIndex == 0) continue;
                    SelectedIndex--;
                }
                else if(keyPressed == ConsoleKey.DownArrow)
                {
                    if(SelectedIndex == Options.Length-1) continue;
                    SelectedIndex++;
                }
            }while(keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }

    }
}