
//////////////////////////////////////////////////////////////////// 1/5

//////////////////////////////////
///////////Spørgsmål 1.1//////////
//////////////////////////////////
//Svar: 1, 2, 3 og 4 viser ikke fejl


//MotorVehicle motorVehicle = new MotorVehicle();
//MotorVehicle motorVehicle = new Car();
//MotorVehicle motorVehicle = new Audi();
//Audi audi = new Audi();

////Error
//Audi audi = new Car(); 
////Error
//Audi audi = new MotorVehicle();


//////////////////////////////////
///////////Spørgsmål 1.2//////////
//////////////////////////////////
//Svar: Ja

//Audi audi = new Audi()
//{
//    Horsepower = 563,
//    Brand = "Audi",
//    Model = "A8"
//};


//////////////////////////////////
///////////Spørgsmål 1.3//////////
//////////////////////////////////
//Svar: Nej

//MotorVehicle motorVehicle = new MotorVehicle()
//{
//    Horsepower = 563
//};




//////////////////////////////////////////////////////////////////// 2/5


//////////////////////////////////
///////////Spørgsmål 2.1//////////
//////////////////////////////////
///Svar:

//MotorVehicleList motorVehicleList = new()
//{
//    Cars = new List<Car>()
//    {

//        new Car() { Brand = "Toyota", Model = "Aygo", Horsepower = 60 },

//        new Car() { Brand = "Fiat", Model = "Punto", Horsepower = 90 },

//        new Car() { Brand = "Audi", Model = "A6", Horsepower = 175 }

//    }
//};


//////////////////////////////////
///////////Spørgsmål 2.2//////////
//////////////////////////////////
///Svar:



//List<Car> HorsepowerOver60List = 
//    motorVehicleList.Cars.Where(obj => obj.Horsepower > 60).ToList();

//Console.WriteLine("Cars with horsepower over 60:");

//foreach (Car car in HorsepowerOver60List)
//{
//    Console.WriteLine
//        (
//        $"{car.Brand} {car.Model} - " +
//        $"Horsepower: {car.Horsepower}"
//        );
//}


//////////////////////////////////
///////////Spørgsmål 2.3//////////
//////////////////////////////////
///Svar:

//List<Car> AudiList = 
//    motorVehicleList.Cars.Where(obj => obj.Brand.Contains("Audi")).ToList();

//Console.WriteLine();

//Console.WriteLine("Cars from Audi:");

//foreach(Car car in AudiList)
//{
//    Console.WriteLine
//        (
//        $"{car.Brand} {car.Model} - " +
//        $"Horsepower: {car.Horsepower}"
//        );
//}


//////////////////////////////////////////////////////////////////// 3/5

//////////////////////////////////
///////////Spørgsmål 3.1//////////
//////////////////////////////////

//Svar:
//Cars.Where(...); //returnere en List<Car>


//////////////////////////////////
///////////Spørgsmål 3.2//////////
//////////////////////////////////
//Svar:
//Cars.FirstOrDefault(...); //og
//Cars.First(...);


//////////////////////////////////
///////////Spørgsmål 3.3//////////
//////////////////////////////////

//Svar:
//Cars.FirstOrDefault(..); //retunerer null


//////////////////////////////////
///////////Spørgsmål 3.4//////////
//////////////////////////////////

//Svar:
//Cars.First(...); //crash


//////////////////////////////////////////////////////////////////// 4/5


//////////////////////////////////
///////////Spørgsmål 4.1//////////
//////////////////////////////////

//Svar: Lav en virtual method i Car.cs som skal overrides i Audi.cs



//////////////////////////////////////////////////////////////////// 5/5

//////////////////////////////////
///////////Spørgsmål 5.1//////////
//////////////////////////////////

//Svar: SetSyn har to metoder og er derfor Overload

//welcome
Console.WriteLine("Vælg uddannelseslinje\n" +
    "1) Programmering\n" +
    "2) Support\n" +
    "3) Infrastruktur\n" +
    "\n" +
    "Vælg 1, 2 eller 3");

SchoolingCategory schoolingCategory = new();

List<TECPerson> tecpersons = new();

//Compiler Error CS1503 Argument1 cannot convert
Course course = new(schoolingCategory);

//menu choice
var menu = Convert.ToInt32(Console.ReadLine());
switch (menu)
{

    case 1:
        course.SchoolingName = SchoolingCategory.Programmeringslinje;
        course.SetCourses();
        break;

    case 2:

        course.SchoolingName = SchoolingCategory.Supporterlinje;
        course.SetCourses();
        break;

    case 3:

        course.SchoolingName = SchoolingCategory.Infrastrukturlinje;
        course.SetCourses();
        break;

}

Console.ReadKey();