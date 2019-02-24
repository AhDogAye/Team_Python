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
<<<<<<< HEAD
        public Basic2d background;
        public Basic2d backBackground;
        public World()
        {
            backBackground = new TronBattleRoyale.Basic2d("2d\\Board\\Black", new Vector2(Globals.screenWidth / 2, Globals.screenHeight / 2), new Vector2(Globals.screenWidth, Globals.screenHeight));
            background = new Basic2d("2d\\Board\\Background", new Vector2(Globals.screenWidth/2, Globals.screenHeight/2 - 75), new Vector2(Globals.screenWidth, Globals.screenHeight - 75));
=======

        public Player player;

        public World()
        {

            player = new Player("2d//Tron Bikes//Bike1", new Vector2(300, 300), new Vector2(48, 48));

>>>>>>> 54397cd57dd9afb9e3033ad5b8a92258a9d7de82
        }

        public virtual void Update()
        {

            player.Update();
               
        }

        public virtual void Draw()
        {
<<<<<<< HEAD
            backBackground.Draw();
            background.Draw();
            
=======

            player.Draw();

>>>>>>> 54397cd57dd9afb9e3033ad5b8a92258a9d7de82
        }

    }
}
