// See https://aka.ms/new-console-template for more information

List<int> numbers = new List<int> { 2, 4, 7, 10, 11, 32, 45, 87 };
var key = 0;
var keyIndex = 0;


Console.Write("NUMBERS: ");
for (int i = 0; i < numbers.Count; ++i) {
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();

var validInput = false;
while (!validInput) {
    Console.Write("Enter a whole number value, fool: ");
    try {
        key = int.Parse(Console.ReadLine());
        validInput = true;
    } catch {
        continue;
    }
}

keyIndex = LinearSearch(numbers, numbers.Count, key);


if (keyIndex == -1) {
    Console.WriteLine(key + " was not found.");
} else {
    Console.WriteLine("Found " + key + " at index " + keyIndex + ".");
}

static int LinearSearch(List<int> numbers, int numbersSize, int key) {

    for (int i = 0; i < numbers.Count; ++i) {
        if (numbers[i] == key) {
            return i;
        }
    }

    return -1; // not found
}