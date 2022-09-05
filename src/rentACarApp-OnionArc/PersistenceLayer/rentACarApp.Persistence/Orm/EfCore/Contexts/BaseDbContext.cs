using Microsoft.EntityFrameworkCore;
using rentACarApp.Core.Domain.Entiyies;

namespace rentACarApp.Persistence.Orm.EfCore.Contexts;

#region Description

//TODO 002.Persistence : Create BaseDbContext Class

#endregion
public class BaseDbContext : DbContext
{
    #region DbSets

    #region Description

    // TODO 002.01.Persistence.BaseDbContext : Add DbSet Propertiyies

    #endregion

    public DbSet<Brand> Brands { get; set; }
    #endregion


}