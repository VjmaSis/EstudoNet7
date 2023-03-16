using AutoMapper;
using dotnetrpg.Application.Dtos.Character;
using dotnetrpg.core.Models;
using dotnetrpg.Core.Models;
using dotnetrpg.Data.Repositorios.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetrpg.Application.Service.CharacterService
{
    public class CharacterService : ICharacterService
    {
 
        private readonly IMapper _mapper;
        private readonly ICharactersRepository _charactersRepository;

        public CharacterService(IMapper mapper, ICharactersRepository charactersRepository)
        {
            _mapper = mapper;
            _charactersRepository = charactersRepository;
        }
        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            var respose = new ServiceResponse<List<GetCharacterDto>>();
            var characters = await  _charactersRepository.AddCharacter(_mapper.Map<Character>(newCharacter));
            respose.Data = _mapper.Map<List<GetCharacterDto>>(characters);
            return respose;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id)
        {
            var respose = new ServiceResponse<List<GetCharacterDto>>();
            var character = await _charactersRepository.DeleteCharacter(id);
            respose.Data = _mapper.Map<List<GetCharacterDto>>(character);

            return respose;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAll()
        {
            var respose = new ServiceResponse<List<GetCharacterDto>>();
            respose.Data = _mapper.Map<List<GetCharacterDto>>(await _charactersRepository.GetAllCharacters());
            return respose;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetById(int id)
        {
            var respose = new ServiceResponse<GetCharacterDto>();

            var character = await _charactersRepository.GetCharacter(id);
            respose.Data = _mapper.Map<GetCharacterDto>(character);
            return respose;

        }

        public async Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateCharacter)
        {
            var respose = new ServiceResponse<GetCharacterDto>();
            var caracter = await _charactersRepository.UpdateCharacter(_mapper.Map<Character>(updateCharacter));
            if (caracter is not null)
            {
                respose.Data = _mapper.Map<GetCharacterDto>(caracter);

            }
            else
            {
                respose.Sucesso = false;
                respose.Mensagem = "Personagem não encontrado";
                respose.Data = null;
            }
            return respose;

        }
    }
}
