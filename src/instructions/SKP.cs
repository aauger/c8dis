using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8dis.instructions
{
    class SKP : IInstruction
    {
        public String Emit(UInt16 u)
        {
            return "SKP V" + Nibble.Get(u, 2);
        }

        public Boolean Match(UInt16 u)
        {
            return Nibble.Get(u, 3) == 0x0E &&
                   Nibble.Get(u, 1) == 0x09 &&
                   Nibble.Get(u, 0) == 0x0E;
        }
    }
}
