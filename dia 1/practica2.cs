Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Bienvenido a la panaderia La Espina");
Console.WriteLine("Como se llama?");
string cliente  = Console.ReadLine();
Console.WriteLine("Hola, " + cliente + ". Que le sirvo hoy?");
Console.WriteLine("¿Que producto desea?");
string producto    = Console.ReadLine();
Console.WriteLine("Anotado: " + producto + "para" + cliente + ".");
