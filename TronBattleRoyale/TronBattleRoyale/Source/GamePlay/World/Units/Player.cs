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
        public int direction = 0;
        public int moving = 0;
        public Player(string PATH, Vector2 POS, Vector2 DIMS) : base(PATH, POS, DIMS)
        {

        }

        public override void Update()
        {
            //while (moving < 100)
            
                if (Globals.keyboard.GetPress("A") && direction != 2)
                {
<<<<<<< HEAD
                    pos = new Vector2(pos.X - 3, pos.Y);
=======
                    if (pos.X > 25)
                    {
                        pos = new Vector2(pos.X - 10, pos.Y);
                        direction = 1;
                    }
>>>>>>> origin/eli
                }

                else if (Globals.keyboard.GetPress("D") && direction != 1)
                {
<<<<<<< HEAD
                    pos = new Vector2(pos.X + 3, pos.Y);
=======
                    if (pos.X < 775)
                    {
                        pos = new Vector2(pos.X + 10, pos.Y);
                        direction = 2;
                    }
>>>>>>> origin/eli
                }

                else if (Globals.keyboard.GetPress("W") && direction != 4)
                {
<<<<<<< HEAD
                    pos = new Vector2(pos.X, pos.Y - 3);
=======
                    if (pos.Y > 25)
                    {
                        pos = new Vector2(pos.X, pos.Y - 10);
                        direction = 3; // if going up wont let you go down
                    }
>>>>>>> origin/eli
                }

                else if (Globals.keyboard.GetPress("S") && direction != 3)
                {
<<<<<<< HEAD
                    pos = new Vector2(pos.X, pos.Y + 3);
=======
                    if (pos.Y < 455)
                    {
                        pos = new Vector2(pos.X, pos.Y + 10);
                        direction = 4;
                    }
>>>>>>> origin/eli
                }

                base.Update();
            
        }

        public override void Draw()
        {
            base.Draw();
        }

    }
}
