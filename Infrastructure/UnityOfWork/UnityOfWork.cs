using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.UnityOfWork
{
    public class UnityOfWork : IUnityOfWork, IDisposable
    {
        public UnityOfWork(NotiAPIContext context)
        {
            
        }

        public IAuditoriaRepository Auditorias => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}