using System;



/*A bank account has a holder name (first name, middle name and last name),
 * available amount of money (balance), bank name, IBAN, BIC code and 3 credit
 * card numbers associated with the account. Declare the variables needed to keep 
 * the information for a single bank account using the appropriate
 * data types and descriptive names.
 
 */
namespace BankAccount
{
    class BankAccount
    {
        static void Main()
        {

            string firstName = "Yoanna";
            string middleName = "Ilkova";
            string lastName = "Mareva";
            decimal AmountAva = 382938928932.987m;
            string bankName = "First Investment Bank";
            string IBAN = "BG00FINV91500000000000";
            string BIC = "FINVBGSF";
            ulong creditCard =  6000444422221111;
            ulong creditCard2 = 0234455676700005;
            ulong creditCard3 = 4532299478899889;

            Console.WriteLine("First Name:       {0:}\nMiddle Name:      {1}\nLast Name:        {2} \nAmount Available: {3}$",firstName, middleName, lastName,AmountAva );

            Console.WriteLine("CreditCard:       {0:0000 0000 0000 0000}", creditCard);
            Console.WriteLine("CreditCard2:      {0:0000 0000 0000 0000}", creditCard2);
            Console.WriteLine("CreditCard3:      {0:0000 0000 0000 0000}", creditCard3);

            Console.WriteLine("IBAN:             {0}", IBAN);
            Console.WriteLine("{0}\n{1}\n",bankName, BIC);


        }
    }
}
