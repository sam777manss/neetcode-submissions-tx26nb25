public class TimeMap {
    public Dictionary<string, List<(int, string)>> keyValuePairs = new Dictionary<string, List<(int, string)>>();
    public TimeMap() {
        
    }
    
    public void Set(string key, string value, int timestamp) {
        List<(int timestamp, string value)> list = new() { (timestamp, value) };

        if (keyValuePairs.ContainsKey(key))
        {
            keyValuePairs[key].Add((timestamp, value));
        }
        else
            keyValuePairs.Add(key, list);
    }
    
    public string Get(string key, int timestamp) {
        string timestamp_value = string.Empty;
        if (keyValuePairs.ContainsKey(key))
        {
            List<(int timestamp, string value)> ValueTimeStamp = keyValuePairs[key];
            int left = 0, right = ValueTimeStamp.Count() - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (ValueTimeStamp[mid].timestamp == timestamp)
                {
                    timestamp_value = ValueTimeStamp[mid].value;
                    return timestamp_value;
                }
                else if (ValueTimeStamp[mid].timestamp > timestamp)
                {
                    right = mid - 1;
                }
                else if (ValueTimeStamp[mid].timestamp < timestamp)
                {
                    timestamp_value = ValueTimeStamp[mid].value;
                    left = mid + 1;
                }
            }
        }
        else
            return timestamp_value;
        return timestamp_value;
    }
}
