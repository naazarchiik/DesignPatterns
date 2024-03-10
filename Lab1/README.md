# LAB 1

## Code test result from [main method](./Lab1/ConsoleApp/Program.cs#L8-L60) 

![testResult](./Lab1/testResult.png);

## Description of the code

### DRY (Don’t Repeat Yourself)
The code does not contain repeated blocks of code. 
Each piece of information has a single, immutable representation in the code.
We can see it in every class in [directory](./Lab1/ClassLibrary)

### KISS (Keep It Simple, Stupid)
The code is simple and clear. 
It performs its tasks without unnecessary complexity.

### SOLID

* **Liskov Substitution Principle (LSP) :**
Classes [Dollar](./Lab1/ClassLibrary/Dollar.cs) and [Euro](./Lab1/ClassLibrary/Euro.cs) can be replaced by 
[ICurrency](./Lab1/ClassLibrary/ICurrency.cs) without changing the correct execution of the program.
[Warehouse](./Lab1/ClassLibrary/Warehouse.cs) can be replaced by any of its subtypes without changing the correct execution of the program

* **Interface Segregation Principle (ISP) :**
The [ICurrency](./Lab1/ClassLibrary/ICurrency.cs) and [Warehouse](./Lab1/ClassLibrary/Warehouse.cs) interface is specific and contains only the necessary methods.

* **Dependency Inversion Principle (DIP) :**
The [Money](./Lab1/ClassLibrary/Money.cs) class depends on an abstraction ([ICurrency](./Lab1/ClassLibrary/ICurrency.cs)) 
and not on concrete classes ([Dollar](./Lab1/ClassLibrary/Dollar.cs), [Euro](./Lab1/ClassLibrary/Euro.cs))
The [Reporting](./Lab1/ClassLibrary/Reporting.cs) class depends on the abstraction ([Warehouse](./Lab1/ClassLibrary/Warehouse.cs)), not on the concrete class (Warehouse).

### YAGNI (You Aren’t Gonna Need It)
The code does not contain anything superfluous and implements only the necessary functionality.

### Composition Over Inheritance
Composition is used ([Money](./Lab1/ClassLibrary/Money.cs) has an [ICurrency](./Lab1/ClassLibrary/ICurrency.cs) object;  [Reporting](./Lab1/ClassLibrary/Reporting.cs) has a [Warehouse](./Lab1/ClassLibrary/Warehouse.cs) object), not inheritance.

### Program to Interfaces, not Implementations
The [Money](./Lab1/ClassLibrary/Money.cs) class is programmed to the [ICurrency](./Lab1/ClassLibrary/ICurrency.cs) interface, not to specific implementations ([Dollar](./Lab1/ClassLibrary/Dollar.cs), [Euro](./Lab1/ClassLibrary/Euro.cs)).
And the [Reporting](./Lab1/ClassLibrary/Reporting.cs) class is programmed to the [Warehouse](./Lab1/ClassLibrary/Warehouse.cs) interface, not to a specific implementation [Warehouse](./Lab1/ClassLibrary/Warehouse.cs).

### Fail Fast
If the input data for the [Money](./Lab1/ClassLibrary/Money.cs) class or [Reporting](./Lab1/ClassLibrary/Reporting.cs) class is not as expected, the program will immediately report an error.