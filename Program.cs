// Write a method that searches a give substring in a longer string.
// It must return the number of occurrences.

var input = "When Adam saw Eve, he said: Hello. Eve said Hello too. So Adam said HELLO again. Eve said hElLo again.";

var index = 0;
byte countOccurrences = 0;
do
{
    index = input.IndexOf("hello", index, StringComparison.OrdinalIgnoreCase);
    if (index != -1) { countOccurrences++; index += "hello".Length; }
}
while (index != -1);

System.Console.WriteLine(countOccurrences);

// -----------------------------------------------------------------------

// How to get the current working directory
string directory = Directory.GetCurrentDirectory();

string[] files = Directory.GetFiles(directory, "*.cs", SearchOption.AllDirectories);

foreach (var file in files) { System.Console.WriteLine(file); }
System.Console.WriteLine(files.Length);

// -----------------------------------------------------------------------

string result = string.Empty;
for (int i = 1; i < 700; i++)
{
    result += $"{i}";
}

System.Console.WriteLine(result);