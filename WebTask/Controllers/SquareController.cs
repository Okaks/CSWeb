using Microsoft.AspNetCore.Mvc;
using System;

namespace SqrWeb.Controllers
{
    public class SquareController : Controller
    {
        public ActionResult sqrt()
        {
          return View();  
        }
        
        [HttpPost]
        public ActionResult sqrt(string firstNum, string secondNum)
        {
            String result;
            try{
                int firstNumber = int.Parse(firstNum);
                int secondNumber = int.Parse(secondNum);

                result = "";
                if(firstNumber < 0)
                {
                    result += " Error " + firstNumber + " is not valid, (negative)";
                }
                if(secondNumber < 0)
                {
                    result += " Error "+ secondNumber + " is not valid, (negative)";
                }
                if(result == "")
                {
                    double sqrtFirst = Math.Sqrt(firstNumber);
                    double sqrtSecond = Math.Sqrt(secondNumber);

                    if(sqrtFirst > sqrtSecond)
                    {
                        result = "The number " + firstNumber + " with square root " + sqrtFirst + " has a higher square root than the number " + secondNumber + " with square root "+ sqrtSecond;
                    }
                    else if( sqrtFirst < sqrtSecond){
                        result = "The number " +  firstNumber + " with square root " + sqrtFirst + " has a lower square root than the number " + secondNumber + " with square root "+ sqrtSecond;
                    }
                    else{
                        result = "The numbers entered are the same value, please enter another number";
                    }
                }

            }
            catch(Exception e){
                result = "Exception error: "+ e.Message;
            }

            
            ViewBag.result = result;
          return View();  
        }
    }
}