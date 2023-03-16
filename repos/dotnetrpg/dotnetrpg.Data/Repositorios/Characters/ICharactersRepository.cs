using dotnetrpg.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetrpg.Data.Repositorios.Characters
{
    public interface ICharactersRepository
    {
        Task<List<Character>> AddCharacter(Character character);
        Task<List<Character>> DeleteCharacter(int id);
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacter(int id);
        Task<Character> UpdateCharacter(Character character);
    }
}
