namespace RazerTesting
{
    using Colore.Data;
    using Colore.Effects.Keyboard;

    public class ASCII
    {
        static readonly string hash_alphabet = " #      ##       ##     ##      ###     ###      ##     # #     ###      ##     # #     #       # #     ###      #      ##       #      ##       ##     ###     # #     # #     # #     # #     # #     ###     ###      #              #   \r\n# #     # #     #       # #     #       #       #       # #      #        #     # #     #       ###     # #     # #     # #     # #     # #     #        #      # #     # #     # #     # #     # #       #       #      #       #       #  \r\n###     ##      #       # #     ##      ##      # #     ###      #        #     ##      #       ###     # #     # #     ##      # #     ##       #       #      # #     # #     ###      #       #       #       ##      #               #  \r\n# #     # #     #       # #     #       #       # #     # #      #      # #     # #     #       # #     # #     # #     #        ##     # #       #      #      # #     # #     ###     # #      #      #                        #       #  \r\n# #     ##       ##     ##      ###     #        ##     # #     ###      #      # #     ###     # #     # #      #      #         #     # #     ##       #      ###      #      # #     # #      #      ###      #       #              #   \r\n";
        // 3 5 5
        static readonly string speed_alphabet = "\r\n_______       ________     _________   ________     __________   __________   _________   ______  __   ________   _________   ______ __    ______       ______  ___   _____   __   _______     ________     _______      ________     ________    ________   _____  __   ___    __   ___       __   ____  __    __  __   ______      _____     ______            ______ \r\n___    |      ___  __ )    __  ____/   ___  __ \\    ___  ____/   ___  ____/   __  ____/   ___  / / /   ____  _/   ______  /   ___  //_/    ___  /       ___   |/  /   ___  | / /   __  __ \\    ___  __ \\    __  __ \\     ___  __ \\    __  ___/    ___  __/   __  / / /   __ |  / /   __ |     / /   __  |/ /    _ \\/ /   ___  /      _ __ \\    ___  /  _____     ____| |\r\n__  /| |      __  __  |    _  /        __  / / /    __  __/      __  /_       _  / __     __  /_/ /     __  /     ___ _  /    __  ,<       __  /        __  /|_/ /    __   |/ /    _  / / /    __  /_/ /    _  / / /     __  /_/ /    _____ \\     __  /      _  / / /    __ | / /    __ | /| / /    __    /     __  /    __  /       __/ _/    __  /   ___(_)    ____  /\r\n_  ___ |      _  /_/ /     / /___      _  /_/ /     _  /___      _  __/       / /_/ /     _  __  /     __/ /      / /_/ /     _  /| |      _  /___      _  /  / /     _  /|  /     / /_/ /     _  ____/     / /_/ /      _  _, _/     ____/ /     _  /       / /_/ /     __ |/ /     __ |/ |/ /     _    |      _  /     _  /__      _/_/       /_/    ___       ___  / \r\n/_/  |_|      /_____/      \\____/      /_____/      /_____/      /_/          \\____/      /_/ /_/      /___/      \\____/      /_/ |_|      /_____/      /_/  /_/      /_/ |_/      \\____/      /_/          \\___\\_\\      /_/ |_|      /____/      /_/        \\____/      _____/      ____/|__/      /_/|_|      /_/      /____/      (_)       (_)     _(_)      __/_/  ";
        // 8 6 6
        static readonly string pepper_aplhabet = "\r\n  _    _    _    _    _    _    _            _                        _    _    _    _    _   __                         _   _          \r\n /_/  /_)  / `  / |  /_`  /_`  / `  /_/  /    /  /_/  /   /|,/  /|/  / /  /_/  / /  /_/  /_`  /   / / | | | | | \\ / /_/   / '_/  /  .  |\r\n/ /  /_)  /_,  /_.' /_,  /    /_;  / /  /  (_/  /`\\  /_, /  /  / |  /_/  /    /_\\  / \\  ._/  /   /_/  |/  |/|/  /'\\ /   /_. /   .  .  / ";
        // 4 1 3
        static readonly string mini_aplhabet = "\r\n         _     _    _     _    _    __         ___                                  _     _     _     _     __   ___                                    __   _               \r\n  /\\    |_)   /    | \\   |_   |_   /__   |_|    |      |   |/   |    |\\/|   |\\ |   / \\   |_)   / \\   |_)   (_     |    | |   \\  /   \\    /   \\/   \\_/    /    )   |   o   \\  \r\n /--\\   |_)   \\_   |_/   |_   |    \\_|   | |   _|_   \\_|   |\\   |_   |  |   | \\|   \\_/   |     \\_X   | \\   __)    |    |_|    \\/     \\/\\/    /\\    |    /_   o    o   o    | ";
        // 4 3 4
        static readonly string wide_alphabet = "    _      ____     ____   ____    _____   _____    ____   _   _   ___       _   _  __  _       __  __   _   _    ___    ____     ___    ____    ____    _____   _   _  __     __ __        __ __  __ __   __  _____  ___   _      __  \r\n   / \\    | __ )   / ___| |  _ \\  | ____| |  ___|  / ___| | | | | |_ _|     | | | |/ / | |     |  \\/  | | \\ | |  / _ \\  |  _ \\   / _ \\  |  _ \\  / ___|  |_   _| | | | | \\ \\   / / \\ \\      / / \\ \\/ / \\ \\ / / |__  / |__ \\ | |  _  \\ \\ \r\n  / _ \\   |  _ \\  | |     | | | | |  _|   | |_    | |  _  | |_| |  | |   _  | | | ' /  | |     | |\\/| | |  \\| | | | | | | |_) | | | | | | |_) | \\___ \\    | |   | | | |  \\ \\ / /   \\ \\ /\\ / /   \\  /   \\ V /    / /    / / | | (_)  | |\r\n / ___ \\  | |_) | | |___  | |_| | | |___  |  _|   | |_| | |  _  |  | |  | |_| | | . \\  | |___  | |  | | | |\\  | | |_| | |  __/  | |_| | |  _ <   ___) |   | |   | |_| |   \\ V /     \\ V  V /    /  \\    | |    / /_   |_|  |_|  _   | |\r\n/_/   \\_\\ |____/   \\____| |____/  |_____| |_|      \\____| |_| |_| |___|  \\___/  |_|\\_\\ |_____| |_|  |_| |_| \\_|  \\___/  |_|      \\__\\_\\ |_| \\_\\ |____/    |_|    \\___/     \\_/       \\_/\\_/    /_/\\_\\   |_|   /____|  (_)  (_) (_)  | |";
        static readonly string chonk_alphabet = "\r\n _______      ______      ______      _____       _______      _______      _______      _______      _______        _____      __  __      _____        _______      _______      _______      ______      _______      ______      _______      _______      _______      ___ ___      ________      ___ ___      ___ ___      _______      _____      __      __      ___  \r\n|   _   |    |   __ \\    |      |    |     \\     |    ___|    |    ___|    |     __|    |   |   |    |_     _|     _|     |    |  |/  |    |     |_     |   |   |    |    |  |    |       |    |   __ \\    |       |    |   __ \\    |     __|    |_     _|    |   |   |    |   |   |    |  |  |  |    |   |   |    |   |   |    |__     |    |__   |    |  |    |__|    |_  `.\r\n|       |    |   __ <    |   ---|    |  --  |    |    ___|    |    ___|    |    |  |    |       |     _|   |_     |       |    |     <     |       |    |       |    |       |    |   -   |    |    __/    |   -  _|    |      <    |__     |      |   |      |   |   |    |   |   |    |  |  |  |    |-     -|     \\     /     |     __|    ',  ,-'    |__|     __       |  |\r\n|___|___|    |______/    |______|    |_____/     |_______|    |___|        |_______|    |___|___|    |_______|    |_______|    |__|\\__|    |_______|    |__|_|__|    |__|____|    |_______|    |___|       |_______|    |___|__|    |_______|      |___|      |_______|     \\_____/     |________|    |___|___|      |___|      |_______|     |--|      |__|    |__|     _|  |\r\n                                                                                                                                                                                                                                                                                                                                              '--'                      |___,'\r\n";
        static readonly string banner_alphabet = "\r\n    #       ######      #####     ######     #######    #######     #####     #     #    ###          #    #    #    #          #     #    #     #    #######    ######      #####     ######      #####     #######    #     #    #     #    #     #    #     #    #     #    #######     #####     ###     #     ##   \r\n   # #      #     #    #     #    #     #    #          #          #     #    #     #     #           #    #   #     #          ##   ##    ##    #    #     #    #     #    #     #    #     #    #     #       #       #     #    #     #    #  #  #     #   #      #   #          #     #     #    ###    ###      #  \r\n  #   #     #     #    #          #     #    #          #          #          #     #     #           #    #  #      #          # # # #    # #   #    #     #    #     #    #     #    #     #    #             #       #     #    #     #    #  #  #      # #        # #          #            #    ###     #        # \r\n #     #    ######     #          #     #    #####      #####      #  ####    #######     #           #    ###       #          #  #  #    #  #  #    #     #    ######     #     #    ######      #####        #       #     #    #     #    #  #  #       #          #          #          ###      #               # \r\n #######    #     #    #          #     #    #          #          #     #    #     #     #     #     #    #  #      #          #     #    #   # #    #     #    #          #   # #    #   #            #       #       #     #     #   #     #  #  #      # #         #         #           #               #        # \r\n #     #    #     #    #     #    #     #    #          #          #     #    #     #     #     #     #    #   #     #          #     #    #    ##    #     #    #          #    #     #    #     #     #       #       #     #      # #      #  #  #     #   #        #        #                    ###    ###      #  \r\n #     #    ######      #####     ######     #######    #           #####     #     #    ###     #####     #    #    #######    #     #    #     #    #######    #           #### #    #     #     #####        #        #####        #        ## ##     #     #       #       #######       #       ###     #     ##   ";
        static readonly string full_alphabet = " █████╗     ██████╗      ██████╗    ██████╗     ███████╗    ███████╗     ██████╗     ██╗  ██╗    ██╗         ██╗    ██╗  ██╗    ██╗         ███╗   ███╗    ███╗   ██╗     ██████╗     ██████╗      ██████╗     ██████╗     ███████╗    ████████╗    ██╗   ██╗    ██╗   ██╗    ██╗    ██╗    ██╗  ██╗    ██╗   ██╗    ███████╗    ██████╗     ██╗           ██╗ \r\n██╔══██╗    ██╔══██╗    ██╔════╝    ██╔══██╗    ██╔════╝    ██╔════╝    ██╔════╝     ██║  ██║    ██║         ██║    ██║ ██╔╝    ██║         ████╗ ████║    ████╗  ██║    ██╔═══██╗    ██╔══██╗    ██╔═══██╗    ██╔══██╗    ██╔════╝    ╚══██╔══╝    ██║   ██║    ██║   ██║    ██║    ██║    ╚██╗██╔╝    ╚██╗ ██╔╝    ╚══███╔╝    ╚════██╗    ██║    ██╗    ╚██╗\r\n███████║    ██████╔╝    ██║         ██║  ██║    █████╗      █████╗      ██║  ███╗    ███████║    ██║         ██║    █████╔╝     ██║         ██╔████╔██║    ██╔██╗ ██║    ██║   ██║    ██████╔╝    ██║   ██║    ██████╔╝    ███████╗       ██║       ██║   ██║    ██║   ██║    ██║ █╗ ██║     ╚███╔╝      ╚████╔╝       ███╔╝       ▄███╔╝    ██║    ╚═╝     ██║\r\n██╔══██║    ██╔══██╗    ██║         ██║  ██║    ██╔══╝      ██╔══╝      ██║   ██║    ██╔══██║    ██║    ██   ██║    ██╔═██╗     ██║         ██║╚██╔╝██║    ██║╚██╗██║    ██║   ██║    ██╔═══╝     ██║▄▄ ██║    ██╔══██╗    ╚════██║       ██║       ██║   ██║    ╚██╗ ██╔╝    ██║███╗██║     ██╔██╗       ╚██╔╝       ███╔╝        ▀▀══╝     ╚═╝    ██╗     ██║\r\n██║  ██║    ██████╔╝    ╚██████╗    ██████╔╝    ███████╗    ██║         ╚██████╔╝    ██║  ██║    ██║    ╚█████╔╝    ██║  ██╗    ███████╗    ██║ ╚═╝ ██║    ██║ ╚████║    ╚██████╔╝    ██║         ╚██████╔╝    ██║  ██║    ███████║       ██║       ╚██████╔╝     ╚████╔╝     ╚███╔███╔╝    ██╔╝ ██╗       ██║       ███████╗      ██╗       ██╗    ╚═╝    ██╔╝\r\n╚═╝  ╚═╝    ╚═════╝      ╚═════╝    ╚═════╝     ╚══════╝    ╚═╝          ╚═════╝     ╚═╝  ╚═╝    ╚═╝     ╚════╝     ╚═╝  ╚═╝    ╚══════╝    ╚═╝     ╚═╝    ╚═╝  ╚═══╝     ╚═════╝     ╚═╝          ╚══▀▀═╝     ╚═╝  ╚═╝    ╚══════╝       ╚═╝        ╚═════╝       ╚═══╝       ╚══╝╚══╝     ╚═╝  ╚═╝       ╚═╝       ╚══════╝      ╚═╝       ╚═╝           ╚═╝ ";
        // 8 4 6

        protected string selected_alphabet = ASCII.hash_alphabet;
        protected int letter_width = 3;
        protected int letter_space = 5;
        protected int letter_height = 5;
        protected char[] dynamic_width_end = { '╗', '║', '╝' };
        
        private char[] a_z = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '?', '!', ':', ')' };
        private Dictionary<char, string> alphabet = new();

        public ASCII()
        {
            this.alphabet = this.GenerateAlphabet();
        }

        private Dictionary<char, string> GenerateAlphabet()
        {
            Dictionary<char, string> alphabet = new();

            foreach (char letter in this.a_z)
            {
                alphabet.Add(letter, "");
            }

            int col = 0;
            int letter_i = 0;
            int dynamic_width = 0;
            foreach (char s in this.selected_alphabet)
            {
                if (s == '\n')
                {
                    foreach (var (k, v) in alphabet)
                    {
                        alphabet[k] = v + "\n";
                    }
                    col = 0;
                    letter_i = 0;
                    continue;
                }

                if (s == '\r') { continue; }

                if (this.selected_alphabet == ASCII.wide_alphabet)
                {
                    if (dynamic_width != 0 && col == dynamic_width + this.letter_space)
                    {
                        col = 0;
                        letter_i++;
                    }

                    if (this.dynamic_width_end.Contains(s) && col >= this.letter_width)
                    {
                        dynamic_width = col;
                    } else if (col >= dynamic_width)
                    {
                        col++;
                        continue;
                    }
                } else
                {
                    if (col == this.letter_width + this.letter_space)
                    {
                        col = 0;
                        letter_i++;
                    }

                    if (col >= this.letter_width)
                    {
                        col++;
                        continue;
                    }
                }


                alphabet[a_z[letter_i]] += s;

                col++;
            }

            return alphabet;
        }

        public string[] SplitStr(string s)
        {
            string[] a = new string[this.letter_height];

            int i = 0;
            foreach (char c in s)
            {
                if (c == '\n')
                {
                    i++;
                    continue;
                }

                a[i] += c;
            }

            return a;
        }

        private string[] AddSpace(string[] str)
        {
            string[] r = new string[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                r[i] = str[i] + " ";
            }

            return r;
        }

        private string StrArrToStr(string[] s_arr)
        {
            string s = "";

            foreach (string str in s_arr)
            {
                s += str + "\n";
            }

            return s;
        }

        private string[] AddToStrArr(string[] s, char c)
        {
            string[] r = new string[s.Length];
            string[] letter = this.SplitStr(this.GetLetter(c));

            for (int i = 0; i < s.Length; i++)
            {
                r[i] = s[i] + letter[i];
            }

            return r;
        }

        public string GetLetter(char l)
        {
            return alphabet[l.ToString().ToUpper()[0]];
        }

        public string GetPhrase(string s)
        {
            string[] phrase = new string[this.letter_height];

            foreach (char c in s)
            {
                if (c == ' ')
                {
                    phrase = this.AddSpace(phrase);
                    phrase = this.AddSpace(phrase);
                    continue;
                }

                phrase = this.AddToStrArr(phrase, c);
                phrase = this.AddSpace(phrase);
            }

            return this.StrArrToStr(phrase);
        }

        public bool IsRespectingRules(string input)
        {
            string s = input.ToUpper();

            foreach (char c in s)
            {
                if (c != ' ' && !this.a_z.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }

        async public void DisplayPhraseOnKeyboard(string[] phrase, RazerHandler handler)
        {
            char[,] grid = new char[this.letter_height, phrase[0].Length];
            char[,] phrase_grid = new char[this.letter_height, phrase[0].Length];

            for (int i = 0; i < this.letter_height; i++)
            {
                for (int j = 0; j < phrase[0].Length; j++)
                {
                    grid[i, j] = ' ';
                }
            }

            uint y = 0;
            uint x = 0;
            foreach (string s in phrase)
            {
                foreach (char c in s)
                {
                    phrase_grid[y, x] = c;
                    x++;
                }

                x = 0;
                y++;
            }

            this.ChangeHashBy('█', phrase_grid);

            CustomKeyboardEffect keyboard_grid = CustomKeyboardEffect.Create();

            for (int i = 0; i < phrase[0].Length; i++)
            {
                Console.Clear();

                grid = this.ProgressGridRtoL(grid, phrase_grid, i);
                this.ShowGrid(grid, this.letter_height, phrase[0].Length);

                for (int y2 = 1; y2 < 6; y2++)
                {
                    for (int x2 = 0; x2 < phrase[0].Length; x2++)
                    {
                        if (y2 < KeyboardConstants.MaxRows && x2 < KeyboardConstants.MaxColumns)
                        {
                            Color color = grid[y2 - 1, x2] != ' ' ? Color.Purple : Color.Black;
                            keyboard_grid[y2, x2] = color;
                        }
                    }
                }

                await handler.chroma.Keyboard.SetCustomAsync(keyboard_grid);

                Thread.Sleep(150);
            }

            Thread.Sleep(2000);
        }

        public void DisplayPhrase(string[] phrase, bool to_right = false)
        {
            char[,] grid = new char[this.letter_height, phrase[0].Length];
            char[,] phrase_grid = new char[this.letter_height, phrase[0].Length];

            for (int i = 0; i < this.letter_height; i++)
            {
                for (int j = 0; j < phrase[0].Length; j++)
                {
                    grid[i, j] = ' ';
                }
            }

            uint y = 0;
            uint x = 0;
            foreach (string s in phrase)
            {
                foreach (char c in s)
                {
                    phrase_grid[y, x] = c;
                    x++;
                }

                x = 0;
                y++;
            }

            this.ChangeHashBy('█', phrase_grid);

            for (int i = 0; i < phrase[0].Length; i++)
            {
                Console.Clear();

                if (to_right)
                {
                    grid = this.ProgressGridLtoR(grid, phrase_grid, i);
                    this.ShowGrid(grid, this.letter_height, phrase[0].Length);
                } else
                {
                    grid = this.ProgressGridRtoL(grid, phrase_grid, i);
                    this.ShowGrid(grid, this.letter_height, phrase[0].Length);
                }

                Thread.Sleep(150);
            }

            Thread.Sleep(2000);
        }

        private void ShowGrid(char[,] grid, int rows, int cols)
        {
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    Console.Write(grid[y, x]);
                }
                Console.WriteLine();
            }
        }

        private char[,] ProgressGridLtoR(char[,] grid, char[,] phrase_grid, int i)
        {
            char[,] g = grid;

            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = grid.GetLength(1) - 1; x != 0; x--)
                {
                    if (x < grid.GetLength(1) - i)
                    {
                        g[y, grid.GetLength(1) - x] = phrase_grid[y, i];
                    }
                }
            }

            return g;
        }

        private char[,] ProgressGridRtoL(char[,] grid, char[,] phrase_grid, int i)
        {
            if (i == 0)
            {
                return grid;
            }

            char[,] g = grid;

            int x_idx = grid.GetLength(1) - i;

            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = x_idx; x < grid.GetLength(1); x++)
                {
                    g[y, x] = phrase_grid[y, x - x_idx];
                }
            }

            return g;
        }

        private void ChangeHashBy(char c, char[,] grid)
        {
            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    if (grid[y,x] == '#')
                    {
                        grid[y,x] = c;
                    }
                }
            }
        }
    }
}
