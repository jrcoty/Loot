// Jonathan Coty
// 17-Jul-2012

// Controls for Player One

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Loot
{
    class Player_One_Controls
    {

        #region Constructor

        public Player_One_Controls()
        {

        }

        #endregion

        #region Key Controls

        public void key_press(ref float x_spd, ref float y_spd, ref Boolean mirror, ref Boolean moving, 
            float max_x, float max_y, float time)
        {

            // Controls the Left Key
            if (Keyboard.GetState().IsKeyDown(global_vars.P_1_Left))
            {

                mirror = false;
                moving = true; 

                // Checks if the max speed has been reached
                if (x_spd > -(max_x))
                {
                    x_spd -= time;
                }

            }
            
            // Controls the Right Key 
            if (Keyboard.GetState().IsKeyDown(global_vars.P_1_Right)) 
            {

                mirror = true;
                moving = true; 

                // Checks if the max speed has been reached
                if (x_spd < max_x)
                {
                    x_spd += time;
                }

            }
            
            // Checks that no keys are being pressed
            if (Keyboard.GetState().IsKeyUp(global_vars.P_1_Left) && Keyboard.GetState().IsKeyUp(global_vars.P_1_Right))
            {

                // Create the slowdown factor (Twice the speeding up)
                float res = 2f * time;

                // Decide which direction the sprite
                // is moving
                if (mirror)
                {

                    // Decides whether to apply the resistance or
                    // set to 0 if slow enough
                    if ((x_spd - res) < 0)
                    {

                        x_spd = 0f;
                        moving = false; 

                    }
                    else
                    {
                        x_spd -= res;
                    }

                }
                else
                {

                    // Decides whether to apply the resistance or
                    // set to 0 if slow enough
                    if ((x_spd + res) > 0)
                    {

                        x_spd = 0f;
                        moving = false; 

                    }
                    else
                    {
                        x_spd += res;
                    }

                }

            }

        }

        #endregion

    }
}
