using System;
using rpg;
internal class TitleScreenIntro
{
    public void ShowTitleScreenIntro()
    {
        Console.Clear();

        Console.WriteLine();
        new SpeedControl().TypeLineSlowly(CenterText("A small game brought to you by Levi and Google (not Adil yet) .."));
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine();
        new SpeedControl().TypeLineSlowly(CenterText("Created for Bartje von Native, the team proudly presents to you .."));
        Thread.Sleep(1000);

        new TitleScreen().ShowTitleScreen();
    }

    private string CenterText(string text)
    {
        int consoleWidth = Console.WindowWidth;
        int spacesNeeded = consoleWidth - text.Length;
        int leftSpaces = spacesNeeded / 2;

        return new string(' ', leftSpaces) + text + new string(' ', spacesNeeded % 2 == 0 ? leftSpaces : leftSpaces + 1);
    }
}
