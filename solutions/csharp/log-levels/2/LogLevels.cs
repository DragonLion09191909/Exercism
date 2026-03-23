static class LogLine
{
    public static string Message(string logLine)
    {
       int colonIndex = logLine.IndexOf(':');
        return logLine.Substring(colonIndex + 1).Trim();
           
    }

    public static string LogLevel(string logLine)
    {
       int openBracket = logLine.IndexOf('[');
        int closeBracket = logLine.IndexOf(']');
        
        string level = logLine.Substring(openBracket + 1, closeBracket - openBracket - 1);
        return level.ToLower();
    }

    public static string Reformat(string logLine)=> $"{Message(logLine)} ({LogLevel(logLine)})" ;
   
}
