using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Name_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This is a simple program which demonstrates a number of basic programming concepts and is 
             used to illustrate switch case vs if statements.  Each letter in a person's name is assigned a value.
             A formula is applied to the total to work out the meaning of the name.*/

            string firstname = " ";
            string secondname = " ";
            int fntotal = 0;
            int sntotal = 0;
            int nametotal = 0;
            int temp = 0;
            string meaning = " ";

            //Collect first and last names and convert to uppercase
            Console.WriteLine("Please enter your first name.");
            firstname = Console.ReadLine();
            firstname = firstname.ToUpper();

            Console.WriteLine("Please enter your second name.");
            secondname = Console.ReadLine();
            secondname = secondname.ToUpper();

            //convert each string to array of characters
            char[] fname = firstname.ToCharArray();
            char[] sname = secondname.ToCharArray();

            //loop through first name array to find letter value and add to running total
            for (int i = 0; i < fname.Length; i++)
            {
                switch (fname[i])
                {
                    case 'A':
                    case 'J':
                    case 'S':
                        fntotal = fntotal + 1;
                        break;
                    case 'B':
                    case 'K':
                    case 'T':
                        fntotal = fntotal + 2;
                        break;
                    case 'C':
                    case 'L':
                    case 'U':
                        fntotal = fntotal + 3;
                        break;
                    case 'D':
                    case 'M':
                    case 'V':
                        fntotal = fntotal + 4;
                        break;
                    case 'E':
                    case 'N':
                    case 'W':
                        fntotal = fntotal + 5;
                        break;
                    case 'F':
                    case 'O':
                    case 'X':
                        fntotal = fntotal + 6;
                        break;
                    case 'G':
                    case 'P':
                    case 'Y':
                        fntotal = fntotal + 7;
                        break;
                    case 'H':
                    case 'Q':
                    case 'Z':
                        fntotal = fntotal + 8;
                        break;
                    case 'I':
                    case 'R':
                        fntotal = fntotal + 9;
                        break;

                }//end switch
            }//end for


            //loop through second name array to find letter value and add to running total
            for (int i = 0; i < sname.Length; i++)
            {
                if (sname[i] == 'A' || sname[i] == 'J' || sname[i] == 'S')
                    sntotal = sntotal + 1;
                else if (sname[i] == 'B' || sname[i] == 'K' || sname[i] == 'T')
                    sntotal = sntotal + 2;
                else if (sname[i] == 'C' || sname[i] == 'L' || sname[i] == 'U')
                    sntotal = sntotal + 3;
                else if (sname[i] == 'D' || sname[i] == 'M' || sname[i] == 'V')
                    sntotal = sntotal + 4;
                else if (sname[i] == 'E' || sname[i] == 'N' || sname[i] == 'W')
                    sntotal = sntotal + 5;
                else if (sname[i] == 'F' || sname[i] == 'O' || sname[i] == 'X')
                    sntotal = sntotal + 6;
                else if (sname[i] == 'G' || sname[i] == 'P' || sname[i] == 'Y')
                    sntotal = sntotal + 7;
                else if (sname[i] == 'H' || sname[i] == 'Q' || sname[i] == 'Z')
                    sntotal = sntotal + 8;
                else
                    sntotal = sntotal + 9;

            }//end for

            //work out lucky number
            temp = (fntotal % 10) + (fntotal / 10) + (sntotal % 10) + (sntotal / 10);
            nametotal = (temp % 10) + (temp / 10);

            //work out meaning
            switch (nametotal)
            {

                case 1:
                    meaning = "Natural Leaders";
                    break;
                case 2:
                    meaning = "Natural peacemakers";
                    break;
                case 3:
                    meaning = "Creative and optimistic";
                    break;
                case 4:
                    meaning = "Hard workers";
                    break;
                case 5:
                    meaning = "Value freedom";
                    break;
                case 6:
                    meaning = "Carers and providers";
                    break;
                case 7:
                    meaning = "Thinkers";
                    break;
                case 8:
                    meaning = "Have diplomatic skills";
                    break;
                case 9:
                    meaning = "Selfless and generous";
                    break;
            }//end switch

            //final output
            Console.WriteLine("Your name is {0} {1}", firstname, secondname);
            Console.WriteLine("Your number is " + nametotal);
            Console.WriteLine("Your meaning is " + meaning);
            Console.ReadLine();
        }
    }
}
