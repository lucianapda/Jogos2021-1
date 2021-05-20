using Assets.Enums;

public class SecondScene : BaseScene
{
    public override GameScene NextScene => GameScene.EndingMenu;

    public override void ConfigureScene()
    {
        AddDialog("PROTAGONISTA", "O quê?!");
        AddDialog("PROTAGONISTA", "Eu estava em casa até agora, o-onde estou?");
        AddDialog(string.Empty, "* BARULHO *");
        AddDialog("PROTAGONISTA", "Esse barulho, foi uma explosão ou alguma coisa?");
        AddDialog("SER DESCONHECIDO", "GRRRR!");
        AddDialog("PROTAGONISTA", "Eu preciso correr");
        AddDialog("PROTAGONISTA", "O que fez este barulho não parece estar longe!");
        AddDialog(string.Empty, "* [PROTAGONISTA] corre até o final do corredor, até chegar na escada *");
    }
}
