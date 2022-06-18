using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.FirstStage
{
    public class Enemy : Player
    {
        protected override void DoDamge(int damage)
        {
            base.DoDamge(damage);
        }
        public override void takeDamge(int damage = 20)
        {
            DoDamge(damage);   
        }
    }
}
