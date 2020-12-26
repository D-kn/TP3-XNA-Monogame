using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TP4
{
    public class Raquette : Element2D
    {
        private int width;
        private int height;
        private Rectangle collusionRectangle;
        private KeyboardState keyState;

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public Rectangle CollusionRectangle 
        {
            get
            {
                return new Rectangle((int)Position.X, (int)position.Y, texture2D.Width, texture2D.Height);
            }
        }

        public Raquette(Game game, string nomTexture, Vector2 position) : base(game, nomTexture, position)
        {
           
        }

    
        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Right))
            {
                position.X++;
            }
            else if (keyState.IsKeyDown(Keys.Left))
            {
                position.X--;
            }

            base.Update(gameTime);
        }
    }
}
