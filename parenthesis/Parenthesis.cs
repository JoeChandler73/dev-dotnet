namespace parenthesis;

public static class Parenthesis
{
    public static bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
            return false;

        var stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                    return false;

                var token = stack.Pop();

                if (token == '(' && c != ')')
                    return false;
                if (token == '[' && c != ']')
                    return false;
                if (token == '{' && c != '}')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
