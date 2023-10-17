using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class EstadoNotificacion : BaseEntity
    {
        public string Nombreestado;
        public DateTime FechaCreacion;
        public DateTime FechaModificacion;

        public ICollection<ModuloNotificaciones> ModuloNotificaciones { get; set; }
    }
}