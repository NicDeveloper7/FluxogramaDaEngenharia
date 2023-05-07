
    //By NicholasDev

    //Declaração de variáveis "response1" e "response2"
    string response1;
    string response2;

    Console.WriteLine("O objeto está se movendo (S/N)? ");
    response1 = Console.ReadLine()!.ToUpper();
    
    //Verifica se a resposta é "S" (sim), indicando que o objeto está em movimento
    if (response1 == "S") 
    {
        Console.WriteLine("Deveria (S/N)? ");
        response2 = Console.ReadLine()!.ToUpper();
            //Verifica se deveria estar em movimento
            if (response2 == "S") 
            {
              Console.WriteLine("Ótimo");
            }

            //Verificação se a resposta da pergunta anterior é "N" (não)
            else if (response2 == "N")
            {
                //Comando para mostrar na tela "Use Silver Tape"
                Console.WriteLine("Use Silver Tape");
            }
    }

    //Verificação se a resposta da pergunta anterior é "N" (não)
    if (response1 == "N")
    {
        Console.WriteLine("Deveria (S/N)? ");
        response2 = Console.ReadLine()!.ToUpper();

            //Verificação se a resposta da pergunta anterior é "N" (não)
            if (response2 == "N")
            {
                 //Comando para mostrar na tela "Ótimo"
                Console.WriteLine("Ótimo");
            }
            //Verificação se a resposta da pergunta anterior é "S" (sim)
            else if (response2 == "S")
            {
                //Comando para mostrar na tela "Use WD-40"
                Console.WriteLine("Use WD-40");
            }
    }
   