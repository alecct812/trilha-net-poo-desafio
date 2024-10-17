using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "7129", modelo: "Nokia 3310", imei:"818181818", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "3918", modelo: "iPhone 16 Pro", imei:"919191919", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("YouTube");