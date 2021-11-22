using Dominio;
using Dominio.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class DataPrueba
    {
        public static async Task InsertarData(netLisContext context, UserManager<TblUsuario> usuarioManager)
        {
            if (!usuarioManager.Users.Any())
            {
                var usuario = new TblUsuario { IdEmpleado = null, UserName = "admin", Email = "admin@test.com" };
                await usuarioManager.CreateAsync(usuario, "Password1234$");
            }
        }
    }
}
