using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace REAL_Pacman
{
    enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }
   
    class Pacman : Sprite
    {
        int speed = 100;
        Direction direction;
        Vector2 target;

        public Pacman(
            Vector2 location,
            Texture2D texture,
            Rectangle initialFrame,
            Vector2 velocity) :

            base(location, texture, initialFrame, velocity)
        {
            direction = Direction.Right;
            target = location;
            UpdateDirection();
        }

        public void UpdateDirection()
        {
            switch (direction)
            {
                case Direction.Right:
                    Velocity = new Vector2(speed, 0);
                    Rotation = 0;
                    target = location + new Vector2(speed, 0);
                    break;
                case Direction.Left:
                    Velocity = new Vector2(-speed, 0);
                    Rotation = MathHelper.Pi;
                    target = location + new Vector2(-speed, 0);
                    break;
                case Direction.Down:
                    Velocity = new Vector2(0, speed);
                    Rotation = MathHelper.PiOver2;
                    target = location + new Vector2(0, speed);
                    break;
                case Direction.Up:
                    Velocity = new Vector2(0, -speed);
                    Rotation = -MathHelper.PiOver2;
                    target = location + new Vector2(0, - speed);
                    break;
            }
        }
        public override void Update(GameTime gameTime)
        {
            KeyboardState kb = Keyboard.GetState();
            if (kb.IsKeyDown(Keys.Right))
            {
                direction = Direction.Right;
                
            }
            if (kb.IsKeyDown(Keys.Down))
            {
                direction = Direction.Down;
            }

            if (kb.IsKeyDown(Keys.Left))
            {
                direction = Direction.Left;
            }
            if (kb.IsKeyDown(Keys.Up))
            {
                direction = Direction.Up;
            }

            if (velocity.X >  0 && location.X >= target.X ||
                velocity.X < 0 && location.X <= target.X ||
                velocity.Y > 0 && location.Y >= target.Y ||
                velocity.Y < 0 && location.Y <= target.Y
            )
    {
        UpdateDirection();
    }

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

    }
}
