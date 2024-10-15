using Inlämningsuppgift2_ShotgunGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift2_ShotgunGame.Abstracts
{
    public abstract class ShotgunParticipant
    {
        public string Name { get; set; }
        public int CurrentAmmo { get; set; }
        public MoveType Move { get; set; }

        protected ShotgunParticipant(string name, int currentAmmo)
        {
            Name = name;
            CurrentAmmo = currentAmmo;
        }
        public void ChooseMove(MoveType move)
        {
            Move = move;
        }

        public virtual void LoadAmmo()
        {
            Move = MoveType.Reload;
            IncreaseAmmo();
        }

        public virtual void Shoot()
        {
            Move = MoveType.Shoot;
            DecreaseAmmo();
        }

        public virtual void Block()
        {
            Move = MoveType.Block;
        }


        public virtual void ShotgunFinish()
        {
            Move = MoveType.Shotgun;
            ShotgunDecrease();
        }

        public virtual void DecreaseAmmo()
        {

            CurrentAmmo--;

        }
        public virtual void IncreaseAmmo()
        {

            CurrentAmmo++;

        }

        public virtual void ShotgunDecrease()
        {

            CurrentAmmo -=3;

        }
    }
}
