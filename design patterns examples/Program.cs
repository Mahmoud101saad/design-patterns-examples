using design_patterns_examples.Factory;
//asd
void WriteColoredLine(
   string text, ConsoleColor color = ConsoleColor.Green)
{
	Console.ForegroundColor = color;
	Console.WriteLine(text);
}


#region singleton pattern
//Counter counter1 = Counter.GetInstance();
//Counter counter2 = Counter.GetInstance();

//counter1.AddOne();
//counter2.AddOne();
//Console.WriteLine($"Counter 1: {counter1.count}");
//Console.WriteLine($"Counter 2: {counter2.count}");
//Console.WriteLine();
//counter1.AddOne();
//Console.WriteLine($"Counter 1: {counter1.count}");
//Console.WriteLine($"Counter 2: {counter2.count}");

//// multiple threads

//Task task1 = Task.Factory.StartNew(() => {
//	Counter counter1 = Counter.GetInstance();
//	counter1.AddOne();
//	Console.WriteLine($"Counter 1: {counter1.count}");
//});

//Task task2 = Task.Factory.StartNew(() => {
//	Counter counter2 = Counter.GetInstance();
//	counter2.AddOne();
//	Console.WriteLine($"Counter 2: {counter2.count}");
//	Console.WriteLine();
//});
#endregion


#region prototype pattern	
//EmployeePrototype tempEmp1 = new TempEmployee();
//tempEmp1.Name = "temp employee 1";
//tempEmp1.Id = 1;
//tempEmp1.EmpAddress = new Address { City = "city 1", Building = "B1", StreetName = "street name" };

//EmployeePrototype tempEmp2 = tempEmp1.ShallowCopy();

//Console.WriteLine("========= Temp Emp 1 Original Values=============");
//Console.WriteLine(tempEmp1.ToString());
//Console.WriteLine("========= Temp Emp 2 Copy========================");
//Console.WriteLine(tempEmp2.ToString());

//tempEmp2.EmpAddress.City = "new city";
//tempEmp2.Id = 2;
//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("========= Temp Emp 1 After Change ===============");
//Console.WriteLine(tempEmp1.ToString());
//Console.WriteLine("========= Temp Emp 2 ============================");
//Console.WriteLine(tempEmp2.ToString());
#endregion


#region builder pattern

//System.Text.StringBuilder sb = new System.Text.StringBuilder();
//sb.Append("Word 1,");
//sb.Append("Word 2");

//WriteColoredLine(sb.ToString(), ConsoleColor.Cyan);

//Director director = new Director();
//IBuilder carBuilder = new CarBuilder("Jeep");

//// Making Car
//director.Construct(carBuilder);
//Product car = carBuilder.GetVehicle();
//WriteColoredLine($"Car {car.Show()}");


#endregion

#region factory pattern
string cardNumber, bankCode;

//1-create factory =
BankFactory bankFactory = new BankFactory();

WriteColoredLine("Enter card number:");

cardNumber = Console.ReadLine();
bankCode = cardNumber.Substring(0, 6);

//2- create bank object based on bank code
IBank bank = bankFactory.createBanck(bankCode);


WriteColoredLine(bank.withdraw());



#endregion
Console.ReadKey();