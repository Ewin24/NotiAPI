using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class TipoRequerimiento : BaseEntity
{
    public string Nombre;
    public DateTime FechaCreacion;
    public DateTime FechaModificacion;
    public ICollection<ModuloNotificaciones> ModuloNotificaciones { get; set; }
}