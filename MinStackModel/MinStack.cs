using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinStackModel
{
    public class MinStack
    {
        private List<int> listStack;
        int capacity = 10000;
        int minCalls ;
        public MinStack()
        {
            minCalls = 0;
            listStack = new List<int>(capacity);

        }

        public void push(int a)
        {
            if (minCalls <= 30000)
            {
                listStack.Add(a);
            }
            else
            {
                throw new Exception("Minimum number of Function Calls must not exceed 3*10^4");
            }
            minCalls++;


        }

        public void pop()
        {
            if (minCalls <= 30000)
            {


                if (listStack.Count > 0)
                {
                    listStack.Remove(listStack[listStack.Count - 1]);
                }
                else
                {
                    throw new Exception("No Item found to be Poped");
                }
            }
            else
            {
                throw new Exception("Minimum number of Function Calls must not exceed 3*10^4");
            }
            minCalls++;

        }

        public int top()
        {
            int ontop = 0;
            
            if (minCalls <= 30000)
            {

                if (listStack.Count > 0)
                {

                    ontop = listStack[listStack.Count - 1];
                }
                else
                {
                    throw new Exception("No Items available on top");
                }
            }
            else
            {
                throw new Exception("Minimum number of Function Calls must not exceed 3*10^4");
            }


            return ontop;



        }

        public int getMin()
        {
            int min = 0;
            if (minCalls <= 30000)
            {

                if (listStack.Count > 0)
                {
                    min = listStack.Min<int>();
                }
                else
                {
                    throw new Exception("No Items found");

                }
            }
            else
            {
                throw new Exception("Minimum number of Function Calls must not exceed 3*10^4");
            }


            return min;
        }






    }
}
