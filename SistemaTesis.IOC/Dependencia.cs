using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using SistemaTesis.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using SistemaTesis.Entity;
//using SistemaTesis.DAL.Interfaces;
//using SistemaTesis.DAL.Implementacion;
//using SistemaTesis.BLL.Interfaces;
//using SistemaTesis.BLL.Implementacion;


namespace SistemaTesis.IOC
{
    public static class Dependencia
    {

        public static void InyectarDependencia(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<TESISPRv2Context>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("CadenaSQL"));
            });
        }
    }
}
