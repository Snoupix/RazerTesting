namespace RazerTesting
{
    using System;
    using Colore.Data;
    using Colore.Effects.Keyboard;

    public enum Cell
    {
        Dead = 0,
        Alive = 1,
    }

    internal class GOL
    {
        private int grid_y = 30;
        private int grid_x = 115;
        private int random_gen = 6;

        public Cell[,] grid;
        public int cells_changed = int.MaxValue;

        public GOL()
        {
            this.grid = this.Generate_grid();
        }

        private Cell[,] Generate_grid()
        {
            Random seed = new();
            Cell[,] g = new Cell[this.grid_y, this.grid_x];

            for (int y = 0; y < this.grid_y; y++)
            {
                for (int x = 0; x < this.grid_x; x++)
                {
                    g[y, x] = seed.Next(this.random_gen) == 0 ? Cell.Alive : Cell.Dead;
                }
            }

            return g;
        }

        async public void Run_Chroma(RazerHandler handler)
        {
            this.random_gen = 4;
            this.grid_y = KeyboardConstants.MaxRows + 10;
            this.grid_x = KeyboardConstants.MaxColumns + 25;
            this.grid = this.Generate_grid();

            CustomKeyboardEffect keyboard_grid = CustomKeyboardEffect.Create();

            while (this.cells_changed > 10)
            {
                Console.Clear();

                Console.WriteLine(this.Next_gen());

                for (int i = 0; i < this.grid_y; i++)
                {
                    for (int j = 0; j < this.grid_x; j++)
                    {
                        if (i < KeyboardConstants.MaxRows && j < KeyboardConstants.MaxColumns)
                        {
                            Color color = this.grid[i, j] == Cell.Alive ? Color.Purple : Color.Black;
                            //this.chroma.Keyboard[i, j] = color;
                            keyboard_grid[i, j] = color;
                        }
                    }
                }

                await handler.chroma.Keyboard.SetCustomAsync(keyboard_grid);
                Thread.Sleep(200);
            }
        }

        public void Run_Console()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            while (this.cells_changed > 30)
            {
                Console.Clear();

                Console.WriteLine(this.Next_gen());
                Thread.Sleep(50);

                if (this.cells_changed == 0)
                {
                    break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public string Next_gen()
        {
            string s = "";
            Cell[,] grid_copy = (Cell[,])this.grid.Clone();

            this.cells_changed = 0;

            for (int y = 0; y < this.grid_y; y++)
            {
                for (int x = 0; x < this.grid_x; x++)
                {
                    s += (this.grid[y, x] == Cell.Alive ? "#" : " "); // █
                    int alive_neigbours = this.Get_alive_count(y, x);

                    if (this.grid[y, x] == Cell.Alive)
                    {
                        if (alive_neigbours < 2)
                        {
                            grid_copy[y, x] = Cell.Dead;
                            this.cells_changed++;
                            continue;
                        }
                        else if (alive_neigbours > 3)
                        {
                            grid_copy[y, x] = Cell.Dead;
                            this.cells_changed++;
                            continue;
                        }
                    }
                    else if (alive_neigbours == 3)
                    {
                        grid_copy[y, x] = Cell.Alive;
                        this.cells_changed++;
                    }
                }

                s += "\n";
            }

            this.grid = grid_copy;
            return s;
        }

        private int Get_alive_count(int y_pos, int x_pos)
        {
            int count = 0;

            for (int y = y_pos-1; y < y_pos+2; y++)
            {
                if (y < 0 || y == this.grid_y)
                {
                    continue;
                }

                for (int x = x_pos-1; x < x_pos+2; x++)
                {
                    if (x < 0 || x == this.grid_x || (y == y_pos && x == x_pos))
                    {
                        continue;
                    }

                    if (this.grid[y, x] == Cell.Alive)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
