using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8dis.instructions
{
    class SKNP : IInstruction
    {
        public String Emit(UInt16 u)
        {
            return "SKNP V" + Nibble.Get(u, 2);
        }

        public Boolean Match(UInt16 u)
        {
            return Nibble.Get(u, 3) == 0x0E &&
                   Nibble.Get(u, 1) == 0x0A &&
                   Nibble.Get(u, 0) == 0x01;
        }
    }
}
