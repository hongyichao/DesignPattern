
using State;

var directionService = new DirectionService();

directionService.travelMode = new DrivingMode();
directionService.GetEta();
directionService.GetDirection();

directionService.travelMode = new BicyclingMode();
directionService.GetEta();
directionService.GetDirection();