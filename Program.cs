// Encapsulation

//using DesignPatternLearning.src.OopsPrinciples.Encapsulation;

//BankAccount bankAccount = new BankAccount(100);

//System.Console.WriteLine(bankAccount.GetBalance());

//bankAccount.Deposit(100);
//System.Console.WriteLine(bankAccount.GetBalance());

//bankAccount.Withdraw(150);
//System.Console.WriteLine(bankAccount.GetBalance());

// Abstraction 

//using DesignPatternLearning.src.OopsPrinciples.Abstraction;

//EmailService emailService = new EmailService();

//emailService.Connect();
//emailService.Authenticate();
//emailService.SendEmail();
//emailService.Disconnect();


// Inheritence

//using DesignPatternLearning.src.OopsPrinciples.Inheritance;

//Car car = new Car();

//car.Brand = "mahindra";
//car.Start();
//car.Stop();
//car.NoOfWheels = 4;
//car.NoOfDoors = 4;

//Console.WriteLine("car brand: " + car.Brand);

//Bike bike  = new Bike();

//bike.Brand = "splender";
//bike.Start();
//bike.Stop();
//bike.NoOfWheels = 2;

//Console.WriteLine("bike brand: " + bike.Brand);


// Polymorphism
//using DesignPatternLearning.src.OopsPrinciples.Polymorphism;

//List<Vehicle> Vehicles = new List<Vehicle>();

//Vehicles.Add(new Car
//{
//    Brand = "Toyota",
//    Model = "Carrier",
//    Year = 2020,
//    NoOfDoors = 4
//});

//Vehicles.Add(new Motercycle
//{
//    Brand = "Splender",
//    Model = "Z",
//    Year = 2021
//});

//foreach (var vehicle in Vehicles)
//{
//    vehicle.Start();
//}


// S O L I D
// S 


// O


// L 


// I


// D



// DESIGN PATTERNS

// 1. Memento Pattern

//using DesignPatternLearning.src.DesignPattern.Behavioural;
//using DesignPatternLearning.src.DesignPattern.Behavioural.Memento;

//var editor = new Editor();
//var history = new History(editor);

//history.Backup();
//editor.Title = "Test";
//history.Backup();
//editor.Content = "Hello there, my name is Dawn";
//history.Backup();
//editor.Title = "The life of a dev: my memento";

//Console.WriteLine("Title: " + editor.Title);
//Console.WriteLine("Content: " + editor.Content);

//history.Undo();

//Console.WriteLine("Title: " + editor.Title);
//Console.WriteLine("Content: " + editor.Content);

//history.ShowHistory();

// 2. State Pattern

// bad solution

//using DesignPatternLearning.src.DesignPattern.Behavioural.State;

//var doc = new Document();
//doc.State = DocumentStates.Moderation;
//doc.CurrentUserRole = UserRoles.Admin;

//Console.WriteLine(doc.State);

//doc.Publish();

//Console.WriteLine(doc.State);

// Good solution

    // corrected

