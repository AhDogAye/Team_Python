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
        public Basic2d background;
        public Basic2d backBackground;
        public World()
        {
            backBackground = new TronBattleRoyale.Basic2d("2d\\Board\\Black", new Vector2(Globals.screenWidth / 2, Globals.screenHeight / 2), new Vector2(Globals.screenWidth, Globals.screenHeight));
            background = new Basic2d("2d\\Board\\Background", new Vector2(Globals.screenWidth/2, Globals.screenHeight/2 - 75), new Vector2(Globals.screenWidth, Globals.screenHeight - 75));
        }

        public virtual void Update()
        {
            
        }

        public virtual void Draw()
        {
            backBackground.Draw();
            background.Draw();
            
        }

    }
}
