using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");

Smartphone nokia = new Nokia(numero:"999999999", modelo:"modelo 1", imei: "1111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Smartphone iphone = new Iphone(numero:"111111111", modelo:"modelo 2", imei:"2222222222", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");