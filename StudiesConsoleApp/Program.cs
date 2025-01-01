namespace StudiesConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        GetPINs(input);
        foreach (var pin in list)
        {
            Console.Write(pin + ", ");
        }
    }

    private static Dictionary<char, string> hash = new Dictionary<char, string>()
    {
        {'0', "08"},
        {'1', "124"},
        {'2', "2135"},
        {'3', "326"},
        {'4', "4157"},
        {'5', "52468"},
        {'6', "6359"},
        {'7', "748"},
        {'8', "80579"},
        {'9', "968"}
    };
    
    private static List<string> list = []; //it's different from codewars, because of c#13
    
    static List<string> GetPINs(string observed)
    {
        Backtrack("", observed);
        return list;
    }
    
    static void Backtrack(string combination, string digits)
    {
        if (digits.Length == 0 && !list.Contains(combination))
        {
            list.Add(combination);
        }
        else {
            foreach (char num in hash[digits[0]])
            {
                Backtrack(combination + num, digits.Substring(1));
            }
        }
    }
}