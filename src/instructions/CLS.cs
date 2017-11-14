using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8dis.instructions
{
    public class CLS : IInstruction
    {
        public String Emit(UInt16 u)
        {
            return "CLS";
        }

        public Boolean Match(UInt16 u)
        {
            if (Nibble.Get(u, 0) == 0x00 &&
                Nibble.Get(u, 1) == 0x0E &&
                Nibble.Get(u, 2) == 0x00 &&
                Nibble.Get(u, 3) == 0x00)
                return true;
            return false;
        }
    }
}
