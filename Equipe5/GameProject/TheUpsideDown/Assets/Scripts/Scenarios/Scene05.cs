using Assets.Enums;

public class Scene05 : DialogScene
{
    public override GameScene NextScene => GameScene.SixthScenario;

    public override void ConfigureSceneDialog()
    {
        AddCatDialog($"Parece que você conseguiu derrotar {LazzinessName}, muito bem");
        AddCatDialog($"Agora, estamos próximos do chefão {InsecurityName}");
        AddCatDialog($"{InsecurityName} se esconde e aparece repentinamente em lugares diferentes");
        AddCatDialog("Tome cuidado, ele só vai conseguir te atacar quando estiver visível");
        AddProtagonistDialog("Acho que estou pronta para ele");
        AddCatDialog("Então vamos lá!");
        AddProtagonistDialog("Espere, antes da luta, percebi uma coisa...");
        AddProtagonistDialog("Estes monstros são caracteristicas da minha personalidade?");
        AddCatDialog("De certa forma, sim");
        AddCatDialog("Pode-se dizer que todos são monstros interiores seus");
        AddProtagonistDialog("(Que horror...)");
        AddProtagonistDialog("(Se eu derrotá-los, eu conseguirei melhorar?)");
    }
}
