using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploCurso.Application.Servicos;
using ExemploCurso.Domain.Interfaces.Repository;
using ExemploCurso.Domain.Interfaces.Services;
using ExemploCurso.Repository.Contexto;
using ExemploCurso.Repository.Repositorios;
using ExemploCurso.Repository.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExemploCurso.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            
            // Serviços
            builder.Services.AddScoped<IPedidoService, PedidoService>();


            // Infra - Data
            builder.Services.AddDbContext<ExemploCursoContext>(options =>
                           options.UseInMemoryDatabase("DB"));

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();
            builder.Services.AddScoped<IItemPedidoRepositorio, ItemPedidoRepositorio>();
        }
    }
}
