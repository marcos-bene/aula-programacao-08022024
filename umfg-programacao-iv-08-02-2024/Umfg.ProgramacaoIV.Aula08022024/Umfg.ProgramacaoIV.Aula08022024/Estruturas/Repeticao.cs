using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.ProgramacaoIV.Aula08022024.Estruturas
{
    internal class Repeticao
    {
        public void Executar()
        {
            var teste = "UMFG Educacional";

            #region for

            //for(int i = 0; i < teste.Length; i++)
            //{
            //    Console.WriteLine(teste[i]);
            //}

            #endregion for

            #region while

            //var count = 0;

            //while (count < teste.Length)
            //{
            //    Console.WriteLine(teste[count]);
            //    count++;
            //}

            #endregion while

            #region do while

            //var count = 0;

            //do
            //{
            //    Console.WriteLine(teste[count]);
            //    count++;
            //} while (count < teste.Length);

            #endregion do while

            #region foreach

            foreach (var item in teste)
                Console.WriteLine(item);

            #endregion foreach
        }
    }
}
