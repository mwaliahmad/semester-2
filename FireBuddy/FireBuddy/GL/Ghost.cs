using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FireBuddy.GL
{
    public abstract class Ghost : GameObject
    {
        public Ghost(Image ghostImage,GameObjectType type) : base(type, ghostImage)
        {
        }

        public abstract GameCell nextCell();
        public abstract void move(GameCell gameCell);
    }
}

