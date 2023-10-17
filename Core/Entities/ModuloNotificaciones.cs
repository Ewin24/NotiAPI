using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Core.Entities;

public class ModuloNotificaciones : BaseEntity
{
    public string AsuntoNotificacion;
    public string TextoNotificacion;
    public DateTime FechaCreacion;
    public DateTime FechaModificacion;


    public long IdTipoNotificacion;
    public TipoNotificaciones TipoNotificaciones;
    public long IdRadicado;
    public Radicados Radicados { get; set; }
    public long IdEstadoNotificacion;
    public EstadoNotificacion EstadoNotificaciones { get; set; }
    public long IdhiloRespuesta;
    public HiloRespuestaNotificacion HiloRespuestaNotificaciones { get; set; }
    public long IdFormato;
    public Formatos Formatos { get; set; }
    public long IdRequerimiento; //foranea con tiporequerimiento
    public TipoRequerimiento TipoRequerimientos { get; set; }
}
