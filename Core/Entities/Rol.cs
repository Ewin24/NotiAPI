using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Rol : BaseEntity
{
    public string Nombre;
    public DateTime FechaCreacion;
    public DateTime FechaModificacion;

    public ICollection<RolvsMaestro> RolVsMaestros { get; set; }
    public ICollection<GenericosVsSubmodulos> GenericosVsSubmodulos { get; set; }
}