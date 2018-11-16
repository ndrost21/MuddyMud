using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }

        public HealingPotion(int iD, string name, string namePlural, int amountToHeal) : base(iD, name, namePlural)
        {
            ID = iD;
            Name = name;
            NamePlural = namePlural;
            AmountToHeal = amountToHeal;
        }
    }
}
