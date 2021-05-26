using Assets.Enums;
using Assets.Helpers;
using Assets.Utils.Extensions;

public class ThirdScene : BaseScene
{
    public override GameScene NextScene => GameScene.EleventhScene;

    public override void ConfigureScene()
    {
        var protagonistName = Protagonist.ToCamelCase();

        AddDialog(CharactersNames.Get(Character.FriendlyCat), "Rápido, venha comigo!");
        AddContextDialog($"Sem pensar duas vezes, [{Protagonist}] segue o felino.");
        AddDialog(Protagonist, "Quem é você?");
        AddDialog(CharactersNames.Get(Character.FriendlyCat), "Eu? Eu sou Gato!");
        AddDialog(CharactersNames.Get(Character.Cat), "Sou como um guia aqui, ajudando as pessoas que se perdem neste lugar");
        AddDialog(CharactersNames.Get(Character.Cat), "E você, quem é?");
        AddDialog(Protagonist, $"Meu nome é {protagonistName}");
        AddDialog(Protagonist, "E que lugar é este?! Tudo parece sujo, bagunçado, muito diferente do meu apartamento!");
        AddDialog(CharactersNames.Get(Character.Cat), "Este lugar? Simples!");
        AddDialog(CharactersNames.Get(Character.Cat), "Você está no mundo invertido, ele se parece bastante com a sua casa, só que... sujo e bagunçado, como você mesmo disse.");
        AddDialog(Protagonist, "Mas por que eu estou aqui? O que faço para voltar para o MEU mundo?");
        AddDialog(CharactersNames.Get(Character.Cat), $"Muitas perguntas, {protagonistName}, você nem está me deixando falar direito!");
        AddDialog(Protagonist, "Eu estou nervosa, não sei onde estou e muito menos o que fazer!");
        AddDialog(CharactersNames.Get(Character.Cat), "Ok, ok. Sua justificativa é razoável, mas não precisa mais se preocupar, pois eu estou aqui!");
        AddDialog(Protagonist, "...");
        AddDialog(Protagonist, "(É sério isso?)");
        AddDialog(CharactersNames.Get(Character.Cat), "Como você já entende que não está mais em casa, a primeira coisa que você precisa entender é sobre como este mundo funciona");
        AddDialog(CharactersNames.Get(Character.Cat), "Aqui, como acabamos de experimentar, existem monstros que te atacam na primeira oportunidade que tem");
        AddDialog(CharactersNames.Get(Character.Cat), "Recomendo que você fuja deles por enquanto, pois você precisa sobreviver");
        AddDialog(CharactersNames.Get(Character.Cat), "Você também tinha perguntado sobre como sair daqui, certo?");
        AddDialog(CharactersNames.Get(Character.Cat), "Então, existem duas maneiras, a fácil e a difícil");
        // Fazer com que o player escolha qual resposta ouvir primeiro.
        AddDialog(CharactersNames.Get(Character.Cat), "A mais difícil, é derrotando alguns monstros mais fortes, se tiver sorte, conseguirá voltar ao seu mundo");
        AddDialog(CharactersNames.Get(Character.Cat), "A mais fácil é morrendo, obviamente");
        AddDialog(CharactersNames.Get(Character.Cat), "Mas não se preocupe! Como eu disse antes, estou aqui para te ajudar");
    }
}