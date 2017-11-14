using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8dis.instructions
{
    public class JP : IInstruction
    {
        public String Emit(UInt16 u)
        {
            return "JP " + ((Nibble.Get(u, 2) << 8) | (Nibble.Get(u, 1) << 4) | Nibble.Get(u, 0));
        }

        public Boolean Match(UInt16 u)
        {
            return Nibble.Get(u, 3) == 0x01;
        }
    }
}
