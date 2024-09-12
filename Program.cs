// string pangram = "The quick brown fox jumps over the lazy dog";
// Console.WriteLine("");

// string[] words = pangram.Split(" ");

// string[] reversedWords = new string[words.Length];
// int index = 0;

// foreach(string word in words)
// {
//     char[] charArray = word.ToCharArray();
//     Array.Reverse(charArray);
//     reversedWords[index] = new string(charArray);
//     index++;
// }
// string result = String.Join(" ", reversedWords);
// Console.WriteLine(result);

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] orderIds = orderStream.Split(",");
// Array.Sort(orderIds);
// for (int i =0; i < orderIds.Length; i++)
// {
//     if(orderIds[i].Length == 4)
//     {
//         Console.WriteLine(orderIds[i]);
//     }
//     else
//     Console.WriteLine(orderIds[i] + "\t- Error");

// }
// using System.Globalization;

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;


// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
// Console.WriteLine(" ");
// Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
// Console.WriteLine(" ");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C2}. ");
// Console.WriteLine(" ");

// Console.WriteLine("Here's a quick comparison:\n");
// string firstProduct = currentProduct.PadRight(20);
// string myProduct = currentReturn.ToString("P", new CultureInfo("en-US"));
// string myProfit = currentProfit.ToString("C", new CultureInfo("en-US"));
// string comparisonMessage = firstProduct + myProduct + "   " + myProfit;

// // Your logic here
// //Console.WriteLine($"{firstProduct}  {currentReturn:P2}");
// Console.WriteLine(comparisonMessage);


// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));


// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

// Remove Replace characters
//Rmove
// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

//Replace
// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);


//Code Challenge
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string openSpan = "<span>";
const string closeSpan = "</span>";


int openingPosition = input.IndexOf(openSpan);
openingPosition += openSpan.Length;
int closingPosition = input.LastIndexOf(closeSpan);
int length = closingPosition - openingPosition;
quantity = "Quantity: " + input.Substring(openingPosition, length);

output = input.Replace("&trade;", "&reg;");

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);