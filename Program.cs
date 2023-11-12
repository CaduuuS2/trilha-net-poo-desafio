using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

    Smartphone nokia = new Nokia("22258190", "s23", "1234", 2024);
    Smartphone iphone = new Iphone("22253241", "i15", "1254", 2024);

    nokia.InstalarAplicativo("WhatsApp");
    iphone.InstalarAplicativo("Telegram");

    nokia.Ligar();
    iphone.Ligar();

    nokia.ReceberLigacao();
    iphone.ReceberLigacao();