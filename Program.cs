using ConsoleFourangleClasses.Classes;

Console.WriteLine("Чектырехугольник1");
ClsFourangle fourngle1 = new ClsFourangle();
fourngle1.KeyboardInput();
fourngle1.SidesCalculation();
fourngle1.DiagonalsCalculation();
Console.WriteLine($"Периметр = {fourngle1.Perimetr()}");

Console.WriteLine("Четырехугольник 2");
ClsFourangle fourngle2 = new ClsFourangle(-5, 4, 8, 6, 9, -4, -4, -3);

fourngle2.SidesCalculation();
fourngle2.DiagonalsCalculation();
Console.WriteLine($"Периметр = {fourngle2.Perimetr()}");