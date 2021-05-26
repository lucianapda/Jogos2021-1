using Assets.Enums;
using Assets.Helpers;

public class SecondScene : BaseScene
{
    public override GameScene NextScene => GameScene.ThirdScenario;
    public override bool LoadNextSceneWithoutLoadingScene => true;

    public override void ConfigureScene()
    {
        AddDialog(Protagonist, "O quê?!");
        AddDialog(Protagonist, "Eu estava em casa até agora, o-onde estou?");
        AddContextDialog("* BARULHO *");
        AddDialog(Protagonist, "Esse barulho, foi uma explosão ou alguma coisa?");
        AddDialog(CharactersNames.Get(Character.UnknowBeing), "GRRRR!");
        AddDialog(Protagonist, "Eu preciso correr");
        AddDialog(Protagonist, "O que fez este barulho não parece estar longe!");
        AddContextDialog($"* [{Protagonist}] corre até o final do corredor, até chegar na escada *");
    }
}
