using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "1929201823901", modelo: "Nokia XR21", imei: "1203940205910294", memoria: 128);
Smartphone iphone = new Iphone(numero: "9348502784018203", modelo: "Iphone 15", imei: "190283720273827618", memoria: 256);

Console.WriteLine("Smartphone Nokia XR21");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone 15");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
