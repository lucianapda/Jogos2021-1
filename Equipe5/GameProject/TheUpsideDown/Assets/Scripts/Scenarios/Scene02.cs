using Assets.Enums;
using Assets.Helpers;

public class Scene02 : DialogScene
{
    public override GameScene NextScene => GameScene.ThirdScenario;
    public override bool LoadNextSceneWithoutLoadingScene => true;

    public override void ConfigureSceneDialog()
    {
        AddDialog(Protagonist, "O qu�?!");
        AddDialog(Protagonist, "Eu estava em casa at� agora, o-onde estou?");
        AddContextDialog("* BARULHO *");
        AddDialog(Protagonist, "Esse barulho, foi uma explos�o ou alguma coisa?");
        AddDialog(CharactersNames.Get(Character.UnknowBeing), "GRRRR!");
        AddDialog(Protagonist, "Eu preciso correr");
        AddDialog(Protagonist, "O que fez este barulho n�o parece estar longe!");
        AddContextDialog($"* [{Protagonist}] corre at� o final do corredor, at� chegar na escada *");
    }
}
