using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRevisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------------

                 //Instânciando os Cursos

            Curso ds = new Curso();
            ds.id = 1;
            ds.setNome("Desenvolvimentos de Sistemas");

            Curso lgt = new Curso();
            lgt.id = 2;
            lgt.setNome("Logística");

            Curso adm = new Curso();
            adm.id = 3;
            adm.setNome("Administração");

            Curso mkt = new Curso();
            mkt.id = 4;
            mkt.setNome("Marketing");

            //-------------------------------------------------------------------------------------
               
                 //Instânciando os Professores

            Professor prof01 = new Professor();
            prof01.setMatricula(12);
            prof01.setNome("Tone Alex Guerra");

            //-------------------------------------------------------------------------------------

                 //Relacionando

            ds.prof = prof01;
            lgt.prof = prof01;
            mkt.prof = prof01;

            Curso inform = new Curso();
            inform.id = 5;
            inform.setNome("Informática");
            inform.prof = new Professor();
            inform.prof.setMatricula(90);
            inform.prof.setNome("Franklin");


            //-------------------------------------------------------------------------------------

                 //Atividade

            Curso fiscq = new Curso();
            fiscq.id = 6;
            fiscq.setNome("Física Quântica");
            fiscq.prof = new Professor();
            fiscq.prof.setMatricula(10);
            fiscq.prof.setNome("Andrew");
            fiscq.modal = new Modalidade();
            fiscq.modal.setCodigo(123);
            fiscq.modal.setCategoria("EAD");


        }
    }
}
