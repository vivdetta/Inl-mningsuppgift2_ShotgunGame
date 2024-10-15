using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlämningsuppgift2_ShotgunGame.Abstracts;

namespace Inlämningsuppgift2_ShotgunGame.Classes
{
    public class Player1 : ShotgunParticipant
    {
        public Player1(string name) : base(name: name, currentAmmo: 0)
        {

        }
       
    }
}
