using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace REAL_Pacman
{
    class Pacman : Sprite
    {
        public Pacman(
            Vector2 location,
            Texture2D texture,
            Rectangle initialFrame,
            Vector2 velocity) :
            base(location, texture, initialFrame, velocity)
        {

        }

        public Pacman()
        {
            // TODO: Complete member initialization
        }

        public override void Update(GameTime gameTime)
        {
            //insert keyboard clicks code
            
            
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

    }
}
