using Microsoft.Xna.Framework;


namespace TP4
{
    public class MurDeBrique :GameComponent
    {
        private Brique mur;
        private int screenHeight;
        private int screenWidth;
        public Brique Mur { get => mur; set => mur = value; }
        public int ScreenHeight { get => screenHeight; set => screenHeight = value; }
        public int ScreenWidth { get => screenWidth; set => screenWidth = value; }

        public MurDeBrique(Game game) : base(game)
        {
            screenWidth = Game.GraphicsDevice.PresentationParameters.BackBufferWidth;
            screenHeight = Game.GraphicsDevice.PresentationParameters.BackBufferHeight;
            
        }

        public override void Initialize()
        {
           
            for(int i=0; i <(int) screenHeight/64; i++)
            {
                mur = new Brique(Game, "wall_1", new Vector2(0, i*64+1));
                this.Game.Components.Add(mur);
            }
            for (int k = 0; k < (int)screenHeight / 64; k++)
            {
                mur = new Brique(Game, "wall_1", new Vector2(770, k * 64 + 1));
                this.Game.Components.Add(mur);
            }

            for (int j = 0; j < (int)screenWidth / 64; j++)
            {
                mur = new Brique(Game, "wall_1", new Vector2(j * 64 + 1, 1));
                this.Game.Components.Add(mur);
            }
            for (int l = 0; l < (int)screenWidth / 64; l++)
            {
 
                mur = new Brique(Game, "wall_1", new Vector2(l * 64 + 1, 576));
                this.Game.Components.Add(mur);
            }

            base.Initialize();
        }
    }
}
