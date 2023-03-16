using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetrpg.Application.Service.CharacterService;
using dotnetrpg.Data.Repositorios.Characters;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace dotnetrpg.IoC
{
    public static class InjecaoDependencia
    {
        public static void InjetarDependencia(WebApplicationBuilder builder)
        {
            #region Services
            builder.Services.AddScoped<ICharacterService, CharacterService>();
            #endregion

            #region Repositorios
            builder.Services.AddScoped<ICharactersRepository, CharactersRepository>();
            #endregion
        }
    }
}
