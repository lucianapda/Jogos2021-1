using Assets.Utils.Attributes;

namespace Assets.Enums
{
    public enum GameScene
    {
        [StringValue("MainMenu")]
        MainMenu = 1,
        [StringValue("1 - The Apartment")]
        FirstScenario,
        [StringValue("2 - Apartment Hall")]
        SecondScenario,
        [StringValue("3 - Stairs")]
        ThirdScenario,
        [StringValue("4 - Level 1")]
        FourthScenario,
        [StringValue("5 - Between Fights")]
        FifthScene,
        [StringValue("6 - Level 2")]
        SixthScenario,
        [StringValue("7 - Between Fights")]
        SeventhScene,
        [StringValue("8 - Level 3")]
        EighthScenario,
        [StringValue("9 - Plot")]
        NinethScene,
        [StringValue("10 - Final Battle")]
        TenthScenario,
        [StringValue("11 - Ending")]
        EleventhScene,
        [StringValue("Loading")]
        Loading,
        [StringValue("EndingMenu")]
        EndingMenu
    }
}
