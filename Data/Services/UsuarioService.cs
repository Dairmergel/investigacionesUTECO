using InvestigacionesUTECO.Data.Context;
using InvestigacionesUTECO.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InvestigacionesUTECO.Data.Services;

public class UsuarioServices:IUsuarioServices
{
    private readonly IUTECODbContext context;

    public UsuarioServices(IUTECODbContext context)
    {
        this.context = context;
    }

    public async Task<bool> Crear(Usuario data)
    {

        try
        {
            context.Usuarios.Add(data);
            await context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
    public async Task<bool> Login(string correo, string clave)
    {

        try
        {
            var usuario = await context.Usuarios.FirstOrDefaultAsync(u=>u.Correo == correo);
            if(usuario != null){
                return usuario.Contrasena == clave;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }
}

public interface IUsuarioServices
{
    public Task<bool> Crear(Usuario data);
    public Task<bool> Login(string correo, string clave);
}