using GameJun.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJun
{
    public class Archer : AbstractCharacter
    {
        public Archer()
        {
            health = 7;
            defense = 2;
            damage = 7;
            name = "Лучник";
        }
        public override void Attack(AbstractCharacter other)
        {
            other.Damage(damage);
        }

        public override void Damage(int amount)
        {
            health -= amount - defense;
        }

        public override string Name()
        {
            return name;
        }

        public override bool IsAlive()
        {
            if (health > 0)
            {
                return true;
            }
            return false;
        }
    }
}
