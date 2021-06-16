using Assets.Enums;

public class Scene01 : DialogScene
{
    public override GameScene NextScene => GameScene.SecondScenario;
    public override bool LoadNextSceneWithoutLoadingScene => true;

    public override void ConfigureSceneDialog()
    {
        AddDialog(Protagonist, "Estou com fome, mas acho que n�o tem nada em casa...");
        AddDialog(Protagonist, "Preciso ir ao mercado");
        AddContextDialog($"* [{Protagonist}] levanta e vai em dire��o � porta *");
    }
}
