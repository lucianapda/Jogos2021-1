using Assets.Enums;
using UnityEngine;

public class Scene06 : BaseScene
{
    public override GameScene NextScene => GameScene.SeventhScene;

    void Start()
    {
        Loader.CurrentScene = GameScene.SixthScenario;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            ChangeScene();
        }
    }
}
