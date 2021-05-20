using Assets.Enums;

public class SecondScene : BaseScene
{
    public override GameScene NextScene => GameScene.EndingMenu;

    public override void ConfigureScene()
    {
        AddDialog("PROTAGONISTA", "O qu�?!");
        AddDialog("PROTAGONISTA", "Eu estava em casa at� agora, o-onde estou?");
        AddDialog(string.Empty, "* BARULHO *");
        AddDialog("PROTAGONISTA", "Esse barulho, foi uma explos�o ou alguma coisa?");
        AddDialog("SER DESCONHECIDO", "GRRRR!");
        AddDialog("PROTAGONISTA", "Eu preciso correr");
        AddDialog("PROTAGONISTA", "O que fez este barulho n�o parece estar longe!");
        AddDialog(string.Empty, "* [PROTAGONISTA] corre at� o final do corredor, at� chegar na escada *");
    }
}
