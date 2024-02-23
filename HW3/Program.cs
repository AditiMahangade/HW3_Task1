// Aditi Mahangade
// MIS 3013 HW3 Task 1 Time to burn calories

double totalBurned = 0.0;
int numOfMinutes = 0;

string message = "How many calories do you wish to burn in this workout session? ";
Console.Write(message);
string userInputStr = Console.ReadLine();
double goalCaloriesDbl = Convert.ToDouble(userInputStr);

while (totalBurned < goalCaloriesDbl)
{
    numOfMinutes++;
    // numOfMinutes = numOfMinutes + 1;
    // numOfMinutes += 1;
    totalBurned = totalBurned + 3.9;
    message = string.Format("After {1} minute(s), you have burned {0:F2} calories", totalBurned, numOfMinutes);
    Console.WriteLine(message);
}