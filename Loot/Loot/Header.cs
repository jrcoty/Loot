// Jonathan Coty
// 28-Jun-2012

// Header Class
// Handles the Header

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Loot
{
    class Header
    {

        private Vector2 vector;
        private Rectangle rect;

        private float eTime; 


        #region Constructor

        public Header()
        {

            // Nothing to initialize

        }

        #endregion

        #region Update

        public void Update(GameTime time)
        {

            eTime += (float)time.ElapsedGameTime.TotalMilliseconds;

            switch_Frame(); 

        }

        // Sub to switch frame of character portrait
        private void switch_Frame()
        {

            // 
            if (eTime > 1000f)
            {

                if (global_vars.Header[0,3] == 4)
                {
                    
                    global_vars.Header[0,3] = 5; 

                }
                else
                {

                    global_vars.Header[0,3] = 4;

                }

                eTime = 0f;

            }

        }

        #endregion  

        #region Draw

        public void Draw(SpriteBatch batch)
        {

            float temp_x, temp_y;

            // Nested for loop that cycles through the header 
            // array
            for (int n = 0; n < global_vars.Header_Row; n++)
            {

                for (int m = 1; m < global_vars.Header_Col; m+=2)
                {

                    // Add the offset value from the background
                    temp_x = (float)(m * global_vars.Sprite_Width) + global_vars.Header[n, m - 1]; 


                    temp_y = (float)(n * global_vars.Sprite_Height) + global_vars.Y_H_Offset;

                    vector = new Vector2(temp_x, temp_y);

                    // Retrieve the desired tile from the global spritesheet
                    rect = tile_Rect(global_vars.Header[n, m]);

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
                    x_temp = 46;
                    y_temp = 1;
                    break;

                case 2:
                    x_temp = 55;
                    y_temp = 1;
                    break;

                case 3:
                    x_temp = 46;
                    y_temp = 11;
                    break;

                case 4:
                    x_temp = 46;
                    y_temp = 28;
                    break;

                case 5:
                    x_temp = 55;
                    y_temp = 28;
                    break;

                case 6:
                    x_temp = 46;
                    y_temp = 37;
                    break;

                case 7:
                    x_temp = 55;
                    y_temp = 37;
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
