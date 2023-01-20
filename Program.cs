using RazerTesting;

RazerHandler handler = await RazerHandler.BuildNew();

while (true)
{
    GameType chosen_type = ConsoleManagement.GetGameType();

    switch (chosen_type)
    {
        case GameType.GameOfLife:
            {
                GOL game = new();

                game.Run_Chroma(handler);

                ConsoleManagement.Continue();
            }
            break;
        case GameType.ConsoleGameOfLife:
            {
                GOL game = new();

                game.Run_Console();

                ConsoleManagement.Continue();
            }
            break;
        case GameType.ConsoleASCII:
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;

                ASCII ascii = new();

                string input = ConsoleManagement.GetStringInput();

                if (!ascii.IsRespectingRules(input))
                {
                    continue;
                }

                ascii.DisplayPhrase(ascii.SplitStr(ascii.GetPhrase(input)));
                Console.ForegroundColor = ConsoleColor.Gray;

                ConsoleManagement.Continue();
            }
            break;
        case GameType.ASCII:
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;

                ASCII ascii = new();

                string input = ConsoleManagement.GetStringInput();

                if (!ascii.IsRespectingRules(input))
                {
                    continue;
                }

                ascii.DisplayPhraseOnKeyboard(ascii.SplitStr(ascii.GetPhrase(input)), handler);
                Console.ForegroundColor = ConsoleColor.Gray;

                ConsoleManagement.Continue();
            }
            break;
        case GameType.EXIT:
            {
                System.Environment.Exit(0);
            }
            break;
    }
}
