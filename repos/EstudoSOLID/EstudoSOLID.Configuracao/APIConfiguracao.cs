using EstudoSOLID.Dominio.Entidades;
using EstudoSOLID.Infraestrutura.Contratos.Base;
using EstudoSOLID.Infraestrutura.Contratos.Pessoas;
using EstudoSOLID.Repositorio.Repositorios.Pessoas;
using EstudoSOLID.Servico.Contratos.Basse;
using EstudoSOLID.Servico.Dtos;
using EstudoSOLID.Servico.Servico;
using Microsoft.Extensions.DependencyInjection;

namespace EstudoSOLID.Configuracao
{
    public abstract class ApiConfiguracao()
    {
        public static void Configurar(IServiceCollection service)
        {
            service.AddScoped<IAdicionarRepositorio<Pessoa>, PessoaRepositorio>();
            service.AddScoped<IAtualizarRepositorio<Pessoa>, PessoaRepositorio>();
            service.AddScoped<IBuscarPorIdRepositorio<Pessoa>, PessoaRepositorio>();
            service.AddScoped<IBuscarTodosRepositorio<Pessoa>, PessoaRepositorio>();
            service.AddScoped<IDeletarRepositorio, PessoaRepositorio>();
            service.AddScoped<IPessoaRepositorio, PessoaRepositorio>();

            service.AddScoped<IServiceBase<PessoaDto>, PessoaService>();
        }
    }
}
