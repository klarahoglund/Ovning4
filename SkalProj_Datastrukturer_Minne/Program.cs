using System;
using System.Collections;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>


        static List<string> list = new List<string>();
        static string newinput = "5";
        static char firstChar;
        static string firstCharAsString;
        static string cleanString;
        static string nextInLine;
        static Queue<string> queue = new Queue<string>();
        static Stack stackLine = new Stack();



        static void Main()
        {


            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {

            do
            {
                //Instruktioner
                Console.WriteLine();
                Console.WriteLine("****************************************");
                Console.WriteLine("Please navigate through the menu by inputting (+, -,  0) of your choice"
                    + "\n+. directly followed of what you want to add to the list. "
                    + "\n-. directly followed of what you want to remove from the list."
                    + "\n0. If you are done with this part."
                    + "\np. print list.");
                Console.WriteLine("****************************************");
                Console.WriteLine();

                newinput = Console.ReadLine();
                try
                {
                    if (newinput != null)
                    {
                        firstChar = newinput[0]; // set input to the first char in an input line
                        firstCharAsString = firstChar.ToString(); //Läser in hela strängen 
                    }
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.

                {
                    //Console.Clear();
                    Console.WriteLine("Please enter some input!");

                }

                switch (firstCharAsString)
                {
                    case "0":
                        list.Clear();
                        break;

                    case "+":
                        cleanString = DeleteFirstLetter(newinput);
                        //Console.WriteLine($"After: {cleanString}");
                        list.Add(cleanString);
                        //Console.WriteLine("Listans kapasitet är nu: " + list.Capacity);
                        //Console.WriteLine("Listans antal är nu: " + list.Count);

                        //
                        break;
                    case "-":
                        cleanString = DeleteFirstLetter(newinput);
                        list.Remove(cleanString);
                        //Console.WriteLine("Listans kapasitet är nu: " + list.Capacity);
                        //Console.WriteLine("Listans antal är nu: " + list.Count);

                        break;
                    case "p":
                        Console.WriteLine();
                        Console.WriteLine("**************************");
                        Console.WriteLine("The list at this moment:");
                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("**************************");
                        break;
                    default:

                        break;

                }
            } while (firstCharAsString != "0");

        }

        private static string DeleteFirstLetter(string newinput)

        {
            //  Console.WriteLine("Do it ");
            newinput = newinput.Remove(0, 1);
            //  Console.WriteLine($"In prog: {newinput}");
            return newinput;
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {

            do
            {
                //Instruktioner
                Console.WriteLine("Please navigate through the menu by inputting  (1, 2,  0) of your choice"
                    + "\n*1 Open store and start que. "
                    + "\n*2 Put in line. "
                    + "\n*3 remove from line"
                    + "\n*4 show line"
                    + "\n*0 If you are done with this part.");
                newinput = Console.ReadLine();
                try
                {
                    if (newinput != null)
                    {
                        firstChar = newinput[0]; // set input to the first char in an input line
                        firstCharAsString = firstChar.ToString(); //Läser in hela strängen 
                    }
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.

                {
                    //Console.Clear();
                    Console.WriteLine("Please enter some input!");

                }

                switch (firstCharAsString)
                {
                    case "0":

                        break;
                    case "1":
                        OpenStore();
                        break;
                    case "2":
                        PutInLine();
                        break;
                    case "3":
                        DoneInLine();
                        break;
                    case "4":
                        MyQue(queue);
                        break;
                    default:

                        break;

                }
            } while (firstCharAsString != "0");



            {
                /*
                 * Loop this method untill the user inputs something to exit to main menue.
                 * Create a switch with cases to enqueue items or dequeue items
                 * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
                */
            }
        }

        private static void MyQue(Queue<string> queue)
        {
            foreach (var person in queue)
            {
                Console.WriteLine(person + ", ");
            }
        }




        private static void DoneInLine()
        {
            queue.Dequeue();

        }

        private static void PutInLine()
        {
            Console.WriteLine("Enter the name of the person who is joining the que: ");
            nextInLine = Console.ReadLine();
            queue.Enqueue(nextInLine);
        }

        private static void OpenStore()
        {
            Console.WriteLine("I am open");
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()

        {
            do
            {
                //Instruktioner
                Console.WriteLine("STACK: Please navigate through the menu by inputting  (1, 2, 3, 4,  0) of your choice"
                    + "\n1. Open store and start que. "
                    + "\n2. Put in line. "
                    + "\n3. remove from line"
                    + "\n4. show line"
                    + "\n5. Reverse text"
                    + "\n0. If you are done with this part.");
                newinput = Console.ReadLine();
                try
                {
                    if (newinput != null)
                    {
                        firstChar = newinput[0]; // set input to the first char in an input line
                        firstCharAsString = firstChar.ToString(); //Läser in hela strängen 
                    }
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.

                {
                    //Console.Clear();
                    Console.WriteLine("Please enter some input!");

                }

                switch (firstCharAsString)
                {
                    case "0":
                        list.Clear();
                        break;
                    case "1":
                        OpenStore();
                        break;
                    case "2":
                        PutInStackLine();
                        break;
                    case "3":
                        DoneInStackLine();
                        break;
                    case "4":
                        MyStackLine();
                        break;
                    case "5":
                        ReverseText();
                        break;
                    default:

                        break;

                }
            } while (firstCharAsString != "0");



            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        private static void ReverseText()
        {
            string text;

            Console.WriteLine("Enter some text to reverse: ");
            Stack reverser = new Stack();

            text = Console.ReadLine();
            char[] chars = text.ToCharArray();

            foreach (var item in chars)
            {
                reverser.Push(item);

            }
            foreach (var item in reverser)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        private static void MyStackLine()
        {
            Console.WriteLine("This is th line: ");
            foreach (var item in stackLine)
            {
                Console.WriteLine(item + ", ");
            }

        }

        private static void DoneInStackLine()
        {
            //vänd stacken 
            Stack temp = new Stack();

            foreach (var item in stackLine)
            {
                temp.Push(item);
            }

            temp.Pop();
            stackLine.Clear();
            foreach (var item in temp)
            {
                stackLine.Push(item);
            }
        }

        private static void PutInStackLine()
        {
            Console.WriteLine("Enter the name of the person who is joining the que: ");
            nextInLine = Console.ReadLine();
            stackLine.Push(nextInLine);
        }

        static void CheckParanthesis()
        {
            List<char> opens = new List<char>();
            List<char> listA = new List<char>();
            List<char> listB = new List<char>();
            bool okay = true;

            Console.WriteLine("Enter a string for examination. ");

            string text = Console.ReadLine();
            char[] theString = text.ToCharArray();


            //Check att första är en öppningparantes

            for (int i = 0; i < theString.Length; i++)
            {
                if (theString[i] == '(' || theString[i] == ')')
                {
                    opens.Add(theString[i]);
                }
            }

            if (opens[0] != '(')
            {
                okay = false;
            }
                
            


            for (int i = 0; i < theString.Length; i++)
            {
                if (theString[i] == '(')
                {
                    listA.Add(theString[i]);

                }
                else if (theString[i] == ')')
                {
                    listB.Add(theString[i]);
                }
            }   
            if (listA.Count != listB.Count)
            {
                okay = false;
            }


            for (int i = 0; i < listA.Count; i++)
            {
                if (listA[i] != '(' && listB[i] != ')') { okay = false; break; }
            }


            if (okay)
            {
                Console.WriteLine("Det funkar fint med paranteserna");
            }
            else if (!okay)
            {
                Console.WriteLine("Det är fel med paranterserna eller det finns inga");

            }








            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

        }
    }


