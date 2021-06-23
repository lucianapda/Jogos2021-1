using Assets.Enums;
using UnityEngine;

public class Scene08 : FigthScene
{
    public override GameScene NextScene => GameScene.NinethScene;
    public GameObject Bunny;

    void Start()
    {
        Loader.CurrentScene = GameScene.EighthScenario;
    }

    protected override bool ShouldChangeScene()
        => !Bunny.gameObject.activeSelf;
}
