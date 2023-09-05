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
    public static bool IsPermutation(int[] a, int[] b) {
        Dictionary<int, bool> elementSet = new Dictionary<int, bool>();

        // Each element is keyed with value zero 
        foreach (int i in a) {
            if (!elementSet.ContainsKey(i))
                elementSet.Add(i, false); 
        }
        
        // For each element in b, check if it is in set 
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