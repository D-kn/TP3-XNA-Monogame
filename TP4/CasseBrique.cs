using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TP4
{
    public class CasseBrique : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Balle maBalle;
        private Raquette maRaquette;
        private MurDeBrique monMurDeBrique;
        private Hud hud;

        public CasseBrique()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            this._graphics.IsFullScreen = false;
            this._graphics.PreferredBackBufferWidth = 832;
            this._graphics.PreferredBackBufferHeight = 640;
            this._graphics.ApplyChanges();

            maRaquette = new Raquette(this, "raquette", new Vector2(this._graphics.PreferredBackBufferWidth / 2-35, (int)3 * this._graphics.PreferredBackBufferHeight/4));
            Components.Add(maRaquette);
            hud = new Hud(this, new Vector2(150, 150), "Score");
            maBalle = new Balle(this, "ball", new Vector2(maRaquette.Position.X + 30, maRaquette.Position.Y-15));
            Components.Add(maBalle);
            monMurDeBrique = new MurDeBrique(this);
            Components.Add(monMurDeBrique);
            Components.Add(hud);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkGreen);

            base.Draw(gameTime);
        }
    }
}
