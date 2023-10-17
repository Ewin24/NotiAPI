using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class PermisosGenericos : BaseEntity
{
    public string NombrePermiso;
    public DateTime FechaCreacion;
    public DateTime FechaModificacion;

    public ICollection<GenericosVsSubmodulos> GenericosVsSubmodulos { get; set; }
}