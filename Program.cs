using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Iphone(numero: "123456", modelo: "Modelo '", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "5763", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

