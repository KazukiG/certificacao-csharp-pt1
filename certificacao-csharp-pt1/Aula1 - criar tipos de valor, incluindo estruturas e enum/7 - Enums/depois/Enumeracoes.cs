using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Enumeracoes : IAulaItem
    {
        public void Executar()
        {
            DiasDaSemana primeiroDia = DiasDaSemana.Seg;

            DiasDeTrabalho diasDeTrabalho
                = DiasDeTrabalho.Ter & DiasDeTrabalho.Qui & DiasDeTrabalho.Sex;

            Console.WriteLine(primeiroDia);
            Console.WriteLine(diasDeTrabalho);
        }
    }
    //como mostro o número?
    enum DiasDaSemana { Seg = 3, Ter = 10, Qua = 15, Qui, Sex, Sab, Dom }

    //[Flags] //Se remover a Flag irá somar
    enum DiasDeTrabalho { Seg = 0, Ter = 1, Qua = 2, Qui = 4, Sex = 8, Sab = 16, Dom = 32 }
}