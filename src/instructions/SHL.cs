using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8dis.instructions
{
    class SHL : IInstruction
    {
        public String Emit(UInt16 u)
        {
            return "SHL V" + Nibble.Get(u, 2) + ", V" + Nibble.Get(u, 1);
        }

        public Boolean Match(UInt16 u)
        {
            return Nibble.Get(u, 3) == 0x08 && Nibble.Get(u, 0) == 0x0E;
        }
    }
}
