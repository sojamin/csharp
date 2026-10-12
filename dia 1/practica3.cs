Console.OutputEncoding = System.Text.Encoding.UTF8;
DateTime ahora = DateTime.Now;
Console.WriteLine("Fecha: " + ahora.ToString(HH: mm));
Console.WriteLine("Dia de la semana: " + ahora.DayOfWeek);
Console.WriteLine("Faltan " + (19 - ahora.Hour) + "horas pra el cierre.");
