using Assets.Enums;
using Assets.Helpers;

public class EleventhScene : BaseScene
{
    public override GameScene NextScene => GameScene.EndingMenu;

    public override void ConfigureScene()
    {
        AddDialog(Protagonist, "Hummm, espere, há instantes eu estava no mundo invertido, agora estou... em casa ?!");
        AddDialog(Protagonist, "Tudo que eu precisei enfrentar era apenas a minha imaginação?");
        AddDialog(Protagonist, "Estou confusa...");
        AddDialog(Protagonist, "Entretanto, me sinto melhor comigo mesma ao mesmo tempo...");
        AddDialog(Protagonist, "Ok, preciso comentar sobre essa loucura com minha psicóloga, ela vai adorar");
        AddDialog(CharactersNames.Get(Character.FriendlyCat), "Miau");
        AddDialog(Protagonist, "O que foi isso?");
        AddDialog(Protagonist, "Ah, um gatinho...");
        AddDialog(Protagonist, "Enfim, eu estava indo ao mercado comprar comida, né?");
        AddDialog(Protagonist, "Preciso ir andando, antes que eles fechem");
    }
}
