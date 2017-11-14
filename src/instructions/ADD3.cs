using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8dis.instructions
{
    class ADD3 : IInstruction
    {
        public String Emit(UInt16 u)
        {
            return "ADD I, V" + Nibble.Get(u, 2);
        }

        public Boolean Match(UInt16 u)
        {
            return Nibble.Get(u, 3) == 0x0F &&
                   Nibble.Get(u, 1) == 0x01 &&
                   Nibble.Get(u, 0) == 0x0E;
        }
    }
}
