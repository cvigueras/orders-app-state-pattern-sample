// See https://aka.ms/new-console-template for more information

using Orders.State.Pattern.App.DocumentModel;

Console.WriteLine("Hello, World!");
var header = Header.Create(2024,"Golosinas CarlosV");
var document = Document.Create(header);
var line = Line.Create(document.Number, header.Exercise, 1, "CV", 23.25);
document.RegisterLine(line);
var line2 = Line.Create(document.Number, header.Exercise, 2, "CV", 13.28);
document.RegisterLine(line2);
Console.WriteLine("El estado del documento es: " + document.GetState());
Console.WriteLine("El tipo del documento es: " + document.Type);
document.ProcessDocument();
Console.WriteLine("El estado del documento es: " + document.GetState());
Console.WriteLine("El tipo del documento es: " + document.Type);
document.ProcessDocument();
Console.WriteLine("El estado del documento es: " + document.GetState());
Console.ReadLine();