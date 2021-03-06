﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.

namespace OOPGSM
{
    class CallHistoryTest
    {
        public static void Test()
        {
            MobileDevice phone = new MobileDevice("Alkatel", "CC");
            phone.AddCall(new Call(55, "897777000"));
            phone.AddCall(new Call(22, "062666666"));
            decimal totalPrice = phone.CalculatePrice(0.37m);
            phone.AddCall(new Call(60, "062333333"));
            phone.AddCall (new Call(160, "888888333"));
            totalPrice = phone.CalculatePrice(0.37m);
            Console.WriteLine("Price: {0:0.00}", totalPrice);
            totalPrice = phone.calculatePriceMaxOut(0.37m);
            Console.WriteLine("Price: {0:0.00}", totalPrice);
        }
    }
}
