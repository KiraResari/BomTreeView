using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView
{
    class GameCharacterRepository
    {
        private static readonly GameCharacter sylvia
            = new GameCharacter("Sylvia", "Nefilim", "Axe");
        private static readonly GameCharacter bokay
            = new GameCharacter("Bokay", "Nefilim", "Bow");
        private static readonly List<GameCharacter> claudiasChildren
            = new List<GameCharacter>() { sylvia, bokay };
        private static readonly GameCharacter claudia
            = new GameCharacter("Claudia", "Nefilim", "Axe", claudiasChildren);
        private static readonly List<GameCharacter> ameliasChildren
            = new List<GameCharacter>() { claudia };
        private static readonly GameCharacter amelia
            = new GameCharacter("Amelia", "Nefilim", "None", ameliasChildren);
        private static readonly GameCharacter jioan
            = new GameCharacter("Jioan", "Celinne", "Fists");
        private static readonly GameCharacter idra
            = new GameCharacter("Idra", "Dragon", "Claws");
        private static readonly GameCharacter michael
            = new GameCharacter("Michael", "Seraph", "Iserial Projectors");
        private static readonly GameCharacter gabriel
            = new GameCharacter("Gabriel", "Seraph", "Greatsword");
        private static readonly GameCharacter uriel
            = new GameCharacter("Uriel", "Seraph", "Knuckles");
        private static readonly GameCharacter raphael
            = new GameCharacter("Raphael", "Seraph", "Lance");
        private static readonly GameCharacter amadeus
            = new GameCharacter("Amadeus", "Seraph", "Staff");
        private static readonly GameCharacter bianca
            = new GameCharacter("Bianca", "Sprite", "Orb");
        private static readonly List<GameCharacter> novasChildren
            = new List<GameCharacter>() { michael, raphael, uriel, gabriel, amadeus, bianca };
        private static readonly GameCharacter nova
            = new GameCharacter("Nova", "Goddess", "Scythe", novasChildren);

        public static readonly List<GameCharacter> sampleGameCharacters = new List<GameCharacter>()
        {
            amelia,
            jioan,
            idra,
            nova
        };

        public static GameCharacter GetCharacterByName(string characterName)
        {
            List<GameCharacter> flattenedGameCharacterList = GetFlattenedGameCharacterList();
            foreach(GameCharacter gameCharacter in flattenedGameCharacterList)
            {
                if(gameCharacter.Name == characterName)
                {
                    return gameCharacter;
                }
            }
            throw new Exception("Could not find character with name: " + characterName);
        }

        private static List<GameCharacter> GetFlattenedGameCharacterList()
        {
            List<GameCharacter> flattenedGameCharacterList = new List<GameCharacter>();
            foreach(GameCharacter gameCharacter in sampleGameCharacters)
            {
                flattenedGameCharacterList.Add(gameCharacter);
                flattenedGameCharacterList.AddRange(gameCharacter.GetFlattenedChildrenList());
            }
            return flattenedGameCharacterList;
        }
    }
}
