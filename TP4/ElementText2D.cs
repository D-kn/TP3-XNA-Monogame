using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace TP4
{
    public abstract class ElementText2D : DrawableGameComponent
    {
        protected Vector2 position;
        protected string text;
        protected SpriteBatch spriteBatch;
        private SpriteFont font;
        public Vector2 Position { get => position; set => position = value; }
        public string Text { get => text; set => text = value; }
        public SpriteFont Font { get => font; set => font = value; }

        public ElementText2D(Game game, Vector2 position, string text) : base(game)
        {
            this.position = position;
            this.text = text;
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            font = ((CasseBrique)Game).Content.Load<SpriteFont>("SpriteFont/" + text);
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(font, "Score : ", position, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
