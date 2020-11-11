
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaByteBank;

namespace BibliotecaByteBank.Sistema
{
   public interface Autenticavel
    {
        bool Autenticar(string senha);
    }
}
