using GameJun.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameJun
{
    public class Melee : AbstractCharacter
    {
        public Melee()
        {
            health = 15;
            defense = 7;
            damage = 3;
            name = "Ближник";
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
            else
            {
                return false;
            }
        }
    }
}
