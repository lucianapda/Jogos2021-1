using Assets.Enums;
using Assets.Utils.Extensions;

namespace Assets.Helpers
{
    public static class CharactersNames
    {
        public static string Get(Character character)
        {
            if (character == Character.Protagonist)
                return "PROTAGONISTA";

            return character.GetStringValue().ToUpper();
        }
    }
}
