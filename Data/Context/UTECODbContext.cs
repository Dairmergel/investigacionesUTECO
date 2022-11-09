using InvestigacionesUTECO.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InvestigacionesUTECO.Data.Context;

public class UTECODbContext:DbContext,IUTECODbContext
{
    public UTECODbContext(DbContextOptions options) : base(options)
    {

    }

    #region  Tablas
    public virtual DbSet<Usuario> Usuarios {get; set;} = null!;
    #endregion

    #region Funciones
    public override int SaveChanges()
    {
        return base.SaveChanges();
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
    #endregion
}

public interface IUTECODbContext
{
    #region  Tablas
    public DbSet<Usuario> Usuarios {get; set;}

    #endregion

    #region Funciones
    public int SaveChanges();
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    #endregion
}