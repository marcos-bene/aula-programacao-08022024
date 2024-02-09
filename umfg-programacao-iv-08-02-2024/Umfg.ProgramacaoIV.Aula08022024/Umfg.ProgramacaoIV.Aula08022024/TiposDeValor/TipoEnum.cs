using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.ProgramacaoIV.Aula08022024.Enums;

namespace Umfg.ProgramacaoIV.Aula08022024.TiposDeValor
{
    internal class TipoEnum
    {
        public void Executar()
        {
            var diasUteis = TipoDiasDaSemana.Segunda
                | TipoDiasDaSemana.Terca
                | TipoDiasDaSemana.Quarta
                | TipoDiasDaSemana.Quinta
                | TipoDiasDaSemana.Sexta;

            var finalDeSemana = TipoDiasDaSemana.Sabado
                | TipoDiasDaSemana.Domingo;

            var naoIdentificado = TipoDiasDaSemana.NaoIdentificado;

            Console.WriteLine(diasUteis.Equals(TipoDiasDaSemana.Quarta));
            Console.WriteLine(finalDeSemana.Equals(TipoDiasDaSemana.Segunda));
            Console.WriteLine(naoIdentificado);
        }
    }
}
