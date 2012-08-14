// Jonathan Coty
// 17-Jul-2012

// Controls for Player One

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Loot.Players
{
    class Player_One_Controls
    {

        // private Boolean a_down = false;
        private const float t_Fac = 2f; 

        #region Constructor

        public Player_One_Controls()
        {

        }

        #endregion

        #region Key Controls

        public void key_press(ref float x_spd, ref float y_spd, ref Boolean mirror, ref PlayerState ps, 
            float max_x, float max_y, float time)
        {

            // Controls the Left Designated Key
            if (Keyboard.GetState().IsKeyDown(global_vars.P_1_Left))
            {

                mirror = false;
                ps = PlayerState.moving;

                // Curtails the sliding when quickly switching directions
                // if (x_spd > 0) { x_spd -= (time * 2f); }

                if (x_spd > 0) { time *= t_Fac; }

                // Checks if the max speed has been reached
                if (x_spd > -(max_x)) { x_spd -= time; }

            }

            // Controls the Right Designated Key 
            if (Keyboard.GetState().IsKeyDown(global_vars.P_1_Right)) 
            {

                mirror = true;
                ps = PlayerState.moving;

                // Curtails the sliding when quickly switching directions
                // if (x_spd < 0) { x_spd += (time * 2f); }
                if (x_spd < 0) { time *= t_Fac; }

                // Checks if the max speed has been reached
                if (x_spd < max_x) { x_spd += time; }

            }

            // Checks that no directional keys are being pressed
            // if (Keyboard.GetState().IsKeyUp(global_vars.P_1_Left) && Keyboard.GetState().IsKeyUp(global_vars.P_1_Right) || Keyboard.GetState().IsKeyDown(global_vars.P_1_A))
            if (Keyboard.GetState().IsKeyUp(global_vars.P_1_Left) && Keyboard.GetState().IsKeyUp(global_vars.P_1_Right))
            {

                // Create the slowdown factor (Twice that of speeding up)
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
                        ps = PlayerState.standing;  

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
                        ps = PlayerState.standing; 

                    }
                    else
                    {
                        x_spd += res;
                    }

                }

            }

            // Controls the A Designated Key
            //if (Keyboard.GetState().IsKeyDown(global_vars.P_1_A) && ps != PlayerState.attack_over)
            //{

            //    ps = PlayerState.attacking;
                
            //}

            //if (Keyboard.GetState().IsKeyUp(global_vars.P_1_A))
            //{
            //    a_down = false;
            //}

        }

        #endregion

    }
}
