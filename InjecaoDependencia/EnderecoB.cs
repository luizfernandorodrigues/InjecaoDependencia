using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public class EnderecoB : IObjetoEndereco
    {
        public string Cidade { get; set; }
        public string Uf { get; set; }
    }
}
