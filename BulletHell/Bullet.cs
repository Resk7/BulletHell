using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace BulletHell
{
    public class Bullet : Sprite
    {
        public float Rotation { get; set; }
        public Rectangle Rectangle { get; private set; }

        public Bullet(Vector2 vector2, Texture2D texture2D, SpriteBatch spriteBatch, float rotation) : base(vector2, texture2D, spriteBatch)
        {
            Rotation = rotation;
        }

        public override void Draw()
        {
            SpriteBatch.Draw(Texture2D, Vector2, null, null, new Vector2(Texture2D.Width / 2, Texture2D.Height / 2), (float)Rotation, null, Color.OrangeRed, SpriteEffects.None, 0);
        }

        public void RectangleUpdate()
        {
            Rectangle = new Rectangle((int)Vector2.X, (int)Vector2.Y, Texture2D.Width, Texture2D.Height);
        }
    }
}
