using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TP4
{
    public class Balle : Element2D
    {
        private Vector2 deplacement;
        private int screenHeight;
        private int screenWidth;
        private Raquette maRaq;
        public Balle(Game game, string nomTexture, Vector2 position) : base(game, nomTexture, position)
        {
            screenWidth = Game.GraphicsDevice.PresentationParameters.BackBufferWidth;
            screenHeight = Game.GraphicsDevice.PresentationParameters.BackBufferHeight;
        }

        public override void Initialize()
        {
            deplacement = Vector2.One;
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
          
            position -= deplacement;
           
            if ((deplacement.X < 64 && position.X <= 64)
             || (deplacement.X > 64 && position.X >= screenWidth-64))
            {
                // Si on est dans un des deux cas, on inverse le déplacement sur les abscisses
                deplacement.X = -deplacement.X;
            }

            // On fait la même opération mais pour le haut/bas
            if ((deplacement.Y < 64 && position.Y <= 64))
            {
                // Si c'est le cas, on inverse le déplacement sur les ordonnées
                deplacement.Y = -deplacement.Y;
            }

            if ((deplacement.X < 0 && maRaq.CollusionRectangle().Contains((int)position.X, (int)position.Y + texture2D.Height / 2)))
            {
                deplacement = new Vector2(-deplacement.X, deplacement.Y);
                
            }

            base.Update(gameTime);
        }
    }
}
