﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGame
{
    public interface ISeaGrid
    {

        int Width
        {
        }
        int Height
        {

        }

        // '' <summary>
        // '' Indicates that the grid has changed.
        // '' </summary>
        event EventHandler Changed;

        // '' <summary>
        // '' Provides access to the given row/column
        // '' </summary>
        // '' <param name="row">the row to access</param>
        // '' <param name="column">the column to access</param>
        // '' <value>what the player can see at that location</value>
        // '' <returns>what the player can see at that location</returns>
        TileView Item(int row, int column)
        {
        }

        // '' <summary>
        // '' Mark the indicated tile as shot.
        // '' </summary>
        // '' <param name="row">the row of the tile</param>
        // '' <param name="col">the column of the tile</param>
        // '' <returns>the result of the attack</returns>
        AttackResult HitTile(int row, int col)
        {
        }
    }
}
