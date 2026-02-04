using System;
using System.Globalization;
using System.Text;

class Inventory
{
    public static void inventory()
    {
        
        string inp = Console.ReadLine();
        inp = inp.Trim();

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < inp.Length; i++)
        {
            if (i ==0 ||inp[i] != inp[i - 1]){
                sb.Append(inp[i]);
            }
        }
        string cleaned = System.Text.RegularExpressions.Regex.Replace(
            sb.ToString(),
            @"\s+",
            " "
        );
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string result = textInfo.ToTitleCase(cleaned.ToLower());
        Console.WriteLine(result);
    }
}
