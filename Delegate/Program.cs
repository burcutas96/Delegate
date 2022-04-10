
using Delegate;

CustomerManager customerManager = new CustomerManager();
MyDelegate myDelegate = customerManager.SendMessage;
myDelegate += customerManager.ShowAlert;
myDelegate -= customerManager.SendMessage;

MyDelegate2 myDelegate2 = customerManager.SendMessage2;
myDelegate2 += customerManager.ShowAlert2;

Matematik matematik = new Matematik();
MyDelegate3 myDelegate3 = matematik.Topla;
myDelegate3 += matematik.Carp;

Console.WriteLine(myDelegate3(2, 4)); 
myDelegate2("Hello...");
myDelegate();

public delegate void MyDelegate();
public delegate void MyDelegate2(string text);
public delegate int MyDelegate3(int number1, int number2);








