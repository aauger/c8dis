using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8dis.instructions
{
    public class SE2 : IInstruction
    {
        public String Emit(UInt16 u)
        {
            return "SE V" + Nibble.Get(u, 2) + ", V" + Nibble.Get(u, 1);
        }

        public Boolean Match(UInt16 u)
        {
            return Nibble.Get(u, 3) == 0x05 && Nibble.Get(u, 0) == 0x00;
        }
    }
}

