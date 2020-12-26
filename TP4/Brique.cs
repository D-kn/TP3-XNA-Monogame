using Microsoft.Xna.Framework;

namespace TP4
{
    public class Brique : Element2D
    {
        private int width;
        private int height;
        // this is a comment line
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public Brique(Game game, string nomTexture, Vector2 position) : base(game, nomTexture, position)
        {
        }
        public override void Initialize()
        {
            base.Initialize();
        }

    }
}
