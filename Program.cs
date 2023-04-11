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
Console.WriteLine($"Площадь = {fourngle2.Ploshad()}");

ClsParallelogram parall = new ClsParallelogram();
parall.KeyboardInput();
parall.SidesCalculation();
parall.DiagonalsCalculation();
parall.HeightCalculation();
Console.WriteLine($"Периметр = {parall.Perimetr()}");
Console.WriteLine($"Площадь = {parall.Ploshad()}");

ClsRectangle rec = new ClsRectangle();
rec.KeyboardInput();
rec.SidesCalculation();
rec.DiagonalsCalculation();
Console.WriteLine($"Периметр = {rec.Perimetr()}");
Console.WriteLine($"Площадь = {rec.Ploshad()}");

ClsRhomb rhomb = new ClsRhomb();
rhomb.KeyboardInput();
rhomb.SidesCalculation();
rhomb.DiagonalsCalculation();
Console.WriteLine($"Периметр = {rhomb.Perimetr()}");
Console.WriteLine($"Площадь = {rhomb.Ploshad()}");