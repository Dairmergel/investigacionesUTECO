using InvestigacionesUTECO.Data.Context;
using InvestigacionesUTECO.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InvestigacionesUTECO.Data.Services;

public class FomularioSevices:IFomularioSevices
{
    private readonly IUTECODbContext context;

    public FomularioSevices(IUTECODbContext context)
    {
        this.context = context;
    }

    public async Task<bool> Crear(Formulario data)
    {

        try
        {
            context.Formularios.Add(data);
            await context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
}
public interface IFomularioSevices
{
    public Task<bool> Crear(Formulario data);
   
}