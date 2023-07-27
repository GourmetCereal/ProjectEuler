/*
 Project Euler Activity 1
 Sum together all multiples of 3 and 5 below 1000
 Multiples of 3: 3, 6, 9, 12, 15, 18, 21....
 Multiples of 5: 5, 10, 15, 20, 25, 30...
 3x1, 3x2, 3x3, 3x4...
 5x1, 5x2, 5x3, 5x4...
 Largest value 999
 Run through all multiples up to 999 append all values to list, add all values at the end
*/

using System;

public class Multiples{
    static int a = 3;
    static int b = 5;
    static int aMax = 333;
    static int bMax = 199;
    static void Main(){
        //calculate all multiples up to maximum increments
        //a x (aMax x aMax+1)/2
        int valA = a*(aMax/2)*(aMax+1);
        Console.WriteLine(valA);
        int valB = b*(bMax/2)*(bMax+1);
        Console.WriteLine(valB);
        int total = valA + valB;
        Console.WriteLine("The Total of the Multiples of 3 and 5 below 1000 is: " + total);
    }
}