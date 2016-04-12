/*
*  Kathryn Hoskins
*  CSIT180 Lab4
*
*  Write a console program that uses an array to store a student’s scores on 5 quizzes.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIT180_Lab4_Hoskins
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            int[] myIntArray = new int[5];
            myIntArray = myProgram.getScores(myIntArray.Length);
            myProgram.showData(myIntArray);
            Console.ReadLine();
        }

        /*
        *  public int[] getScores(int arraySize)
        *  
        *  Parameters: the size of the array you wish to populate with scores
        *  Returns: a populated int array
        */
        public int[] getScores(int arraySize)
        {
            int[] populatedArray;
            //using testNum only for output
            int testNum = 0;        
            populatedArray = new int[arraySize];

            for (int i = 0; i < populatedArray.Length; i++)
            {
                //test num is between 1 - populatedArray.length
                testNum++;
                Console.Write("Please enter the score for test {0:f0}: ", testNum);
                populatedArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            return populatedArray;      
        }

        /*
        *  public double findAverage(int[] theScores)
        *  
        *  Parameters: an int array you wish to find the advrage of
        *  Returns: the average of the array as a double
        */
        public double findAverage(int[] theScores)
        {
            double averageOfScores = 0.0;
            //for each item in the array add them to the averageOfScores
            foreach (int testScore in theScores)
            {
                averageOfScores += testScore;
            }
            //after all of the items have been added to averageOfScores, 
            //find the average by dividing by the total number of items (theScores.Length)
            averageOfScores /= theScores.Length;
            return averageOfScores;
        }

        /*
        *  public void showData(int[] theIntArray)
        *  
        *  Parameters: outputs the values in theIntArray and outputs the average of the items in theIntArray
        *  Returns: none
        */
        public void showData(int[] theIntArray)
        {
            //finding the average
            double theAverage = findAverage(theIntArray);

            for(int i = 0; i < theIntArray.Length; i++)
            {
                //outputing the index of the array, using .write() first 
                Console.Write("The score at position {0:f0} ", i);
                //next using .writeLine() to output the value of the array at the index 
                Console.WriteLine("was {0:f0} ", theIntArray[i]);

                //by using .write() and then .writeLine() I am able to have the output on one line
            }
            Console.Write("The average is: {0:f2}", theAverage);
            
            return;
        }
    }
}
