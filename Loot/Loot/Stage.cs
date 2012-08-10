// Jonathan Coty
// 26-Jun-2012

// Stage Class
// Handles the background and level generation 

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Loot
{
    class Stage
    {

        private Vector2 vector;
        private Rectangle rect;

        private Header header = new Header(); 

        #region Constructor

        public Stage()
        {

            // Nothing to initialize

        }

        #endregion

        public void Update(GameTime time)
        {

            header.Update(time); 

        }

        #region Draw

        public void Draw(SpriteBatch batch)
        {

            float temp_x, temp_y;

            batch.Draw(global_vars.Background, new Vector2(0,0), new Rectangle(0, 0, global_vars.ScreenWidth, global_vars.ScreenHeight), global_vars.Sprite_Color);

            header.Draw(batch); 

            // Nested for loop that cycles through the layout 
            // array
            for (int n = 0; n < global_vars.Layout_Row; n++)
            {

                for (int m = 0; m < global_vars.Layout_Col; m++)
                {

                    // Add the offset value from the background
                    temp_x = (float)m * global_vars.Sprite_Width;

                    temp_y = (float)(n * global_vars.Sprite_Height) + global_vars.Y_Offset;

                    vector = new Vector2(temp_x, temp_y);

                    // Retrieve the desired tile from the global spritesheet
                    rect = tile_Rect(global_vars.Layout[n, m]);

                    // Draw the tile from the global spritesheet
                    batch.Draw(global_vars.Sprite_Sheet, vector, rect, global_vars.Sprite_Color);

                }

            }

        }

        #endregion

        #region Tiles

        private Rectangle tile_Rect(int tile_Val)
        {

            int x_temp, y_temp;

            switch (tile_Val)
            {

                case 1:
                    x_temp = 1;
                    y_temp = 1;
                    break;

                case 2:
                    x_temp = 10;
                    y_temp = 1;
                    break;

                case 3:
                    x_temp = 19;
                    y_temp = 1;
                    break;

                case 4:
                    x_temp = 1;
                    y_temp = 10;
                    break;

                case 5:
                    x_temp = 10;
                    y_temp = 10;
                    break;

                case 6:
                    x_temp = 19;
                    y_temp = 10;
                    break;

                case 7:
                    x_temp = 1;
                    y_temp = 19;
                    break;

                case 8:
                    x_temp = 28;
                    y_temp = 1;
                    break;

                case 9:
                    x_temp = 37;
                    y_temp = 1;
                    break;

                case 10:
                    x_temp = 28;
                    y_temp = 10;
                    break;

                case 11:
                    x_temp = 52;
                    y_temp = 35;
                    break;

                case 12:
                    x_temp = 35;
                    y_temp = 52;
                    break;

                case 13:
                    x_temp = 52;
                    y_temp = 52;
                    break;

                case 14:
                    x_temp = 35;
                    y_temp = 69;
                    break;

                case 15:
                    x_temp = 52;
                    y_temp = 69;
                    break;

                case 16:
                    x_temp = 1;
                    y_temp = 52;
                    break;

                case 17:
                    x_temp = 18;
                    y_temp = 52;
                    break;

                case 18:
                    x_temp = 1;
                    y_temp = 69;
                    break;

                case 19:
                    x_temp = 18;
                    y_temp = 69;
                    break;

                case 20:
                    x_temp = 1;
                    y_temp = 86;
                    break;

                case 21:
                    x_temp = 35;
                    y_temp = 86;
                    break;

                case 22:
                    x_temp = 18;
                    y_temp = 86;
                    break;

                case 23:
                    x_temp = 52;
                    y_temp = 86;
                    break;

                default:
                    x_temp = 10;
                    y_temp = 19;
                    break;

            }

            return new Rectangle(x_temp, y_temp, global_vars.Sprite_Width, global_vars.Sprite_Height);

        }

        #endregion

    }
}
