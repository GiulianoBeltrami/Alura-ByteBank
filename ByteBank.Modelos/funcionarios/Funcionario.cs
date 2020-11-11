using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaByteBank.funcionarios
{
    public abstract class Funcionario
    {
        public static int NumeroFuncionarios { get; private set; }
        public Funcionario(double salario,string cpf)
        {
            this.CPF = cpf;
            this.Salario = salario;
            NumeroFuncionarios++;
        }
        public Funcionario(string cpf) : this(1500,cpf)
        {
            this.CPF = cpf;
        }

        internal protected abstract double GetBonificacao(); //retorna a bonificacao

        public abstract void AumentarSalario(int porcentagem_aumento); //aumento em porcentagem

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        
    }
}
