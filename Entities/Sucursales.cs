using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Sucursales : BaseEntity
    {
       public int Codigo { get; set; }
       public string Descripcion    { get; set; }
       public string Direccion      { get; set; }
       public string Identificacion { get; set; }
       public DateTime FechaCreacion  { get; set; }
       public int IdMoneda { get; set; }
    }
}
