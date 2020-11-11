using System;
using BibliotecaByteBank.Exception;
using BibliotecaByteBank.funcionarios;
using BibliotecaByteBank.Sistema;

namespace BibliotecaByteBank
{
    /// <summary>
    /// Define uma conta corrente no banco ByteBank
    /// </summary>
    public class ContaCorrente
    {
        //se declarar valor, o valor será o default
                                                //consultar a var. //mudar a var.
        public static int TotalDeContasCriadas { get      ;       private set; } //static: propriedade que pertence a toda a classe
                                                                                 //e objetos separadamente(Agencia,NumeroConta..)
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public int NumeroConta { get; } //o set se torna somente leitura e só pode ser alterado no construtor
        public int NumeroAgencia { get; }     
        public int ContadorDeSaquesNaoPermitidos { get; private set; }
        public int ContadorDeTrasnferenciasNaoPermitidas { get; private set; }
        /// <summary>
        /// Cria uma instância da conta corrente com os argumentos fornecidos
        /// </summary>
        /// <param name="agencia">Identificação do numero da <see cref="NumeroAgencia"/> e esta deve ser maior que zero</param>
        /// <param name="numeroConta">Identificação do numero da <see cref="NumeroConta"/> e esta deve ser maior que zero</param>
        public ContaCorrente(int agencia, int numeroConta)
        {
            if (agencia <= 0 || numeroConta <= 0)
            {
                if (agencia <=0)
                    throw new ArgumentException("A Agencia da conta deve ser maior que zero.",nameof(agencia));
                if (numeroConta <= 0)
                    throw new ArgumentException("O número da conta deve ser maior que zero.", nameof(numeroConta));
            }
            else
            {
                this.NumeroAgencia = agencia;
                this.NumeroConta = numeroConta;
                TotalDeContasCriadas++;
                TaxaOperacao = 30 / TotalDeContasCriadas;
            }
        }
        private double _saldo;
        public double Saldo 
        {
            get 
            {
                return _saldo;
            }
            set 
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }
        /// <summary>
        /// Realiza saque na propriedade <see cref="Saldo"/>
        /// </summary>
        /// <exception cref="ArgumentException">Exceção lançada quando o argumento<paramref name="valor"/>é menor que zero</exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o <paramref name="valor"/>é maior que o <see cref="Saldo"/></exception>
        /// <param name="valor">Representa o valor do saque e deve ser maior que zeroe menor que <see cref="Saldo"/>></param>
        public void Sacar(double valor)
        {
            if (valor > this._saldo)
            {    //não pode sacar pois não tem saldo
                ContadorDeSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException("Valor maior que o saldo no banco.");
            }
            if (valor < 0)
                throw new ArgumentException("Valor menor que zero.",nameof(valor));
                //pode sacar pois tem saldo
                this._saldo -= valor;
               
        }
        //void quer dizer que não possui retorno
        public void Depositar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor de deposito menor que zero.", nameof(valor));
            this._saldo += valor;
        }
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException) 
            {
                ContadorDeTrasnferenciasNaoPermitidas++;
                throw;
            }
            //não precisa de else pois caso o if seja positivo já sairá da função
            //pode transferir pois tem saldo
            contaDestino.Depositar(valor); // deposita o valor transferido em outra conta
        }
    }
}

//classe é a planta de uma casa
//objeto é a casa, algo físico