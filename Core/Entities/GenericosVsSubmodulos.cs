using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class GenericosVsSubmodulos : BaseEntity
{
    public DateTime FechaCreacion;
    public DateTime FechaModificacion;

    public long idGenericos { get; set; }
    public PermisosGenericos PermisosGenericos { get; set; }
    public long idSubmodulos { get; set; }
    public MaestrosVsSubmodulos MaestrosVsSubmodulos { get; set; }
    public long idRol { get; set; }
    public Rol Roles { get; set; }
}