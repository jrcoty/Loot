// Jonathan Coty
// 27-Jun-2012

// Player One class

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Loot.Players
{

    public enum PlayerState
    {
        standing,
        moving,
        attacking,
        attack_over
    }

    class Player_One
    {

        // Sprite sheet variables
        private Rectangle rect;

        private int s_x_pos = 1;
        private int s_y_pos = 28;

        private int frame = 1; 

        // Player One variables
        private float x_pos = 144f;
        private float y_pos = 128f;

        private Boolean mirror = false;

        private float x_spd = 0f;
        private float y_spd = 0f;

        private const float max_x_spd = 0.6f;
        private const float max_y_spd = 0.6f; 

        private float eTime;
        private float mTime;

        private SpriteEffects m_effect;

        private PlayerState p_state; 

        // Player Controls
        private Player_One_Controls poc = new Player_One_Controls();

        #region Constructor

        // Initialize Player One with the correct sprite 
        // location
        public Player_One()
        {

            rect = new Rectangle(s_x_pos, s_y_pos, global_vars.Sprite_Width, global_vars.Sprite_Height); 

        }

        #endregion  

        #region Update

        public void Update(GameTime time)
        {

            eTime += (float)time.ElapsedGameTime.TotalMilliseconds;

            mTime = (float)time.ElapsedGameTime.TotalSeconds; 

            // Call to check for a Key Press
            poc.key_press(ref x_spd, ref y_spd, ref mirror, ref p_state, max_x_spd, max_y_spd, mTime);

            // Updates the X-Position based on the speed
            x_pos += x_spd; 

            switch_Frame(); 

        }

        // Sub to switch the sprite's frames
        private void switch_Frame()
        {

            switch (p_state)
            {

                case PlayerState.moving:

                    if (eTime > 100f)
                    {

                        switch (frame)
                        {

                            case 1:
                                s_x_pos = 19;
                                s_y_pos = 28;

                                frame++;

                                break;

                            case 2:
                                s_x_pos = 28;
                                s_y_pos = 28;

                                frame++;

                                break;

                            case 3:
                                s_x_pos = 37;
                                s_y_pos = 28;

                                frame = 1;

                                break;

                            case 4:
                                s_x_pos = 10;
                                s_y_pos = 28;

                                frame = 1;

                                break;

                            default:
                                frame = 1;
                                break;

                        }

                        eTime = 0f;

                    }

                    break;

                case PlayerState.attacking:

                    if (eTime > 300f)
                    {

                        s_x_pos = 28;
                        s_y_pos = 28;

                        p_state = PlayerState.attack_over; 

                    }
                    else
                    {

                        s_x_pos = 46;
                        s_y_pos = 28;

                    }

                    eTime = 0f; 

                    break;

                default:

                    if (eTime > 500f)
                    {

                        switch (frame)
                        {

                            case 1:
                                s_x_pos = 10;
                                s_y_pos = 28;

                                frame++;

                                break;

                            case 2:
                                s_x_pos = 1;
                                s_y_pos = 28;

                                frame--;

                                break;

                            default:
                                frame = 1;
                                break;

                        }

                        eTime = 0f;

                    }
                    break;

            }

            rect = new Rectangle(s_x_pos, s_y_pos, global_vars.Sprite_Width, global_vars.Sprite_Height); 

        }

        #endregion  

        #region Draw

        // Draw the Player One sprite
        public void Draw(SpriteBatch batch)
        {

            if (mirror) { m_effect = SpriteEffects.FlipHorizontally; } else { m_effect = SpriteEffects.None; }

            // batch.Draw(global_vars.Sprite_Sheet, new Vector2(x_pos, y_pos), rect, global_vars.Sprite_Color);

            batch.Draw(global_vars.Sprite_Sheet, new Vector2(x_pos, y_pos), rect, global_vars.Sprite_Color, 0f, new Vector2(0, 0), 1, m_effect, 0f); 

            batch.DrawString(global_vars.Font, "(" + x_pos.ToString() + ", " + y_pos.ToString() + ") \n"
                             + "X_Spd: " + x_spd.ToString() + "\n Y_Spd: " + y_spd.ToString() + "\n" 
                             + "Time Factor: " + mTime.ToString(), new Vector2(10, 10), Color.White); 
        }

        #endregion  

    }
}
