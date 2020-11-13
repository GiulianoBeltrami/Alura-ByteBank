using System;
using System.Text.RegularExpressions;
using BibliotecaByteBank;
/*
    using Humanizer;
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
    public class Program
    {
        static void Main(string[] args)

        {
            //string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=XXXX&valor=1500";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);
            Console.WriteLine(extrator.GetValor("MOEDAORIGEM"));
            //regex
            string padrao = "[0-9]{4,5}[-]?[0-9]{4}"; //<padrão><contador>
            string teste = "Meu telefone é 1234-4321";
            Match resultado = Regex.Match(teste, padrao);
            Console.WriteLine(resultado);

            ContaCorrente conta1 = new ContaCorrente(123, 324145);
            Console.WriteLine(conta1);

            Cliente cliente1 = new Cliente();
            cliente1.cpf = "123";
            Cliente cliente2 = new Cliente();
            cliente2.cpf = "123";

            Console.WriteLine(cliente1.Equals(cliente2));

            Console.ReadLine();
        }
       
    }
}
