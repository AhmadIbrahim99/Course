using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.FirstStage
{
    public class Move
    {
        public double xMove { get; set; }
        public double zMove { get; set; }
        public double speed{ get; set; }
        public bool isJump { get; set; }

        virtual public void movement() 
        {
            // movement
        }
        virtual public void jumb()
        {
            if (isJump) return;

            isJump = true;
            // jumb
        }



    }
}
