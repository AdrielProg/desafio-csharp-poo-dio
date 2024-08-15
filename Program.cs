using DesafioPOO.Models;

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone("(87)95412-6352", "XYZ-200", "001970-01-010000-0", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");

Console.WriteLine();

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("(87)95412-6389", "AZ-400", "001970-01-010000-0", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube Music");


