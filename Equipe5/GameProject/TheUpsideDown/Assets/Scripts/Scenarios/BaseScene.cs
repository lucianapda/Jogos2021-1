using Assets.Enums;
using UnityEngine;

public abstract class BaseScene : MonoBehaviour
{
    public abstract GameScene NextScene { get; }
    public virtual bool LoadNextSceneWithoutLoadingScene { get; } = false;

    public abstract void ConfigureScene();

    protected void ChangeScene()
    {
        Loader.Load(NextScene, LoadNextSceneWithoutLoadingScene);
    }
}
