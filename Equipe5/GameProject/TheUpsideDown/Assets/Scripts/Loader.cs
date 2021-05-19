using Assets.Enums;
using Assets.Utils.Extensions;
using UnityEngine.SceneManagement;

public static class Loader
{
    private static GameScene _targetScene;

    public static void Load(GameScene scene)
    {
        SceneManager.LoadScene(GameScene.Loading.GetStringValue());

        _targetScene = scene;
    }

    public static void LoadTargetScene()
    {
        SceneManager.LoadScene(_targetScene.GetStringValue());
    }
}
