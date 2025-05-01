using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private bool Order{get;set;}

        public CompareByName(bool input_order)
        {
            Order = input_order;
        }
        public int Compare(Player x, Player y)
        {
            int compared_name = 0;
            if(this.Order == true)
            {
                compared_name= x.Name.CompareTo(y.Name);
            }
            else if(this.Order == false)
            {
                compared_name= y.Name.CompareTo(x.Name);
            }
            return compared_name;
        }
    }
}