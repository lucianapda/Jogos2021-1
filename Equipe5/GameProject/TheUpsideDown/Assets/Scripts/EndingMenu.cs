using UnityEngine;

public class EndingMenu : MonoBehaviour
{
    public void GoToMainMenu()
    {
        Loader.Load(Assets.Enums.GameScene.MainMenu);
    }
}
