//Purchase Discount App

Console.WriteLine("Hello! Welcome in Coderz market :)");
DateTime dateTime = DateTime.UtcNow;
string dateTimeStr = dateTime.ToString("dd-MMMM-yyyy");
string dateTimeStr2 = dateTime.ToString("hh:mm-ss tt");
Console.WriteLine($"Date: {dateTimeStr} | Time: {dateTimeStr2}");
Console.WriteLine("=====================================================");

Console.WriteLine("Enter the value of your purchase invoice:");
double billValue = Convert.ToDouble(Console.ReadLine());

double BillDiscount; //Discount value
double Total; //Total price after discount

if (billValue >= 500)
{
    BillDiscount = billValue * 0.2;
    Console.WriteLine($"Your Discount is %20: ${BillDiscount}");
    Console.WriteLine($"Total Price: ${Total = billValue - BillDiscount}");
}
else if (billValue <= 499 && billValue >= 300)
{
    BillDiscount = billValue * 0.1;
    Console.WriteLine($"Your Discount is %10: ${BillDiscount}");
    Console.WriteLine($"Total Price: ${Total = billValue - BillDiscount}");
}
else if(billValue < 300 && billValue >= 1)
{
    Console.WriteLine($"Total Price: ${billValue}");
}
else
{ //if the value in minus (-)
    Console.WriteLine("You owe us money :)");
}
