using Assets.Enums;

public class FirstScene : BaseScene
{
    public override GameScene NextScene => GameScene.SecondScenario;
    public override bool LoadNextSceneWithoutLoadingScene => true;

    public override void ConfigureScene()
    {
        AddDialog(Protagonist, "Estou com fome, mas acho que não tem nada em casa...");
        AddDialog(Protagonist, "Preciso ir ao mercado");
        AddContextDialog($"* [{Protagonist}] levanta e vai em direção à porta *");
    }
}
