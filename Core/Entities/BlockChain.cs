using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Core.Entities;
public class BlockChain : BaseEntity
{
    public long IdNotification;
    public long IdhiloRespuesta;
    public string HashGenerado;
    public DateTime FechaCreacion;
    public DateTime FechaModificacion;

    public long IdAuditoria;
    public Auditoria Auditoria;

    public long IdTipoNotificaciones;
    public TipoNotificaciones TipoNotificaciones;

    public long IdHiloRespuesta;
    public HiloRespuestaNotificacion HiloRespuestaNotificacion;
}