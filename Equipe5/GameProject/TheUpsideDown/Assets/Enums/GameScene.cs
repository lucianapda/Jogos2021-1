﻿using Assets.Utils.Attributes;

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
        [StringValue("Loading")]
        Loading,
        [StringValue("EndingMenu")]
        EndingMenu
    }
}
