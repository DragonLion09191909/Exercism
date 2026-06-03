  public static class Languages
 {
     public static List<string> NewList() => new List<string>();
    
     public static List<string> GetExistingLanguages()
     {
         var list = new List<string> { "C#", "Clojure", "Elm" };
         return list;
     }

     public static List<string> AddLanguage(List<string> languages, string language) => languages.Append(language).ToList();
     
     public static int CountLanguages(List<string> languages)=>languages.Count();
     
     public static bool HasLanguage(List<string> languages, string language)=>languages.Contains(language);

     public static List<string> ReverseList(List<string> languages) => languages.Reverse<string>().ToList();
   

     public static bool IsExciting(List<string> languages)
     {
         if (languages == null || languages.Count == 0) return false;
         return languages[0] == "C#" || (languages.Count >= 2 && languages.Count < 4 && languages[1] == "C#");
     }
     public static List<string> RemoveLanguage(List<string> languages, string language)
     {
        languages.Remove(language);
         return languages;
     }

     public static bool IsUnique(List<string> languages)
     {
         var seen = new HashSet<string>();
         return !languages.Any(item => !seen.Add(item));

     }
    
 }