using System.Collections.Generic;

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {

        if (input.Length == 0)
            return true;

        if ((input.Contains("(") == false) || (input.Contains(")") == false))
            return false;

        List<string> onlyParenthesis = new List<string>();

        while (input.Contains("(") || input.Contains(")"))
        {
            if (input.Contains("(") && input.Contains(")"))
            {
                if (input.IndexOf("(") < input.IndexOf(")"))
                {
                    onlyParenthesis.Add("(");
                    int found = input.IndexOf("(");
                    input = input.Remove(found, 1);
                }
                else if (input.IndexOf(")") < input.IndexOf("("))
                {
                    onlyParenthesis.Add(")");
                    int found = input.IndexOf(")");
                    input = input.Remove(found, 1);
                }
            }
            else if (input.Contains("(") && (input.Contains(")") == false))
            {
                onlyParenthesis.Add("(");
                int found = input.IndexOf("(");
                input = input.Remove(found, 1);
            }
            else if (input.Contains(")") && (input.Contains("(") == false))
            {
                onlyParenthesis.Add(")");
                int found = input.IndexOf(")");
                input = input.Remove(found, 1);
            }

        }
        
        string onlyParenthesisString = string.Join("", onlyParenthesis);


        if (onlyParenthesisString.Length % 2 != 0)
            return false;

        while (onlyParenthesisString.Contains("()"))
        {
            onlyParenthesisString = onlyParenthesisString.Replace("()", "");
        }


        if (onlyParenthesisString.Length == 0)
            return true;
        else
            return false;

    }
}
