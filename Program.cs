using System;

namespace FazerDieta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção de dieta para o treino desejado:");
            Console.WriteLine("1- Hipertrofia/Proteína");
            Console.WriteLine("2- Definição Muscular");
            Console.WriteLine("3- Emagrecimento Saudável");
            Console.WriteLine("4- Dieta do Programador");
            Console.WriteLine("5- Dieta da Gamer Girl");
            Console.WriteLine("6- Dieta dos 9 anos");
            Console.Write("Opção: ");
            int.TryParse(Console.ReadLine(), out int Op);

            switch (Op){
                case 1:
                    Console.WriteLine(" Café da Manhã: Leite desnatado com abacate");
                    Console.WriteLine(" Almoço: Peixe cozido com espinafre temperado com gotas de limão");
                    Console.WriteLine(" Lanche: 3 castanhas + 1 iogurte desnatado");
                    Console.WriteLine(" Jantar: Salada de atum com aipo, alface, pepino e queijo");
                    Console.WriteLine("Obs: Evite comer alimentos com carboidratos/massas");
                    break;
                case 2:
                    Console.WriteLine(" Café da Manhã: Omelete 4 claras e 1 gema");
                    Console.WriteLine(" Almoço: Salada à vontade, 5 castanhas-do-pará, azeite extra-virgem, limão e pimenta ");
                    Console.WriteLine(" Lanche: sanduíche com 2 ovos mexidos");
                    Console.WriteLine(" Jantar: Salada e filé de carne magra (patinho, alcatra, coxão duro");
                    Console.WriteLine("Obs: Opte por comprar massa integral ou light");
                    break;
                case 3:
                    Console.WriteLine(" Café da Manhã: 240 ml de leite desnatado + omelete feita com 1 ovo e tomate");
                    Console.WriteLine(" Lanche da Manhã: 1 maçã + 3 castanhas");
                    Console.WriteLine(" Almoço: 150 g de filé de peixe + 2 col de sopa de grão de bico + salada cozida + 2 fatias de abacaxi");
                    Console.WriteLine(" Lanche da tarde: 1 iogurte desnatado + 1 col de sopa de linhaça");
                    Console.WriteLine("Obs: Não jante e evite carboidratos/massas");
                    break;
                case 4:
                    Console.WriteLine(" Café da Manhã: Sente-se no computador e tome coca-cola e coma um McDonalds");
                    Console.WriteLine(" Lanche da Manhã: Coca-Cola com xilitos na frente do computador");
                    Console.WriteLine(" Almoço: Espere sentado no computador sua mãe/esposa trazer 2 pizzas, uma de Calabresa com Catupiry e outra de Frango com Catupiry");
                    Console.WriteLine(" Lanche da tarde: Na frente do computador coma 3 sanduíches de carne moída assada no óleo com queijo e muita maionese");
                    Console.WriteLine(" Jantar: Espere sentado no computador sua mãe/esposa trazer a Lasagna de Bacon com 5 camadas de queijo e carne");
                    Console.WriteLine(" Lanche da Madrugada: Na frente do computador coma pão com pasta de amendoim e goiabada");
                    Console.WriteLine("Obs: Reze todos os dias pra não morrer de um ataque cardíaco");
                    break;
                case 5:
                    Console.WriteLine(" Café da Manhã: Comece uma stream de pijama e mostrando a alça do sutiã");
                    Console.WriteLine(" Lanche da Manhã: Deixe a câmera ligada e se troque em outro cômodo que projete sua sombra na câmera de forma a sugerir que você está pelada porém fora de alcance");
                    Console.WriteLine(" Almoço: Coma fazendo o máximo de barulho possível e pingando gordura no seu decote");
                    Console.WriteLine(" Lanche da tarde: Reclame do mundo machista e do patriarcado enquanto recebe doação de seguidores pra pack dos pezinhos");
                    Console.WriteLine(" Jantar: Peça uma pizza e faça piada com o entregador depois que ele for embora, pegue com as maos gordurosas no teclado e depois encerre a stream");
                    Console.WriteLine(" Lanche da Madrugada: Faça uma live no instagram fingindo ser solteira e estar carente");
                    Console.WriteLine("Obs: Lucre 2.500 por mês no patreon");
                    break;
                case 6:
                    Console.WriteLine("Se inscreva no canal do PewDiePie e ajude a derrotar T-Series");
                    break;
                default:
                    System.Console.WriteLine("Essa opção não é válida, tente novamente.");
                    break;

            }
        }
    }
}
