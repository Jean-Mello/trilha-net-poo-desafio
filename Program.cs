using DesafioPOO.Models;

//Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("123456789", "modelo 1", "11111111", 64);
Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Smartphone iphone = new Iphone("789456123", "modelo 2", "222222222", 128);
Console.WriteLine("\nSmartphone Iphone:");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");