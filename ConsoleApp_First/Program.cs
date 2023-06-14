using System;

namespace ConsoleApp_First
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            int y = 0;
            while (y < 3)
            {
                Console.WriteLine("Shelby Thromas " + y);
                y++;
            }
            Console.WriteLine("Loop ended"); //loopend
        
        #endregion

        #region
        string[] BrandTV = { "LG", "SONY", "SAMSUNG", "TCL", "JVC" };
        foreach (string television in BrandTV)
            {
            Console.WriteLine("Brand_Shelby" + television);
            }
    #endregion
}
}
}

//console.writeline("hello, world!");
/* if (20>18)
 * {
 * Console.Writeline("20 is Greater than 18")
 * }
 */

/*if else
 * int time = 20 ;
 *if (time < 18)
 *{
 *Console.Writeline("Good day.");
 *}
 *else
 *{
 *Console.Writeline("Good Evening.");
 *}
 */

/*if else if else
 * int time = 22;
 * if (time < 10){
 * Console.WriteLine("Good bad");
 * }else if (time <20) {
 * Console.Writeline("Good Bye.");
 * } else {
 * Console.WriteLine("Good evening.");
 * }
 */

/*switch(exprssion)
 * {
 * case result_expression1 : // block of code to be executed.break;
 * case result_expression2 : // block of code to be executed.break;
 * defualt : // block of code to be executed.break;
 * }
 */

/*for (int iterator = 0; iterator < 5: iterator++)
 * {
 * Console.Writeline("Counter"+i0;
 * }
 */

/*for (int iterator =0; iterator < 3;iterator++)
 * {
 * Console.WriteLine("Outer Loop :"+iterator);
 * 
 * for(int_iterator = 0;_iterator < 20; ++_iterator)
 * {
 * Console.WriteLine("Inner Loop:"+i); // 2 time
 * }
 * }
 */