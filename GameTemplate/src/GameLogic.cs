﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwinGameSDK;
using static SwinGameSDK.SwinGame; // requires mcs version 4+, 
// using SwinGameSDK.SwinGame; // requires mcs version 4+, 

namespace MyGame
{
    public class GameLogic
    {
        public static void Main()
        {
            // Opens a new Graphics Window
            SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);
            // Load Resources
            LoadResources();
            SwinGame.PlayMusic(GameMusic("Background"));
            // Game Loop
            for (
            ; (((SwinGame.WindowCloseRequested() == true)
                        || (CurrentState == GameState.Quitting))
                        == false);
            )
            {
                HandleUserInput();
                DrawScreen();
            }

            SwinGame.StopMusic();
            // Free Resources and Close Audio, to end the program.
            FreeResources();
        }
    }
}
