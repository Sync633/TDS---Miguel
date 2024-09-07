using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses
{
    internal class Veiculo
    {
        private String placa;
        private String cor;
        private int ano;

        public String getPlaca()
        { return placa; }
        public void setPlaca(String p)
        { 
            placa = p.ToUpper();
        }


        public String getCor()
        { return cor; }
        public void setCor(String c) 
        {
            cor = c; 
        }


        public int getAno()
        { return ano; }
        public void setAno(int a) 
        { 
            ano = a; 
        }
    }
}
