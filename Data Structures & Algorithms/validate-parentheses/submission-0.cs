public class Solution {
    public bool IsValid(string s) {
            Stack<char> stack = new();
            var pairs = new HashSet<(char, char)>
            {
                ('(', ')'),
                ('{', '}'),
                ('[', ']')
            };

            if (s.Length == 0)
                return true;
            foreach(char c in s)
            {
                if(c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if(c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                        return false;
                    char last = stack.Pop();

                    // check if pair exits
                    if (!pairs.Contains((last, c)))
                        return false;
                }
                else
                {
                    return false;
                }
            }
        return stack.Count == 0;
    }
}
