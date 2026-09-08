public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter) => 
        str.Substring(str.IndexOf(delimiter) + delimiter.Length);
    

    public static string SubstringBetween(this string str, string start, string end)
    {
        int sta = str.IndexOf(start) + start.Length;
        int en = str.IndexOf(end);
        return str.Substring(sta, en - sta);
    }

    public static string Message(this string str) => str.SubstringAfter(": ");
    
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}