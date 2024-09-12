using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class Calc
    {
        private Queue<string> historico = new Queue<string>();
        public string Addition(int num1, int num2)
        {
            RegistrarHistoricoOperacoes(1, num1, num2, num1+num2);
            return $"{num1} + {num2} = {num1+num2}";
        }

        public string Subtraction(int num1, int num2)
        {
            RegistrarHistoricoOperacoes(2, num1, num2, num1-num2);
            return $"{num1} - {num2} = {num1-num2}";
        }

        public string Multiplication(int num1, int num2)
        {
            RegistrarHistoricoOperacoes(3, num1, num2, num1*num2);
            return $"{num1} * {num2} = {num1*num2}";
        }

        public string Division(int num1, int num2)
        {
            try {
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException) {
                Console.WriteLine("Divisão de {0} por zero.", num1);
                return "Operação Inválida";
            }
            RegistrarHistoricoOperacoes(4, num1, num2, num1/num2);
            return $"{num1} / {num2} = {num1/num2}";
        }

        public void RegistrarHistoricoOperacoes(int operacao, int num1, int num2, int result)
        {
            switch (operacao)
            {
                case 1:
                    if (historico.Count() < 3)
                    {
                        historico.Enqueue($"{num1} + {num2} = {result}");
                    }
                    else
                    {
                        historico.Dequeue();
                        historico.Enqueue($"{num1} + {num2} = {result}");
                    }
                    break;
                
                case 2:
                    if (historico.Count() < 3)
                    {
                        historico.Enqueue($"{num1} - {num2} = {result}");
                    }
                    else
                    {
                        historico.Dequeue();
                        historico.Enqueue($"{num1} - {num2} = {result}");
                    }
                    break;
                
                case 3:
                    if (historico.Count() < 3)
                    {
                        historico.Enqueue($"{num1} * {num2} = {result}");
                    }
                    else
                    {
                        historico.Dequeue();
                        historico.Enqueue($"{num1} * {num2} = {result}");
                    }
                    break;
                
                case 4:
                    if (historico.Count() < 3)
                    {
                        historico.Enqueue($"{num1} / {num2} = {result}");
                    }
                    else
                    {
                        historico.Dequeue();
                        historico.Enqueue($"{num1} / {num2} = {result}");
                    }
                    break;
                
                default: break;
            }
        }

        public Queue<string> ExibirHistoricoOperacoes()
        {
            return historico;
        }

    }
}