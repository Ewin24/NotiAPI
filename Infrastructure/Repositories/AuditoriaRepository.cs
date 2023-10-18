using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class AuditoriaRepository : GenericRepository<Auditoria>, IAuditoriaRepository
    {
        public AuditoriaRepository(NotiAPIContext context) : base(context)
        {
        }
    }
}