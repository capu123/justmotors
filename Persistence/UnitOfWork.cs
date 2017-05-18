using System.Threading.Tasks;

namespace justmotors.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JustmotorsDbContext context;
        public UnitOfWork(JustmotorsDbContext context)
        {
            this.context = context;

        }
        public async Task CompleteAsync()
        {
           await context.SaveChangesAsync();
        }
    }
}