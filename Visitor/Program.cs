
using Visitor;

var file = WavFile.read("test.wav");


file.Execute(new NoiseReductionOperation());

file.Execute(new ReverbOperation());

file.Execute(new NormalizeOperation());

