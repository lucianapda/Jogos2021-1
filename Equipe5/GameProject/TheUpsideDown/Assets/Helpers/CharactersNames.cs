using Assets.Enums;
using Assets.Utils.Extensions;

namespace Assets.Helpers
{

    public static class CharactersNames
    {
        public static string ProtagonistName { get; set; }

        public static string Get(Character character)
        {
            if (character == Character.Protagonist)
                return ProtagonistName;

            return character.GetStringValue().ToUpper();
        }
    }
}
