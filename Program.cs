using System.Collections.Generic; 

// Top level statements
// Test the solution here 
int[] basis = {1, 2, 3, 4, 5}; 
int[] perm = {5, 4, 3, 1, 2};
int[] excp = {2, 3, 4, 5, 6}; 

Console.WriteLine("Basis array: 1, 2, 3, 4, 5"); 
Console.WriteLine($"Array 5, 4, 3, 2, 1 is a permutation: {IsPermutation(basis, perm)}");
Console.WriteLine($"Array 2, 3, 4, 5, 6 is a permutation: {IsPermutation(basis, excp)}");

public static partial class Program {

    /// <summary>
    /// Determine if 'b' is a permutation of 'a' 
    /// Permutation has each element in 'a' exactly once 
    /// This method keys each element of 'a' in a dictionary 
    /// with value false 
    /// Iterate over the elements in 'b', if it is in the dictionary
    /// and is set as false, set the value to true indicating it has occured 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static bool IsPermutation(int[] a, int[] b) {
        Dictionary<int, bool> elementSet = new Dictionary<int, bool>();

        // Each element in the basis array is keyed with value 
        // false initially  
        foreach (int i in a) {
            if (!elementSet.ContainsKey(i))
                elementSet.Add(i, false); 
        }
        
        // For each element in b, check if it is in set 
        // If it is false, set to true 
        // If an element has value true, then it has been seen before
        // and b is not a permutation (must occur once)
        foreach (int i in b) {
            if (elementSet.ContainsKey(i)) {
                if (elementSet[i])
                    return false; 
                else 
                    elementSet[i] = true; 
            } else 
                return false; 
        }

        return true; 
    }
}