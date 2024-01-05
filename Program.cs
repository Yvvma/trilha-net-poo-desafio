using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(Numero: "728198", Modelo: "Model 1", IMEI: "111111111111111", Memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone");
Smartphone iphone = new Iphone(Numero: "1234", Modelo: "Model 2", IMEI: "222222222222222", Memoria: 128);
iphone.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");