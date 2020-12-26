using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TP4
{
    public abstract class Element2D : DrawableGameComponent
    {
        protected Vector2 position;
        private SpriteBatch spriteBatch;
        protected Texture2D texture2D;
        private string nomTexture;

        public Vector2 Position { get => position; set => position = value; }
        public Texture2D Texture2D { get => texture2D; set => texture2D = value; }
        public string NomTexture { get => nomTexture; set => nomTexture = value; }

        public Element2D(Game game, string nomTexture, Vector2 position) : base(game)
        {
            this.nomTexture = nomTexture;
            this.Position = position;
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            texture2D = ((CasseBrique)Game).Content.Load<Texture2D>("Textures/" + nomTexture);
            base.LoadContent();
        }
        public override void Draw(GameTime gameTime)
        {
            this.spriteBatch.Begin();
            this.spriteBatch.Draw(texture2D, position, Color.White);
            this.spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
