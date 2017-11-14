using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8dis
{
    class Nibble
    {
        public static byte Get(ushort i, int nib)
        {
            return (byte)((i & (0x0F << nib*4)) >> nib*4);
        }

        public static UInt16 SwapEndianness(UInt16 u)
        {
            return (ushort)((u >> 8) | (u << 8));
        }
    }
}
