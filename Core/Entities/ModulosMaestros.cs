using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class ModulosMaestros : BaseEntity
{
    public string NombreModulo;
    public DateTime FechaCreacion;
    public DateTime FechaModificacion;

    public ICollection<RolvsMaestro> RolvsMaestros { get; set; }
    public ICollection<MaestrosVsSubmodulos> MaestrosVsSubmodulos { get; set; }
}