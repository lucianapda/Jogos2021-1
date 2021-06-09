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
            if (character == Character.Protagonist)
                return string.IsNullOrWhiteSpace(ProtagonistName) ? DefaultProtagonistName : ProtagonistName;

            return character.GetStringValue().ToUpper();
        }
    }
}
