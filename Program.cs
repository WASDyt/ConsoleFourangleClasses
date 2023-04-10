using ConsoleFourangleClasses.Classes;

Console.WriteLine("Чектырехугольник1");
ClsFourangle fourngle1 = new ClsFourangle();
fourngle1.KeyboardInput();
fourngle1.SidesCalculation();
fourngle1.DiagonalsCalculation();
Console.WriteLine($"Периметр = {fourngle1.Perimetr()}");
Console.WriteLine($"Площадь = {fourngle1.Ploshad()}");

Console.WriteLine("Четырехугольник 2");
ClsFourangle fourngle2 = new ClsFourangle(-5, 4, 8, 6, 9, -4, -4, -3);

fourngle2.SidesCalculation();
fourngle2.DiagonalsCalculation();
Console.WriteLine($"Периметр = {fourngle2.Perimetr()}");

ClsParallelogram parall = new ClsParallelogram();
parall.KeyboardInput();
parall.SidesCalculation();
parall.DiagonalsCalculation();
Console.WriteLine($"Периметр = {parall.Perimetr()}");

ClsParallelogram rec = new ClsParallelogram();
rec.KeyboardInput();
rec.SidesCalculation();
rec.DiagonalsCalculation();
Console.WriteLine($"Периметр = {rec.Perimetr()}");

ClsParallelogram rhomb = new ClsParallelogram();
rhomb.KeyboardInput();
rhomb.SidesCalculation();
rhomb.DiagonalsCalculation();
Console.WriteLine($"Периметр = {rhomb.Perimetr()}");