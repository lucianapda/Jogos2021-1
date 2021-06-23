using Assets.Enums;
using UnityEngine;

public class Scene10 : BaseScene
{
    public override GameScene NextScene => GameScene.EleventhScene;

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
