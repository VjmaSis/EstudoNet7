using dotnetrpg.core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetrpg.Data.Repositorios.Characters
{
    public class CharactersRepository : ICharactersRepository
    {
        private readonly ContextoPrincipal _contextoPrincipal;

        public CharactersRepository(ContextoPrincipal contextoPrincipal)
        {
           _contextoPrincipal = contextoPrincipal;
        }
        public async Task<List<Character>> AddCharacter(Character character)
        {
            _contextoPrincipal.Characters.Add(character);
            await _contextoPrincipal.SaveChangesAsync();
            return await GetAllCharacters();
        }

        public async Task<List<Character>> DeleteCharacter(int id)
        {
            var character = _contextoPrincipal.Characters.FirstOrDefault(c => c.Id == id);
            if (character != null)
            {
                _contextoPrincipal.Characters.Remove(character);
                await _contextoPrincipal.SaveChangesAsync();
            }
            return await GetAllCharacters();
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return await _contextoPrincipal.Characters.ToListAsync();
        }

        public async Task<Character> GetCharacter(int id)
        {
            var caracter = await _contextoPrincipal.Characters.FirstOrDefaultAsync(x => x.Id == id);
            if (caracter != null)
                return caracter;
            
            return null;
        }

        public async Task<Character> UpdateCharacter(Character character)
        {
            var characterDb = await _contextoPrincipal.Characters.FindAsync(character.Id);
            if (characterDb is not null)
            {
                characterDb.Strength = character.Strength;
                characterDb.Name = character.Name;
                characterDb.Defense = character.Defense;
                characterDb.Class = character.Class;
                characterDb.HitPoints = character.HitPoints;
                characterDb.Intelligence = character.Intelligence;

                _contextoPrincipal.Characters.Update(characterDb);
                await _contextoPrincipal.SaveChangesAsync(); 
            }

            return character;
        }
    }
}
