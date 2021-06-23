using Assets.Enums;

public class Scene09 : DialogScene
{
    public override GameScene NextScene => GameScene.TenthScenario; // Mudar para TenthScene quando o Gato for incluído

    public override void ConfigureSceneDialog()
    {
        AddCatDialog($"Nossa {ProtagonistName}, você ta destruindo todos eles, sensacional!");
        AddCatDialog("Vamos, ainda temos mais alguns monstros para derrotar");
        AddProtagonistDialog($"{Cat}, antes de irmos...");
        AddProtagonistDialog("Você sabe muitos detalhes sobre cada um desses monstros");
        AddProtagonistDialog("Como você conseguiu descobrir tantas coisas sobre eles?");
        AddCatDialog("...");
        AddCatDialog("Eu sempre passeio por aqui quando estou entediado");
        AddCatDialog("Conheço cada pedaço dessa região, tenho observado eles há um tempo, por isso sei como agem...");
        AddProtagonistDialog("Mas como você vem acompanhando eles se eles são monstros baseados na minha personalidade?");
        AddProtagonistDialog("Inclusive, como você sabe disso?");
        AddCatDialog("E-eu te disse, você não é a primeira pessoa a passar por aqui, por isso eu sabia que os monstros eram baseados na sua personalidade");
        AddCatDialog("Mas vamos deixar isso de lado, precisamos ir para-");
        AddProtagonistDialog("Mesmo assim, não faz sentido você saber dos comportamentos deles");
        AddProtagonistDialog("Há quanto tempo eles estão aqui para você saber tanto sobre eles?");
        AddCatDialog("Garota, as vezes você me tira do sério.");
        AddProtagonistDialog("Quê?");
        AddCatDialog("Eu achei que você seria mais divertida que os outros, afinal, foi umas das poucas que conseguiu ir tão longe");
        AddCatDialog("Você deve ter percebido que este mundo não tem NADA além dos monstrinhos verdes e desses chefões que aparecem");
        AddCatDialog("O que você acha que eu faço nos momentos em que não tem ninguém aqui comigo?");
        AddCatDialog("Isso mesmo, NADA! Os monstrinhos são burros e os chefões também! Além de quererem brigar o tempo todo...");
        AddProtagonistDialog("Mas o que isso tem a ver com o fato de eu estar aqui?");
        AddCatDialog("Tola, você ainda não entendeu...");
        AddProtagonistDialog("Entendeu o quê?");
        AddCatDialog("Eu que lhe trouxe para cá!");
        AddCatDialog("Faz um tempo que estive lhe observando no mundo normal, vendo sua vida chata e tediosa, achei que poderia me divertir com você aqui, por isso te invoquei");
        AddProtagonistDialog("COMO ASSIM?!");
        AddCatDialog("Sim, eu fiz tudo isso, com o único propósito de tentar deixar meus dias menos tedioso");
        AddCatDialog("Mas olhe pelo lado bom, você conseguiu me entreter");
        AddProtagonistDialog("Me leve de volta para o meu mundo, AGORA!");
        AddCatDialog("Hahahaha, como se isso fosse acontecer");
        AddCatDialog("Agora que sabe a verdade, preciso por um fim nisso tudo...");
    }
}
