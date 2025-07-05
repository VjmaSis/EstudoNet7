using EstudoSOLID.Dominio.Entidades;
using EstudoSOLID.Infraestrutura.Contratos.Pessoas;
using EstudoSOLID.Servico.Dtos;
using Mapster;

namespace EstudoSOLID.Servico.Servico
{
    public class PessoaService(IPessoaRepositorio pessoaRepository) : IPessoaService
    {
        private readonly IPessoaRepositorio _pessoaRepository = pessoaRepository;

        public async Task<PessoaDto> AddAsync(PessoaDto model)
        {
            var pessoa = model.Adapt<Pessoa>();
            var result = await _pessoaRepository.Adicionar(pessoa);

            return result.Adapt<PessoaDto>();
        }

        public async Task<PessoaDto?> BuscarPorNome(string nome)
        {
            var pessoa = await _pessoaRepository.BuscarPorNome(nome);
            return pessoa.Adapt<PessoaDto>();
        }

        public async Task DeleteAsync(int id)
        {
            await _pessoaRepository.Deletar(id);
        }

        public async Task<IEnumerable<PessoaDto>> GetAllAsync()
        {
            
            var pessoas = await _pessoaRepository.BuscarTodos();
            return pessoas.Adapt<IEnumerable<PessoaDto>>();
        }

        public async Task<PessoaDto> GetByIdAsync(int id)
        {
            var pessoa = await _pessoaRepository.BuscarPorId(id);
            return pessoa.Adapt<PessoaDto>();
        }

        public async Task<PessoaDto?> UpdateAsync(PessoaDto model)
        {
            var pessoa = _pessoaRepository.BuscarPorId(model.Id);
            if (pessoa is not null)
            {
                var pessoaBD = model.Adapt<Pessoa>();
                var result = await _pessoaRepository.Atualizar(pessoaBD);
                return result.Adapt<PessoaDto>();
            }

            return null;
        }
    }
}
