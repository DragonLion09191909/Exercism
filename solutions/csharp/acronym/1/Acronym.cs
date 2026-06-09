     using System.Text;

public static class Acronym
 {
     public static string Abbreviate(string phrase)
     {
         if (string.IsNullOrWhiteSpace(phrase)) return string.Empty;
         StringBuilder result = new StringBuilder();
         string[] words = phrase.Split(new char[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
         foreach (string word in words)
         {      
             foreach (char c in word)
             {
                 if (char.IsLetter(c))
                 {
                     result.Append(char.ToUpper(c));
                     break; 
                 }
             }
         }
         return result.ToString();
     }
 }