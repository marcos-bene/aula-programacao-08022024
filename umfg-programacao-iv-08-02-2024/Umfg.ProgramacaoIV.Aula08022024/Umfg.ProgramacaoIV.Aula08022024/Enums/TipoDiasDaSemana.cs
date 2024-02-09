using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.ProgramacaoIV.Aula08022024.Enums
{
    internal enum TipoDiasDaSemana : byte
    {
        /// <summary>
        /// Representa um dia da semana não identificado
        /// </summary>
        [Description("Não identificado")]
        NaoIdentificado = 0,

        /// <summary>
        /// Representa a segunda-feira da semana
        /// </summary>
        [Description("Segunda-Feira")]
        Segunda = 1,

        /// <summary>
        /// Representa a terça-feira da semana
        /// </summary>
        [Description("Terça-Feira")]
        Terca = 2,

        /// <summary>
        /// Representa a quarta-feira da semana
        /// </summary>
        [Description("Quarta-Feira")]
        Quarta = 3,

        /// <summary>
        /// Representa a quinta-feira da semana
        /// </summary>
        [Description("Quinta-Feira")]
        Quinta = 4,

        /// <summary>
        /// Representa a sexta-feira da semana
        /// </summary>
        [Description("Sexta-Feira")]
        Sexta = 5,

        /// <summary>
        /// Representa a sabado da semana
        /// </summary>
        [Description("Sábado")]
        Sabado = 6,

        /// <summary>
        /// Representa a domingo da semana
        /// </summary>
        [Description("Domingo")]
        Domingo = 7
    }
}
