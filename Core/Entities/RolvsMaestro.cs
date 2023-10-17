using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Core.Entities;
public class RolvsMaestro : BaseEntity
{
    public DateTime FechaCreacion;
    public DateTime FechaModificacion;
    
    public long IdRol;
    public Rol Roles { get; set; }
    public long IdMaestro;
    public ModulosMaestros ModulosMaestros { get; set; }
}