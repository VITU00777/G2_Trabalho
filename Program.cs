using System;
using static System.Console;

namespace Switch_Case_G2
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta ="";
            int pontuacao = 10;
            int idade;
          

            WriteLine("---------------");
            WriteLine("| QUIZ DETRAN |");
            WriteLine("---------------");

            WriteLine("");//Espaço

            Write("Informe sua idade: ");
            idade = Convert.ToInt16(ReadLine());

            WriteLine("");//Espaço

            switch(idade)
            {
                case >17:

                    //Pergunta 1--------------------------------------------------------------------------
                    WriteLine("1)Qual dessas alternativas é uma competência do DETRAN ? ");
                    WriteLine("A) Organizar estatísticas de trânsito em todo o país.");//Incorreta
                    WriteLine("B) Coordenar os órgãos do Sistema Nacional de Trânsito.");//Correta
                    WriteLine("C) Vistoriar, registrar, licenciar e emplacar veículos.");//Incorreta
                    WriteLine("D) Aprovar a sinalização de trânsito.");//Incorreta

                    WriteLine("");//Espaço----------
                    resposta = ReadLine();

                    resposta = resposta.ToUpper();
                    

                    switch(resposta)
                    {
                        case "A":
                            pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;

                        case "B":
                            WriteLine("Alternativa Correta !");//Correta
                        break;  

                        case "C":
                            pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;  

                        case "D":
                        pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;

                        default:
                            WriteLine("Alternativa Inválida !");
                        break;         
                    }

                    WriteLine("");//Espaço----------

                    //Pergunta 2--------------------------------------------------------------------------
                    WriteLine("2)Após um acidente com motocicleta, a vítima está inconsciente e caída no chão com os joelhos dobrados. Nesta situação, um cuidado a ser prestado à vítima é: ");
                    WriteLine("A) Transportar a vítima para o hospital o mais rápido possível, na posição sentada.");//Incorreta
                    WriteLine("B) Verificar presença de fratura no joelho e tentar colocar a articulação no lugar.");//Incorreta
                    WriteLine("C) Não tirar o capacete do motociclista."); //Correta
                    WriteLine("D) Movimentar a cabeça para cima e para baixo, e de um lado para outro.");//Incorreta

                    WriteLine("");//Espaço----------
                    resposta = ReadLine();

                    resposta = resposta.ToUpper();
                    
                    switch(resposta)
                    {
                        case "A":
                            pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;

                        case "B":
                            pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;  

                        case "C":
                            WriteLine("Alternativa Correta !");//Correta
                        break;  

                        case "D":
                        pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;

                        default:
                            WriteLine("Alternativa Inválida !");
                        break;         
                    }

                    WriteLine("");//Espaço----------

                //Pergunta 3--------------------------------------------------------------------------
                    WriteLine("3)É uma medida administrativa prevista no Código de Trânsito Brasileiro: ");
                    WriteLine("A) Frequência obrigatória em curso de reciclagem.");//Incorreta
                    WriteLine("B) Recolhimento da Carteira Nacional de Habilitação.");//Correta
                    WriteLine("C) Apreensão de animais que se encontrem soltos na via.");//Incorreta
                    WriteLine("D) Advertência verbal.");//Incorreta

                    WriteLine("");//Espaço----------
                    resposta = ReadLine();

                    resposta = resposta.ToUpper();
                    
                    switch(resposta)
                    {
                        case "A":
                            pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;

                        case "B":
                            WriteLine("Alternativa Correta !");//Correta
                        break;  

                        case "C":
                            pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;  

                        case "D":
                        pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;

                        default:
                            WriteLine("Alternativa Inválida !");
                        break;         
                    }

                    WriteLine("");//Espaço----------

                //Pergunta 4--------------------------------------------------------------------------
                    WriteLine("4)Uma das regras fundamentais para fazer a sinalização do acidente é: ");//Incorreta
                    WriteLine("A) Sinalizar o local até a uma distância a 3 metros do acidente.");//Incorreta
                    WriteLine("B) Iniciar a sinalização após o acidente ser visível.");//Incorreta
                    WriteLine("C) Não sinalizar com materiais encontrados nas imediações, tais com galhos de árvores e latas.");//Incorreta
                    WriteLine("D) Não permitir que curiosos parem na via destinada ao tráfego.");//Correta
                
                    WriteLine("");//Espaço----------
                    resposta = ReadLine();
                    

                    resposta = resposta.ToUpper();
                    
                    switch(resposta)
                    {
                        case "A":
                            pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;

                        case "B":
                            pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;  

                        case "C":
                            pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;  

                        case "D":
                            WriteLine("Alternativa Correta !");//Correta
                        break;

                        default:
                            WriteLine("Alternativa Inválida !");
                        break;         
                    }

                    WriteLine("");//Espaço----------

                    //Pergunta 5--------------------------------------------------------------------------
                    WriteLine("5)Em caso de acidente de trânsito com vítima, para acionar o Corpo de Bombeiros, deve-se ligar para: ");
                    WriteLine("A) 199.");//Incorreta
                    WriteLine("B) 191.");//Incorreta
                    WriteLine("C) 193.");//Correta
                    WriteLine("D) 190.");//Incorreta

                    WriteLine("");//Espaço----------
                    resposta = ReadLine();

                    resposta = resposta.ToUpper();
                    
                    switch(resposta)
                    {
                        case "A":
                            pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;

                        case "B":
                            pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;  

                        case "C":
                            WriteLine("Alternativa Correta !");//Correta
                        break;  

                        case "D":
                        pontuacao = pontuacao - 2;
                            WriteLine("Alternativa Incorreta !");
                        break;

                        default:
                            WriteLine("Alternativa Inválida !");
                        break;         
                    }

                    WriteLine("");//Espaço----------


                    


                    WriteLine("");//Espaço----------

                    switch(pontuacao)
                    {
                        case >7:
                            WriteLine("Obrigado por responder o QUIZ! Agora você está apto para dirigir!");
                            WriteLine($"Você obteve um total de {pontuacao} pontos ({pontuacao}/10).");
                        break;

                        
                        default:
                            WriteLine("Obrigado por responder o QUIZ! Infelizmente você não está apto para dirigir.");
                            WriteLine($"Você obteve um total de {pontuacao} pontos ({pontuacao}/10).");
                        break;
                    }

                    WriteLine("");//Espaço----------
                break;

                default:
                    WriteLine("Você não tem a idade necessária para dirigir.");   
                break;
                
            }
        }
    }
}