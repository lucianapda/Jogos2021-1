using Assets.Utils.Attributes;

namespace Assets.Enums
{
    public enum GameScene
    {
        [StringValue("MainMenu")]
        MainMenu,
        [StringValue("1 - The Apartment")]
        FirstScenario,
        [StringValue("2 - Apartment Hall")]
        SecondScenario,
        [StringValue("3 - Stairs")]
        ThirdScenario,
        [StringValue("11 - Ending")]
        EleventhScene,
        [StringValue("Loading")]
        Loading,
        [StringValue("EndingMenu")]
        EndingMenu
    }
}
