using System;
using rpg;
internal class FileSelectionHandler
{
    public void FileSelectHandler()
    {

        string filePath = "..\\..\\..\\saveFiles\\SaveFile1.txt";
        var fileStream = new FileStream(filePath, FileMode.Open);

        try
        {
            string fileContent1 = File.ReadAllText(filePath);

            string myString1 = fileContent1;

            Console.WriteLine("\n\nsaveClass.txt:\n\n");
            Console.WriteLine(myString1);
            fileStream.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("");
            Console.WriteLine("Error reading file: " + ex.Message);
            fileStream.Close();
        }

        while (true)
        {
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
    }
    private string CenterText(string text)
    {
        int consoleWidth = Console.WindowWidth;
        int spacesNeeded = consoleWidth - text.Length;
        int leftSpaces = spacesNeeded / 2;

        return new string(' ', leftSpaces) + text + new string(' ', spacesNeeded % 2 == 0 ? leftSpaces : leftSpaces + 1);
    }
}


/*            if (File.Exists("..\\..\\..\\saveFiles\\SaveFile1.txt"))
            {
                string filePath = "..\\..\\..\\saveFiles\\SaveFile1.txt";
                var fileStream = new FileStream(filePath, FileMode.Open);

                try
                {
                    string fileContent1 = File.ReadAllText(filePath);

                    string myString1 = fileContent1;

                    Console.WriteLine("\n\nsaveClass.txt:\n\n");
                    Console.WriteLine(myString1);
                    fileStream.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error reading file: " + ex.Message);
                    fileStream.Close();
                }
                break;
            }*/