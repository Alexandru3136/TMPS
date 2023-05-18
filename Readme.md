     În acest proiect, clasa Calculator este implementată ca un Singleton,
astfel încât să fie disponibilă o singură instanță a acesteia în
întregul program. Factory Method este utilizat pentru crearea
instanțelor de operații (Addition și Subtraction), oferind o modalitate
flexibilă de creare a diferitelor tipuri de operații matematice.


     Singleton este un model de design care permite crearea unei singure
instanțe a unei clase și asigură că toate apelurile la acea clasă se
referă la aceeași instanță. În acest proiect, clasa Calculator este
implementată ca un Singleton. Aceasta asigură că există o singură
instanță a clasei Calculator în cadrul programului.


     Factory Method este un alt model de design care oferă o modalitate de
creare a obiectelor fără a specifica exact clasa concretă a obiectului
ce trebuie creat. În proiect, avem clasa abstractă OperationFactory,
care definește o metodă abstractă CreateOperation() pentru crearea
instanțelor de operații matematice. Există două clase care extind
OperationFactory: AdditionFactory și SubtractionFactory. Aceste clase
concrete implementează metoda CreateOperation() și creează instanțe ale
claselor Addition și Subtraction.


// Clasa Singleton pentru Calculator public class Calculator { private
static Calculator \_instance;

private Calculator() { }

public static Calculator Instance { get { if (\_instance == null) {
\_instance = new Calculator(); } return \_instance; } }

public double ExecuteOperation(IOperation operation, double a, double b)
{ return operation.Calculate(a, b); } }

// Operația de adunare public class Addition : IOperation { public
double Calculate(double a, double b) { return a + b; } }

// Operația de scădere public class Subtraction : IOperation { public
double Calculate(double a, double b) { return a - b; } }


     În metoda Main(), se creează o instanță a Calculator folosind Singleton
și se utilizează Factory Method pentru a crea instanțele de operații
(Addition și Subtraction). Apoi, se apelează metoda ExecuteOperation()
pentru a efectua operații matematice și a obține rezultatele.


class Program { static void Main(string\[\] args) { // Utilizare
Singleton Calculator calculator = Calculator.Instance;

// Utilizare Factory Method OperationFactory factory = new
AdditionFactory(); IOperation operation = factory.CreateOperation();

double result = calculator.ExecuteOperation(operation, 5, 3);
Console.WriteLine(\"Addition: 5 + 3 = \" + result);

factory = new SubtractionFactory(); operation =
factory.CreateOperation();

result = calculator.ExecuteOperation(operation, 5, 3);
Console.WriteLine(\"Subtraction: 5 - 3 = \" + result);

Console.ReadLine(); } }
