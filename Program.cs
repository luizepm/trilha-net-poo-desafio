using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("11944444444", "N95", "1234567890", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("19955555555", "Iphone 14 Pro Max", "9876543210", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
