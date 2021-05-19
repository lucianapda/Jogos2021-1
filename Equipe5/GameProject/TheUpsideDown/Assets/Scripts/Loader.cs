using Assets.Enums;
using UnityEngine.SceneManagement;

public static class Loader
{
    private static GameScene targetScene;

    public static void Load(GameScene scene)
    {
        SceneManager.LoadScene(GameScene.Loading.ToString());

        targetScene = scene;
    }

    public static void LoadTargetScene()
    {
        SceneManager.LoadScene(targetScene.ToString());
    }
}
