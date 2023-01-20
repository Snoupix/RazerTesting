namespace RazerTesting
{
    public enum GameType
    {
        None = 0,
        GameOfLife = 1,
        ConsoleGameOfLife = 2,
        ConsoleASCII = 3,
        ASCII = 4,
        EXIT = 5,
    }
    public static class ConsoleManagement
    {
        static private Dictionary<string, uint> choices = new Dictionary<string, uint>()
        {
            { "{0}. Conway's Game of life on your keyboard", (uint)GameType.GameOfLife },
            { "{0}. Larger Conway's Game of life on the console", (uint)GameType.ConsoleGameOfLife },
            { "{0}. Little ASCII art on the console", (uint)GameType.ConsoleASCII },
            { "{0}. Little ASCII art on the console and your keyboard", (uint)GameType.ASCII },
            { "{0}. Exit", (uint)GameType.EXIT },
        };

        private static void HighlightChoice(int index)
        {
            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < ConsoleManagement.choices.Count; i++)
            {
                Console.ResetColor();
                KeyValuePair<string, uint> choice = ConsoleManagement.choices.ElementAt(i);

                if (i == index)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(choice.Key, choice.Value);
                    continue;
                }

                Console.WriteLine(choice.Key, choice.Value);
            }

            Console.SetCursorPosition(0, choices.Count + 3);
        }

        public static GameType GetGameType()
        {
            int i = 1;
            GameType chosen_type = GameType.GameOfLife;

            ConsoleManagement.HighlightChoice(0);

            Console.SetCursorPosition(0, choices.Count + 2);
            Console.WriteLine("Use your UP and DOWN arrow keys to navigate and press ENTER to validate.");

            var k = Console.ReadKey();

            while (true)
            {
                if (k.Key == ConsoleKey.Enter)
                {
                    Console.ResetColor();
                    return chosen_type;
                }

                if (k.Key == ConsoleKey.UpArrow)
                {
                    if (i == 1)
                    {
                        k = Console.ReadKey();
                        continue;
                    }

                    i--;
                    ConsoleManagement.HighlightChoice(i-1);

                    chosen_type = (GameType)Enum.GetValues(chosen_type.GetType()).GetValue(i);
                }

                if (k.Key == ConsoleKey.DownArrow)
                {
                    if (i == Enum.GetValues(chosen_type.GetType()).Length-1)
                    {
                        k = Console.ReadKey();
                        continue;
                    }

                    i++;
                    ConsoleManagement.HighlightChoice(i-1);

                    chosen_type = (GameType)Enum.GetValues(chosen_type.GetType()).GetValue(i);
                }

                k = Console.ReadKey();
            }
        }

        public static string GetStringInput()
        {
            Console.Clear();
            Console.WriteLine("Rules: 'A to Z' with '?', '!', ':' or ')' and between 1 and 20 characthers long");
            Console.Write("Phrase input: ");
            var result = Console.ReadLine();

            if (result == null)
            {
                throw new Exception("You must enter a phrase and respect the rules");
            }

            return result;
        }

        public static void Continue()
        {
            Thread.Sleep(1000);

            Console.Clear();
            Console.WriteLine("~Press any key to continue :)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
