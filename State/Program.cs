// See https://aka.ms/new-console-template for more information
using State;

Console.WriteLine("Hello, World!");

var directionService = new DirectionService();

directionService.travelMode = new DrivingMode();
directionService.GetEta();
directionService.GetDirection();

directionService.travelMode = new BicyclingMode();
directionService.GetEta();
directionService.GetDirection();