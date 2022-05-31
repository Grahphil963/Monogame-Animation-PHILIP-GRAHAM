using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Animation_PHILIP_GRAHAM
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D tribbleGreyTexture;
        Rectangle tribbleGreyRect;
        Vector2 tribbleGreySpeed;
        Texture2D tribbleBrownTexture;
        Rectangle tribbleBrownRect;
        Vector2 tribbleBrownSpeed;
        Texture2D tribbleCreamTexture;
        Rectangle tribbleCreamRect;
        Vector2 tribbleCreamSpeed;
        Texture2D tribbleOrangeTexture;
        Rectangle tribbleOrangeRect;
        Vector2 tribbleOrangeSpeed;
        Texture2D tribbleBackgroundTexture;
        Rectangle tribbleBackgroundRect;








        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            tribbleGreySpeed = new Vector2(2, 8);
            tribbleBrownSpeed = new Vector2(5, 0);
            tribbleCreamSpeed = new Vector2(0, 3);
            tribbleOrangeSpeed = new Vector2(9, 9);
            tribbleBackgroundRect = new Rectangle(0, 0, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            tribbleGreyTexture = Content.Load<Texture2D>("tribbleGrey");
            tribbleGreyRect = new Rectangle(300, 10, 100, 100);
            tribbleBrownTexture = Content.Load<Texture2D>("tribbleBrown");
            tribbleBrownRect = new Rectangle(200, 20, 100, 100);
            tribbleCreamTexture = Content.Load<Texture2D>("tribbleCream");
            tribbleCreamRect = new Rectangle(400, 30, 100, 100);
            tribbleOrangeTexture = Content.Load<Texture2D>("tribbleOrange");
            tribbleOrangeRect = new Rectangle(500, 40, 100, 100);
            tribbleBackgroundTexture = Content.Load<Texture2D>("tribbleBackground");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here


            tribbleGreyRect.X += (int)tribbleGreySpeed.X;
            tribbleGreyRect.Y += (int)tribbleGreySpeed.Y;

            if (tribbleGreyRect.Right > _graphics.PreferredBackBufferWidth || tribbleGreyRect.X < 0)
                tribbleGreySpeed.X *= -1;
            if (tribbleGreyRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleGreyRect.Y < 0)
                tribbleGreySpeed.Y *= -1;

            tribbleBrownRect.X += (int)tribbleBrownSpeed.X;
            tribbleBrownRect.Y += (int)tribbleBrownSpeed.Y;
            if (tribbleBrownRect.Right > _graphics.PreferredBackBufferWidth || tribbleBrownRect.X < 0)
                tribbleBrownSpeed.X *= -1;
            if (tribbleBrownRect.Y > _graphics.PreferredBackBufferHeight || tribbleBrownRect.Y < 0)
                tribbleBrownSpeed.Y *= -1;

            tribbleCreamRect.X += (int)tribbleCreamSpeed.X;
            tribbleCreamRect.Y += (int)tribbleCreamSpeed.Y;
            if (tribbleCreamRect.Right > _graphics.PreferredBackBufferWidth || tribbleCreamRect.X < 0)
                tribbleCreamSpeed.X *= -1;
            if (tribbleCreamRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleCreamRect.Y < 0)
                tribbleCreamSpeed.Y *= -1;

            tribbleOrangeRect.X += (int)tribbleOrangeSpeed.X;
            tribbleOrangeRect.Y += (int)tribbleOrangeSpeed.Y;
            if (tribbleOrangeRect.Right > _graphics.PreferredBackBufferWidth || tribbleOrangeRect.X < 0)
                tribbleOrangeSpeed.X *= -1;
            if (tribbleOrangeRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleOrangeRect.Y < 0)
                tribbleOrangeSpeed.Y *= -1;




            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(tribbleBackgroundTexture, tribbleBackgroundRect, Color.White);
            _spriteBatch.Draw(tribbleGreyTexture, tribbleGreyRect, Color.White);
            _spriteBatch.Draw(tribbleBrownTexture, tribbleBrownRect, Color.White);
            _spriteBatch.Draw(tribbleCreamTexture, tribbleCreamRect, Color.White);
            _spriteBatch.Draw(tribbleOrangeTexture, tribbleOrangeRect, Color.White);



            _spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
