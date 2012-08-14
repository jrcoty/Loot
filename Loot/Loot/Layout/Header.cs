// Jonathan Coty
// 28-Jun-2012

// Header Class
// Handles the Header

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Loot.Layout
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
                    rect = Tiles.header_Tiles(global_vars.Header[n, m]);

                    // Draw the tile from the global spritesheet
                    batch.Draw(global_vars.Sprite_Sheet, vector, rect, global_vars.Sprite_Color);

                }

            }

        }

        #endregion

    }
}
