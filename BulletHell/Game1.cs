using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BulletHell
{
    public class Main : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D EnemyCubeTexture;
        Texture2D BulletTexture;

        Enemy EnemyCube;
        Enemy EnemyTwo;

        public Main()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Load textures.
            EnemyCubeTexture = Content.Load<Texture2D>("Block");
            BulletTexture = Content.Load<Texture2D>("WhiteBall");

            EnemyCube = new Enemy(Vector2.One * 100, EnemyCubeTexture, BulletTexture, spriteBatch, 0.02f, 15);
            EnemyTwo = new Enemy(Vector2.One * 200, EnemyCubeTexture, BulletTexture, spriteBatch, 0.02f, 15);
        }


        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            EnemyCube.Update(gameTime);
            EnemyTwo.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();

            EnemyCube.Draw();
            EnemyTwo.Draw();

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
