using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex01.Entities.Enums;


// dentro da pasta entities para separar melhor as entidades do projeto, ex: cliente, funcionário, etc
namespace Ex01.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        // declara a enumeração que foi criada na outra pasta
        // eu também poderia declarar um enum diretamente dentro desta classe, sem criar separado
        public OrderStatus Status { get; set; }


        // ToString padrão
        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }

    }
}
