using System;
using System.Threading.Tasks;

namespace justmotors.Persistence
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}