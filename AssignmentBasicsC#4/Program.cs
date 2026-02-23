using System.Diagnostics;
using System.Text;

namespace Assignment4C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //(a) Explain why this code is inefficient. Reference what happens in memory.
            //Because string is immutable every += creates a new string object in memory and copies the old value which causes unnecessary memory allocations and slower performance
            //(b) Rewrite this code using StringBuilder to be more efficient.
            //StringBuilder sb = new StringBuilder();

            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append("PROD-").Append(i).Append(",");
            //}

            //string productList = sb.ToString();
            //Console.WriteLine(productList);
            //(c) Add timing code (using Stopwatch) to both versions and report the time difference.
            //-->string
            //Stopwatch sw1 = Stopwatch.StartNew();

            //string productList = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList += "PROD-" + i + ",";
            //}

            //sw1.Stop();
            //Console.WriteLine("String Time: " + sw1.ElapsedMilliseconds + " ms");
            //--.>StringBuilder
            //Stopwatch sw2 = Stopwatch.StartNew();

            //StringBuilder sb = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append("PROD-").Append(i).Append(",");
            //}

            //string result = sb.ToString();

            //sw2.Stop();
            //Console.WriteLine("StringBuilder Time: " + sw2.ElapsedMilliseconds + " ms");
            #endregion
            #region Q2
            //Console.Write("Enter age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write("Enter day of week (1=Sun, 2=Mon, ..., 6=Fri, 7=Sat): ");
            //int day = int.Parse(Console.ReadLine());

            //Console.Write("Do you have a student ID? (yes/no): ");
            //string student = Console.ReadLine().ToLower();
            //double price = 0;

            //if (age < 5)
            //{
            //    price = 0;
            //    Console.WriteLine("Ticket is free for age under 5.");
            //}
            //else if (age >= 5 && age <= 12)
            //{
            //    price = 30;
            //}
            //else if (age >= 13 && age <= 59)
            //{
            //    price = 50;
            //}
            //else // age >= 60
            //{
            //    price = 25;
            //}
            //double breakdownPrice = price;
            //if (price > 0 && (day == 6 || day == 7)) // Fri or Sat
            //{
            //    price += 10;
            //    Console.WriteLine("Weekend surcharge added: +10 LE");
            //}
            //if (price > 0 && student == "yes")
            //{
            //    double discount = price * 0.2;
            //    price -= discount;
            //    Console.WriteLine("Student discount applied (20%): -" + discount + " LE");
            //}
            //Console.WriteLine($"Base price: {breakdownPrice} LE");
            //Console.WriteLine($"Final ticket price: {price} LE");
            #endregion
            #region Q3
            //string fileExtension = " pdf";
            //string fileType;
            //switch (fileExtension.Trim())
            //{
            //    case ".pdf":
            //        fileType = "PDF Document";
            //        break;

            //    case ".doc":
            //    case "doc":
            //        fileType = "Word Document";
            //        break;

            //    case ".xlsx":
            //    case "xls":
            //        fileType = "Excel Spreadsheet";
            //        break;
            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "Image File";
            //        break;

            //    default:
            //        fileType = "Unknown File Type";
            //        break;
            //}
            //Console.WriteLine("File type: " + fileType);

            #endregion
            #region َQ4
            //int temperature = 35;

            //string weatherAdvice = temperature < 0 ? "Freezing! Stay indoors."
            //                    : temperature < 15 ? "Cold. Wear a jacket."
            //                    : temperature < 25 ? "Pleasant weather."
            //                    : temperature < 35 ? "Warm. Stay hydrated."
            //                    : "Hot! Avoid sun exposure.";

            //Console.WriteLine(weatherAdvice);
            #endregion
            #region Q5

            //int attempts = 0;
            //const int maxAttempts = 5;
            //bool isValid = false;

            //do
            //{
            //    Console.Write("Enter password: ");
            //    string password = Console.ReadLine();
            //    attempts++;

            //    bool hasUpper = false;
            //    bool hasDigit = false;
            //    bool hasSpace = false;

            //    // ===== Check characters =====
            //    foreach (char c in password)
            //    {
            //        if (char.IsUpper(c)) hasUpper = true;
            //        if (char.IsDigit(c)) hasDigit = true;
            //        if (char.IsWhiteSpace(c)) hasSpace = true;
            //    }

            //    // ===== Validate rules =====
            //    string errors = "";
            //    if (password.Length < 8) errors += "- Must be at least 8 characters long\n";
            //    if (!hasUpper) errors += "- Must contain at least one uppercase letter\n";
            //    if (!hasDigit) errors += "- Must contain at least one digit\n";
            //    if (hasSpace) errors += "- Must not contain spaces\n";

            //    if (errors == "")
            //    {
            //        isValid = true;
            //        Console.WriteLine("Password accepted!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Password invalid. Please fix:");
            //        Console.WriteLine(errors);

            //        if (attempts >= maxAttempts)
            //        {
            //            Console.WriteLine("Account locked");
            //            break;
            //        }
            //    }

            //} while (!isValid && attempts < maxAttempts);

            #endregion
            #region َQ6
            //int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };

            //// ===== (a) Find all failing scores (<50) =====
            //Console.WriteLine("Failing scores (below 50):");
            //foreach (int score in scores)
            //{
            //    if (score < 50)
            //        Console.WriteLine(score);
            //}

            //// ===== (b) Find first score above 90 =====
            //Console.WriteLine("\nFirst score above 90:");
            //foreach (int score in scores)
            //{
            //    if (score > 90)
            //    {
            //        Console.WriteLine(score);
            //        break; // Stop searching
            //    }
            //}

            //// ===== (c) Calculate class average excluding scores below 40 =====
            //int sum = 0;
            //int count = 0;
            //foreach (int score in scores)
            //{
            //    if (score >= 40) // Exclude absent
            //    {
            //        sum += score;
            //        count++;
            //    }
            //}
            //double average = (count > 0) ? (double)sum / count : 0;
            //Console.WriteLine("\nClass average (excluding <40): " + average);

            //// ===== (d) Count students in each grade range =====
            //int gradeA = 0, gradeB = 0, gradeC = 0, gradeD = 0, gradeF = 0;

            //foreach (int score in scores)
            //{
            //    if (score >= 90) gradeA++;
            //    else if (score >= 80) gradeB++;
            //    else if (score >= 70) gradeC++;
            //    else if (score >= 60) gradeD++;
            //    else gradeF++;
            //}

            //Console.WriteLine("\nGrade distribution:");
            //Console.WriteLine("A (90-100): " + gradeA);
            //Console.WriteLine("B (80-89) : " + gradeB);
            //Console.WriteLine("C (70-79) : " + gradeC);
            //Console.WriteLine("D (60-69) : " + gradeD);
            //Console.WriteLine("F (<60)   : " + gradeF);

            #endregion
        }
    }
}
