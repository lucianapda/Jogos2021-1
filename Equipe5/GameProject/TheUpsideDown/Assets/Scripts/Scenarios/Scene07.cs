using Assets.Enums;

public class Scene07 : DialogScene
{
    public override GameScene NextScene => GameScene.EighthScenario;

    public override void ConfigureSceneDialog()
    {
        AddCatDialog($"Parece que você se saiu bem com {InsecurityName} também, parabéns!");
        AddCatDialog($"Agora, estamos próximos do chefão {AnxietyName}");
        AddCatDialog("Diferente dos outros, ele se movimenta rapidamente");
        AddCatDialog("Uma luta contra ele será mais desafiador, mas acredito que esteja preparada");
        AddProtagonistDialog("Eu vou vencr, não importa quão desafiador seja!");
        AddProtagonistDialog("(Tem algo que me incomoda...)");
        AddProtagonistDialog($"({Cat} sempre sabe detalhes sobre os chefões...)");
        AddProtagonistDialog("(E se eles são monstros internos meus, como ele poderia saber disso?)");
        AddProtagonistDialog("(Muito estranho...)");
        AddCatDialog($"{ProtagonistName}, aconteceu algo? Você parece pensativa");
        AddProtagonistDialog("Ah, eu? Nada demais, vamos para a próxima luta...");
    }
}
