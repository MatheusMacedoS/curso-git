using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataMaxPagamento = new DateTime(2019, 04, 18);
            DateTime dataAtual = DateTime.Now;
            bool dividaPaga = false;

            double valorProduto = 25.00;
            double porcentagemJurosInicial = 0.05;
            double juros;
            double valorTotal;
            int diasAtraso = dataAtual.Subtract(dataMaxPagamento).Days;

            if (!dividaPaga)
            {
                if(dataAtual.Subtract(dataMaxPagamento) < new TimeSpan(0, 0, 0))
                {
                    Console.WriteLine($"Valor do produto: {valorProduto}");
                    Console.WriteLine("Sua divida ainda não foi paga!");
                    Console.WriteLine($"Prazo Maximo: {dataMaxPagamento.ToString("dd/MM/yyyy")}");
                }
                else
                {
                    juros = porcentagemJurosInicial * dataAtual.Subtract(dataMaxPagamento).Days;
                    valorTotal = valorProduto + valorProduto * juros;
                    Console.WriteLine("Sua divida ainda não foi paga!");
                    Console.WriteLine($"Prazo quebrado: {dataMaxPagamento.ToString("dd/MM/yyyy")}, {diasAtraso} dias de atraso");

                    Console.WriteLine();

                    Console.WriteLine($"Valor do produto: RS{valorProduto.ToString("F2")}");
                    Console.WriteLine($"Juros: {juros * 100}%");
                    Console.WriteLine($"Valor total: R${valorTotal.ToString("F2")}");

                }
            }
            else
            {
                Console.WriteLine("Divida paga com sucesso!");
            }
            Console.ReadLine();
        }
    }
}
