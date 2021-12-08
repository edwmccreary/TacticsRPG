using System;

namespace TacticsRPG.Models
{
    public class Grid
    {
        public int length {get;set;} = 10;
        public int width {get;set;} = 10;

        //public Tile[,] grid {get;set;} = new Tile[10,10];
        public Tile[,] grid {get;set;}

        public Grid(int length, int width){
            this.length = length;
            this.width = width;
            int id = 0;
            grid = new Tile[length,width];
            for(int col = 0; col < length; col++){
                for(int row = 0; row < width; row++){
                    grid[col,row] = new Tile(id,0);
                    id++;
                }
            }
            grid[0,0].type = 1;
        }

        

    }
}