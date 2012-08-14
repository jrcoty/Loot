// Jonathan Coty
// 26-Jun-2012

// Stage Class
// Handles the background and level generation 

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Loot.Layout
{
    class Stage
    {

        private Vector2 vector;
        private Rectangle rect;

        private Layout.Header header = new Layout.Header(); 

        #region Constructor

        public Stage()
        {

            // Nothing to initialize

        }

        #endregion

        #region Update

        public void Update(GameTime time)
        {

            header.Update(time); 

        }

        #endregion

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
                    rect = Tiles.tile_Rect(global_vars.Layout[n, m]);

                    // Draw the tile from the global spritesheet
                    batch.Draw(global_vars.Sprite_Sheet, vector, rect, global_vars.Sprite_Color);

                }

            }

        }

        #endregion

    }
}
