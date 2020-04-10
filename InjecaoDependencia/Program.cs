using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            EnderecoA endA = new EnderecoA();
            endA.Rua = "Rua Endereço A";
            endA.Numero = 1;

            EnderecoB endB = new EnderecoB();
            endB.Cidade = "Sao Paulo";
            endB.Uf = "SP";

            Empresa empresa = new Empresa(endA);

            Empresa empresa1 = new Empresa(endB);
        }
    }
}
