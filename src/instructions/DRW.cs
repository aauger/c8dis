using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8dis.instructions
{
    class DRW : IInstruction
    {
        public String Emit(UInt16 u)
        {
            return "DRW V" + Nibble.Get(u, 2) + ", V" + Nibble.Get(u, 1) + ", " + Nibble.Get(u, 0);
        }

        public Boolean Match(UInt16 u)
        {
            return Nibble.Get(u, 3) == 0x0D;
        }
    }
}
