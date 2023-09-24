using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> score = new List<int>();
        int aliceScore = 0;
        int bobScore = 0;
        for (int i = 0; i < a.Count(); i++)
        {
            for (int j = i; j < b.Count(); i++, j++)
            {
                aliceScore += a[i] > b[j] ? 1 : 0;
                bobScore += a[i] < b[j] ? 1 : 0;
            }
        }
        score.Add(aliceScore);
        score.Add(bobScore);
        return score;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> a = new List<int> { 1, 2, 3 };
        List<int> b = new List<int> { 3, 2, 1 };
        Console.WriteLine("Resultado de alice: {0} \n Resultado de alice: {1}", Result.compareTriplets(a, b)[0], Result.compareTriplets(a, b)[1]);
    }
}
