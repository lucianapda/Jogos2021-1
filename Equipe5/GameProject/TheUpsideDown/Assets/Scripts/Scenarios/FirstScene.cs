using Assets.Enums;

public class FirstScene : BaseScene
{
    public override GameScene NextScene => GameScene.SecondScenario;
    public override bool LoadNextSceneWithoutLoadingScene => true;

    public override void ConfigureScene()
    {
        AddDialog(Protagonist, "Estou com fome, mas acho que n�o tem nada em casa...");
        AddDialog(Protagonist, "Preciso ir ao mercado");
        AddContextDialog($"* [{Protagonist}] levanta e vai em dire��o � porta *");
    }
}
