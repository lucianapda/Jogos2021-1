using Assets.Enums;
using Assets.Helpers;

public class Scene02 : DialogScene
{
    public override GameScene NextScene => GameScene.ThirdScenario;
    public override bool LoadNextSceneWithoutLoadingScene => true;

    public override void ConfigureSceneDialog()
    {
        AddProtagonistDialog("O qu�?!");
        AddProtagonistDialog("Eu estava em casa at� agora, o-onde estou?");
        AddContextDialog("* BARULHO *");
        AddProtagonistDialog("Esse barulho, foi uma explos�o ou alguma coisa?");
        AddDialog(CharactersNames.Get(Character.UnknowBeing), "GRRRR!");
        AddProtagonistDialog("Eu preciso correr");
        AddProtagonistDialog("O que fez este barulho n�o parece estar longe!");
        AddContextDialog($"* [{Protagonist}] corre at� o final do corredor, at� chegar na escada *");
    }
}
