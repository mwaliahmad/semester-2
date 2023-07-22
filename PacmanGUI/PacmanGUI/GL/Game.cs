using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace PacmanGUI.GL
{
    public class Game
    {
        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.NONE,Properties.Resources.simplebox);
            return blankGameObject;
        }
        public static GameObject getRewardGameObject()
        {
            GameObject palletGameObject = new GameObject(GameObjectType.REWARD, Properties.Resources.pallet);
            return palletGameObject;
        }
        public static Image getGameObjectImage(char displayCharacter)
        {
            Image img = Properties.Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                img = Properties.Resources.vertical;
            }

            if (displayCharacter == '#')
            {
                img = Properties.Resources.horizontal;
            }

            if (displayCharacter == '.')
            {
                img = Properties.Resources.pallet;
            }
            if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                img =Properties.Resources.pacman_open;
            }
            if (displayCharacter == 'H' || displayCharacter == 'h')
            {
                img = Properties.Resources.ghost_blue;
            }
            if (displayCharacter == 'V' || displayCharacter == 'v')
            {
                img = Properties.Resources.ghost_orange;
            }
            if (displayCharacter == 'R' || displayCharacter == 'r')
            {
                img = Properties.Resources.ghost_fright;
            }
            if (displayCharacter == 'S' || displayCharacter == 's')
            {
                img = Properties.Resources.ghost_pink;
            }
            return img;
        }
    }
}