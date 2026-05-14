// 9. Write a new program similar to the program # 6 but take user input for Student Fee and University Discount
// Hint:
// Create a variable named fee and take user input for fee.
// Create another variable discountPercent and take user input.
// Compute the discount and assign it to the discount variable.
// Compute and print the fee you have to pay by subtracting the discount from the fee.
// I/P => fee, discountPercent
// O/P => The discount amount is INR ___ and final discounted fee is INR ___

using System;
class FeeDiscount_2{
    static void Main(){
   int fee=Convert.ToInt32(Console.ReadLine());
   int discountPercent=Convert.ToInt32(Console.ReadLine());

   double disAmount=(fee*discountPercent)/100.0;
   double disFee=fee-disAmount;

   Console.WriteLine("The discount amount is INR "+disAmount+" and final discounted fee is INR "+disFee);
}
}
