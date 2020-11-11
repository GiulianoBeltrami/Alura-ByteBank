using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaByteBank.funcionarios
{
    class Designer : Funcionario
    {
        public Designer(double salario, string cpf) : base(salario, cpf)
        {

        }
        internal protected override double GetBonificacao() //retorna a bonificacao
        {
            return Salario*0.15;
        }
        public override void AumentarSalario(int porcentagem_aumento)
        {
            this.Salario += this.Salario * porcentagem_aumento / 100;
        }
    }
}
