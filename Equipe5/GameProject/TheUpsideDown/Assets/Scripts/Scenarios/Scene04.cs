using Assets.Enums;
using UnityEngine;

public class Scene04 : FigthScene
{
    public override GameScene NextScene => GameScene.FifthScene;
    public GameObject Slime;
    public GameObject Snail;

    void Start()
    {
        Loader.CurrentScene = GameScene.FourthScenario;
    }

    protected override bool ShouldChangeScene()
        => !Slime.gameObject.activeSelf && !Snail.gameObject.activeSelf;
}
