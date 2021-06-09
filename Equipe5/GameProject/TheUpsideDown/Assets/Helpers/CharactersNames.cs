using Assets.Enums;
using Assets.Utils.Extensions;

namespace Assets.Helpers
{

    public static class CharactersNames
    {
        public static string ProtagonistName { get; set; }
        public static string DefaultProtagonistName = "Evelyn";

        public static string Get(Character character)
        {
            string characterName;

            if (character == Character.Protagonist)
                characterName = string.IsNullOrWhiteSpace(ProtagonistName) ? DefaultProtagonistName : ProtagonistName;
            else
                characterName = character.GetStringValue().ToUpper();

            return characterName.ToUpper();
        }
    }
}
