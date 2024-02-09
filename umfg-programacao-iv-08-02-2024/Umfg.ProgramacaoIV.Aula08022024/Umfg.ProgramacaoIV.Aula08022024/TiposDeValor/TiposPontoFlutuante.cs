using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.ProgramacaoIV.Aula08022024.TiposDeValor
{
    internal class TiposPontoFlutuante
    {
        public void Executar()
        {
            #region Tipos Ponto Flutuante

            var pontoFlutuanteDouble = 1.33;
            var pontoFlutuanteFloat = 1.33f;
            var pontoFlutuanteDecimal = 1.33m;

            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            Console.WriteLine(10.10f + 20.20f == 30.30f);
            Console.WriteLine(10.10f + 20.20f);

            Console.WriteLine(10.10m + 20.20m == 30.30m);
            Console.WriteLine(10.10m + 20.20m);

            #endregion Tipos Ponto Flutuante
        }
    }
}