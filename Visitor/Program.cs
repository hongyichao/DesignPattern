// See https://aka.ms/new-console-template for more information
using Visitor;

Console.WriteLine("Hello, World!");


var file = WavFile.read("test.wav");


file.Execute(new NoiseReductionOperation());

file.Execute(new ReverbOperation());

file.Execute(new NormalizeOperation());

