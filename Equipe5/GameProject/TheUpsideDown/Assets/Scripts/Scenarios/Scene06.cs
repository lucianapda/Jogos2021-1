using Assets.Enums;
using UnityEngine;

public class Scene06 : FigthScene
{
    public override GameScene NextScene => GameScene.SeventhScene;
    public GameObject Slime;
    public GameObject Chameleon;

    void Start()
    {
        Loader.CurrentScene = GameScene.SixthScenario;
    }

    protected override bool ShouldChangeScene()
        => !Slime.gameObject.activeSelf && !Chameleon.gameObject.activeSelf;
}
