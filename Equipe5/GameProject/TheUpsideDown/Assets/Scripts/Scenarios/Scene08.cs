using Assets.Enums;
using UnityEngine;

public class Scene08 : BaseScene
{
    public override GameScene NextScene => GameScene.NinethScene;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            ChangeScene();
        }
    }
}
