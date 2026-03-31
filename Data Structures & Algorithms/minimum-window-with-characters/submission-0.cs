public class Solution {
    public string MinWindow(string s, string t) {
                 Dictionary<char, int> need = new Dictionary<char, int>();
            foreach (char c in t)
                need[c] = need.GetValueOrDefault(c) + 1;

            List<string> validWindows = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                // Only start if s[i] is a char we need
                if (!need.ContainsKey(s[i])) continue;

                Dictionary<char, int> window = new Dictionary<char, int>();
                int formed = 0;

                for (int j = i; j < s.Length; j++)
                {
                    char c = s[j];

                    if (need.ContainsKey(c))
                    {
                        window[c] = window.GetValueOrDefault(c) + 1;

                        // Count as formed only when count exactly matches
                        if (window[c] == need[c])
                            formed++;
                    }

                    // All characters satisfied — store this window
                    if (formed == need.Count)
                    {
                        validWindows.Add(s.Substring(i, j - i + 1));
                        break; // No need to go further from this i
                    }
                }
            }

            if (validWindows.Count == 0) return string.Empty;

            // Find shortest string
            string result = validWindows[0];
            foreach (string w in validWindows)
            {
                if (w.Length < result.Length)
                    result = w;
            }

        return result;   
    }
}
