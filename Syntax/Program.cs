//// original given
//int answer = 4;
//string response;
//if (answer < 9)
//{
//    response = answer + " is less than nine";
//}
//else
//{
//    response = answer + " is greater than or equal to nine";
//}

//Console.WriteLine(response);

//inferred

//var answer = 4;
//var response = "";

//if (answer < 9)
//{
//  response = answer + " is less than nine";
//}
//else
//{
//  response = answer + " is greater than or equal to nine";
//}

//Console.WriteLine(response);



//string interpolation

int answer = 4;

if (answer < 9)
{
    Console.WriteLine($"{answer} is less than nine");
}
else
{
    Console.WriteLine($"{answer} is greater than or equal to nine");
}



//ternary operator

int answer = 4;
string response;
response = (answer < 9)? ($"{answer} is less than 9") : ($"{answer} is greater than 9");
Console.WriteLine(response);