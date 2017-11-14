using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8dis.instructions
{
    class DEFAULT : IInstruction
    {
        public String Emit(UInt16 u)
        {
            return "0x" + u.ToString("X4");
        }

        public Boolean Match(UInt16 u)
        {
            return true;
        }
    }
}
