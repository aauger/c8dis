using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using c8dis.instructions;

namespace c8dis
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryReader br = new BinaryReader(new FileStream(args[0], FileMode.Open));
            StreamWriter sw = new StreamWriter(args[1]);

            IInstruction[] inst = new IInstruction[] {
                new CLS(),
                new SCD(),
                new SCR(),
                new SCL(),
                new EXIT(),
                new LOW(),
                new HIGH(),
                new RET(),
                //new SYS(),
                new JP(),
                new CALL(),
                new SE(),
                new SNE(),
                new SE2(),
                new LD(),
                new ADD(),
                new LD2(),
                new OR(),
                new AND(),
                new XOR(),
                new ADD2(),
                new SUB(),
                new SHR(),
                new SUBN(),
                new SHL(),
                new SNE2(),
                new LD3(),
                new JP2(),
                new RND(),
                new DRW2(),
                new DRW(),
                new SKP(),
                new SKNP(),
                new LD4(),
                new LD5(),
                new LD6(),
                new LD7(),
                new ADD3(),
                new LD8(),
                new LD9(),
                new LD10(),
                new LD11(),
                new LD12(),
                new LD13(),
                new LD14(),
                new DEFAULT()
            };


            while (br.BaseStream.Position != br.BaseStream.Length)
            {
                UInt16 u = Nibble.SwapEndianness(br.ReadUInt16());

                foreach (IInstruction i in inst)
                {
                    if (i.Match(u))
                    {
                        sw.WriteLine(i.Emit(u));
                        break;
                    }
                }
            }

            br.Close();
            sw.Close();
        }
    }
}
