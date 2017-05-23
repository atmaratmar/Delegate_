using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Delegate definition
            /* A delegate is type safe a funnction pointer. meaning a dalegate point to a function, and then when you invoke this 
             * Dalegate the function will invoked. sence the dalegate is function pointer lets create function  */
            #endregion
            #region 3
            /* we create an instance this dalegate and in to the constractor of this Dalegate you pass the 
             * name of the function to which you want this Dalegate point to  in our Example i want to point 
             * this dalegate to Hello function 
             look at the intlisence the paramter we pass should be (void (string)target) is our method conforming
             this function yes so now we can pass our method name now to invoke that method all you do is to invoke
             this Dalegate  now if you see our dalegate in number2 it expect a string now this dalecagte will 
             call Hello method and pss the pass our message that method and what ever that method should it will do
             the job in this case it vill print the message*/
            #endregion 
            HelloFunctionDalegate del = new HelloFunctionDalegate(Hello);
            del("hello from dalegate");


        }

        #region 1
        /* we have a simple function lets say Hello and this function taks a message of type string lets called string
         strMessage, and all this function does it print the message to the console*/
        #endregion
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage + " ," + "atmar");
        }
    }
    #region 2
    /*now to create a class we use class key word similerly we create delegate class we write dalegate to remmeber dalegate syntext
    similer to a function signetuer apart from it had dalegate key word 
    it has access modfier return type and parameter .but if you put dalegate key word there it become dalegate meaning this dalegate 
    can be used to point to a function 
    this delegate can be point to any function which has void return type and taks parameter 
    now how do make this dálegate point to a function to do that you have to create an instance of this dalegate and this is where 
    a dalegate is similer to a class. if i have a cutomer class i can say customer c1 equal to new customer  c1 is the instance
    of that class similerly i can create instance of this dalegate */
    #endregion
    public delegate void HelloFunctionDalegate(string Message);
}
