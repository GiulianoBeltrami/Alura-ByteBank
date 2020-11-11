using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaByteBank.funcionarios
{
    class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(double salario, string cpf) : base(salario, cpf)
        {

        }
        internal protected override double GetBonificacao() //retorna a bonificacao
        {
            return Salario;
        }
        public override void AumentarSalario(int porcentagem_aumento)
        {
            this.Salario += this.Salario * porcentagem_aumento / 100;
        }
    }
}
