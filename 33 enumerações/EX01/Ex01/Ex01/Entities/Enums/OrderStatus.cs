using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dentro da pasta enums para auxiliar na organização
namespace Ex01.Entities.Enums
{
    // declara uma enumeração e indica que terá os valores associados a um int
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
