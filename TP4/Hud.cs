using Microsoft.Xna.Framework;

namespace TP4
{
    public class Hud : ElementText2D
    {

        public Hud(Game game, Vector2 position, string text) : base(game, position, text)
        {
        }

        public override void Update(GameTime gameTime)
        {
            position.X = 70;
            position.Y = 70;
            base.Update(gameTime);
        }
    }
}
