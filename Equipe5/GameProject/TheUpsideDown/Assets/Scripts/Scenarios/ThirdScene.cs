using Assets.Enums;
using Assets.Helpers;
using Assets.Utils.Extensions;

public class ThirdScene : BaseScene
{
    public override GameScene NextScene => GameScene.FourthScenario;

    public override void ConfigureScene()
    {
        var protagonistName = Protagonist.ToCamelCase();

        AddDialog(CharactersNames.Get(Character.FriendlyCat), "R�pido, venha comigo!");
        AddContextDialog($"Sem pensar duas vezes, [{Protagonist}] segue o felino.");
        AddDialog(Protagonist, "Quem � voc�?");
        AddDialog(CharactersNames.Get(Character.FriendlyCat), "Eu? Eu sou Gato!");
        AddDialog(CharactersNames.Get(Character.Cat), "Sou como um guia aqui, ajudando as pessoas que se perdem neste lugar");
        AddDialog(CharactersNames.Get(Character.Cat), "E voc�, quem �?");
        AddDialog(Protagonist, $"Meu nome � {protagonistName}");
        AddDialog(Protagonist, "E que lugar � este?! Tudo parece sujo, bagun�ado, muito diferente do meu apartamento!");
        AddDialog(CharactersNames.Get(Character.Cat), "Este lugar? Simples!");
        AddDialog(CharactersNames.Get(Character.Cat), "Voc� est� no mundo invertido, ele se parece bastante com a sua casa, s� que... sujo e bagun�ado, como voc� mesmo disse.");
        AddDialog(Protagonist, "Mas por que eu estou aqui? O que fa�o para voltar para o MEU mundo?");
        AddDialog(CharactersNames.Get(Character.Cat), $"Muitas perguntas, {protagonistName}, voc� nem est� me deixando falar direito!");
        AddDialog(Protagonist, "Eu estou nervosa, n�o sei onde estou e muito menos o que fazer!");
        AddDialog(CharactersNames.Get(Character.Cat), "Ok, ok. Sua justificativa � razo�vel, mas n�o precisa mais se preocupar, pois eu estou aqui!");
        AddDialog(Protagonist, "...");
        AddDialog(Protagonist, "(� s�rio isso?)");
        AddDialog(CharactersNames.Get(Character.Cat), "Como voc� j� entende que n�o est� mais em casa, a primeira coisa que voc� precisa entender � sobre como este mundo funciona");
        AddDialog(CharactersNames.Get(Character.Cat), "Aqui, como acabamos de experimentar, existem monstros que te atacam na primeira oportunidade que tem");
        AddDialog(CharactersNames.Get(Character.Cat), "Recomendo que voc� fuja deles por enquanto, pois voc� precisa sobreviver");
        AddDialog(CharactersNames.Get(Character.Cat), "Voc� tamb�m tinha perguntado sobre como sair daqui, certo?");
        AddDialog(CharactersNames.Get(Character.Cat), "Ent�o, existem duas maneiras, a f�cil e a dif�cil");
        // Fazer com que o player escolha qual resposta ouvir primeiro.
        AddDialog(CharactersNames.Get(Character.Cat), "A mais dif�cil, � derrotando alguns monstros mais fortes, se tiver sorte, conseguir� voltar ao seu mundo");
        AddDialog(CharactersNames.Get(Character.Cat), "A mais f�cil � morrendo, obviamente");
        AddDialog(CharactersNames.Get(Character.Cat), "Mas n�o se preocupe! Como eu disse antes, estou aqui para te ajudar");
    }
}