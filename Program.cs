using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iPhone = new Iphone
    (
        numero: "+55 88 988887777",
        modelo: "12 Pro",
        imei: "xxx-111-yyy-222",
        memoria: 128
    );

Nokia nokia = new Nokia
    (
        numero: "+55 99 955554444",
        modelo: "C20",
        imei: "aaa-333-ccc-999",
        memoria: 64
    );
//operando a classe Iphone
Console.WriteLine(iPhone);
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Github");

Console.WriteLine("--------------------------");
//operando a classe Nokia
Console.WriteLine(nokia);
nokia.Ligar();
nokia.ReceberLigacao();
iPhone.InstalarAplicativo("Youtube");
