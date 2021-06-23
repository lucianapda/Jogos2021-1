using Assets.Enums;
using UnityEngine;

public class Scene08 : BaseScene
{
    public override GameScene NextScene => GameScene.NinethScene;

    void Start()
    {
        Loader.CurrentScene = GameScene.EighthScenario;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            ChangeScene();
        }
    }
}
