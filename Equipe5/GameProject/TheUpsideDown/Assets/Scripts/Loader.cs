using Assets.Enums;
using Assets.Utils.Extensions;
using UnityEngine.SceneManagement;

public static class Loader
{
    private static GameScene _targetScene;
    public static GameScene CurrentScene { get; set; }

    public static void Load(GameScene scene, bool loadRightNow = false)
    {
        CurrentScene = scene;
        if (loadRightNow)
            SceneManager.LoadScene(scene.GetStringValue());
        else
        {
            SceneManager.LoadScene(GameScene.Loading.GetStringValue());

            _targetScene = scene;
        }
    }

    public static void LoadTargetScene()
    {
        SceneManager.LoadScene(_targetScene.GetStringValue());
    }
}
