using Assets.Enums;
using UnityEngine;

public class Scene04 : BaseScene
{
    public override GameScene NextScene => GameScene.FifthScene;

    void Start()
    {
        Loader.CurrentScene = GameScene.FourthScenario;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            ChangeScene();
        }
    }
}
