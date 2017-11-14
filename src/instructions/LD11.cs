using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8dis.instructions
{
    class LD11 : IInstruction
    {
        public String Emit(UInt16 u)
        {
            return "LD V" + Nibble.Get(u, 2) + ", [I]";
        }

        public Boolean Match(UInt16 u)
        {
            return Nibble.Get(u, 3) == 0x0F &&
                   Nibble.Get(u, 1) == 0x06 &&
                   Nibble.Get(u, 0) == 0x05;
        }
    }
}
