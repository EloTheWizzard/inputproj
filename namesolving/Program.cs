using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namesolving
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";//ввод
            string text = "";//общий текст
            bool inputcounter = false;//вкл\выкл счетчика вводов
            int wordsnumber = 0;// кол-во введеных строк
            Console.WriteLine("write words, and press enter after words to continue.\n" +
                "dont use space btn, numbers,only letters.\n" +
                "if you want to exit press enter 2 times.\n\n" +
                "write icf (input counter off) to stop counting your input\n" +
                "write ics (input counter start) to start counting your input\n\n" +
                "TEXT HERE:");
            do
            {
                input = Console.ReadLine();
                bool isNumber = Int32.TryParse(input, out int num);
                    if (input == "icf")
                {
                    inputcounter = false;
                    wordsnumber--;
                    if (wordsnumber >= 0)
                    {
                        Console.WriteLine($"INPUT COUNTER (OFF), total number of inputs {wordsnumber}");
                    }
                    else
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"!!!INPUT COUNTER NOT POWERED ON YET, WRITE ICS!!!");
                        }
                      
                    }
                    
                    wordsnumber = -1;
                }
                if (input == "ics")
                {
                   
                    if (inputcounter == true)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("!!!ICS WORKING NOW (WRITE ICF TO TURN OFF INPUT COUNTER)!!!");//ics working now (write icf to turn off input counter)
                        }
                       
                        wordsnumber--;
                    }
                    else
                    {
                        Console.WriteLine($"INPUT COUNTER(ON)");
                    }
                    inputcounter = true;                   
                }
                if (inputcounter == true)
                {
                    if (wordsnumber > 0)
                    {
                        Console.WriteLine($"number of input: {wordsnumber}");
                    }
                    
                }

                if (isNumber) 
                {
                    Console.WriteLine("text mistake");
                }
                    else
                {
                    if (input == "ics" || input == "icf")
                    {
                        text = "";
                    }
                    else
                    {
                        text = text + input;
                    }
             
                    Console.WriteLine(text);
                    wordsnumber++;
                }
            } while (input != "");

           
        }
    }
}
