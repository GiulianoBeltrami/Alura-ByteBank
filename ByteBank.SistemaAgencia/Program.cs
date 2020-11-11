using System;
using Humanizer;
/*
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BibliotecaByteBank.Exception;
    using BibliotecaByteBank.funcionarios;
    using BibliotecaByteBank.Sistema;
    using BibliotecaByteBank;
    using System.Runtime.CompilerServices;
 */


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2020,11,16);
            DateTime dataAtual = DateTime.Now;
            TimeSpan diferenca = dataFimPagamento - dataAtual;
            Console.WriteLine(TimeSpanHumanizeExtensions.Humanize(diferenca));

            //Console.WriteLine(dataAtual);
            //dataLegivel(diferenca);

            Console.ReadLine();
        }

    
    }
}
