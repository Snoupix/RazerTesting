namespace RazerTesting
{
    using Colore;
    using Colore.Data;
    using Colore.Effects.Keyboard;
    public class RazerHandler
    {
        public readonly IChroma chroma;

        public RazerHandler(IChroma chroma)
        {
            this.chroma = chroma;
            this.Init_keyboard();
        }

        async public static Task<RazerHandler> BuildNew()
        {
            IChroma chroma = await ColoreProvider.CreateNativeAsync();
            return new RazerHandler(chroma);
        }

        public Color Get_random_rgb()
        {
            Random seed = new();
            string rgb = "0x" + seed.Next(5, 99).ToString() + seed.Next(5, 99).ToString() + seed.Next(5, 99).ToString();

            return Color.FromRgb(Convert.ToUInt32(rgb, 16));
        }

        async private void Init_keyboard()
        {
            Console.Clear();
            Console.WriteLine("Look at your keyboard !");

            for (int i = 0; i < KeyboardConstants.MaxRows; i++)
            {
                for (int j = 0; j < KeyboardConstants.MaxColumns; j++)
                {

                    this.chroma.Keyboard[i, j] = this.Get_random_rgb();
                    Thread.Sleep(35);
                }
            }

            Thread.Sleep(1000);
            await this.chroma.Keyboard.SetAllAsync(Color.Black);
            Thread.Sleep(1500);
        }
    }
}
