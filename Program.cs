// Fernando Aguilar
// 10-20-22
// Mini Challenge #4 Greater Than, Less Than, or Equal Too Endpoint
// The program will ask the user to input two numbers. Will include data validation.
// The terminal will output whether the values are greater than, less than, or equal to each other.
// Peer Reviewed By: Brandon Le

Console.Clear();

string playAgain = "";
bool wrongAns = true;
bool wrongAns2 = true;
double rightAns = 0;
double rightAns2 = 0;
while(playAgain != "end")
{
    Console.WriteLine(" Hello! Pick two numbers to compare!");
    Console.WriteLine(" Choose your first number. Enter end to close program.");
string num1 = Console.ReadLine();
if(num1 == "end" || num1 == "End" || num1 == "END")
{
    Console.WriteLine(" Good bye! ");
    break;
}else{
Console.WriteLine( " Choose your second number.");
string num2 = Console.ReadLine();

wrongAns = double.TryParse(num1, out rightAns);
wrongAns2 = double.TryParse(num2, out rightAns2);

if((wrongAns != true) || (wrongAns2 != true))
{
    Console.WriteLine(" One or both of your inputs are incorrect.");
}
else if(rightAns > rightAns2)
{
    Console.WriteLine( num1 + " is greater than " + num2);
    Console.WriteLine( num2 + " is less than " + num1 );
}
else if ( rightAns < rightAns2 )
{
    Console.WriteLine(num1 + " is less than " + num2);
    Console.WriteLine(num2 + " is greater than " + num1 );
}else {
    Console.WriteLine( num1 + " is equal to " + num2 );
}
}
Console.WriteLine(" Would you like to play again? type end to close program or type yes to play again. ");
num1 = Console.ReadLine().ToUpper();
if(num1 == "yes".ToUpper())
{
    Console.WriteLine(" Let's play again! ");
}
else
{
Console.WriteLine(" Good bye! ");
break;
}
}