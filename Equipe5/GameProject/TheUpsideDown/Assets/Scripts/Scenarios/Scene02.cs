using Assets.Enums;
using Assets.Helpers;

public class Scene02 : DialogScene
{
    public override GameScene NextScene => GameScene.ThirdScenario;
    public override bool LoadNextSceneWithoutLoadingScene => true;

    public override void ConfigureSceneDialog()
    {
        AddProtagonistDialog("O quê?!");
        AddProtagonistDialog("Eu estava em casa até agora, o-onde estou?");
        AddContextDialog("* BARULHO *");
        AddProtagonistDialog("Esse barulho, foi uma explosão ou alguma coisa?");
        AddDialog(CharactersNames.Get(Character.UnknowBeing), "GRRRR!");
        AddProtagonistDialog("Eu preciso correr");
        AddProtagonistDialog("O que fez este barulho não parece estar longe!");
        AddContextDialog($"* [{Protagonist}] corre até o final do corredor, até chegar na escada *");
    }
}
