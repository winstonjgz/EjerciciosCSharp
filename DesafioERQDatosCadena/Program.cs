const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string openDiv = "<div>";
const string closeDiv = "</div>";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = input.IndexOf(openDiv);
int closingPosition = input.IndexOf(closeDiv);

openingPosition += openDiv.Length;
int length = closingPosition - openingPosition;

//Para el monto 
int openingPositionQ = input.IndexOf(openSpan);
int closingPositionQ = input.IndexOf(closeSpan);
openingPositionQ += openSpan.Length;
int lengthQ = closingPositionQ - openingPositionQ;
quantity = input.Substring(openingPositionQ, lengthQ);
System.Console.WriteLine($"Quantity: {quantity}");

//Console.WriteLine(input.Substring(openingPosition, length));
output = input.Substring(openingPosition, length);
output = output.Replace("trade", "reg");
//System.Console.WriteLine(quantity);
System.Console.WriteLine($"Output: {output}");
