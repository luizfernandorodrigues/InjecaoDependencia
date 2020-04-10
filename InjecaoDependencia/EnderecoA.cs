using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public class EnderecoA : IObjetoEndereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
    }
}
