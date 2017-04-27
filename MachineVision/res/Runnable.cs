
//其他的类有应该继承这个

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineVision.res
{
    class Runnable
    {
        public Runnable() { sequence = 0; }
        private int sequence { get; set; }
        public void run() { int a = 0; }
        public int getsequence() { return sequence; }
        private void setsequence(int sequence) { this.sequence = sequence; }

    }
}
