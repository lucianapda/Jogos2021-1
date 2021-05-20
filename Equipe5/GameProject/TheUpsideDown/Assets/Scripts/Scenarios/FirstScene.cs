using Assets.Enums;

public class FirstScene : BaseScene
{
    public override GameScene NextScene => GameScene.SecondScenario;
    public override bool LoadNextSceneWithoutLoadingScene => true;

    public override void ConfigureScene()
    {
        AddDialog("PROTAGONISTA", "Estou com fome, mas acho que não tem nada em casa...");
        AddDialog("PROTAGONISTA", "Preciso ir ao mercado");
        AddDialog(string.Empty, "* [PROTAGONISTA] levanta e vai em direção à porta *");
    }
}
