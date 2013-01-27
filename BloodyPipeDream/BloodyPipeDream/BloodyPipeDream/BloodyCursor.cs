﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BloodyPipeDream
{
    class BloodyCursor
    {
        private int grid_x;
        private int grid_y;
		private int Width, Height;
		private int Thickness;

        BloodyTile next_tile = null; // the tile next in the queue

        public BloodyCursor(int width, int height)
        {
            grid_x = 1;
            grid_y = 1;

			Width = width;
			Height = height;
			Thickness = 2;
        }

        public Vector2 getGridPosition()
        {
            return new Vector2(grid_x, grid_y);
        }

        public void setGridPosition(int grid_x, int grid_y)
        {
            this.grid_x = grid_x;
            this.grid_y = grid_y;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle r = new Rectangle(grid_x * Width, grid_y * Height, Width, Height);
			Border border = new Border(r, Thickness, Color.Yellow);
			border.Draw(spriteBatch);
        }
    }
}
