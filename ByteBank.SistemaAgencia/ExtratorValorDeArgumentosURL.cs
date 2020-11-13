using System;
/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        public readonly string _argumentos;
        public string _url { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {
            // é o throw Exception
            if (string.IsNullOrEmpty(url) == true)
            {
                throw new ArgumentException($"O argumento {nameof(url)} não pode ser nulo ou vazio.");
            }
                this._url = url;
                int IndiceInterrogacao = url.IndexOf('?');
                _argumentos = url.Substring(IndiceInterrogacao++);
        }
        public string GetValor(string nomeArgumento)
        {
            string normalizarArgumentosUrl = _argumentos.ToLower(); // moedaorigem=real&moedadestino=xxx&valor=1500
            nomeArgumento = nomeArgumento.ToLower(); // VALOR -> valor ..
            //moedaOrigem=real&moedaDestino=XXXX&valor=1500
            //<nome argumento>=<valor>&<nome argumento>=<valor>
            string termo = nomeArgumento + "="; //retornar o indice inicial
                                                // do argumento Ex: moedaDestino=XXXX
                                                // termo : moedaOrigem=
            int indiceTermo = normalizarArgumentosUrl.IndexOf(termo); //retorna um inteiro com o indice
                                                          //de início do termo Ex:[15]
                                                          //termo: real&moedaDestino=XXXX
                                                          //      15,16..
            string resultado = _argumentos.Substring(indiceTermo + termo.Length); //real&moedaDestino=XXXX
            int indiceEComercial = resultado.IndexOf('&');
            if (indiceEComercial == -1) //caso não encontre o &
            {
                return resultado;
            }
            return resultado.Remove(indiceEComercial); 
                
        }

    }
}
