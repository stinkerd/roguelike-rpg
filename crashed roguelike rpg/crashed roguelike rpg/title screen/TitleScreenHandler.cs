using System;
using System.Data;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using rpg;

internal class TitleScreenHandler
{
    public void TitleScreenInput()
    {
        string titleInput = Console.ReadLine();
        Console.Clear();
        Console.WriteLine();

        if (titleInput == "1")
        {
            while (true)
            {
                Console.WriteLine(CenterText("Please select a save:"));
                Console.WriteLine();

                new FileSelection().FileSelect();

                Console.WriteLine();
                Console.WriteLine(CenterText("-------------------------"));

                var userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    new FileSelection().FileSelect();
                    break;
                }
                else if (userInput == "2")
                {
                    new FileSelection().FileSelect();
                    break;
                }
                else if (userInput == "3")
                {
                    new FileSelection().FileSelect();
                    break;
                }
                else if (string.IsNullOrEmpty(userInput))
                {
                    new TitleScreen().ShowTitleScreen();
                    break;
                }
                else
                {
                    new TitleScreen().ShowTitleScreen();
                    break;
                }
            }
        }


        else if (titleInput == "2")
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(CenterText("Developmemt has not yet begun!"));
            Console.WriteLine();
            Console.WriteLine(CenterText("Enter to return to menu"));
            Console.WriteLine(CenterText("-------------------------"));
            while (true)
            {
                string playerContinue = Console.ReadLine();

                if (string.IsNullOrEmpty(playerContinue))
                {
                    new TitleScreen().ShowTitleScreen();
                    break;
                }
                else
                {
                    new TitleScreen().ShowTitleScreen();
                    break;
                }
            }
        }


        else if (titleInput == "3")
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(CenterText("Developmemt has not yet begun!"));
            Console.WriteLine();
            Console.WriteLine(CenterText("Enter to return to menu"));
            Console.WriteLine(CenterText("-------------------------"));
            while (true)
            {
                string playerContinue = Console.ReadLine();

                if (string.IsNullOrEmpty(playerContinue))
                {
                    new TitleScreen().ShowTitleScreen();
                    break;
                }
                else
                {
                    new TitleScreen().ShowTitleScreen();
                    break;
                }
            }
        }


        else if (titleInput == "4")
        {
            Console.Clear();
            Console.WriteLine();
            string bye = "Thank you so much for playing ";
            string game = "Crashed: Exo Escapists";

            Console.Write(bye);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(game);
            Console.ResetColor();
            Console.WriteLine("! We hope to see you soon again!");
            Console.WriteLine();
        }


        else
        {
            new TitleScreen().ShowTitleScreen();
        }
    }
    private string CenterText(string text)
    {
        int consoleWidth = Console.WindowWidth;
        int spacesNeeded = consoleWidth - text.Length;
        int leftSpaces = spacesNeeded / 2;

        return new string(' ', leftSpaces) + text + new string(' ', spacesNeeded % 2 == 0 ? leftSpaces : leftSpaces + 1);
    }
}