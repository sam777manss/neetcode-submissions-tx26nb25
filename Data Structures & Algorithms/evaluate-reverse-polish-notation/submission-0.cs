public class Solution {
public int EvalRPN(string[] tokens)
        {
            List<string> tk = new List<string>();
            tk.AddRange(tokens);
            int leftFirst = default, leftSecond = default, result = default;
            string opt = default;
            for (int i = 0; i < tk.Count; i++)
            {
                if (tk[i] == "+" || tk[i] == "-" || tk[i] == "*" || tk[i] == "/")
                {
                    opt = tk[i];                    
                    if (tk.Count > 2)
                    {
                        leftFirst = int.Parse(tk[i - 1]);
                        leftSecond = int.Parse(tk[i - 2]);                        
                    }
                    if (opt == "+")
                    {
                        result = leftSecond + leftFirst;
                    }
                    if (opt == "-")
                    {
                        result = leftSecond - leftFirst;
                    }
                    if (opt == "/")
                    {
                        result = leftSecond / leftFirst;
                    }
                    if (opt == "*")
                    {
                        result = leftSecond * leftFirst;
                    }
                    tk.RemoveAt(i);
                    tk.RemoveAt(i - 1);
                    tk[i - 2] = result.ToString();
                    i = 0;
                }
            }

            return int.Parse(tk[0]);
        }
}
