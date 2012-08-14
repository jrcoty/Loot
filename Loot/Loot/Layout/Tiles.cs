// Jonathan Coty
// 11-Aug-2012

// Returns rectangle object of specified tile
// object 

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Loot.Layout
{
    static class Tiles
    {

        // Uses the value from the global_vars layout 
        // variable to return correct rectangle object
        public static Rectangle stage_Tiles(int tile_Val)
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

        // Uses the value from the global_vars header
        // variable to return correct rectangle object
        public static Rectangle header_Tiles(int tile_Val)
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
                    x_temp = 55;
                    y_temp = 28;
                    break;

                case 5:
                    x_temp = 64;
                    y_temp = 28;
                    break;

                case 6:
                    x_temp = 55;
                    y_temp = 37;
                    break;

                case 7:
                    x_temp = 64;
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

    }
}
