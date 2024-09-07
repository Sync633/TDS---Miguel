using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRevisao
{
    internal class Modalidade
    {
        private int codigo;
        private string categoria;


        public void setCodigo(int codigo) 
        { 
            this.codigo = codigo;
        }

        public void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }


    }
}
