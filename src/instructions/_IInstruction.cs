using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8dis.instructions
{
    interface IInstruction
    {
        bool Match(ushort u);
        string Emit(ushort u);
    }
}
