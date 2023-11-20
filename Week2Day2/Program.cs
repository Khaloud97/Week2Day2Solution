namespace Week2Day2
{
     class Program
    {   //class 
        //static DataType FunctionName (Arguments or Parameters)
        //{
        //    logic of cup of tea
        //    return something from the same DataType
        //}

        //static void (Notype) FunctionName (Arguments or Parameters)
        //{
        //    logic of cup of tea
        //     No return 
        //     Console.WriteLine("");
        //}
        //-----------------------------------------------------------------------------------------------
        //------------------------------Example of static Function in Behaviour---------------------------

        static void PrintLine( )
        {
            Console.WriteLine("----------");
        }

        //------------------ Example of general Function in Behaviour ----------------------------

        static void PrintLineGe(int n=10, string pattern="_")//n=10 , pattern="_" is the defoult value
        {
            for(int i=0; i<n; i++) {
                Console.Write(pattern);
            }
            Console.WriteLine();

            
        }

        //----------------------------------------Example  of Function have dataType--------------------------------------------

        static int SumFunction(int x, int y)
        {
            return x + y;
        }

        static int MultFunction(int x, int y)
        {
            return x * y;
        }

        //-----------------------------------------------------------------------------------------------
        static void PrintLineUser(int lengthPattern , string pattern ,bool flage = false)//n=10 , pattern="_" is the defoult value
        {  
            if(flage == true) {
                for (int i = 0; i < lengthPattern; i++)
                {
                    Console.WriteLine(pattern);
                }
            }
            else {
                for (int i = 0; i < lengthPattern; i++)
                  {
                    Console.Write(pattern);
                  }
                }
           


        }

        //---------------------------------------function with Swap value--------------------------------------------------------

        static void SwapValue(int x, int y ) {

            Console.WriteLine( $"Oraginal value {x} , {y}");
            int temp = x;
            x = y; //replace x value with y
            y = temp; //replace y value with Temp Value (old x)
            Console.WriteLine($"Swapped Successfuly {x} , {y}");

        }

        //---------------------------------------function with Swap refrenc--------------------------------------------------------

        static void SwapreRrenc(ref int x, ref int y)
        {

            Console.WriteLine($"Oraginal value {x} , {y}");
            int temp = x;
            x = y; //replace x value with y
            y = temp; //replace y value with Temp Value (old x)
            Console.WriteLine($"Swapped with refrenc Successfuly {x} , {y}");

        }

        //-----------------------------------------------------------------------------------------------
       /*tatic void HeadLines(string s)
        {
            Console.Title = s;
            
            Console.WriteLine(s);
            

        }
       */

        static void Main(string[] args)//startup Function
        {
            #region Example  of Function:
            Console.WriteLine("Hello, To Function example !");
            PrintLine();

            //-----------------------------------------------------------------------
            Console.WriteLine("------------Function PrintLineGe--------");
            PrintLineGe(6, "*__*");//call the Function to print it
            PrintLineGe(pattern: "*%%*", n: 4);
            PrintLineGe();

            //-----------------------------------------------------------------------
            Console.WriteLine("-------------My Example  of Function value enter by user:-------------- ");
            Console.Write("Enter the pattern you want: ");
            string pattern = Console.ReadLine();

            Console.Write("Enter the length of your  pattern: ");
            int lengthPattern = Convert.ToInt32(Console.ReadLine());

            //Console.ReadLine();
            bool flage = true;
            //Console.WriteLine(flage);

            Console.WriteLine("With flage true :");
            PrintLineUser(lengthPattern, pattern, flage);

            Console.WriteLine("With flage false :");
            PrintLineUser(lengthPattern, pattern);
            #endregion

            //-----------------------------------------------------------------------

            #region Example  of Function  have dataType:
            Console.WriteLine("\n---------Example  of Function have dataType------------------------");
            Console.WriteLine("The Function of sum :");
            SumFunction(2, 4);
            Console.WriteLine($"The Sum ={SumFunction(2, 4)}");


            Console.WriteLine("The Function of Multiplication :");
            MultFunction(2, 4);
            Console.WriteLine($"The Multiplication ={MultFunction(2, 4)}");
            #endregion

            //-----------------------------------------------------------------------
            Console.WriteLine("\n\n----------------------------");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Example of Swap function with value:");
            #region Example of Swap function with value:


            //HeadLines("Example of Swap function with value:");
            int a = 4, b = 5;

            Console.WriteLine("Output of calling the swap by passing value: ");
            SwapValue(a, b);

            Console.WriteLine($"a value = {a} , b value ={b} this is what is stored in stack");
            Console.WriteLine($" value {a} , {b} is not chage ");
            #endregion
          //-----------------------------------------------------------------------
          Console.WriteLine("\n----------------------------");
            Console.WriteLine("Example of Swap function with refrenc:");
            #region Example of Swap function with refrenc:
            Console.WriteLine("Output of swap refrenc: ");
            //int a = 4, b = 5;

            SwapreRrenc(ref a, ref b);
            Console.WriteLine($"a value = {a} , b value ={b} this is what is stored in stack");

            #endregion
        }                      
    }
}