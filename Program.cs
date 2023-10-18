using DesafioPOO.Models;

Console.WriteLine("Demo Nokia Smartphone");
Smartphone nokia = new Nokia(numero: "+5599123456789", modelo: "modeloParaDemonstracao", imei: "1112223334", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("instagram");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "+5599123456789", modelo: "modeloParaDemonstracao", imei: "1112223334", memoria: 8);
iphone.Ligar();
iphone.InstalarAplicativo("instagram");
iphone.ReceberLigacao();