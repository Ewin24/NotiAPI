using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class SubModulos : BaseEntity
{
    public string NombreSubmodulo;
    public DateTime FechaCreacion;
    public DateTime FechaModificacion;

    public ICollection<MaestrosVsSubmodulos> MaestrosVsSubmodulos { get; set; }
}
