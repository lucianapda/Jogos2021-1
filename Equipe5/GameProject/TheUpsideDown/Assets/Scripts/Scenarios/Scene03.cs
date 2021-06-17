using Assets.Enums;
using Assets.Helpers;

public class Scene03 : DialogScene
{
    public override GameScene NextScene => GameScene.FourthScenario;

    public override void ConfigureSceneDialog()
    {
        var friendlyCatName = CharactersNames.Get(Character.FriendlyCat);

        AddDialog(friendlyCatName, "Rápido, venha comigo!");
        AddContextDialog($"Sem pensar duas vezes, [{Protagonist}] segue o felino.");
        AddDialog(Protagonist, "Quem é você?");
        AddDialog(friendlyCatName, "Eu? Eu sou Gato!");
        AddCatDialog("Sou como um guia aqui, ajudando as pessoas que se perdem neste lugar");
        AddCatDialog("E você, quem é?");
        AddDialog(Protagonist, $"Meu nome é {ProtagonistName}");
        AddDialog(Protagonist, "E que lugar é este?! Tudo parece sujo, bagunçado, muito diferente do meu apartamento!");
        AddCatDialog("Este lugar? Simples!");
        AddCatDialog("Você está no mundo invertido, ele se parece bastante com a sua casa, só que... sujo e bagunçado, como você mesma disse.");
        AddProtagonistDialog("Mas por que eu estou aqui? O que faço para voltar para o MEU mundo?");
        AddCatDialog($"Muitas perguntas, {ProtagonistName}, você nem está me deixando falar direito!");
        AddDialog(Protagonist, "Eu estou nervosa, não sei onde estou e muito menos o que fazer!");
        AddCatDialog("Ok, ok. Sua justificativa é razoável, mas não precisa mais se preocupar, pois eu estou aqui!");
        AddProtagonistDialog("...");
        AddProtagonistDialog("(É sério isso?)");
        AddCatDialog("Como você já entende que não está mais em casa, a primeira coisa que você precisa entender é sobre como este mundo funciona");
        AddCatDialog("Aqui, como acabamos de experimentar, existem monstros que te atacam na primeira oportunidade que tem");
        AddCatDialog("Recomendo que você fuja deles por enquanto, pois você precisa sobreviver");
        AddCatDialog("Você também tinha perguntado sobre como sair daqui, certo?");
        AddCatDialog("Então, existem duas maneiras, a fácil e a difícil");
        // Fazer com que o player escolha qual resposta ouvir primeiro.
        AddCatDialog("A mais difícil é derrotando alguns monstros mais fortes, se tiver sorte, conseguirá voltar ao seu mundo");
        AddCatDialog("A mais fácil é morrendo, obviamente");
        AddCatDialog("Hehe");
        AddCatDialog("Mas não se preocupe! Como eu disse antes, estou aqui para te ajudar");
        AddProtagonistDialog("...");
        AddProtagonistDialog("Tá, como um vídeo game então...");
        AddProtagonistDialog("Depois que derrotar um deles, eu posso voltar para casa?");
        AddCatDialog("Normalmente, quando uma quantidade destes chefões é derrotada, você consegue voltar para o seu mundo, mas só descobriremos depois de derrotá-los.");
        AddProtagonistDialog("Certo...");
        AddCatDialog($"Estamos pertos do chefão {LazzinessName}");
        AddCatDialog("Ele se movimenta lentamente, seja precisa em seus golpes para conseguir derrotá-lo");
        AddProtagonistDialog("Deixe comigo! Vou derrotá-lo. Preciso de mais alguma dica?");
        AddCatDialog("Esse monstro é muito resistente, você precisa persistir na luta");
        AddProtagonistDialog("Vou persistir, esse monstro não sobreviverá!");
        AddCatDialog($"Tome cuidado, {ProtagonistName}");
    }
}