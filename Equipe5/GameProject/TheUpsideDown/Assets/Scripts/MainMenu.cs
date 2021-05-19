using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        Loader.Load(Assets.Enums.GameScene.FirstScenario);
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
