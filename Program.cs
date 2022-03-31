using System.Reflection;
using Spectre.Console;

AnsiConsole.Write(new FigletText("This is fine.").Centered());
AnsiConsole.WriteLine();

using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ThisIsFine.this is fine 1.png");
var image = new CanvasImage(stream!);
var leftPadding = Math.Max(0, (Console.WindowWidth / 2) - ((image.Width / 2) * image.PixelWidth));
var paddedImage = new Padder(image, new Padding(leftPadding, 0, 0, 0));
AnsiConsole.Write(paddedImage);