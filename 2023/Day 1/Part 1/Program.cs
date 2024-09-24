string[] calibrationDoc = File.ReadAllLines("..\\calibrationDoc.txt");

int totalSum = 0;

Console.WriteLine("Calibration values of");

// Loop through entire array
for (int i = 0; i < calibrationDoc.Length; i++)
{
  string calibrationValue = "";
  char curChar;
  bool isInt = false;

  // Loop through entire line from index 0
  for (int j = 0; j < calibrationDoc[i].Length; j++)
  {
    // if curChar is convertible to digit then stop the loop immediately,
    // then add the digit as the first character of calibrationValue 
    curChar = calibrationDoc[i][j];
    isInt = char.IsDigit(curChar);
    if (isInt)
    {
      calibrationValue += curChar;
      break;
    }
  }

  // Loop through entire line from last index of current line
  for (int j = calibrationDoc[i].Length - 1; j >= 0; j--)
  {
    curChar = calibrationDoc[i][j];
    isInt = char.IsDigit(curChar);
    if (isInt)
    {
      calibrationValue += curChar;
      break;
    }
  }

  int calibrationNum = int.Parse(calibrationValue);

  Console.WriteLine($"Line {i + 1} : {calibrationNum}");

  totalSum += calibrationNum;
}

Console.WriteLine($"Sum of all the calibration values : {totalSum}");
