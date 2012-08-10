// Jonathan Coty
// 25-Jun-2012

// Global variables for Loot

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace Loot
{
    static class global_vars
    {

        // Global Screen Variables
        private static int screen_width = 480; //160;
        private static int screen_height = 432; //144;
        private static float scale_x = 3f;
        private static float scale_y = 3f;
        private const float scale_z = 1f;
        private const float y_offset = 32f;
        private const float y_h_offset = 5f;
        private const float x_h_offset = 16f; 
        private static Boolean screen_nat = true; 

        // Sprite variables
        private const string sheet_name = "sprite_sheet"; 
        private static Texture2D sprite_sheet;

        private const int sprite_width = 8;
        private const int sprite_height = 8; 

        private static Color sprite_color = Color.White; 

        // Player 1 Controls
        private static Keys p_one_left = Keys.A;
        private static Keys p_one_righ = Keys.D;
        private static Keys p_one_a = Keys.K;
        private static Keys p_one_b = Keys.J;

        // Stage Variables
        private const string back_name = "background";
        private static Texture2D background;

        // Global State Variables
        // private static GameState g_state; 
        
        private static int o_Score = 0;
        private static int t_Score = 0;

        private enum GameState
        {
            start, 
            normal, 
            paused
        }

        // **DEBUG**
        private static SpriteFont font; 

        // Global Header Information
        private static int header_col = 28;
        private static int header_row = 2;
        private static int[,] header = new int[,] {{-1, 1, -7, 4, -12, 3, -20, 3, -28, 3, -36, 0, -44, 0, -35, 2, -41, 6, -46, 3, -54, 3, -62, 3, -70, 0, -78, 0},
                                                   {-1, 0, -7, 0, -12, 0, -20, 0, -28, 0, -36, 0, -44, 0, -35, 0, -41, 0, -46, 0, -54, 0, -62, 0, -70, 0, -78, 0}}; 

        // Global layout
        private static int layout_col = 20;
        private static int layout_row = 14;

        private static int[,] layout = new int[,] {{3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 4}, 
                                                   {3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9, 0, 0, 4}, 
                                                   {5, 5, 5, 5, 6, 9, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5},
                                                   {3, 0, 0, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4},
                                                   {3, 0, 0, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4},
                                                   {3, 0, 4, 5, 5, 5, 5, 5, 5, 5, 4, 9, 4, 5, 5, 5, 5, 5, 5, 5},
                                                   {3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, 4},
                                                   {3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, 4},
                                                   {3, 0, 0, 9, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 3, 0, 4},
                                                   {3, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4},
                                                   {3, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 4},
                                                   {3, 0, 0, 1, 1, 3, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4},
                                                   {3,10,10, 4, 5, 6, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4},
                                                   {5, 2, 2, 5, 5, 5, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 9, 4}};

        #region Screen Variables

        // Screen Width Get/Set
        public static int ScreenWidth
        {
            get { return screen_width; }
            set { screen_width = value; }
        }

        // Screen Height Get/Set
        public static int ScreenHeight
        {
            get { return screen_height; }
            set { screen_height = value; }
        }

        // X Scale Get/Set
        public static float XScale
        {
            get { return scale_x; }
            set { scale_x = value; }
        }

        // Y Scale Get/Set
        public static float YScale
        {
            get { return scale_y; }
            set { scale_y = value; }
        }

        // Z Scale Get
        public static float ZScale
        {
            get { return scale_z; }
        }

        // Y Offset
        public static float Y_Offset
        {
            get { return y_offset; }
        }

        // Screen Native Get/Set
        public static Boolean Screen_Native
        {
            get { return screen_nat; }
            set { screen_nat = value; }
        }

        #endregion

        #region State Variables

       // public static GameState Game_State
        //{
          //  get { return g_state; }
           // set { g_state = value; }
        //}

        // Player One Score Get/Set
        public static int O_SCore
        {
            get { return o_Score; }
            set { o_Score = value; }
        }

        // Player Two Score Get/Set
        public static int H_SCore
        {
            get { return t_Score; }
            set { t_Score = value; }
        }

        #endregion

        #region Header

        // Header Get
        public static int[,] Header
        {
            get { return header; }
        }

        // Header column Get
        public static int Header_Col
        {
            get { return header_col; }
        }

        // Header row get
        public static int Header_Row
        {
            get { return header_row; }
        }

        // Y Header Offset
        public static float Y_H_Offset
        {
            get { return y_h_offset; }
        }

        // X Header Offset
        public static float X_H_Offset
        {
            get { return x_h_offset; }
        }

        #endregion

        #region Layout

        // Layout Get
        public static int[,] Layout
        {
            get { return layout; }
        }

        // Layout column Get
        public static int Layout_Col
        {
            get { return layout_col; }
        }

        // Layout row get
        public static int Layout_Row
        {
            get { return layout_row; }
        }

        #endregion

        #region Display Variables

        // Font Get/Set
        public static SpriteFont Font
        {

            get { return font; }
            set { font = value; }

        }

        #endregion  

        #region Sprite Variables

        // Sprite sheet Get/Set
        public static Texture2D Sprite_Sheet
        {
            get { return sprite_sheet; }
            set { sprite_sheet = value; }
        }

        // Sprite sheet name Get
        public static string Sheet_Name
        {
            get { return sheet_name; }
        }

        // Sprite Width Get
        public static int Sprite_Width
        {
            get { return sprite_width; }
        }

        // Sprite Height Get
        public static int Sprite_Height
        {
            get { return sprite_height; }
        }

        // Sprite Color Get
        public static Color Sprite_Color
        {
            get { return sprite_color; }
        }

        // Background Get/Set
        public static Texture2D Background
        {
            get { return background; }
            set { background = value; }
        }

        // Background sheet name Get
        public static string Back_Name
        {
            get { return back_name; }
        }

        #endregion

        #region Player Controls

        // Player 1 Left movement Get/Set
        public static Keys P_1_Left
        {
            get { return p_one_left; }
            set { p_one_left = value; }
        }

        // Player 1 Right movement Get/Set
        public static Keys P_1_Right
        {
            get { return p_one_righ; }
            set { p_one_righ = value; }
        }

        #endregion

    }
}
