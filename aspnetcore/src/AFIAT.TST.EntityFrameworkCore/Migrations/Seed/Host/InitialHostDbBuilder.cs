using AFIAT.TST.EntityFrameworkCore;

namespace AFIAT.TST.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly TSTDbContext _context;

        public InitialHostDbBuilder(TSTDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
