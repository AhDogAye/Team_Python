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
    public class Player : Unit
    {

        public McTimer attackTimer = new McTimer(125);

        public Player(string PATH, Vector2 POS, Vector2 DIMS) : base(PATH, POS, DIMS)
        {

        }

        public override void Update()
        {
            if (Globals.keyboard.GetPress("A"))
            {
                if (pos.X > 25)
                {
                    pos = new Vector2(pos.X - 10, pos.Y);
                }
            }

            else if (Globals.keyboard.GetPress("D"))
            {
                if (pos.X < 775)
                {
                    pos = new Vector2(pos.X + 10, pos.Y);
                }
            }

            else if (Globals.keyboard.GetPress("W"))
            {
                if (pos.Y > 25)
                {
                    pos = new Vector2(pos.X, pos.Y - 10);
                }
            }

            else if (Globals.keyboard.GetPress("S"))
            {
                if (pos.Y < 455)
                {
                    pos = new Vector2(pos.X, pos.Y + 10);
                }
            }

            base.Update();
        }

        public override void Draw()
        {
            base.Draw();
        }

    }
}
