using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.ProgramacaoIV.Aula08022024.TiposDeValor
{
    internal class TipoDateTime
    {
        public void Executar()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd"));
            Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

            Console.WriteLine(DateTime.Now.ToString("yyyy/dd/MM"));
            Console.WriteLine(DateTime.Now.ToString("yyyy/dd/MM hh:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("yyyy/dd/MM HH:mm:ss"));

            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToLocalTime());

            var dataUm = DateTime.Now;
            var dataDois = new DateTime(2024, 02, 08);

            Console.WriteLine("dataUm" + dataUm);
            Console.WriteLine("dataDois" + dataDois);
        }
    }
}