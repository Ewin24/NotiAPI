using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class TipoNotificaciones : BaseEntity
{
    public string NombreTipo;
    public DateTime FechaCreacion;
    public DateTime FechaModificacion;

    public ICollection<BlockChain> BlockChains { get; set; }
    public ICollection<ModuloNotificaciones> ModuloNotificaciones { get; set; }
}