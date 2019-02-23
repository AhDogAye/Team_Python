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
    public class Unit : Basic2d
    {

        public bool dead;
        public float hitDist;

        public Unit(string PATH, Vector2 POS, Vector2 DIMS) : base(PATH, POS, DIMS)
        {

            dead = false;

            hitDist = 20.0f;

        }

        public override void Update()
        {


            base.Update();
        }

        public virtual void GetHit()
        {

            dead = true;

        }

        public override void Draw()
        {
            base.Draw();
        }

    }
}
