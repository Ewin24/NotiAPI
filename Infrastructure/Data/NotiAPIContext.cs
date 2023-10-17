using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class NotiAPIContext : DbContext
{
    public NotiAPIContext(DbContextOptions<NotiAPIContext> options) : base(options)
    {
    }
    DbSet<Auditoria> Auditorias { get; set; }
    DbSet<BlockChain> BlockChains { get; set; }
    DbSet<EstadoNotificacion> EstadoNotificacions { get; set; }
    DbSet<Formatos> Formatos { get; set; }
    DbSet<HiloRespuestaNotificacion> HiloRespuestaNotificacions { get; set; }
    DbSet<MaestrosVsSubmodulos> MaestrosVsSubmodulos { get; set; }
    DbSet<ModuloNotificaciones> ModuloNotificaciones { get; set; }
    DbSet<ModulosMaestros> ModulosMaestros { get; set; }
    DbSet<PermisosGenericos> PremisosGenerados { get; set; }
    DbSet<Radicados> Radicados { get; set; }
    DbSet<Rol> Roles { get; set; }
    DbSet<RolvsMaestro> RolvsMaestros { get; set; }
    DbSet<SubModulos> SubModulos { get; set; }
    DbSet<TipoNotificaciones> TipoNotificaciones { get; set; }
    DbSet<TipoRequerimiento> TipoRequerimientos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
