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
        public static void Main(string[] args)

        {
            int[] num = new int[5] {1,2,3,4,5 };

            SomarNumeros(num);



            Console.ReadLine();
        }

        //{1,2,3,4} -> 1+2  
        //             3+4
        static void SomarNumeros(int[] numeros)
        {
            //1,2,3,4
            //[0],[1],[2],[3]

            for (int i = 0; i < numeros.Length-1;i+=2)
            {
                int primeiroNumero = numeros[i];
                int segundoNumero = numeros[i+1];
                int soma = primeiroNumero + segundoNumero;
                Console.WriteLine($"{primeiroNumero}+{segundoNumero}={soma}");
                Console.WriteLine(i);
            }
        }

        static void TestaArrayDeContaCorrente() 
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                new ContaCorrente(1239, 32412), //[0]
                new ContaCorrente(1234, 22412), //[1]
                new ContaCorrente(1237, 36412)  //[2]
                };
        }
        static void TestaArrayInt()
        {
            //array : coleção de elementos que podem ser resgatados por índices
            int[] idades = new int[5]; //array(lista) com índices de inteiros que possuem 5 posições
            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            int idades_ = 0;
            for (int contador = 0; contador < idades.Length; contador++)
            {
                idades_ = idades_ + idades[contador];
            }

            Console.WriteLine(idades_ / idades.Length);

        }
    }
}





/*
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
 */