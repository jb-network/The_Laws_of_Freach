// This is challenge work for the "C# Players Guide"
// Level 12 The Laws of Freach Challenge
// This challenge requires us to modify code to change the looping structure from a for loop to a for each loop

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;

foreach (int item in array)
    total += item;

float average = (float)total / array.Length;
Console.WriteLine(average);

