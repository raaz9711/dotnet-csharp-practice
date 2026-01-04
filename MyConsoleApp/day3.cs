namespace MyConsoleApp
{
    public static class Day3
    {
    public static void StringReverse(string s)
        {
            Console.WriteLine(s);
            s = new String(s.Reverse().ToArray());
            Console.WriteLine(s);

        }

//Palindrome checker (ignoring spaces/punctuation)
    public static bool IsPalindrone(string input)
        {
    if (string.IsNullOrEmpty(input)) return true;
    
    int left = 0;
    int right = input.Length - 1;
    
    while (left < right)
    {
        // Skip non-alphanumeric characters from left
        while (left < right && !char.IsLetterOrDigit(input[left]))
            left++;
        
        // Skip non-alphanumeric characters from right
        while (left < right && !char.IsLetterOrDigit(input[right]))
            right--;
        
        // Compare characters (case-insensitive)
        if (char.ToLower(input[left]) != char.ToLower(input[right]))
            return false;
        
        left++;
        right--;
    }
    
    return true;
        }    
    
    }
}