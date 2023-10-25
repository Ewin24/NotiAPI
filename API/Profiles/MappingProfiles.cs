using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Auditoria, AuditoriaDto>().ReverseMap();
        CreateMap<EstadoNotificacion, EstadoNotificacionDto>().ReverseMap();
        CreateMap<Formatos, FormatoDto>().ReverseMap();
        CreateMap<GenericosVsSubmodulos, GenericosVsSubmodulosDto>().ReverseMap();
        CreateMap<HiloRespuestaNotificacion, HiloRespuestaNotificacionDto>().ReverseMap();
        CreateMap<MaestrosVsSubmodulos, MaestrosVsSubmodulosDto>().ReverseMap();
        CreateMap<ModuloNotificaciones, ModuloNotificacionDto>().ReverseMap();
        CreateMap<ModulosMaestros, ModulosMaestrosDto>().ReverseMap();
        CreateMap<PermisosGenericos, PermisosGenericoDto>().ReverseMap();
        CreateMap<Radicados, RadicadosDto>().ReverseMap();
        CreateMap<Radicados, RadicadosDto>().ReverseMap();
        CreateMap<Rol, RolDto>().ReverseMap();
        CreateMap<RolvsMaestro, RolVsMaestroDto>().ReverseMap();
        CreateMap<SubModulos, SubModulosDto>().ReverseMap();
        CreateMap<TipoNotificaciones, TipoNotificacionesDto>().ReverseMap();
        CreateMap<TipoRequerimiento, TipoRequerimientoDto>().ReverseMap();
    }
}