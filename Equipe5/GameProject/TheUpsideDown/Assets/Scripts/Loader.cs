using Assets.Enums;
using UnityEngine.SceneManagement;

public static class Loader
{
    private static GameScene _targetScene;

    public static void Load(GameScene scene)
    {
        SceneManager.LoadScene(GameScene.Loading.ToString());

        _targetScene = scene;
    }

    public static void LoadTargetScene()
    {
        SceneManager.LoadScene(_targetScene.ToString());
    }
}
