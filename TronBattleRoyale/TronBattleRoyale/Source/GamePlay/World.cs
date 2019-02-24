using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace TronBattleRoyale
{

    public class World
    {

        public Player player;

        public World()
        {

            player = new Player("2d//Tron Bikes//Bike1", new Vector2(300, 300), new Vector2(48, 48));

        }

        public virtual void Update()
        {

            player.Update();
               
        }

        public virtual void Draw()
        {

            player.Draw();

        }

    }
}
