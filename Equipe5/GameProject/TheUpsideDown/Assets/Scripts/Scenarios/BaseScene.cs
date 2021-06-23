using Assets.Enums;
using UnityEngine;

public abstract class BaseScene : MonoBehaviour
{
    public abstract GameScene NextScene { get; }
    public virtual bool LoadNextSceneWithoutLoadingScene { get; } = false;

    protected void ChangeScene()
    {
        Loader.Load(NextScene, LoadNextSceneWithoutLoadingScene);
    }
}
