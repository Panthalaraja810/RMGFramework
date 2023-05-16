using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RMGFramework.GenericUtilities
{
  
    public class CSharpUtilities
    {
   
        public int RandomThreeNum()
        {
            Random r = new Random();
          int ran =  r.Next(100);

            return ran;
        }
    }
}
