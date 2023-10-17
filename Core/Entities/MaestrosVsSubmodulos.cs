using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Core.Entities;

public class MaestrosVsSubmodulos : BaseEntity
{
    public DateTime FechaCreacion;
    public DateTime FechaModificacion;

    public long IdMaestro;
    public ModulosMaestros ModulosMaestros { get; set; }
    public long IdSubmodulo;
    public SubModulos SubModulos { get; set; }
    public ICollection<GenericosVsSubmodulos> GenericosVsSubmodulos { get; set; }
}
