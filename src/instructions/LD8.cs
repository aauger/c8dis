using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8dis.instructions
{
    class LD8 : IInstruction
    {
        public String Emit(UInt16 u)
        {
            return "LD F, V" + Nibble.Get(u, 2);
        }

        public Boolean Match(UInt16 u)
        {
            return Nibble.Get(u, 3) == 0x0F &&
                   Nibble.Get(u, 1) == 0x02 &&
                   Nibble.Get(u, 0) == 0x09;
        }
    }
}
