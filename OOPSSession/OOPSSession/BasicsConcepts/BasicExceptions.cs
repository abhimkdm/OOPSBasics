using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSSession.BasicsConcepts
{
   public class BasicExceptions
    {
        public int result=0;
        public int Divide(int a, int b) {

            try
            {
                result = a / b;
                //int[] arr = new int[2];
                //arr[0] = 1;
                //arr[1] = 2;
                //arr[3] = 3;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw
            }
            finally {
                Console.WriteLine(result);
            }
            

            return result;
        } 
    }
}
