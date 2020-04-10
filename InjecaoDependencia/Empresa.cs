using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDependencia
{
    public class Empresa : IObjetoEnderecoIJ
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        private IObjetoEndereco Endereco { get; set; }


        //public void SetEndereco(IObjetoEndereco objeto)
        //{
        //    Endereco = objeto;
        //}

        public Empresa(IObjetoEndereco objeto)
        {
            Endereco = Localizador.GetObjetoEndereco();
        }
    }
}
