﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjThirdApp
{
    public class AgeNotValid : ApplicationException
    {
        public AgeNotValid(string Message) : base(Message)
        {

        }
    }
    class ExceptionHandleEg
    {
        static void Main()
        {
            try
            {
                int num = 10, div = 0;
                if (div == 0)
                {
                    throw new DivideByZeroException();
                    //throw new exception();
                }
                else
                {
                    num = num / div;
                }
                Console.WriteLine(num);
                int[] arr = new int[] { 20, 30, 40 };
                //Console.WriteLine(arr[6]);
                Console.WriteLine("Enter the age");
                int Age = Convert.ToInt32(Console.ReadLine());
                if (Age < 18)
                {
                    throw new AgeNotValid("To Vote Age Should be greater than 18");
                }
                else
                {
                    Console.WriteLine("Eligible to vote");
                }
            }
            //Error Child then Parent
            /*catch(Exception e)
             * {
             *      Console.WriteLine(e);
             * }
             */
            catch (DivideByZeroException e)
            {
                //Console.WriteLine(e);
                //Console.WriteLine(e.Message);
                //Console.WriteLine(e.Source);
                Console.WriteLine("Please Enter Valid number!!!!");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Hope you're Good!!!");
            }
        }
    }
}
