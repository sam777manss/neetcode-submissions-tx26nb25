public class Solution {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stk = new Stack<int>();
            int result = default;
            for(int i = 0; i < tokens.Length; i++)
            {
                if(tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "/" || tokens[i] == "*")
                {
                    int last = stk.Pop();
                    int secondlast = stk.Pop();

                    if (tokens[i] == "+")
                    {
                        result = secondlast + last;
                    }
                    else if (tokens[i] == "-")
                    {
                        result = secondlast - last;
                    }
                    else if (tokens[i] == "/")
                    {
                        result = secondlast / last;
                    }
                    else if (tokens[i] == "*")
                    {
                        result = secondlast * last;
                    }
                    stk.Push(result);
                }
                else {
                    stk.Push(int.Parse(tokens[i]));
                }
            }
            return stk.Pop();
        }
}
