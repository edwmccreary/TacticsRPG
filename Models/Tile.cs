using System;

namespace TacticsRPG.Models
{
    public class Tile
    {
        public int type {get;set;} = 0;
        public int id {get;set;} = 0;

        public Tile(int id, int type){
            this.id = id;
            this.type = type;
        }

        

    }
}