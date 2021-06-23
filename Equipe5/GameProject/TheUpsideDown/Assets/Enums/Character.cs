using Assets.Utils.Attributes;

namespace Assets.Enums
{
    public enum Character
    {
        Protagonist,
        [StringValue("Gato")]
        Cat,
        [StringValue("Gato Amigável")]
        FriendlyCat,
        [StringValue("Ser Desconhecido")]
        UnknowBeing,
        [StringValue("Lazziness")]
        Lazziness,
        [StringValue("Insecurity")]
        Insecurity,
        [StringValue("Anxiety")]
        Anxiety
    }
}
