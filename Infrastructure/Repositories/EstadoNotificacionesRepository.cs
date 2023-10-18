using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class EstadoNotificacionesRepository : GenericRepository<EstadoNotificacion>, IEstadoNotificacionRepository
    {
        private readonly NotiAPIContext _context;
        public EstadoNotificacionesRepository(NotiAPIContext context) : base(context)
        {
            _context = context;
        }
    }
}