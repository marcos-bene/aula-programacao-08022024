using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.ProgramacaoIV.Aula08022024.TiposDeValor
{
    internal class TiposInteiros
    {
        public void Executar()
        {
            #region Tipos Inteiros

            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);

            var inteiroUm = int.MinValue;
            var inteiroDois = int.MaxValue;

            Console.WriteLine(inteiroUm);
            Console.WriteLine(inteiroDois);

            var inteiroTres = uint.MinValue;
            var inteiroQuatro = uint.MaxValue;

            Console.WriteLine(inteiroTres);
            Console.WriteLine(inteiroQuatro);

            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);

            #endregion Tipos Inteiros
        }
    }
}