using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.ProgramacaoIV.Aula08022024.Estruturas
{
    internal class Condicao
    {
        private const string C_VALOR_A = "A";

        public void Executar()
        {
            #region base de estruturas de condição

            //var boolTeste = true;

            //if (boolTeste == true)
            //{

            //}
            //else if(boolTeste == false)
            //{

            //}
            //else
            //{

            //}

            //switch (boolTeste)
            //{
            //    case true:
            //        Console.WriteLine(true);
            //        break;
            //    case false:
            //        Console.WriteLine(false);
            //        break;
            //    default:
            //        Console.WriteLine("Erro");
            //        break;
            //}

            #endregion base de estruturas de condição

            #region if

            //Console.WriteLine("Informe seu nome: ");
            //var nome = Console.ReadLine();

            //// caso a condição ocorra em apenas uma linha
            //// não é necessário utilização de chaves
            //// como testar a diferença sinal de esclamação mais igual
            //// operador E é executado com o sinal e comercial (&) duas vezes
            //if (nome != null && !string.IsNullOrWhiteSpace(nome))
            //    Console.WriteLine("Olá " + nome);
            //else
            //    Console.WriteLine("Valor inválido!");

            //// como testar a igualdade sinal de igual duas vezes
            //// o operador OU é executado com o sinal pipe (|) duas vezes
            //if (nome == null || string.IsNullOrWhiteSpace(nome))
            //    Console.WriteLine("Valor inválido!");
            //else
            //    Console.WriteLine("Olá " + nome);

            //if (nome == null || string.IsNullOrWhiteSpace(nome))
            //{
            //    Console.WriteLine("Valor inválido!");
            //    return;
            //}

            //Console.WriteLine("Olá " + nome);

            //Console.WriteLine("ESCOLHA UMA OPÇÃO: ");
            //Console.WriteLine("A");
            //Console.WriteLine("B");
            //var valorDigitado = Console.ReadLine();

            //if (C_VALOR_A.Equals(valorDigitado))
            //{
            //    Console.WriteLine("Seu usuário será Administrador!");
            //    return;
            //}

            //Console.WriteLine("Seu usuário será Padrão!");

            #endregion if

            #region switch case

            Console.WriteLine("Informe um valor: ");
            var valorUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor: ");
            int.TryParse(Console.ReadLine(), out int valorDois);

            Console.WriteLine("valorUm: " + valorUm);
            Console.WriteLine("valorDois: " + valorDois);

            Console.WriteLine("Informe o tipo de operação: ");
            Console.WriteLine("SOMA: 1");
            Console.WriteLine("SUBTRAÇÃO: 2");
            Console.WriteLine("DIVISÃO: 3");
            Console.WriteLine("MULTIPLICAÇÃO: 4");
            var operacao = Console.ReadLine();

            switch (operacao)
            {
                case "1":
                    Console.WriteLine("SOMA: " + (valorUm + valorDois));
                    break;
                case "2":
                    Console.WriteLine("SUBTRAÇÃO: " + (valorUm - valorDois));
                    break;
                case "3":
                    Console.WriteLine("DIVISÃO: " + (valorUm / valorDois));
                    break;
                case "4":
                    Console.WriteLine("MULTIPLICAÇÃO: " + (valorUm * valorDois));
                    break;
                default:
                    Console.WriteLine("Operação não cadastrada");
                    break;
            }

            #endregion switch case
        }
    }
}
