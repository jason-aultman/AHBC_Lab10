using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace AHBC_Lab10
{
    public static class Validator
    {
        public static bool CheckValidInputPositiveDouble(string d)
        {
            if(double.TryParse(d, out double result))
            {
                if (CheckPositiveDouble(result))
                {
                    return true;
                }
                else return false;
            }
            else
            {                
                return false;
            }
        }
        public static bool CheckValidUserInputYorN(string s)
        {
            if (s.ToLower()=="y"||s.ToLower()=="n")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckPositiveDouble(double numberAsDouble)
        {
            if (Math.Abs(numberAsDouble) == numberAsDouble)
            {
                return true;
            }
            else return false;
        }
       

    }
}
