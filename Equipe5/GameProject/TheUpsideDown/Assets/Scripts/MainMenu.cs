using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Loader.Load(Assets.Enums.GameScene.Game);
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
