using System;
using rpg;

internal class TitleScreen
{
    public void ShowTitleScreen()
    {
        Console.Clear();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(CenterText("========================"));
        Console.WriteLine(CenterText("Crashed: Exo Escapists"));
        Console.WriteLine(CenterText("========================"));
        Console.ResetColor();
        Console.WriteLine();

        Thread.Sleep(750);

        Console.WriteLine(CenterText("1) Singleplayer"));
        Thread.Sleep(200);
        Console.WriteLine(CenterText("2) Multiplayer Co-Op"));
        Thread.Sleep(200);
        Console.WriteLine(CenterText("3) Show Stats"));
        Thread.Sleep(200);
        Console.WriteLine(CenterText("4) Exit Game"));
        Console.WriteLine(CenterText("-------------------------"));

        new TitleScreenHandler().TitleScreenInput();
    }

    private string CenterText(string text)
    {
        int consoleWidth = Console.WindowWidth;
        int spacesNeeded = consoleWidth - text.Length;
        int leftSpaces = spacesNeeded / 2;

        return new string(' ', leftSpaces) + text + new string(' ', spacesNeeded % 2 == 0 ? leftSpaces : leftSpaces + 1);
    }
}
