using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "98765-3240", modelo: "Nokia Y68", imei: "8765903215", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero: "99371-2579", modelo: "Iphone X", imei: "5790347001", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
